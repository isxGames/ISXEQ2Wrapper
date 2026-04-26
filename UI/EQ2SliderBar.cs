using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2sliderbar' datatype. Source EQ2SliderBarType inherits
    /// from EQ2WidgetType (INHERITDIRECT(pEQ2WidgetType)) and registers no
    /// members or methods of its own. This class exists as a precise return-type
    /// marker; all useful surface comes from EQ2Widget.
    /// </summary>
    public class EQ2SliderBar : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2SliderBar(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
