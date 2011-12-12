// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class ContainerWindowItem : LavishScriptObject
    {
        public ContainerWindowItem(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        /// <summary>
        /// Note:  The 'ID' MEMBER of the 'containerwindowitem' datatype is used exlusively for the "RemoveItem" METHOD of the 'containerwindow' datatype.  
        /// </summary>
        public int ID
        {
            get
            {
                return GetMember<int>("ID");
            }
        }

        public int LinkID
        {
            get
            {
                return GetMember<int>("LinkID");
            }
        }

        public int Quantity
        {
            get
            {
                return GetMember<int>("Quantity");
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
