// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 
// Credit for this entire class goes to GliderPro. //

using System;
using LavishScriptAPI;
using LavishScriptAPI.Interfaces;

namespace EQ2.ISXEQ2.Extensions
{
    /// <summary>
    /// Extensions to the LavishScriptObject Class
    /// </summary>
    public static class LavishScriptObjectExtensions
    {
        /// <summary>
        /// Returns the requested string member
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <returns>LavishScriptObject string member value</returns>
        public static string GetStringFromLSO(this ILSObject obj, string member)
        {
            using (var lavishScriptObject = obj.GetMember(member))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? null
                           : lavishScriptObject.GetValue<string>();
            }
        }

        /// <summary>
        /// Returns the requested string member based on the arguments provided
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <param name="args">string array of the arguments to pass to the member</param>
        /// <returns>LavishScriptObject string member value</returns>
// ReSharper disable MethodOverloadWithOptionalParameter
        public static string GetStringFromLSO(this ILSObject obj, string member, params string[] args)
// ReSharper restore MethodOverloadWithOptionalParameter
        {
            using (var lavishScriptObject = obj.GetMember(member, args))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? null
                           : lavishScriptObject.GetValue<string>();
            }
        }

        /// <summary>
        /// Returns the requested Int64 member
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <returns>LavishScriptObject Int64 member value</returns>
        public static Int64 GetInt64FromLSO(this ILSObject obj, string member)
        {
            using (var lavishScriptObject = obj.GetMember(member))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? -1
                           : lavishScriptObject.GetValue<Int64>();
            }
        }

        /// <summary>
        /// Returns the requested UInt64 member
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <returns>LavishScriptObject UInt64 member value</returns>
        public static UInt64 GetUInt64FromLSO(this ILSObject obj, string member)
        {
            using (var lavishScriptObject = obj.GetMember(member))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? 0
                           : lavishScriptObject.GetValue<UInt64>();
            }
        }

        /// <summary>
        /// Returns the requested Int64 member based on the arguments provided
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <param name="args">string array of arguments to pass to the member</param>
        /// <returns>LavishScriptObject Int64 member value</returns>
// ReSharper disable MethodOverloadWithOptionalParameter
        public static Int64 GetInt64FromLSO(this ILSObject obj, string member, params string[] args)
// ReSharper restore MethodOverloadWithOptionalParameter
        {
            using (var lavishScriptObject = obj.GetMember(member, args))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? -1
                           : lavishScriptObject.GetValue<Int64>();
            }
        }

        /// <summary>
        /// Retrieves the requested float member
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <returns>LavishScriptObject float member value</returns>
        public static float GetFloatFromLSO(this ILSObject obj, string member)
        {
            using (var lavishScriptObject = obj.GetMember(member))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? -1
                           : lavishScriptObject.GetValue<float>();
            }
        }

        /// <summary>
        /// Retrieves the requested float member based on the arguments provided
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <param name="args">string array of arguments to pass to the member</param>
        /// <returns>LavishScriptObject float member value</returns>
// ReSharper disable MethodOverloadWithOptionalParameter
        public static float GetFloatFromLSO(this ILSObject obj, string member, params string[] args)
// ReSharper restore MethodOverloadWithOptionalParameter
        {
            using (var lavishScriptObject = obj.GetMember(member, args))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? -1
                           : lavishScriptObject.GetValue<float>();
            }
        }

        /// <summary>
        /// Retrieves the requested double member
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <returns>LavishScriptObject double member value</returns>
        public static double GetDoubleFromLSO(this ILSObject obj, string member)
        {
            using (var lavishScriptObject = obj.GetMember(member))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? -1
                           : lavishScriptObject.GetValue<double>();
            }
        }

        /// <summary>
        /// Retrieves the requested double member based on the arguments provided
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <param name="args">string array of arguments to pass to the member</param>
        /// <returns>LavishScriptObject double member value</returns>
// ReSharper disable MethodOverloadWithOptionalParameter
        public static double GetDoubleFromLSO(this ILSObject obj, string member, params string[] args)
// ReSharper restore MethodOverloadWithOptionalParameter
        {
            using (var lavishScriptObject = obj.GetMember(member, args))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? -1
                           : lavishScriptObject.GetValue<double>();
            }
        }

        /// <summary>
        /// Retrieves the requested integer member
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <returns>LavishScriptObject integer member value</returns>
        public static int GetIntFromLSO(this ILSObject obj, string member)
        {
            using (var lavishScriptObject = obj.GetMember(member))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<int>();
            }
        }

        /// <summary>
        /// Retrieves the requested integer member based on the arguments provided
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <param name="args">string array of arguments to pass to the member</param>
        /// <returns>LavishScriptObject integer member value</returns>
// ReSharper disable MethodOverloadWithOptionalParameter
        public static int GetIntFromLSO(this ILSObject obj, string member, params string[] args)
// ReSharper restore MethodOverloadWithOptionalParameter
        {
            using (var lavishScriptObject = obj.GetMember(member, args))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject) ? -1 : lavishScriptObject.GetValue<int>();
            }
        }

        /// <summary>
        /// Retireves the requested boolean member
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <returns>LavishScriptObject boolean member value</returns>
        public static bool GetBoolFromLSO(this ILSObject obj, string member)
        {
            using (var lavishScriptObject = obj.GetMember(member))
            {
                return !LavishScriptObject.IsNullOrInvalid(lavishScriptObject) && lavishScriptObject.GetValue<bool>();
            }
        }

        /// <summary>
        /// Retrieves the requested boolean member based on the arguments provided
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <param name="args"></param>
        /// <returns>LavishScriptObject boolean member value</returns>
// ReSharper disable MethodOverloadWithOptionalParameter
        public static bool GetBoolFromLSO(this ILSObject obj, string member, params string[] args)
