using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
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
        /// Cache of Description
        /// </summary>
        private string _description;

        /// <summary>
        /// Effect Description
        /// </summary>
        public string Description
        {
            get
            {
                Trace.WriteLine(String.Format("Effect:Description"));
                return _description ?? (_description = this.GetStringFromLSO("Description"));
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
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Effect Name
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Effect:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
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

        #endregion

    }
}
