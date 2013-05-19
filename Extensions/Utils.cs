// Credit for this entire class goes to GliderPro //

using System.Collections.Generic;
using LavishScriptAPI;
using LavishScriptAPI.Interfaces;

namespace EQ2.ISXEQ2.Extensions
{
    /// <summary>
    /// Utilities to facilitate manipulation of the LavishScriptObject index into C# datatypes
    /// </summary>
    internal class Util
    {
        private static T[] PrefixArray<T>(T first, T[] rest)
        {
            var newArray = new T[rest.Length + 1];

            newArray[0] = first;

            for (var i = 0; i < rest.Length; i++)
                newArray[i + 1] = rest[i];

            return newArray;
        }

        private static List<T> IndexToLavishScriptObjectList<T>(LavishScriptObject index, string lsTypeName)
        {

            var list = new List<T>();
            var count = index.GetMember<int>("Used");

            if (count == 0)
            {
                return list;
            }

            var constructor = typeof(T).GetConstructor(new[] { typeof(LavishScriptObject) });

            for (var i = 1; i <= count; i++)
            {
                var objectLso = index.GetIndex(i.ToString());

                if (LavishScriptObject.IsNullOrInvalid(objectLso))
                {
                    return list;
                }

                var objectId = objectLso.GetStringFromLSO("ID");

                if (objectId == null)
                {
                    return list;
                }

                if (objectId == string.Empty)
                {
                    return list;
                }

                var lsObject = LavishScript.Objects.NewObject(lsTypeName, objectId);
                var item = (T)constructor.Invoke(new object[] { lsObject });
                list.Add(item);
            }

            return list;
        }

        private static List<T> IndexToStructList<T>(LavishScriptObject index)
        {
            var list = new List<T>();
            var count = index.GetMember<int>("Used");

            for (var i = 1; i <= count; i++)
                list.Add(index.GetIndex<T>(i.ToString()));

            return list;
        }

        public static List<T> IndexToList<T>(LavishScriptObject index, string lsTypeName)
        {
            return typeof(T).IsSubclassOf(typeof(LavishScriptObject)) ? IndexToLavishScriptObjectList<T>(index, lsTypeName) : IndexToStructList<T>(index);
        }

        private static T IndexToLavishScriptObject<T>(LavishScriptObject index, int number)
        {
            var constructor = typeof(T).GetConstructor(new[] { typeof(LavishScriptObject) });

            return (T)constructor.Invoke(new object[] { index.GetIndex(number.ToString()) });
        }

        public static T GetIndexMember<T>(LavishScriptObject index, int number)
        {
            if (typeof(T).IsSubclassOf(typeof(LavishScriptObject)))
                return (T)typeof(T).GetConstructor(new[] { typeof(LavishScriptObject) }).Invoke(new object[] { index.GetIndex(number.ToString()) });
            return index.GetIndex<T>(number.ToString());
        }

        internal static List<T> GetListFromMethod<T>(ILSObject obj, string methodName, string lsTypeName, params string[] args)
        {

            if (obj == null || !obj.IsValid)
                return null;

            using (var index = LavishScript.Objects.NewObject("index:" + lsTypeName))
            {

                string[] allargs;
                if (args.Length > 0)
                {
                    allargs = PrefixArray(index.LSReference, args);
                }
                else
                {
                    allargs = new string[1];
                    allargs[0] = index.LSReference;
                }

                if (!obj.ExecuteMethod(methodName, allargs))
                    return null;

                using (var used = index.GetMember("Used"))
                {
                    if (LavishScriptObject.IsNullOrInvalid(used))
                        return null;
                }

                var list = IndexToList<T>(index, lsTypeName);

                return list;
            }
        }

        internal static T GetFromIndexMethod<T>(ILSObject obj, string methodName, string lsTypeName, int number, params string[] args)
        {
            // argument is 0-based
            number += 1;

            if (obj == null || !obj.IsValid || number <= 0)
                return default(T);

            using (var index = LavishScript.Objects.NewObject("index:" + lsTypeName))
            {
                var allargs = PrefixArray(index.LSReference, args);

                if (!obj.ExecuteMethod(methodName, allargs))
                    return default(T);

                using (var used = index.GetMember("Used"))
                {
                    // if it failed or we want one off the end, return
                    if (LavishScriptObject.IsNullOrInvalid(used) || used.GetValue<int>() < number)
                        return default(T);
                }

                var member = GetIndexMember<T>(index, number);
                return member;
            }
        }

        internal static List<T> GetListFromMember<T>(ILSObject obj, string memberName, string lsTypeName, params string[] args)
        {

            if (obj == null || !obj.IsValid)
                return null;

            using (var index = LavishScript.Objects.NewObject("index:" + lsTypeName))
            {
                var allargs = PrefixArray(index.LSReference, args);

                using (var retval = obj.GetMember(memberName, allargs))
                {
                    if (LavishScriptObject.IsNullOrInvalid(retval))
                        return null;
                }

                var list = IndexToList<T>(index, lsTypeName);

                return list;
            }
        }

        internal static T GetFromIndexMember<T>(ILSObject obj, string memberName, string lsTypeName, int number, params string[] args)
        {
            // argument is 0-based
            number += 1;

            if (obj == null || !obj.IsValid)
                return default(T);

            using (var index = LavishScript.Objects.NewObject("index:" + lsTypeName))
            {
                var allargs = PrefixArray(index.LSReference, args);

                using (var retval = obj.GetMember(memberName, allargs))
                {
                    if (LavishScriptObject.IsNullOrInvalid(retval) || retval.GetValue<int>() < number)
                        return default(T);
                }

                var member = GetIndexMember<T>(index, number);
                return member;
            }
        }
    }
}
