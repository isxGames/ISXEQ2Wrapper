using System;
using System.Diagnostics;
using System.Globalization;
using LavishScriptAPI;
using EQ2.ISXEQ2.Extensions;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to abilities.
    /// An 'ability' is defined as any skill found in your knowledge book. 
    /// </summary>
    public class Ability : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Ability(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of AllowRaid
        /// </summary>
        private bool? _allowRaid;

        /// <summary>
        /// Returns TRUE if the ability can be used on raid members
        /// </summary>
        public bool AllowRaid
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:AllowRaid"));
                if(!_allowRaid.HasValue)
                    _allowRaid = this.GetBoolFromLSO("AllowRaid");
                return _allowRaid.Value;
            }
        }

        /// <summary>
        /// Cache of BackDropIconID
        /// </summary>
        private int? _backDropIconID;

        /// <summary>
        /// Ability Back Drop ID
        /// </summary>
        public int BackDropIconID
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:BackDropIconID"));
                if(!_backDropIconID.HasValue)
                    _backDropIconID = this.GetIntFromLSO("BackDropIconID");
                return _backDropIconID.Value;
            }
        }

        /// <summary>
        /// The casting time of the ability
        /// </summary>
        public float CastingTime
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:CastingTime"));
                return this.GetFloatFromLSO("CastingTime");
            }
        }

        /// <summary>
        /// Returns the class at the index
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>class</returns>
        public Class Class(int index)
        {
            Trace.WriteLine(String.Format("Ability:Class({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Class(this.GetMember("Class", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns the class by class name
        /// </summary>
        /// <param name="name">class name</param>
        /// <returns>class</returns>
        public Class Class(string name)
        {
            Trace.WriteLine(String.Format("Ability:Class({0})", name));
            return new Class(this.GetMember("Class", name));
        }

        /// <summary>
        /// Cache of ConcentrationCost
        /// </summary>
        private int? _concentrationCost;

        /// <summary>
        /// The concentration cost of the ability
        /// </summary>
        public int ConcentrationCost
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:ConcentrationCost"));
                if(!_concentrationCost.HasValue)
                    _concentrationCost = this.GetIntFromLSO("ConcentrationCost");
                return _concentrationCost.Value;
            }
        }

        /// <summary>
        /// Cache of Description
        /// </summary>
        private string _description;

        /// <summary>
        /// The ability description
        /// </summary>
        public string Description
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:Description"));
                return _description ?? (_description = this.GetStringFromLSO("Description"));
            }
        }

        /// <summary>
        /// Cache of DissonanceCost
        /// </summary>
        private int? _dissonanceCost;

        /// <summary>
        /// Ability DissonanceCost (Channelers)
        /// </summary>
        public int DissonanceCost
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:DissonanceCost"));
                if (!_dissonanceCost.HasValue)
                    _dissonanceCost = this.GetIntFromLSO("DissonanceCost");
                return _dissonanceCost.Value;
            }
        }

        /// <summary>
        /// Cache of DissonanceCostPerTick
        /// </summary>
        private int? _dissonanceCostPerTick;

        /// <summary>
        /// Ability Dissonance Cost Per Tick (Channelers)
        /// </summary>
        public int DissonanceCostPerTick
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:DissonanceCostPerTick"));
                if (!_dissonanceCostPerTick.HasValue)
                    _dissonanceCostPerTick = this.GetIntFromLSO("DissonanceCostPerTick");
                return _dissonanceCostPerTick.Value;
            }
        }

        /// <summary>
        /// Cache of DoesNotExpire
        /// </summary>
        private bool? _doesNotExpire;

        /// <summary>
        /// Returns TRUE if the ability does not expire
        /// </summary>
        public bool DoesNotExpire
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:DoesNotExpire"));
                if(!_doesNotExpire.HasValue)
                    _doesNotExpire = this.GetBoolFromLSO("DoesNotExpire");
                return _doesNotExpire.Value;
            }
        }

        /// <summary>
        /// Returns the ability effect at the specified index
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>ability effect</returns>
        public AbilityEffect Effect(int index)
        {
            Trace.WriteLine(String.Format("Ability:Effect({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new AbilityEffect(this.GetMember("Effect", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Cache of EffectRadius
        /// </summary>
        private float? _effectRadius;

        /// <summary>
        /// The radius of the ability effect
        /// </summary>
        public float EffectRadius
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:EffectRadius"));
                if (!_effectRadius.HasValue)
                    _effectRadius = this.GetFloatFromLSO("EffectRadius");
                return _effectRadius.Value;
            }
        }

        /// <summary>
        /// Cache of GroupRestricted
        /// </summary>
        private bool? _groupRestricted;

        /// <summary>
        /// Returns TRUE if the ability is restricted to group members only
        /// </summary>
        public bool GroupRestricted
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:GroupRestricted"));
                if(!_groupRestricted.HasValue)
                    _groupRestricted = this.GetBoolFromLSO("GroupRestricted");
                return _groupRestricted.Value;
            }
        }

        /// <summary>
        /// Cache of HealthCost
        /// </summary>
        private int? _healthCost;

        /// <summary>
        /// The health cost of the ability
        /// </summary>
        public int HealthCost
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:HealthCost"));
                if(!_healthCost.HasValue)
                    _healthCost = this.GetIntFromLSO("HealthCost");
                return _healthCost.Value;
            }
        }

        /// <summary>
        /// Cache of HealthCostPerTick
        /// </summary>
        private int? _healthCostPerTick;

        /// <summary>
        /// The health cost per tick of the ability
        /// </summary>
        public int HealthCostPerTick
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:HealthCostPerTick"));
                if(!_healthCostPerTick.HasValue)
                    _healthCostPerTick = this.GetIntFromLSO("HealthCostPerTick");
                return _healthCostPerTick.Value;
            }
        }

        /// <summary>
        /// Cache of HOIconID
        /// </summary>
        private int? _hOIconID;

        /// <summary>
        /// The heroic opportunity icon ID of the ability. -1 indicates no icon.
        /// </summary>
        public int HOIconID
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:HOIconID"));
                if(!_hOIconID.HasValue)
                    _hOIconID = this.GetIntFromLSO("HOIconID");
                return _hOIconID.Value;
            }
        }

        /// <summary>
        /// Cache of ID
        /// </summary>
        private uint? _iD;

        /// <summary>
        /// Ability ID
        /// </summary>
        public uint ID
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:ID"));
                if(!_iD.HasValue)
                    _iD = this.GetUIntFromLSO("ID");
                return _iD.Value;
            }
        }

        /// <summary>
        /// Cache of IsBeneficial
        /// </summary>
        private bool? _isBeneficial;

        /// <summary>
        /// Returns TRUE if the ability is beneficial (buff)
        /// </summary>
        public bool IsBeneficial
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:IsBeneficial"));
                if (!_isBeneficial.HasValue)
                    _isBeneficial = this.GetBoolFromLSO("IsBeneficial");
                return _isBeneficial.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the ability is queued
        /// </summary>
        public bool IsQueued
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:IsQueued"));
                return this.GetBoolFromLSO("IsQueued");
            }
        }

        /// <summary>
        /// Returns TRUE if the ability is ready
        /// </summary>
        public bool IsReady
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:IsReady"));
                return this.GetBoolFromLSO("IsReady");
            }
        }

        /// <summary>
        /// Cache of MainIconID
        /// </summary>
        private int? _mainIconID;

        /// <summary>
        /// The main icon ID of the ability
        /// </summary>
        public int MainIconID
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:MainIconID"));
                if(!_mainIconID.HasValue)
                    _mainIconID = this.GetIntFromLSO("MainIconID");
                return _mainIconID.Value;
            }
        }

        /// <summary>
        /// Cache of MaxAOETargets
        /// </summary>
        private int? _maxAOETargets;

        /// <summary>
        /// Max number of AOE targets
        /// </summary>
        public int MaxAOETargets
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:MaxAOETargets"));
                if(!_maxAOETargets.HasValue)
                    _maxAOETargets = this.GetIntFromLSO("MaxAOETargets");
                return _maxAOETargets.Value;
            }
        }

        /// <summary>
        /// Cache of MaxDuration
        /// </summary>
        private float? _maxDuration;

        /// <summary>
        /// The maximum duration of the ability
        /// </summary>
        public float MaxDuration
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:MaxDuration"));
                if(!_maxDuration.HasValue)
                    _maxDuration = this.GetFloatFromLSO("MaxDuration");
                return _maxDuration.Value;
            }
        }

        /// <summary>
        /// Cache of MaxRange
        /// </summary>
        private float? _maxRange;

        /// <summary>
        /// The max range of the ability
        /// </summary>
        public float MaxRange
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:MaxRange"));
                if(!_maxRange.HasValue)
                    _maxRange = this.GetFloatFromLSO("MaxRange");
                return _maxRange.Value;
            }
        }

        /// <summary>
        /// Cache of MinDuration
        /// </summary>
        private float? _minDuration;

        /// <summary>
        /// Min duration of ability (Caution: something not working right)
        /// </summary>
        public float MinDuration
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:MinDuration"));
                if(!_minDuration.HasValue)
                    _minDuration = this.GetFloatFromLSO("MinDuration");
                return _minDuration.Value;
            }
        }

        /// <summary>
        /// Cache of MinRange
        /// </summary>
        private float? _minRange;

        /// <summary>
        /// Min Range of the ability
        /// </summary>
        public float MinRange
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:MinRange"));
                if(!_minRange.HasValue)
                    _minRange = this.GetFloatFromLSO("MinRange");
                return _minRange.Value;
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// The name of the ability
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Cache of NumClasses
        /// </summary>
        private int? _numClasses;

        /// <summary>
        /// The number of classes that can use an ability
        /// </summary>
        public int NumClasses
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:NmClasses"));
                if(!_numClasses.HasValue)
                    _numClasses = this.GetIntFromLSO("NumClasses");
                return _numClasses.Value;
            }
        }

        /// <summary>
        /// Cache of NumEffects
        /// </summary>
        private int? _numEffects;

        /// <summary>
        /// The number of effects on the item
        /// </summary>
        public int NumEffects
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:NumEffects"));
                if(!_numEffects.HasValue)
                    _numEffects = this.GetIntFromLSO("NumEffects");
                return _numEffects.Value;
            }
        }

        /// <summary>
        /// Cache of PowerCost
        /// </summary>
        private int? _powerCost;

        /// <summary>
        /// The power cost of the ability
        /// </summary>
        public int PowerCost
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:PowerCost"));
                if(!_powerCost.HasValue)
                    _powerCost = this.GetIntFromLSO("PowerCost");
                return _powerCost.Value;
            }
        }

        /// <summary>
        /// Cache of PowerCostPerTick
        /// </summary>
        private int? _powerCostPerTick;

        /// <summary>
        /// Power cost per tick of the ability
        /// </summary>
        public int PowerCostPerTick
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:PowerCostPerTick"));
                if(!_powerCostPerTick.HasValue)
                    _powerCostPerTick = this.GetIntFromLSO("PowerCostPerTick");
                return _powerCostPerTick.Value;
            }
        }

        /// <summary>
        /// The range of the ability. Same as MaxRange;
        /// </summary>
        public float Range
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:Range"));
                return this.MaxRange;
            }
        }

        /// <summary>
        /// The recast time of the ability
        /// </summary>
        public float RecastTime
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:RecastTime"));
                return this.GetFloatFromLSO("RecastTime");
            }
        }

        /// <summary>
        /// The recovery time of the abilitys
        /// </summary>
        public float RecoveryTime
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:RecoveryTime"));
                return this.GetFloatFromLSO("RecoveryTime");
            }
        }

        /// <summary>
        /// Cache of SavageryCost
        /// </summary>
        private int? _savageryCost;

        /// <summary>
        /// The savagery cost of the ability (Beastlords)
        /// </summary>
        public int SavageryCost
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:SavageryCost"));
                if(!_savageryCost.HasValue)
                    _savageryCost = this.GetIntFromLSO("SavageryCost");
                return _savageryCost.Value;
            }
        }

        /// <summary>
        /// Cache of SavageryCostPerTick
        /// </summary>
        private int? _savageryCostPerTick;

        /// <summary>
        /// The savagery cost per tick of the ability
        /// </summary>
        public int SavageryCostPerTick
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:SavageryCostPerTick"));
                if(!_savageryCostPerTick.HasValue)
                    _savageryCostPerTick = this.GetIntFromLSO("SavageryCostPerTick");
                return _savageryCostPerTick.Value;
            }
        }

        /// <summary>
        /// Cache of SpellBookType
        /// </summary>
        private int? _spellBookType;

        /// <summary>
        /// Spell Book Type of the ability
        /// </summary>
        public int SpellBookType
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:SpellBookType"));
                if(!_spellBookType.HasValue)
                    _spellBookType = this.GetIntFromLSO("SpellBookType");
                return _spellBookType.Value;
            }
        }

        /// <summary>
        /// Cache of TargetType
        /// </summary>
        private int? _targetType;

        /// <summary>
        /// Ability target type
        /// </summary>
        public int TargetType
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:TargetType"));
                if(!_targetType.HasValue)
                    _targetType = this.GetIntFromLSO("TargetType");
                return _targetType.Value;
            }
        }

        /// <summary>
        /// Cache of Tier
        /// </summary>
        private string _tier;

        /// <summary>
        /// The ability tier
        /// </summary>
        public string Tier
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:Tier"));
                return _tier ?? (_tier = this.GetStringFromLSO("Tier"));
            }
        }

        /// <summary>
        /// The time remaining on the ability
        /// </summary>
        public float TimeRemaining
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:TimeRemaining"));
                return this.GetFloatFromLSO("TimeRemaining");
            }
        }

        /// <summary>
        /// The time until the ability is ready. (Preferred over TimeRemaining)
        /// </summary>
        public float TimeUntilReady
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:TimeUntilReady"));
                return this.GetFloatFromLSO("TimeUntilReady");
            }
        }

        /// <summary>
        /// This will recreate the actual link used with in game chat channels (used typically with eq2echo or eq2execute).
        /// </summary>
        /// <returns>link</returns>
        public string ToLink
        {
            get
            {
                Trace.WriteLine(String.Format("Ability:ToLink"));
                return this.GetStringFromLSO("ToLink");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Examines the ability
        /// </summary>
        /// <returns>call success</returns>
        public bool Examine()
        {
            Trace.WriteLine(String.Format("Ability:Examine()"));
            return this.ExecuteMethod("Examine");
        }

        /// <summary>
        /// Uses the ability
        /// </summary>
        /// <returns>call success</returns>
        public bool Use()
        {
            Trace.WriteLine(String.Format("Ability:Use()"));
            return this.ExecuteMethod("Use");
        }

        #endregion
        
    }
}
