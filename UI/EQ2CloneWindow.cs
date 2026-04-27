using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2clonewindow' datatype. Source EQ2CloneWindowType
    /// inherits from EQ2WindowType (INHERITDIRECT(pEQ2WindowType)) and registers
    /// a single ID member returning a 64-bit pointer-sized identifier
    /// (DT-Eq2GuiWindows.cpp:147-152, Dest.Type = pInt64PtrType). Several of the
    /// other windows (LootWindow, ChoiceWindow, ContainerWindow, RewardWindow,
    /// ExamineItemWindow, ReplyDialog) inherit from this type in source via
    /// INHERITDIRECT(pEQ2CloneWindowType), so their wrapper classes inherit
    /// EQ2CloneWindow rather than EQ2Window directly.
    /// </summary>
    public class EQ2CloneWindow : EQ2Window
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2CloneWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns a 64-bit identifier that uniquely identifies this clone-window
        /// instance (the underlying window pointer, exposed as int64).
        /// </summary>
        public long ID
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2CloneWindow:ID"));
                return this.GetInt64FromLSO("ID");
            }
        }

        #endregion

    }
}
