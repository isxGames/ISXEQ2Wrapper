using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2uipage' datatype. Source EQ2UIPageType inherits from
    /// EQ2WidgetType (INHERITDIRECT(pEQ2WidgetType)) and registers NumChildren,
    /// ChildType, Child as members and SpewChildren as a method. This class is a
    /// minimal stub so wrapper accessors can return a precise type; the additional
    /// page-specific surface will be populated by a future batch.
    /// </summary>
    public class EQ2UIPage : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2UIPage(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
