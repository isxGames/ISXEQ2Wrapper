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
}
