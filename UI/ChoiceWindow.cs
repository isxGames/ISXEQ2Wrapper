using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to Choice windows. 
    /// </summary>
    public class ChoiceWindow : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public ChoiceWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// First Choice
        /// </summary>
        public string Choice1
        {
            get
            {
                Trace.WriteLine(String.Format("ChoiceWindow:Choice1"));
                return this.GetStringFromLSO("Choice1");
            }
        }

        /// <summary>
        /// Second Choice
        /// </summary>
        public string Choice2
        {
            get
            {
                Trace.WriteLine(String.Format("ChoiceWindow:Choice2"));
                return this.GetStringFromLSO("Choice2");
            }
        }

        /// <summary>
        /// Choice window text
        /// </summary>
        public string Text
        {
            get
            {
                Trace.WriteLine(String.Format("ChoiceWindow:Text"));
                return this.GetStringFromLSO("Text");
            }
        }

        /// <summary>
        /// Returns the choice window as an EQ2UIPage
        /// </summary>
        public EQ2UIPage ToEQ2UIPage
        {
            get
            {
                Trace.WriteLine(String.Format("ChoiceWindow:ToEQ2UIPage"));
                return new EQ2UIPage(this.GetMember("ToEQ2UIPage"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Selects Choice1
        /// </summary>
        /// <returns>call success</returns>
        public bool DoChoice1()
        {
            Trace.WriteLine(String.Format("ChoiceWindow:DoChoice1()"));
            return this.ExecuteMethod("DoChoice1");
        }

        /// <summary>
        /// Selects Choice2
        /// </summary>
        /// <returns>call success</returns>
        public bool DoChoice2()
        {
            Trace.WriteLine(String.Format("ChoiceWindow:DoChoice2()"));
            return this.ExecuteMethod("DoChoice2");
        }

        #endregion

    }
}
