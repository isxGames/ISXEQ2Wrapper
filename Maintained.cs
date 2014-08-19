using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to 
    /// maintained buffs or debuffs attributed to the current player character. 
    /// </summary>
    public class Maintained : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Maintained(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of ConcentrationCost
        /// </summary>
        private int? _concentrationCost;

        /// <summary>
        /// Maintained effect concentration cost
        /// </summary>
        public int ConcentrationCost
        {
            get
            {
                Trace.WriteLine(String.Format("Maintained:ConcentrationCost"));
                if(!_concentrationCost.HasValue)
                    _concentrationCost = this.GetIntFromLSO("ConcentrationCost");
                return _concentrationCost.Value;
            }
        }

        /// <summary>
        /// Returns the total number of increments of the maintained effect
        /// </summary>
        public int CurrentIncrements
        {
            get
            {
                Trace.WriteLine(String.Format("Maintained:CurrentIncrements"));
                return this.GetIntFromLSO("CurrentIncrements");
            }
        }

        /// <summary>
        /// This is the current duration of the buff/debuff in seconds. 
        /// Buffs/Debuffs that do not have a duration (ie, last forever) will return -1.
        /// </summary>
        public float Duration
        {
            get
            {
                Trace.WriteLine(String.Format("Maintained:Duration"));
                return this.GetFloatFromLSO("Duration");
            }
        }

        /// <summary>
        /// Cache of IsBeneficial
        /// </summary>
        private bool? _isBeneficial;

        /// <summary>
        /// Returns TRUE if teh maintained effect is beneficial (buff)
        /// </summary>
        public bool IsBeneficial
        {
            get
            {
                Trace.WriteLine(String.Format("Maintained:IsBeneficial"));
                if (!_isBeneficial.HasValue)
                    _isBeneficial = this.GetBoolFromLSO("IsBeneficial");
                return _isBeneficial.Value;
            }

        }

        /// <summary>
        /// Cache of MaxDuration
        /// </summary>
        private float? _maxDuration;

        /// <summary>
        /// This is the current duration of the buff/debuff in seconds.
        ///  Buffs/Debuffs that do not have a duration (ie, last forever) will return -1.
        /// </summary>
        public float MaxDuration
        {
            get
            {
                Trace.WriteLine(String.Format("Maintained:MaxDuration"));
                if(!_maxDuration.HasValue)
                    _maxDuration = this.GetFloatFromLSO("MaxDuration");
                return _maxDuration.Value;
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Maintained effect name
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Maintained:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Returns the targget of the maintained buff.
        /// This only works for maintained buffs/debuffs that are of the "Type": 'single target'.
        /// If the Target is no longer alive or present in the game, it will return NULL.
        /// </summary>
        /// <returns>maintained effect target as actor</returns>
        public Actor Target
        {
            get
            {
                Trace.WriteLine(String.Format("Maintained:Target"));
                return new Actor(this.GetMember("Target"));
            }
        }

        /// <summary>
        /// Cache of Type
        /// </summary>
        private string _type;

        /// <summary>
        /// This member returns one of the following strings: self only,pet only,group, or single target
        /// </summary>
        public string Type
        {
            get
            {
                Trace.WriteLine(String.Format("Maintained:Type"));
                return _type ?? (_type = this.GetStringFromLSO("Type"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Cancels the maintained effect, if possible
        /// </summary>
        /// <returns>call success</returns>
        public bool Cancel()
        {
            Trace.WriteLine(String.Format("Maintained:Cancel()"));
            return this.ExecuteMethod("Cancel");
        }

        /// <summary>
        /// Examines the maintained effect
        /// </summary>
        /// <returns></returns>
        public bool Examine()
        {
            Trace.WriteLine(String.Format("Maintained:Examine()"));
            return this.ExecuteMethod("Examine");
        }


        #endregion
    
    }
}
