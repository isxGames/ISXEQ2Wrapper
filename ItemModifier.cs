using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class ItemModifier : LavishScriptObject
    {
        public ItemModifier(LavishScriptObject Obj)
            : base(Obj)
        {
        }
/*
        public ItemModifier()
            : base(LavishScript.Objects.GetObject("ItemModifier"))
        {
        }
*/
        public string Type
        {
            get
            {
                return GetMember<string>("Type");
            }
        }

        public string SubType
        {
            get
            {
                return GetMember<string>("SubType");
            }
        }

        public int Value
        {
            get
            {
                return GetMember<int>("Value");
            }
        }

    }
}
