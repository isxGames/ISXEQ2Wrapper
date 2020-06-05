using System;
using System.Diagnostics;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Allows interaction with Reward Windows. 
    /// </summary>
    public class RewardWindow : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public RewardWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns the RewardWindow as an EQ2Window
        /// </summary>
        public EQ2Window ToEQ2UIPage
        {
            get
            {
                Trace.WriteLine(String.Format("RewardWindow:ToEQ2UIPage"));
                return new EQ2Window(this.GetMember("ToEQ2UIPage"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Accepts the reward
        /// </summary>
        /// <returns>call success</returns>
        public bool Accept()
        {
            Trace.WriteLine(String.Format("RewardWindow:Accept()"));
            return this.ExecuteMethod("Accept");
        }

        /// <summary>
        /// Cancels the reward window
        /// </summary>
        /// <returns>call success</returns>
        public bool Cancel()
        {
            Trace.WriteLine(String.Format("RewardWindow:Cancel()"));
            return this.ExecuteMethod("Cancel");
        }

        /// <summary>
        /// Receives the reward
        /// </summary>
        /// <returns></returns>
        public bool Receive()
        {
            Trace.WriteLine(String.Format("RewardWindow:Receive()"));
            return this.ExecuteMethod("Receive");
        }

        #endregion

    }
}
