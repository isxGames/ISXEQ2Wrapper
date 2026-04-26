using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
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
        /// The number of rewards in the reward pack.
        /// </summary>
        public int NumRewards
        {
            get
            {
                Trace.WriteLine(String.Format("RewardWindow:NumRewards"));
                return this.GetIntFromLSO("NumRewards");
            }
        }

        /// <summary>
        /// Returns the reward at the specified index. (1 to NumRewards)
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>Reward</returns>
        public Reward Reward(int index)
        {
            Trace.WriteLine(String.Format("RewardWindow:Reward({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Reward(this.GetMember("Reward", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns the reward by LinkID. The first argument is treated as a marker
        /// (any value); the second argument is the LinkID. This matches the source
        /// two-argument form which dispatches on argc==2.
        /// </summary>
        /// <param name="linkID">LinkID of the reward</param>
        /// <param name="n">marker argument (source uses argv[1] for LinkID)</param>
        /// <returns>Reward</returns>
        public Reward Reward(uint linkID, int n)
        {
            Trace.WriteLine(String.Format("RewardWindow:Reward({0}, {1})", linkID.ToString(CultureInfo.InvariantCulture), n.ToString(CultureInfo.InvariantCulture)));
            return new Reward(this.GetMember("Reward", n.ToString(CultureInfo.InvariantCulture), linkID.ToString(CultureInfo.InvariantCulture)));
        }

        #endregion

        #region Methods

        /// <summary>
        /// Accepts the reward. Optionally accepts a specific reward by LinkID;
        /// when called with linkID == 0 (default), the source dispatches based on
        /// the number of rewards in the pack.
        /// </summary>
        /// <remarks>
        /// After invocation, the underlying LavishScript window object becomes
        /// invalid: the source closes the window after sending the accept_reward
        /// command (DT-Eq2GuiWindows.cpp:1445-1446). Treat any held RewardWindow
        /// reference as stale after this call.
        /// </remarks>
        /// <param name="linkID">optional LinkID of the reward to accept (0 = default selection)</param>
        /// <returns>call success</returns>
        public bool AcceptReward(uint linkID = 0)
        {
            Trace.WriteLine(String.Format("RewardWindow:AcceptReward({0})", linkID.ToString(CultureInfo.InvariantCulture)));
            return linkID == 0
                ? this.ExecuteMethod("AcceptReward")
                : this.ExecuteMethod("AcceptReward", linkID.ToString(CultureInfo.InvariantCulture));
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

        #endregion

    }
}
