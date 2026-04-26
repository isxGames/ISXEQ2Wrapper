using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2icon' datatype. EQ2IconType inherits from EQ2WidgetType
    /// (INHERITDIRECT(pEQ2WidgetType)) and registers IconID, NodeID, IsReady,
    /// PercentUndimmed, and ToAbility as members. (ToAbility currently lives on
    /// the base EQ2Widget class for legacy reasons; a future batch will migrate
    /// it here.)
    /// </summary>
    public class EQ2Icon : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2Icon(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The icon's IconID. Source: DT-Widgets.cpp:751-756.
        /// </summary>
        public int IconID
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:IconID"));
                return this.GetIntFromLSO("IconID");
            }
        }

        /// <summary>
        /// The icon's NodeID (uint). Source: DT-Widgets.cpp:757-762
        /// (Dest.DWord, Dest.Type = pUIntType).
        /// </summary>
        public uint NodeID
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:NodeID"));
                return this.GetUIntFromLSO("NodeID");
            }
        }

        /// <summary>
        /// True when the icon is "ready" (PercentIconUnDimmed greater than 0).
        /// Source: DT-Widgets.cpp:769-777.
        /// </summary>
        public bool IsReady
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:IsReady"));
                return this.GetBoolFromLSO("IsReady");
            }
        }

        /// <summary>
        /// The fraction of the icon that is currently un-dimmed (0.0 - 1.0).
        /// Source: DT-Widgets.cpp:778-783.
        /// </summary>
        public float PercentUndimmed
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:PercentUndimmed"));
                return this.GetFloatFromLSO("PercentUndimmed");
            }
        }

        #endregion

    }
}
