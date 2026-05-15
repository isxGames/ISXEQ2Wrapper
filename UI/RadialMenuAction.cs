using System;
using System.Diagnostics;
using EQ2.ISXEQ2.CharacterActor;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'radialmenuaction' datatype. Represents a single action
    /// entry inside a RadialMenuWindow. Note: RadialMenuAction is NOT a window; it
    /// inherits LavishScriptObject directly.
    /// </summary>
    public class RadialMenuAction : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public RadialMenuAction(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The command line associated with this action.
        /// </summary>
        public string Command
        {
            get
            {
                Trace.WriteLine(String.Format("RadialMenuAction:Command"));
                return this.GetStringFromLSO("Command");
            }
        }

        /// <summary>
        /// The label shown for this action on the radial menu.
        /// </summary>
        public string Label
        {
            get
            {
                Trace.WriteLine(String.Format("RadialMenuAction:Label"));
                return this.GetStringFromLSO("Label");
            }
        }

        /// <summary>
        /// The maximum range at which this action is usable.
        /// </summary>
        public float MaxRange
        {
            get
            {
                Trace.WriteLine(String.Format("RadialMenuAction:MaxRange"));
                return this.GetFloatFromLSO("MaxRange");
            }
        }

        /// <summary>
        /// The actor that this action targets.
        /// </summary>
        public Actor Target
        {
            get
            {
                Trace.WriteLine(String.Format("RadialMenuAction:Target"));
                return new Actor(this.GetMember("Target"));
            }
        }

        /// <summary>
        /// True if the action is currently unavailable (greyed out).
        /// </summary>
        public bool Unavailable
        {
            get
            {
                Trace.WriteLine(String.Format("RadialMenuAction:Unavailable"));
                return this.GetBoolFromLSO("Unavailable");
            }
        }

        /// <summary>
        /// The reason text shown when the action is unavailable.
        /// </summary>
        public string UnavailableReason
        {
            get
            {
                Trace.WriteLine(String.Format("RadialMenuAction:UnavailableReason"));
                return this.GetStringFromLSO("UnavailableReason");
            }
        }

        /// <summary>
        /// The verb shown for this action (e.g. the action's UI verb form).
        /// </summary>
        public string Verb
        {
            get
            {
                Trace.WriteLine(String.Format("RadialMenuAction:Verb"));
                return this.GetStringFromLSO("Verb");
            }
        }

        #endregion

    }
}
