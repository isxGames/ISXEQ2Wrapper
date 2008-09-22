using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class AbilityEffect : LavishScriptObject
    {
        public AbilityEffect(LavishScriptObject Obj)
            : base(Obj)
        {
        }
/*
        public AbilityEffect()
            : base(LavishScript.Objects.GetObject("AbilityEffect"))
        {
        }
*/
        public int PercentSuccess
        {
            get
            {
                return GetMember<int>("PercentSuccess");
            }
        }

        public int Indentation
        {
            get
            {
                return GetMember<int>("Indentation");
            }
        }

        public string Description
        {
            get
            {
                return GetMember<string>("Description");
            }
        }
    }
}
