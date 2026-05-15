using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2reforgewindow' datatype. Inherits from EQ2Window.
    /// Exposed via the ReforgeWindow TLO. Members are stubbed empty in this
    /// batch and will be filled in by a dedicated ReforgeWindow audit batch.
    /// </summary>
    public class ReforgeWindow : EQ2Window
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public ReforgeWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
