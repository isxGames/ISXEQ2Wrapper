using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.AbilityEffect
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to Achievements.
    /// </summary>
    public class Achievement : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Achievement(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of description
        /// </summary>
        private string _description;

        /// <summary>
        /// Achievement Description
        /// </summary>
        public string Description
        {
            get
            {
                Trace.WriteLine(String.Format("Achievement:Description"));
                return _description ?? (_description = this.GetStringFromLSO("Description"));
            }
        }

        /// <summary>
        /// Cache of ID
        /// </summary>
        private int? _iD;

        /// <summary>
        /// Achievement ID
        /// </summary>
        public int ID
        {
            get
            {
                Trace.WriteLine(String.Format("Achievement:ID"));
                if(!_iD.HasValue)
                    _iD = this.GetIntFromLSO("ID");
                return _iD.Value;
            }
        }

        /// <summary>
        /// Cache of Level
        /// </summary>
        private int? _level;

        /// <summary>
        /// Achievement level
        /// </summary>
        public int Level
        {
            get
            {
                Trace.WriteLine(String.Format("Achievement:Level"));
                if(!_level.HasValue)
                    _level = this.GetIntFromLSO("Level");
                return _level.Value;
            }
        }

        /// <summary>
        /// Cache of MaxLevel
        /// </summary>
        private int? _maxLevel;

        /// <summary>
        /// Max Level of the Achievement
        /// </summary>
        public int MaxLevel
        {
            get
            {
                Trace.WriteLine(String.Format("Achievement:MaxLevel"));
                if(!_maxLevel.HasValue)
                    _maxLevel = this.GetIntFromLSO("MaxLevel");
                return _maxLevel.Value;
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Achievement name
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Achievement:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Cache of PointCostPerLevel
        /// </summary>
        private int? _pointCostPerLevel;

        /// <summary>
        /// Achievement point cost per level
        /// </summary>
        public int PointCostPerLevel
        {
            get
            {
                Trace.WriteLine(String.Format("Achievement:PointCostPerLevel"));
                if(!_pointCostPerLevel.HasValue)
                    _pointCostPerLevel = this.GetIntFromLSO("PointCostPerLevel");
                return _pointCostPerLevel.Value;
            }
        }

        /// <summary>
        /// Cache of ReqLevelToBuy
        /// </summary>
        private int? _reqLevelToBuy;

        /// <summary>
        /// Requred level to purchase the Achievement
        /// </summary>
        public int ReqLevelToBuy
        {
            get
            {
                Trace.WriteLine(String.Format("Achievement:ReqLevelToBuy"));
                if(!_reqLevelToBuy.HasValue)
                    _reqLevelToBuy = this.GetIntFromLSO("ReqLevelToBuy");
                return _reqLevelToBuy.Value;
            }
        }

        /// <summary>
        /// Returns the achievement as an ability
        /// </summary>
        /// <returns>ability</returns>
        public Ability ToAbility
        {
            get
            {
                Trace.WriteLine(String.Format("Achievement:ToAbility"));
                return new Ability(this.GetMember("ToAbility"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Examines the achievement
        /// </summary>
        /// <returns>call success</returns>
        public bool Examine()
        {
            Trace.WriteLine(String.Format("Achievement:Examine()"));
            return this.ExecuteMethod("Examine");
        }


        #endregion

    }
}
