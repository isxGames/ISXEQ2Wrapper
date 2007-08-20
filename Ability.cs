using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Ability : LavishScriptObject
    {
        public Ability(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Ability()
            : base(LavishScript.Objects.GetObject("Ability"))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public string Description
        {
            get
            {
                return GetMember<string>("Description");
            }
        }

        public string Tier
        {
            get
            {
                return GetMember<string>("Tier");
            }
        }

        public int HealthCost
        {
            get
            {
                return GetMember<int>("HealthCost");
            }
        }

        public int PowerCost
        {
            get
            {
                return GetMember<int>("PowerCost");
            }
        }

        public int ConcentrationCost
        {
            get
            {
                return GetMember<int>("ConcentrationCost");
            }
        }

        public int MainIconID
        {
            get
            {
                return GetMember<int>("MainIconID");
            }
        }

        public int HOIconID
        {
            get
            {
                return GetMember<int>("HOIconID");
            }
        }

        public float CastingTime
        {
            get
            {
                return GetMember<float>("CastingTime");
            }
        }

        public float RecoveryTime
        {
            get
            {
                return GetMember<float>("RecoveryTime");
            }
        }

        public float RecastTime
        {
            get
            {
                return GetMember<float>("RecastTime");
            }
        }

        public float MaxDuration
        {
            get
            {
                return GetMember<float>("MaxDuration");
            }
        }

        public float TimeUntilReady
        {
            get
            {
                return GetMember<float>("TimeUntilReady");
            }
        }

        public bool IsReady
        {
            get
            {
                return GetMember<bool>("IsReady");
            }
        }

        public int NumClasses
        {
            get
            {
                return GetMember<int>("NumClasses");
            }
        }

        public Class Class(int ClassNum)
        {
            LavishScriptObject Obj = GetMember("Class", ClassNum.ToString());
            return new Class(Obj);
        }

        public Class Class(string ClassName)
        {
            LavishScriptObject Obj = GetMember("Class", ClassName);
            return new Class(Obj);
        }

        public int NumEffects
        {
            get
            {
                return GetMember<int>("NumEffects");
            }
        }

        public AbilityEffect Effect()
        {
            LavishScriptObject Obj = GetMember("Effect");
            return new AbilityEffect(Obj);
        }

        public int BackDropIconID
        {
            get
            {
                return GetMember<int>("BackDropIconID");
            }
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

        public bool DoesNotExpire
        {
            get
            {
                return GetMember<bool>("DoesNotExpire");
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

        public float EffectRadius
        {
            get
            {
                return GetMember<float>("EffectRadius");
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

        public int NumAbilities
        {
            get
            {
                return GetMember<int>("NumAbilities");
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
