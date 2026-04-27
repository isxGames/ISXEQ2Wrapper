using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.AbilityEffect
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to effects that are on the current player character.
    /// </summary>
    public class Effect : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Effect(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of BackDropID
        /// </summary>
        private int? _backDropID;

        /// <summary>
        /// Back Drop ID of Effect
        /// </summary>
        public int BackDropIconID
        {
            get
            {
                Trace.WriteLine(String.Format("Effect:BackDropIconID"));
                if(!_backDropID.HasValue)
                    _backDropID = this.GetIntFromLSO("BackDropIconID");
                return _backDropID.Value;
            }
        }

        /// <summary>
        /// Current Increments on Effect
        /// </summary>
        public int CurrentIncrements
        {
            get
            {
                Trace.WriteLine(String.Format("Effect:CurrentIncrements"));
                return this.GetIntFromLSO("CurrentIncrements");
            }
        }

        /// <summary>
        /// This is the current duration of the effect in seconds.
        /// </summary>
        public float Duration
        {
            get
            {
                Trace.WriteLine(String.Format("Effect:Duration"));
                return this.GetFloatFromLSO("Duration");
            }
        }

        /// <summary>
        /// Cache of ID
        /// </summary>
        private int? _iD;

        /// <summary>
        /// Effect ID
        /// </summary>
        public int ID
        {
            get
            {
                Trace.WriteLine(String.Format("Effect:ID"));
                if(!_iD.HasValue)
                    _iD = this.GetIntFromLSO("ID");
                return _iD.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the effectinfo data has been loaded for this effect.
        /// If FALSE, accessing EffectInfo members may return stale or default values
        /// while ISXEQ2 asynchronously requests the data from the server.
        /// </summary>
        public bool IsEffectInfoAvailable
        {
            get
            {
                Trace.WriteLine(String.Format("Effect:IsEffectInfoAvailable"));
                return this.GetBoolFromLSO("IsEffectInfoAvailable");
            }
        }

        /// <summary>
        /// Cache of MainIconID
        /// </summary>
        private int? _mainIconID;

        /// <summary>
        /// Effect main icon ID
        /// </summary>
        public int MainIconID
        {
            get
            {
                Trace.WriteLine(String.Format("Effect:MainIconID"));
                if(!_mainIconID.HasValue)
                    _mainIconID = this.GetIntFromLSO("MainIconID");
                return _mainIconID.Value;
            }
        }

        /// <summary>
        /// Cache of MaxDuration
        /// </summary>
        private float? _maxDuration;

        /// <summary>
        /// This is the maximum duration of the effect in seconds.
        /// Note: If you log off and back on with 'duration' buffs/effects, 
        /// will notice that the 'MaxDuration' will change to reflect that. 
        /// </summary>
        public float MaxDuration
        {
            get
            {
                Trace.WriteLine(String.Format("Effect:MaxDuration"));
                if(!_maxDuration.HasValue)
                    _maxDuration = this.GetFloatFromLSO("MaxDuration");
                return _maxDuration.Value;
            }
        }

        /// <summary>
        /// Returns the EffectInfo for this effect.
        /// Use IsEffectInfoAvailable to confirm the effectinfo data has loaded.
        /// </summary>
        public EffectInfo ToEffectInfo
        {
            get
            {
                Trace.WriteLine(String.Format("Effect:ToEffectInfo"));
                return new EffectInfo(this.GetMember("ToEffectInfo"));
            }
        }

        /// <summary>
        /// Cache of Type
        /// </summary>
        private string _type;

        /// <summary>
        /// The effect type (e.g. spell category string)
        /// </summary>
        public string Type
        {
            get
            {
                Trace.WriteLine(String.Format("Effect:Type"));
                return _type ?? (_type = this.GetStringFromLSO("Type"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Cancels the effect, if possible
        /// </summary>
        /// <returns>call success</returns>
        public bool Cancel()
        {
            Trace.WriteLine(String.Format("Effect:Cancel()"));
            return this.ExecuteMethod("Cancel");
        }

        /// <summary>
        /// Examines the effect
        /// </summary>
        /// <returns>call success</returns>
        public bool Examine()
        {
            Trace.WriteLine(String.Format("Effect:Examine()"));
            return this.ExecuteMethod("Examine");
        }

        /// <summary>
        /// Hides the effect's icon from the on-screen effect window
        /// </summary>
        /// <returns>call success</returns>
        public bool Hide()
        {
            Trace.WriteLine(String.Format("Effect:Hide()"));
            return this.ExecuteMethod("Hide");
        }

        #endregion

    }
}
