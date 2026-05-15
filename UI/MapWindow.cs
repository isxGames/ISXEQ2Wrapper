using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2mapwindow' datatype. Inherits from EQ2CloneWindow.
    /// Exposed via the MapWindow TLO. Members are stubbed empty in this batch
    /// and will be filled in by a dedicated MapWindow audit batch.
    /// </summary>
    public class MapWindow : EQ2CloneWindow
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public MapWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
