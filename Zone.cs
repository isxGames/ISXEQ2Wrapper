// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Zone : LavishScriptObject
    {
        public Zone(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Zone()
            : base(LavishScript.Objects.GetObject("Zone"))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public string ShortName
        {
            get
            {
                return GetMember<string>("ShortName");
            }
        }

        public int ID
        {
            get
            {
                return GetMember<int>("ID");
            }
        }
    }


}
