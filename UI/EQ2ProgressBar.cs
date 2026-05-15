using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2progressbar' datatype. Inherits from EQ2Widget. Exposes
    /// no members or methods of its own. This class exists as a precise return-type
    /// marker; all useful surface (including Percent) comes from EQ2Widget.
    /// </summary>
    public class EQ2ProgressBar : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2ProgressBar(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
