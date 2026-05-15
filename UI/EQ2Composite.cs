using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2composite' datatype. Inherits from EQ2UIPage. Exposes
    /// no members or methods of its own. This class exists as a precise return-type
    /// marker; all useful surface comes from EQ2UIPage and below.
    /// </summary>
    public class EQ2Composite : EQ2UIPage
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2Composite(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
