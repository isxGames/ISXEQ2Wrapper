using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2travelmapwindow' datatype. Inherits from EQ2Window.
    /// Exposed via the TravelMapWindow TLO. Members are stubbed empty in this
    /// batch and will be filled in by a dedicated TravelMapWindow audit batch.
    /// </summary>
    public class TravelMapWindow : EQ2Window
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public TravelMapWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
