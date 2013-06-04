// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;
using EQ2.ISXEQ2.Extensions;

namespace EQ2.ISXEQ2
{
    public class Ability : LavishScriptObject
    {

        #region Constructor

        public Ability(LavishScriptObject obj)
            : base(obj)
        {
        }

        public Ability()
            : base(LavishScript.Objects.GetObject("Ability"))
        {
        }

        #endregion

        /// <summary>
        /// The name of the ability
        /// </summary>
        public string Name
        {
            get
            {
                return this.GetStringFromLSO("Name");
            }
        }

        /// <summary>
        /// The ability description
        /// </summary>
        public string Description
        {
            get
            {
                return this.GetStringFromLSO("Description");
            }
        }

        /// <summary>
        /// The ability tier
        /// </summary>
        public string Tier
        {
            get
            {
                return this.GetStringFromLSO("Tier");
            }
        }

        /// <summary>
        /// The health cost of the ability
        /// </summary>
        public int HealthCost
        {
            get
            {
                return this.GetIntFromLSO("HealthCost");
            }
        }

        /// <summary>
        /// The power cost of the ability
        /// </summary>
        public int PowerCost
        {
            get
            {
                return this.GetIntFromLSO("PowerCost");
            }
        }

        /// <summary>
        /// The concentration cost of the ability
        /// </summary>
        public int ConcentrationCost
        {
            get
            {
                return this.GetIntFromLSO("ConcentrationCost");
            }
        }

        /// <summary>
        /// The savagery cost of the ability
        /// </summary>
        public int SavageryCost
        {
            get
            {
                return this.GetIntFromLSO("SavageryCost");
            }
        }

        /// <summary>
        /// The savagery cost per tick of the ability
        /// </summary>
        public int SavageryCostPerTick
        {
            get
            {
                return this.GetIntFromLSO("SavageryCostPerTick");
            }
        }

        /// <summary>
        /// The main icon ID of the ability
        /// </summary>
        public int MainIconID
        {
            get
            {
                return this.GetIntFromLSO("MainIconID");
            }
        }

        /// <summary>
        /// The heroic opportunity icon ID of the ability. -1 indicates no icon.
        /// </summary>
        public int HOIconID
        {
            get
            {
                return this.GetIntFromLSO("HOIconID");
            }
        }

        /// <summary>
        /// The casting time of the ability
        /// </summary>
        public float CastingTime
        {
            get
            {
                return this.GetFloatFromLSO("CastingTime");
            }
        }

        /// <summary>
        /// The recovery time of the abilitys
        /// </summary>
        public float RecoveryTime
        {
            get
            {
                return this.GetFloatFromLSO("RecoveryTime");
            }
        }

        /// <summary>
        /// The recast time of the ability
        /// </summary>
        public float RecastTime
        {
            get
            {
                return this.GetFloatFromLSO("RecastTime");
            }
        }

        /// <summary>
        /// The maximum duration of the ability
        /// </summary>
        public float MaxDuration
        {
            get
            {
                return this.GetFloatFromLSO("MaxDuration");
            }
        }

        /// <summary>
        /// The time remaining on the ability
        /// </summary>
        public float TimeRemaining
        {
            get
            {
                return this.GetFloatFromLSO("TimeRemaining");
            }
        }

        /// <summary>
        /// True if the ability is ready
        /// </summary>
        public bool IsReady
        {
            get
            {
                return this.GetBoolFromLSO("IsReady");
            }
        }

        public string ToLink
        {
            get
            {
                return GetMember<string>("ToLink");
            }
        }

        public uint ID
        {
            get
            {
                return GetMember<uint>("ID");
            }
        }

        /// <summary>
        /// The number of classes that can use an ability
        /// </summary>
        public int NumClasses
        {
            get
            {
                return this.GetIntFromLSO("NumClasses");
            }
        }

        /// <summary>
        /// Returns the class entered. Can be used to determine at what level an ability is available.
        /// </summary>
        /// <param name="classNum">the desired class</param>
        /// <returns>the class</returns>
        public Class Class(int classNum)
        {
            return this.GetClassFromLSO(classNum.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Returns the class entered. Can be used to determine at what level an ability is available.
        /// </summary>
        /// <param name="className">the desired class</param>
        /// <returns>the class</returns>
        public Class Class(string className)
        {
            return this.GetClassFromLSO(className);
        }

        public int HealthCostPerTick
        {
            get
            {
                return GetMember<int>("HealthCostPerTick");
            }
        }

        public int PowerCostPerTick
        {
            get
            {
                return GetMember<int>("PowerCostPerTick");
            }
        }

        public int MaxAOETargets
        {
            get
            {
                return GetMember<int>("MaxAOETargets");
            }
        }
/* Something wrong with this.
        public float MinDuration
        {
            get
            {
                return GetMember<float>("MinDuration");
            }
        }
*/
        public bool DoesNotExpire
        {
            get
            {
                return GetMember<bool>("DoesNotExpire");
            }
        }

        public int BackDropIconID
        {
            get
            {
                return GetMember<int>("BackDropIconID");
            }
        }

        public AbilityEffect Effect()
        {
            LavishScriptObject Obj = GetMember("Effect");
            return new AbilityEffect(Obj);
        }

        public int NumEffects
        {
            get
            {
                return GetMember<int>("NumEffects");
            }
        }

        public bool GroupRestricted
        {
            get
            {
                return GetMember<bool>("GroupRestricted");
            }
        }

        public bool AllowRaid
        {
            get
            {
                return GetMember<bool>("AllowRaid");
            }
        }

        public int TargetType
        {
            get
            {
                return GetMember<int>("TargetType");
            }
        }

        public int SpellBookType
        {
            get
            {
                return GetMember<int>("SpellBookType");
            }
        }

        public float EffectRadius
        {
            get
            {
                return GetMember<float>("EffectRadius");
            }
        }

        /// <summary>
        /// The time until the ability is ready
        /// </summary>
        public float TimeUntilReady
        {
            get
            {
                return this.GetFloatFromLSO("TimeUntilReady");
            }
        }

        public float Range
        {
            get
            {
                return GetMember<float>("Range");
            }
        }

        public float MinRange
        {
            get
            {
                return GetMember<float>("MinRange");
            }
        }

        public float MaxRange
        {
            get
            {
                return GetMember<float>("MaxRange");
            }
        }
/* State? */
        /// <summary>
        /// True if the ability is queued
        /// </summary>
        public bool IsQueued
        {
            get
            {
                return this.GetBoolFromLSO("IsQueued");
            }
        }

        public bool Use()
        {
            return ExecuteMethod("Use");
        }

        public bool Examine()
        {
            return ExecuteMethod("Examine");
        }
    }
}
