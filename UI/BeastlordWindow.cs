using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2beastlordwindow' datatype. Inherits from EQ2Window.
    /// Exposed via the BeastlordWindow TLO. Members are stubbed empty in this
    /// batch and will be filled in by a dedicated BeastlordWindow audit batch.
    /// </summary>
    public class BeastlordWindow : EQ2Window
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public BeastlordWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
