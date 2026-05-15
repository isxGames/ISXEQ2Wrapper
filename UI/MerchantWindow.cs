using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2merchantwindow' datatype. Inherits from EQ2Window.
    /// Exposed via the MerchantWindow TLO. Members are stubbed empty in this
    /// batch and will be filled in by a dedicated MerchantWindow audit batch.
    /// </summary>
    public class MerchantWindow : EQ2Window
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public MerchantWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
