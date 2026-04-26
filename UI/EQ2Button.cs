using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2button' datatype. Source EQ2ButtonType inherits from
    /// EQ2WidgetType (INHERITDIRECT(pEQ2WidgetType)) and registers a single Text
    /// member. All other useful surface comes from EQ2Widget.
    /// </summary>
    public class EQ2Button : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2Button(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The button's display text. Convenience for GetProperty("Text") —
        /// source (DT-Widgets.cpp:451-470) reads the underlying CButton's Text
        /// property directly. Added to source on 2024-01-01 [20231212.0025].
        /// </summary>
        public new string Text
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Button:Text"));
                return this.GetStringFromLSO("Text");
            }
        }

        #endregion

    }
}
