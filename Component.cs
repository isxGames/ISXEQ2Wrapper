// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Component : LavishScriptObject
    {
        public Component(LavishScriptObject Obj)
            : base(Obj)
        {
        }
/*
        public Component()
            : base(LavishScript.Objects.GetObject("Component"))
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

        public int Quantity
        {
            get
            {
                return GetMember<int>("Quantity");
            }
        }

        public int QuantityOnHand
        {
            get
            {
                return GetMember<int>("QuantityOnHand");
            }
        }
    }
}
