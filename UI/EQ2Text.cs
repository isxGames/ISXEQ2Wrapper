using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2text' datatype. Inherits from EQ2Widget. Exposes no
    /// members or methods of its own. All useful surface comes from EQ2Widget;
    /// this class exists as a precise return-type marker for accessors that return
    /// an 'eq2text' (e.g. CurrentQuest's nine fields).
    /// </summary>
    public class EQ2Text : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2Text(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
