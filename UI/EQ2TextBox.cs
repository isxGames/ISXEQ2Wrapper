using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2textbox' datatype. Source EQ2TextBoxType inherits
    /// from EQ2WidgetType (INHERITDIRECT(pEQ2WidgetType)) and registers a single
    /// AppendText method. The Recipient/Subject/Body fields of MailWindow return
    /// values of this type.
    /// </summary>
    public class EQ2TextBox : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2TextBox(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Methods

        /// <summary>
        /// Appends the given text to the textbox. The source comment notes that
        /// to "SetText" the wrapper should use SetProperty("Text", value) instead.
        /// </summary>
        /// <param name="text">text to append</param>
        /// <returns>call success</returns>
        public bool AppendText(string text)
        {
            Trace.WriteLine(String.Format("EQ2TextBox:AppendText({0})", text));
            return this.ExecuteMethod("AppendText", text);
        }

        #endregion

    }
}
