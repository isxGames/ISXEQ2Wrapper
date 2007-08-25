using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;
using LavishVMAPI;

namespace EQ2.ISXEQ2
{
    public class EQ2 : LavishScriptObject
    {
        public EQ2()
            :
            base(LavishScript.Objects.GetObject("EQ2"))
        {
        }

        public EQ2(LavishScriptObject Copy)
            :
            base(Copy)
        {
        }

        public void CreateCustomActorArray(params string[] Args)
        {
            ExecuteMethod("CreateCustomActorArray", Args);
        }

        public int CustomActorArraySize
        {
            get { return GetMember<int>("CustomActorArraySize"); }
        }

        public List<Actor> GetActors()
        {
            LavishScriptObject Index = LavishScript.Objects.NewObject("index:actor");

            int Count = GetMember<int>("GetActors", Index.GetLSReference());
            List<Actor> List = new List<Actor>(Count);

            for (int i = 1; i < Count; i++)
            {
                List.Add(new Actor(Index.GetIndex(i.ToString())));
            }

            return List;
        }

        public List<Actor> GetActors(params string[] Args)
        {
            LavishScriptObject Index = LavishScript.Objects.NewObject("index:actor");

            string[] allargs = new string[Args.Length + 1];

            allargs[0] = Index.GetLSReference();
            for (int i = 0; i < Args.Length; i++)
            {
                allargs[i + 1] = Args[i];
            }

            int Count = GetMember<int>("GetActors", allargs);
            List<Actor> List = new List<Actor>(Count);

            for (int i = 1; i < Count; i++)
            {
                List.Add(new Actor(Index.GetIndex(i.ToString())));
            }

            return List;
        }
    }
}
