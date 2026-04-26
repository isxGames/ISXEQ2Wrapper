using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2list' datatype. Source EQ2ListType inherits from
    /// EQ2WidgetType (INHERITDIRECT(pEQ2WidgetType)) and registers HighlightRow
    /// and GetOptions as methods (no members of its own). This class is a minimal
    /// stub; the list-specific surface will be populated by a future batch.
    /// </summary>
    public class EQ2List : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2List(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
