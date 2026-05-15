using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2channelerwindow' datatype. Inherits from EQ2Window.
    /// Exposed via the ChannelerWindow TLO. Members are stubbed empty in this
    /// batch and will be filled in by a dedicated ChannelerWindow audit batch.
    /// </summary>
    public class ChannelerWindow : EQ2Window
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public ChannelerWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
