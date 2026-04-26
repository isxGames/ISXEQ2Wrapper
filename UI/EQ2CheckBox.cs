using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2checkbox' datatype. Source EQ2CheckBoxType inherits
    /// from EQ2WidgetType (INHERITDIRECT(pEQ2WidgetType)) and registers no
    /// members or methods of its own. This class exists as a precise return-type
    /// marker; all useful surface comes from EQ2Widget.
    /// </summary>
    public class EQ2CheckBox : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2CheckBox(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
