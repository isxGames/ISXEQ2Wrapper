// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Class : LavishScriptObject
    {
        public Class(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Class()
            : base(LavishScript.Objects.GetObject("Class"))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public int Level
        {
            get
            {
                return GetMember<int>("Level");
            }
        }
    }
}
