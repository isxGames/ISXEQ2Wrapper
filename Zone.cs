// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;
using EQ2.ISXEQ2.Extensions;

namespace EQ2.ISXEQ2
{
    public class Zone : LavishScriptObject
    {
        public Zone(LavishScriptObject obj)
            : base(obj)
        {
        }

        public Zone()
            : base(LavishScript.Objects.GetObject("Zone"))
        {
        }

        /// <summary>
        /// The name of the zone
        /// </summary>
        public string Name
        {
            get
            {
                return this.GetStringFromLSO("Name");
            }
        }

        /// <summary>
        /// The short name of the zone
        /// </summary>
        public string ShortName
        {
            get
            {
                return this.GetStringFromLSO("ShortName");
            }
        }

        /// <summary>
        /// The ID of the zone
        /// </summary>
        public int ID
        {
            get
            {
                return this.GetIntFromLSO("ID");
            }
        }
    }


}
