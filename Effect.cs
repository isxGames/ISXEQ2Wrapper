// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

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
/*
        public Effect()
            : base(LavishScript.Objects.GetObject("Effect"))
        {
        }
*/
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

        public float MaxDuration
        {
            get
            {
                return GetMember<float>("MaxDuration");
            }
        }

        public float Duration
        {
            get
            {
                return GetMember<float>("Duration");
            }
        }

        public int BackDropIconID
        {
            get
            {
                return GetMember<int>("BackDropIconID");
            }
        }

        public int MainIconID
        {
            get
            {
                return GetMember<int>("MainIconID");
            }
        }

        public int ID
        {
            get
            {
                return GetMember<int>("ID");
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
