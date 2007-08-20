using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Maintained : LavishScriptObject
    {
        public Maintained(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Maintained()
            : base(LavishScript.Objects.GetObject("Maintained"))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public string Type
        {
            get
            {
                return GetMember<string>("Type");
            }
        }

        public bool IsBeneficial
        {
            get
            {
                return GetMember<bool>("IsBeneficial");
            }
        }

        public int ConcentrationCost
        {
            get
            {
                return GetMember<int>("ConcentrationCost");
            }
        }

        public Actor Target()
        {
            LavishScriptObject Obj = GetMember("Target");
            return new Actor(Obj);
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
