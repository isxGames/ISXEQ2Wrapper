using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'travelmapwindowlocation' datatype. Represents a single
    /// destination on the TravelMapWindow's location list. Source
    /// TravelMapWindowLocationType (LSTypeDef_Ptr, no INHERITDIRECT) registers
    /// ten members and no methods.
    /// </summary>
    public class TravelMapWindowLocation : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public TravelMapWindowLocation(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The world-space coordinates of the teleport destination.
        /// </summary>
        public Point3f Destination
        {
            get
            {
                Trace.WriteLine(String.Format("TravelMapWindowLocation:Destination"));
                return new Point3f(this.GetMember("Destination"));
            }
        }

        /// <summary>
        /// The destination description (the teleport-location description text).
        /// </summary>
        public string DestinationDescription
        {
            get
            {
                Trace.WriteLine(String.Format("TravelMapWindowLocation:DestinationDescription"));
                return this.GetStringFromLSO("DestinationDescription");
            }
        }

        /// <summary>
        /// The location's unique ID.
        /// </summary>
        public uint ID
        {
            get
            {
                Trace.WriteLine(String.Format("TravelMapWindowLocation:ID"));
                return this.GetUIntFromLSO("ID");
            }
        }

        /// <summary>
        /// The lower level bound for the destination zone.
        /// </summary>
        public int LowerLevel
        {
            get
            {
                Trace.WriteLine(String.Format("TravelMapWindowLocation:LowerLevel"));
                return this.GetIntFromLSO("LowerLevel");
            }
        }

        /// <summary>
        /// The map X-coordinate (screen-space) of this location's pin.
        /// </summary>
        public int MapPositionX
        {
            get
            {
                Trace.WriteLine(String.Format("TravelMapWindowLocation:MapPositionX"));
                return this.GetIntFromLSO("MapPositionX");
            }
        }

        /// <summary>
        /// The map Y-coordinate (screen-space) of this location's pin.
        /// </summary>
        public int MapPositionY
        {
            get
            {
                Trace.WriteLine(String.Format("TravelMapWindowLocation:MapPositionY"));
                return this.GetIntFromLSO("MapPositionY");
            }
        }

        /// <summary>
        /// The upper level bound for the destination zone.
        /// </summary>
        public int UpperLevel
        {
            get
            {
                Trace.WriteLine(String.Format("TravelMapWindowLocation:UpperLevel"));
                return this.GetIntFromLSO("UpperLevel");
            }
        }

        /// <summary>
        /// The destination zone's display description.
        /// </summary>
        public string ZoneDescription
        {
            get
            {
                Trace.WriteLine(String.Format("TravelMapWindowLocation:ZoneDescription"));
                return this.GetStringFromLSO("ZoneDescription");
            }
        }

        /// <summary>
        /// The destination zone's full name.
        /// </summary>
        public string ZoneName
        {
            get
            {
                Trace.WriteLine(String.Format("TravelMapWindowLocation:ZoneName"));
                return this.GetStringFromLSO("ZoneName");
            }
        }

        /// <summary>
        /// The destination zone's short name.
        /// </summary>
        public string ZoneShortName
        {
            get
            {
                Trace.WriteLine(String.Format("TravelMapWindowLocation:ZoneShortName"));
                return this.GetStringFromLSO("ZoneShortName");
            }
        }

        #endregion

    }
}
