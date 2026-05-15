using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.CharacterActor
{
    /// <summary>
    /// Represents an object currently being moved/placed in the world via the moveable-object
    /// placement system. Exposed via EQ2.ObjectBeingMoved. Wraps the ISXEQ2 'moveableobject'
    /// datatype.
    /// </summary>
    public class MoveableObject : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public MoveableObject(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The object's location prior to the current move operation
        /// </summary>
        public Point3f OldLocation
        {
            get
            {
                Trace.WriteLine(String.Format("MoveableObject:OldLocation"));
                return new Point3f(this.GetMember("OldLocation"));
            }
        }

        /// <summary>
        /// The object's heading prior to the current move operation
        /// </summary>
        public float OldHeading
        {
            get
            {
                Trace.WriteLine(String.Format("MoveableObject:OldHeading"));
                return this.GetFloatFromLSO("OldHeading");
            }
        }

        /// <summary>
        /// The object's scale prior to the current move operation
        /// </summary>
        public float OldScale
        {
            get
            {
                Trace.WriteLine(String.Format("MoveableObject:OldScale"));
                return this.GetFloatFromLSO("OldScale");
            }
        }

        /// <summary>
        /// The object's heading as currently being placed
        /// </summary>
        public float NewHeading
        {
            get
            {
                Trace.WriteLine(String.Format("MoveableObject:NewHeading"));
                return this.GetFloatFromLSO("NewHeading");
            }
        }

        /// <summary>
        /// The object's scale as currently being placed
        /// </summary>
        public float NewScale
        {
            get
            {
                Trace.WriteLine(String.Format("MoveableObject:NewScale"));
                return this.GetFloatFromLSO("NewScale");
            }
        }

        /// <summary>
        /// Vertical offset (Y delta) of the object as currently being placed
        /// </summary>
        public float HeightOffset
        {
            get
            {
                Trace.WriteLine(String.Format("MoveableObject:HeightOffset"));
                return this.GetFloatFromLSO("HeightOffset");
            }
        }

        /// <summary>
        /// Current mouse X-coordinate (screen-space) during the move operation
        /// </summary>
        public int CurrentMouseX
        {
            get
            {
                Trace.WriteLine(String.Format("MoveableObject:CurrentMouseX"));
                return this.GetIntFromLSO("CurrentMouseX");
            }
        }

        /// <summary>
        /// Current mouse Y-coordinate (screen-space) during the move operation
        /// </summary>
        public int CurrentMouseY
        {
            get
            {
                Trace.WriteLine(String.Format("MoveableObject:CurrentMouseY"));
                return this.GetIntFromLSO("CurrentMouseY");
            }
        }

        /// <summary>
        /// The actor ID of the object being moved
        /// </summary>
        public uint ActorID
        {
            get
            {
                Trace.WriteLine(String.Format("MoveableObject:ActorID"));
                return this.GetUIntFromLSO("ActorID");
            }
        }

        #endregion

    }
}
