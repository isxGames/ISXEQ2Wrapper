using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to reply dialogs. 
    /// </summary>
    public class ReplyDialog : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public ReplyDialog(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Text
        /// </summary>
        public string Text
        {
            get
            {
                Trace.WriteLine(String.Format("ReplyDialog:Text"));
                return this.GetStringFromLSO("Text");
            }
        }

        /// <summary>
        /// Returns the ReplyDialog as an EQ2Window
        /// </summary>
        public EQ2Window ToEQ2UIPage
        {
            get
            {
                Trace.WriteLine(String.Format("ReplyDialog:ToEQ2UIPage"));
                return new EQ2Window(this.GetMember("ToEQ2UIPage"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Selects the dialog by index.
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>call success</returns>
        public bool Choose(int index)
        {
            Trace.WriteLine(String.Format("ReplyDialog:Choose({0})", index.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("Choose", index.ToString(CultureInfo.InvariantCulture));
        }

        /// TODO:Find out if Select is Redundant
        /// <summary>
        /// Selects the dialog by index.
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>call success</returns>
        public bool Select(int index)
        {
            Trace.WriteLine(String.Format("ReplyDialog:Select({0})", index.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("Select", index.ToString(CultureInfo.InvariantCulture));
        }

        #endregion

    }
}
