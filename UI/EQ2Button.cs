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

    }
}
