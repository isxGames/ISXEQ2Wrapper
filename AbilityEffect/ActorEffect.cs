using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.AbilityEffect
{
    /// <summary>
    /// Wraps the source 'actoreffect' datatype. Represents a single effect entry
    /// from an actor's effect list (as opposed to the player's own Effect entries
    /// which are LSTypeDef_Int and live on Effect/Maintained). Source
    /// ActorEffectType (LSTypeDef_Ptr, no INHERITDIRECT) registers six members and
    /// one method.
    /// </summary>
    public class ActorEffect : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public ActorEffect(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The icon ID of the effect's backdrop
        /// </summary>
        public int BackDropIconID
        {
            get
            {
                Trace.WriteLine(String.Format("ActorEffect:BackDropIconID"));
                return this.GetIntFromLSO("BackDropIconID");
            }
        }

        /// <summary>
        /// The current stack count of the effect on the actor
        /// </summary>
        public int CurrentIncrements
        {
            get
            {
                Trace.WriteLine(String.Format("ActorEffect:CurrentIncrements"));
                return this.GetIntFromLSO("CurrentIncrements");
            }
        }

        /// <summary>
        /// The effect's ID
        /// </summary>
        public int ID
        {
            get
            {
                Trace.WriteLine(String.Format("ActorEffect:ID"));
                return this.GetIntFromLSO("ID");
            }
        }

        /// <summary>
        /// Returns true once the underlying examine-effect data has loaded.
        /// First access triggers an asynchronous fetch and returns false; poll
        /// until it returns true before reading ToEffectInfo.
        /// </summary>
        public bool IsEffectInfoAvailable
        {
            get
            {
                Trace.WriteLine(String.Format("ActorEffect:IsEffectInfoAvailable"));
                return this.GetBoolFromLSO("IsEffectInfoAvailable");
            }
        }

        /// <summary>
        /// The icon ID of the effect's main icon
        /// </summary>
        public int MainIconID
        {
            get
            {
                Trace.WriteLine(String.Format("ActorEffect:MainIconID"));
                return this.GetIntFromLSO("MainIconID");
            }
        }

        /// <summary>
        /// Returns the EffectInfo for this effect. Use IsEffectInfoAvailable to
        /// confirm the effectinfo data has loaded before reading members.
        /// </summary>
        public EffectInfo ToEffectInfo
        {
            get
            {
                Trace.WriteLine(String.Format("ActorEffect:ToEffectInfo"));
                return new EffectInfo(this.GetMember("ToEffectInfo"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Examines the effect (issues 'info effect &lt;id&gt;').
        /// </summary>
        /// <returns>call success</returns>
        public bool Examine()
        {
            Trace.WriteLine(String.Format("ActorEffect:Examine()"));
            return this.ExecuteMethod("Examine");
        }

        #endregion

    }
}
