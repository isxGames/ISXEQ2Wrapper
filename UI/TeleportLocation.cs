using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'teleportlocation' datatype. Represents a single teleport
    /// destination on the MapWindow's teleport list. Exposes three members; an
    /// Examine method exists upstream but is not currently registered, so it is
    /// intentionally omitted from this wrapper.
    /// </summary>
    public class TeleportLocation : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public TeleportLocation(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The description of this teleport location.
        /// </summary>
        public string Description
        {
            get
            {
                Trace.WriteLine(String.Format("TeleportLocation:Description"));
                return this.GetStringFromLSO("Description");
            }
        }

        /// <summary>
        /// The teleport location's unique ID.
        /// </summary>
        public uint ID
        {
            get
            {
                Trace.WriteLine(String.Format("TeleportLocation:ID"));
                return this.GetUIntFromLSO("ID");
            }
        }

        /// <summary>
        /// The world-space coordinates of this teleport location.
        /// </summary>
        public Point3f Location
        {
            get
            {
                Trace.WriteLine(String.Format("TeleportLocation:Location"));
                return new Point3f(this.GetMember("Location"));
            }
        }

        #endregion

    }
}
