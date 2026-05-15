using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'reward' datatype. Represents a single reward entry inside
    /// a RewardWindow's reward pack. Exposes a single LinkID member.
    /// </summary>
    public class Reward : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Reward(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns the LinkID of this reward entry.
        /// </summary>
        public uint LinkID
        {
            get
            {
                Trace.WriteLine(String.Format("Reward:LinkID"));
                return this.GetUIntFromLSO("LinkID");
            }
        }

        #endregion

    }
}
