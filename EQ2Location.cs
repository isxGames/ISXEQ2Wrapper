// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class EQ2Location : LavishScriptObject
    {

        public EQ2Location(LavishScriptObject Obj)
            : base(Obj)
        {
        }

		public EQ2Location(Int32 Index) 
			: base(LavishScript.Objects.GetObject("EQ2Loc", Index.ToString()))
		{
		}

		public string Label
        {
            get
            {
                return GetMember<string>("Label");
            }
        }

        public string Notes
        {
            get
            {
                return GetMember<string>("Notes");
            }
        }

        public string Zone
        {
            get
            {
                return GetMember<string>("Zone");
            }
        }

        public float X
        {
            get
            {
                return GetMember<float>("X");
            }
        }

        public float Y
        {
            get
            {
                return GetMember<float>("Y");
            }
        }

        public float Z
        {
            get
            {
                return GetMember<float>("Z");
            }
        }

        public void Delete()
        {
            ExecuteMethod("Delete");
        }

        public void WaypointTo()
        {
            ExecuteMethod("WaypointTo");
        }

        public void Face()
        {
            ExecuteMethod("Face");
        }

    }

	public class EQ2LocationAllZones : EQ2Location
	{

		public EQ2LocationAllZones(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public EQ2LocationAllZones(Int32 Index)
			: base(LavishScript.Objects.GetObject("EQ2Loc", Index.ToString(), "AllZones"))
		{
		}
	}
}
