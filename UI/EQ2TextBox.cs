using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2textbox' datatype. Inherits from EQ2Widget. Exposes a
    /// single AppendText method. The Recipient/Subject/Body fields of MailWindow
    /// return values of this type.
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
        /// Appends the given text to the textbox. To replace the textbox contents
        /// outright, use SetProperty("Text", value) on the widget instead.
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
