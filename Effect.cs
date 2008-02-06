using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Effect : LavishScriptObject
    {
        public Effect(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Effect()
            : base(LavishScript.Objects.GetObject("Effect"))
        {
        }

        public int ID
        {
            get
            {
                return GetMember<int>("ID");
            }
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public string Description
        {
            get
            {
                return GetMember<string>("Description");
            }
        }

        public float Duration
        {
            get
            {
                return GetMember<float>("Duration");
            }
        }

        public float MaxDuration
        {
            get
            {
                return GetMember<float>("MaxDuration");
            }
        }

        public bool Cancel()
        {
            return ExecuteMethod("Cancel");
        }

        public bool Examine()
        {
            return ExecuteMethod("Examine");
        }
    }
}
