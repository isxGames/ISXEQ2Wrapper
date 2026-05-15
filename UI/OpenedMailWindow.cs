using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2openedmailwindow' datatype. Represents the window shown
    /// when an inbox message has been opened. Inherits from EQ2Window. Exposes a
    /// single Message member and a single Cancel method.
    /// </summary>
    public class OpenedMailWindow : EQ2Window
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public OpenedMailWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The message currently displayed in this opened mail window.
        /// </summary>
        public MailMessage Message
        {
            get
            {
                Trace.WriteLine(String.Format("OpenedMailWindow:Message"));
                return new MailMessage(this.GetMember("Message"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Cancels (closes) the opened mail window.
        /// </summary>
        /// <returns>call success</returns>
        public bool Cancel()
        {
            Trace.WriteLine(String.Format("OpenedMailWindow:Cancel()"));
            return this.ExecuteMethod("Cancel");
        }

        #endregion

    }
}
