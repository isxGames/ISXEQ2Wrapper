using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType provides control over and information about Saved EQ2 Locations. 
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

        #region Members

        /// <summary>
        /// Cache of Label
        /// </summary>
        private string _label;

        /// <summary>
        /// The label appended to the location
        /// </summary>
        public string Label
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Location:Label"));
                return _label ?? (_label = this.GetStringFromLSO("Label"));
            }
        }

        /// <summary>
        /// Cache of Notes
        /// </summary>
        private string _notes;

        /// <summary>
        /// Notes associated with this location
        /// </summary>
        public string Notes
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Location:Notes"));
                return _notes ?? (_notes = this.GetStringFromLSO("Notes"));   
            }

        }

        /// <summary>
        /// Cache of X
        /// </summary>
        private float? _x;

        /// <summary>
        /// x-coordinate
        /// </summary>
        public float X
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Location:X"));
                if(!_x.HasValue)
                    _x = this.GetFloatFromLSO("X");
                return _x.Value;
            }
        }

        /// <summary>
        /// Cache of Y
        /// </summary>
        private float? _y;

        /// <summary>
        /// y-coordinate
        /// </summary>
        public float Y
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Location:Y"));
                if(!_y.HasValue)
                    _y = this.GetFloatFromLSO("Y");
                return _y.Value;
            }
        }

        /// <summary>
        /// Cache of Z
        /// </summary>
        private float? _z;

        /// <summary>
        /// z-coordinate
        /// </summary>
        public float Z
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Location:Z"));
                if(!_z.HasValue)
                    _z = this.GetFloatFromLSO("Z");
                return _z.Value;
            }
        }

        /// <summary>
        /// Cache of Zone
        /// </summary>
        private string _zone;

        /// <summary>
        /// The zone of the eq2location
        /// </summary>
        public string Zone
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Location:Zone"));
                return _zone ?? (_zone = this.GetStringFromLSO("Zone"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Deletes the eq2location
        /// </summary>
        /// <returns>call success</returns>
        public bool Delete()
        {
            Trace.WriteLine(String.Format("EQ2Location:Delete"));
            return this.ExecuteMethod("Delete");
        }

        /// <summary>
        /// Rotates the character towards the eq2location
        /// </summary>
        /// <returns>call success</returns>
        public bool Face()
        {
            Trace.WriteLine(String.Format("EQ2Location:Face"));
            return this.ExecuteMethod("Face");
        }

        /// <summary>
        /// Creates an ingame waypoint to the eq2location
        /// </summary>
        /// <returns>call success</returns>
        public bool WaypointTo()
        {
            Trace.WriteLine(String.Format("EQ2Location:WaypointTo"));
            return this.ExecuteMethod("WaypointTo");
        }

        #endregion

    }
}