// ReSharper restore MethodOverloadWithOptionalParameter
        {
            using (var lavishScriptObject = obj.GetMember(member, args))
            {
                return !LavishScriptObject.IsNullOrInvalid(lavishScriptObject) && lavishScriptObject.GetValue<bool>();
            }
        }

        /// <summary>
        /// Returns the requested Int64 member
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <returns>LavishScriptObject Int64 member value</returns>
        public static Int64? GetNullableInt64FromLSO(this ILSObject obj, string member)
        {
            using (var lavishScriptObject = obj.GetMember(member))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? null
                           : (Int64?) lavishScriptObject.GetValue<Int64>();
            }
        }

        /// <summary>
        /// Returns the requested Int64 member based on the arguments provided
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <param name="args">string array of arguments to pass to the member</param>
        /// <returns>LavishScriptObject Int64 member value</returns>
// ReSharper disable MethodOverloadWithOptionalParameter
        public static Int64? GetNullableInt64FromLSO(this ILSObject obj, string member, params string[] args)
// ReSharper restore MethodOverloadWithOptionalParameter
        {
            using (var lavishScriptObject = obj.GetMember(member, args))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? null
                           : (Int64?) lavishScriptObject.GetValue<Int64>();
            }
        }

        /// <summary>
        /// Retrieves the requested float member
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <returns>LavishScriptObject float member value</returns>
        public static float? GetNullableFloatFromLSO(this ILSObject obj, string member)
        {
            using (var lavishScriptObject = obj.GetMember(member))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? null
                           : (float?) lavishScriptObject.GetValue<float>();
            }
        }

        /// <summary>
        /// Retrieves the requested float member based on the arguments provided
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <param name="args">string array of arguments to pass to the member</param>
        /// <returns>LavishScriptObject float member value</returns>
// ReSharper disable MethodOverloadWithOptionalParameter
        public static float? GetNullableFloatFromLSO(this ILSObject obj, string member, params string[] args)
// ReSharper restore MethodOverloadWithOptionalParameter
        {
            using (var lavishScriptObject = obj.GetMember(member, args))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? null
                           : (float?) lavishScriptObject.GetValue<float>();
            }
        }

        /// <summary>
        /// Retrieves the requested double member
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <returns>LavishScriptObject double member value</returns>
        public static double? GetNullableDoubleFromLSO(this ILSObject obj, string member)
        {
            using (var lavishScriptObject = obj.GetMember(member))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? null
                           : (double?) lavishScriptObject.GetValue<double>();
            }
        }

        /// <summary>
        /// Retrieves the requested double member based on the arguments provided
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <param name="args">string array of arguments to pass to the member</param>
        /// <returns>LavishScriptObject double member value</returns>
// ReSharper disable MethodOverloadWithOptionalParameter
        public static double? GetNullableDoubleFromLSO(this ILSObject obj, string member, params string[] args)
// ReSharper restore MethodOverloadWithOptionalParameter
        {
            using (var lavishScriptObject = obj.GetMember(member, args))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? null
                           : (double?) lavishScriptObject.GetValue<double>();
            }
        }

        /// <summary>
        /// Retrieves the requested integer member
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <returns>LavishScriptObject integer member value</returns>
        public static int? GetNullableIntFromLSO(this ILSObject obj, string member)
        {
            using (var lavishScriptObject = obj.GetMember(member))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? null
                           : (int?) lavishScriptObject.GetValue<int>();
            }
        }

        /// <summary>
        /// Retrieves the requested integer member based on the arguments provided
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <param name="args">string array of arguments to pass to the member</param>
        /// <returns>LavishScriptObject integer member value</returns>
// ReSharper disable MethodOverloadWithOptionalParameter
        public static int? GetNullableIntFromLSO(this ILSObject obj, string member, params string[] args)
// ReSharper restore MethodOverloadWithOptionalParameter
        {
            using (var lavishScriptObject = obj.GetMember(member, args))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? null
                           : (int?) lavishScriptObject.GetValue<int>();
            }
        }

        /// <summary>
        /// Retireves the requested boolean member
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <returns>LavishScriptObject boolean member value</returns>
        public static bool? GetNullableBoolFromLSO(this ILSObject obj, string member)
        {
            using (var lavishScriptObject = obj.GetMember(member))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? null
                           : (bool?) lavishScriptObject.GetValue<bool>();
            }
        }

        /// <summary>
        /// Retrieves the requested boolean member based on the arguments provided
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <param name="args"></param>
        /// <returns>LavishScriptObject boolean member value</returns>
// ReSharper disable MethodOverloadWithOptionalParameter
        public static bool? GetNullableBoolFromLSO(this ILSObject obj, string member, params string[] args)
// ReSharper restore MethodOverloadWithOptionalParameter
        {
            using (var lavishScriptObject = obj.GetMember(member, args))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? null
                           : (bool?) lavishScriptObject.GetValue<bool>();
            }
        }

        /// <summary>
        /// Retrieves the requested Actor member based
        /// </summary>
        /// <param name="obj">this</param>
        /// <param name="member">the member to retrieve</param>
        /// <returns>LavishScriptObject Actor member value</returns>
        public static Actor GetActorFromLSO(this ILSObject obj, string member)
        {
            using (var lavishScriptObject = obj.GetMember(member))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? null
                           : lavishScriptObject.GetValue<Actor>();
            }
        }

        public static Class GetClassFromLSO(this ILSObject obj, string member)
        {
            using (var lavishScriptObject = obj.GetMember(member))
            {
                return LavishScriptObject.IsNullOrInvalid(lavishScriptObject)
                           ? null
                           : lavishScriptObject.GetValue<Class>();
            }
        }
    }
}
