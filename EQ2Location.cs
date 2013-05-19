// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Globalization;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// Datatype returned by the EQ2Loc TLO
    /// </summary>
    public class EQ2Location : LavishScriptObject
    {

        #region Constructor

        public EQ2Location(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public EQ2Location(Int32 Index)
            : base(LavishScript.Objects.GetObject("EQ2Loc", Index.ToString()))
        {
        }

        #endregion

        /// <summary>
        /// The label appended to the location
        /// </summary>
		public string Label
        {
            get
            {
                return this.GetStringFromLSO("Label");
            }
        }

        /// <summary>
        /// Notes associated with this location
        /// </summary>
        public string Notes
        {
            get
            {
                return this.GetStringFromLSO("Notes");
            }
        }

        /// <summary>
        /// The zone of the eq2location
        /// </summary>
        public string Zone
        {
            get
            {
                return this.GetStringFromLSO("Zone");
            }
        }

        /// <summary>
        /// x-coordinate
        /// </summary>
        public float X
        {
            get
            {
                return this.GetFloatFromLSO("X");
            }
        }

        /// <summary>
        /// y-coordinate
        /// </summary>
        public float Y
        {
            get
            {
                return this.GetFloatFromLSO("Y");
            }
        }

        /// <summary>
        /// z-coordinate
        /// </summary>
        public float Z
        {
            get
            {
                return this.GetFloatFromLSO("Z");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete()
        {
            ExecuteMethod("Delete");
        }

        /// <summary>
        /// 
        /// </summary>
        public void WaypointTo()
        {
            ExecuteMethod("WaypointTo");
        }

        /// <summary>
        /// 
        /// </summary>
        public void Face()
        {
            ExecuteMethod("Face");
        }

    }

    /// <summary>
    /// Functions as the EQ2Loc TLO
    /// </summary>
	public class EQ2LocationAllZones : EQ2Location
	{

        #region Constructor

        public EQ2LocationAllZones(LavishScriptObject obj)
            : base(obj)
        {
        }

        public EQ2LocationAllZones(Int32 index)
            : base(LavishScript.Objects.GetObject("EQ2Loc", index.ToString(CultureInfo.InvariantCulture), "AllZones"))
        {
        }

        #endregion

	}
}
