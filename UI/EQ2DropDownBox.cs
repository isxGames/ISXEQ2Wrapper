using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2dropdownbox' datatype. Source EQ2DropDownBoxType
    /// inherits from EQ2WidgetType (INHERITDIRECT(pEQ2WidgetType)) and registers
    /// Label as a member and Set/GetOptions as methods. This class is a minimal
    /// stub; the dropdown-specific surface will be populated by a future batch.
    /// </summary>
    public class EQ2DropDownBox : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2DropDownBox(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
