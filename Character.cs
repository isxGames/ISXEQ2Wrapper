using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Character : LavishScriptObject
    {
        public Character()
            : base(LavishScript.Objects.GetObject("Me"))
        {
        }

        public Character(LavishScriptObject Copy)
            : base(Copy)
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public string Race
        {
            get
            {
                return GetMember<string>("Race");
            }
        }

        public int Level
        {
            get
            {
                return GetMember<int>("Level");
            }
        }

        public string Gender
        {
            get
            {
                return GetMember<string>("Gender");
            }
        }

        public string Archetype
        {
            get
            {
                return GetMember<string>("Archetype");
            }
        }

        public string Class
        {
            get
            {
                return GetMember<string>("Class");
            }
        }

        public string SubClass
        {
            get
            {
                return GetMember<string>("SubClass");
            }
        }

        public string TSArchetype
        {
            get
            {
                return GetMember<string>("TSArchetype");
            }
        }

        public string TSClass
        {
            get
            {
                return GetMember<string>("TSClass");
            }
        }

        public string TSSubClass
        {
            get
            {
                return GetMember<string>("TSSubClass");
            }
        }

        public int EffectiveLevel
        {
            get
            {
                return GetMember<int>("EffectiveLevel");
            }
        }

        public int TSLevel
        {
            get
            {
                return GetMember<int>("TSLevel");
            }
        }

        public int Health
        {
            get
            {
                return GetMember<int>("Health");
            }
        }

        public int MaxHealth
        {
            get
            {
                return GetMember<int>("MaxHealth");
            }
        }

        public int Power
        {
            get
            {
                return GetMember<int>("Power");
            }
        }

        public int MaxPower
        {
            get
            {
                return GetMember<int>("MaxPower");
            }
        }

        public int UsedConc
        {
            get
            {
                return GetMember<int>("UsedConc");
            }
        }

        public int MaxConc
        {
            get
            {
                return GetMember<int>("MaxConc");
            }
        }

        public int Attack
        {
            get
            {
                return GetMember<int>("Attack");
            }
        }

        public int BaseAttack
        {
            get
            {
                return GetMember<int>("BaseAttack");
            }
        }
        public float Mitigation
        {
            get
            {
                return GetMember<float>("Mitigation");
            }
        }

        public float OverallAvoidance
        {
            get
            {
                return GetMember<float>("OverallAvoidance");
            }
        }

        public float BaseOverallAvoidance
        {
            get
            {
                return GetMember<float>("BaseOverallAvoidance");
            }
        }

        public float Avoidance
        {
            get
            {
                return GetMember<float>("Avoidance");
            }
        }

        public float BaseAvoidance
        {
            get
            {
                return GetMember<float>("BaseAvoidance");
            }
        }

        public float Parry
        {
            get
            {
                return GetMember<float>("Parry");
            }
        }

        public float BaseParry
        {
            get
            {
                return GetMember<float>("BaseParry");
            }
        }

        public float Deflection
        {
            get
            {
                return GetMember<float>("Deflection");
            }
        }

        public float BaseDeflection
        {
            get
            {
                return GetMember<float>("BaseDeflection");
            }
        }

        public float Block
        {
            get
            {
                return GetMember<float>("Block");
            }
        }

        public float BaseBlock
        {
            get
            {
                return GetMember<float>("BaseBlock");
            }
        }

        public int Strength
        {
            get
            {
                return GetMember<int>("Strength");
            }
        }

        public int Stamina
        {
            get
            {
                return GetMember<int>("Stamina");
            }
        }

        public int Agility
        {
            get
            {
                return GetMember<int>("Agility");
            }
        }

        public int Wisdom
        {
            get
            {
                return GetMember<int>("Wisdom");
            }
        }

        public int Intelligence
        {
            get
            {
                return GetMember<int>("Intelligence");
            }
        }

        public int BaseStrength
        {
            get
            {
                return GetMember<int>("BaseStrength");
            }
        }

        public int BaseStamina
        {
            get
            {
                return GetMember<int>("BaseStamina");
            }
        }

        public int BaseAgility
        {
            get
            {
                return GetMember<int>("BaseAgility");
            }
        }

        public int BaseWisdom
        {
            get
            {
                return GetMember<int>("BaseWisdom");
            }
        }

        public int BaseIntelligence
        {
            get
            {
                return GetMember<int>("BaseIntelligence");
            }
        }

        public int HeatRes
        {
            get
            {
                return GetMember<int>("HeatRes");
            }
        }

        public int ColdRes
        {
            get
            {
                return GetMember<int>("ColdRes");
            }
        }

        public int MagicRes
        {
            get
            {
                return GetMember<int>("MagicRes");
            }
        }

        public int MentalRes
        {
            get
            {
                return GetMember<int>("MentalRes");
            }
        }

        public int DivineRes
        {
            get
            {
                return GetMember<int>("DivineRes");
            }
        }

        public int DiseaseRes
        {
            get
            {
                return GetMember<int>("DiseaseRes");
            }
        }

        public int PoisonRes
        {
            get
            {
                return GetMember<int>("PoisonRes");
            }
        }

        public int BaseHeatRes
        {
            get
            {
                return GetMember<int>("BaseHeatRes");
            }
        }

        public int BaseColdRes
        {
            get
            {
                return GetMember<int>("BaseColdRes");
            }
        }

        public int BaseMagicRes
        {
            get
            {
                return GetMember<int>("BaseMagicRes");
            }
        }

        public int BaseMentalRes
        {
            get
            {
                return GetMember<int>("BaseMentalRes");
            }
        }

        public int BaseDivineRes
        {
            get
            {
                return GetMember<int>("BaseDivineRes");
            }
        }

        public int BaseDiseaseRes
        {
            get
            {
                return GetMember<int>("BaseDiseaseRes");
            }
        }

        public int BasePoisonRes
        {
            get
            {
                return GetMember<int>("BasePoisonRes");
            }
        }

        public int Copper
        {
            get
            {
                return GetMember<int>("Copper");
            }
        }

        public int Silver
        {
            get
            {
                return GetMember<int>("Silver");
            }
        }

        public int Gold
        {
            get
            {
                return GetMember<int>("Gold");
            }
        }

        public int Platinum
        {
            get
            {
                return GetMember<int>("Platinum");
            }
        }

        public int Weight
        {
            get
            {
                return GetMember<int>("Weight");
            }
        }

        public int MaxWeight
        {
            get
            {
                return GetMember<int>("MaxWeight");
            }
        }

        public string PetName
        {
            get
            {
                return GetMember<string>("PetName");
            }
        }

        public int CurrentStatus
        {
            get
            {
                return GetMember<int>("CurrentStatus");
            }
        }

        public float X
        {
            get
            {
                return GetMember<float>("X");
            }
        }

        public float Z
        {
            get
            {
                return GetMember<float>("Z");
            }
        }

        public float Y
        {
            get
            {
                return GetMember<float>("Y");
            }
        }

        public int LifetimeGuildStatus
        {
            get
            {
                return GetMember<int>("LifetimeGuildStatus");
            }
        }

        public bool CombatExpEnabled
        {
            get
            {
                return GetMember<bool>("CombatExpEnabled");
            }
        }

        public int Exp
        {
            get
            {
                return GetMember<int>("Exp");
            }
        }

        public float ExpDebt
        {
            get
            {
                return GetMember<float>("ExpDebt");
            }
        }

        public float TSExp
        {
            get
            {
                return GetMember<float>("TSExp");
            }
        }

        public float TSExpDebt
        {
            get
            {
                return GetMember<float>("TSExpDebt");
            }
        }

        public float Vitality
        {
            get
            {
                return GetMember<float>("Vitality");
            }
        }

        public float TSVitality
        {
            get
            {
                return GetMember<float>("TSVitality");
            }
        }

        public float MentoringXPAdj
        {
            get
            {
                return GetMember<float>("MentoringXPAdj");
            }
        }

        public float Breath
        {
            get
            {
                return GetMember<float>("Breath");
            }
        }

        public float PetHealth
        {
            get
            {
                return GetMember<float>("PetHealth");
            }
        }

        public float PetPower
        {
            get
            {
                return GetMember<float>("PetPower");
            }
        }

        public int CountEffects
        {
            get
            {
                return GetMember<int>("CountEffects");
            }
        }

        public int CountBeneficialEffects
        {
            get
            {
                return GetMember<int>("CountEffects", "Beneficial");
            }
        }

        public int CountDetrimentalEffects
        {
            get
            {
                return GetMember<int>("CountEffects", "Detrimental");
            }
        }

        public int CountMaintained
        {
            get
            {
                return GetMember<int>("CountMaintained");
            }
        }

        public float Heading
        {
            get
            {
                return GetMember<float>("Heading");
            }
        }

        public Maintained Maintained(int MaintainedNum)
        {
            LavishScriptObject Obj = GetMember("Maintained", MaintainedNum.ToString());
            return new Maintained(Obj);
        }

        public Maintained Maintained(string MaintainedName)
        {
            LavishScriptObject Obj = GetMember("Maintained", MaintainedName);
            return new Maintained(Obj);
        }

        public Effect Effect(int EffectNum)
        {
            LavishScriptObject Obj = GetMember("Effect", EffectNum.ToString());
            return new Effect(Obj);
        }

        public Effect Effect(string EffectName)
        {
            LavishScriptObject Obj = GetMember("Effect", EffectName);
            return new Effect(Obj);
        }

        public Effect BeneficialEffect(int EffectNum)
        {
            LavishScriptObject Obj = GetMember("Effect", "Benficial", EffectNum.ToString());
            return new Effect(Obj);
        }

        public Effect BenficialEffect(string EffectName)
        {
            LavishScriptObject Obj = GetMember("Effect", "Beneficial", EffectName);
            return new Effect(Obj);
        }

        public Effect DetrimentalEffect(int EffectNum)
        {
            LavishScriptObject Obj = GetMember("Effect", "Detrimental", EffectNum.ToString());
            return new Effect(Obj);
        }

        public Effect DetrimentalEffect(string EffectName)
        {
            LavishScriptObject Obj = GetMember("Effect", "Detrimental", EffectName);
            return new Effect(Obj);
        }

        public bool InGameWorld
        {
            get
            {
                return GetMember<bool>("InGameWorld");
            }
        }

        public bool AtCharSelect
        {
            get
            {
                return GetMember<bool>("AtCharSelect");
            }
        }

        public bool CastingSpell
        {
            get
            {
                return GetMember<bool>("CastingSpell");
            }
        }

        public int ID
        {
            get
            {
                return GetMember<int>("ID");
            }
        }

        public Item Inventory(params string[] Parameters)
        {
            LavishScriptObject Obj = GetMember("Inventory", Parameters);
            return new Item(Obj);
        }

        public Item Equipment(params string[] Parameters)
        {
            LavishScriptObject Obj = GetMember("Equipment", Parameters);
            return new Item(Obj);
        }

        public GroupMember Group(int GroupNum)
        {
            LavishScriptObject Obj = GetMember("Group", GroupNum.ToString());
            return new GroupMember(Obj);
        }

        public GroupMember Group(string GroupName)
        {
            LavishScriptObject Obj = GetMember("Group", GroupName);
            return new GroupMember(Obj);
        }

        public int GroupCount
        {
            get
            {
                return GetMember<int>("GroupCount");
            }
        }

        public bool Grouped
        {
            get
            {
                return GetMember<bool>("Grouped");
            }
        }

        public Item CustomInventory(int Index)
        {
            LavishScriptObject Obj = GetMember("CustomInventory", Index.ToString());
            return new Item(Obj);
        }

        public Item CustomInventory(params string[] Parameters)
        {
            LavishScriptObject Obj = GetMember("CustomInventory", Parameters);
            return new Item(Obj);
        }

        public int CustomInventoryArraySize
        {
            get
            {
                return GetMember<int>("CustomInventoryArraySize");
            }
        }

        public int NextFreeInvContainer
        {
            get
            {
                return GetMember<int>("NextFreeInvContainer");
            }
        }

        public Actor ToActor()
        {
            LavishScriptObject Obj = GetMember("ToActor");
            return new Actor(Obj);
        }

        public bool AutoAttackOn
        {
            get
            {
                return GetMember<bool>("AutoAttackOn");
            }
        }

        public bool RangedAutoAttackOn
        {
            get
            {
                return GetMember<bool>("RangedAutoAttackOn");
            }
        }

        public Actor CursorActor()
        {
            LavishScriptObject Obj = GetMember("CursorActor");
            return new Actor(Obj);
        }

        public Merchandise Merchandise(int Index)
        {
            LavishScriptObject Obj = GetMember("Merchandise", Index.ToString());
            return new Merchandise(Obj);
        }

        public Merchandise Merchandise(string ItemName)
        {
            LavishScriptObject Obj = GetMember("Merchandise", ItemName);
            return new Merchandise(Obj);
        }

        public int NumItemsICanSell
        {
            get
            {
                return GetMember<int>("NumItemsICanSell");
            }
        }

        public int NumAbilities
        {
            get
            {
                return GetMember<int>("NumAbilities");
            }
        }

        public Ability Ability(int AbilityNum)
        {
            LavishScriptObject Obj = GetMember("Ability", AbilityNum.ToString());
            return new Ability(Obj);
        }

        public Ability Ability(string AbilityName)
        {
            LavishScriptObject Obj = GetMember("Ability", AbilityName);
            return new Ability(Obj);
        }

        public int NumRecipes
        {
            get
            {
                return GetMember<int>("NumRecipes");
            }
        }

        public Recipe Recipe(int RecipeNum)
        {
            LavishScriptObject Obj = GetMember("Recipe", RecipeNum.ToString());
            return new Recipe(Obj);
        }

        public Recipe Recipe(long RecipeID)
        {
            LavishScriptObject Obj = GetMember("Recipe","id", RecipeID.ToString());
            return new Recipe(Obj);
        }

        public Recipe Recipe(string Recipename)
        {
            LavishScriptObject Obj = GetMember("Recipe", Recipename);
            return new Recipe(Obj);
        }

        public bool IsMoving
        {
            get
            {
                return GetMember<bool>("IsMoving");
            }
        }

        public string HouseLocation
        {
            get
            {
                return GetMember<string>("HouseLocation");
            }
        }

        public string BindLocation
        {
            get
            {
                return GetMember<string>("BindLocation");
            }
        }

        public bool In1stPersonView
        {
            get
            {
                return GetMember<bool>("In1stPersonView");
            }
        }

        public bool In3rdPersonView
        {
            get
            {
                return GetMember<bool>("In3rdPersonView");
            }
        }

        public bool IsSitting
        {
            get
            {
                return GetMember<bool>("IsSitting");
            }
        }

        public bool InWater
        {
            get
            {
                return GetMember<bool>("InWater");
            }
        }

        public bool InCombat
        {
            get
            {
                return GetMember<bool>("InCombat");
            }
        }

        public bool TargetLOS
        {
            get
            {
                return GetMember<bool>("TargetLOS");
            }
        }

        public float WaterDepth
        {
            get
            {
                return GetMember<float>("WaterDepth");
            }
        }

        public bool IsLFG
        {
            get
            {
                return GetMember<bool>("IsLFG");
            }
        }

        public bool IsAFK
        {
            get
            {
                return GetMember<bool>("IsAFK");
            }
        }

        public bool IsLFW
        {
            get
            {
                return GetMember<bool>("IsLFW");
            }
        }

        public bool IsAnonymous
        {
            get
            {
                return GetMember<bool>("IsAnonymous");
            }
        }

        public bool IsRolePlaying
        {
            get
            {
                return GetMember<bool>("IsRolePlaying");
            }
        }

        public bool IsDecliningGroupInvites
        {
            get
            {
                return GetMember<bool>("IsDecliningGroupInvites");
            }
        }

        public bool IsDecliningTradeInvites
        {
            get
            {
                return GetMember<bool>("IsDecliningTradeInvites");
            }
        }

        public bool IsDecliningDuelInvites
        {
            get
            {
                return GetMember<bool>("IsDecliningDuelInvites");
            }
        }

        public bool IsCamping
        {
            get
            {
                return GetMember<bool>("IsCamping");
            }
        }

        public float TimeToCampOut
        {
            get
            {
                return GetMember<float>("TimeToCampOut");
            }
        }

        public int RaidCount
        {
            get
            {
                return GetMember<int>("RaidCount");
            }
        }

        public bool InRaid
        {
            get
            {
                return GetMember<bool>("InRaid");
            }
        }

        public int Raid()
        {
            return GetMember<int>("Raid");
        }

        public GroupMember Raid(int Num, bool ByID)
        {
            LavishScriptObject Obj;
            if (ByID)
            {
                Obj = GetMember("Raid", "id",Num.ToString());
            }
            else
            {
                Obj = GetMember("Raid", Num.ToString());
            }
            return new GroupMember(Obj);
        }

        public GroupMember Raid(int GroupNum, int MemberNum)
        {
            LavishScriptObject Obj = GetMember("Raid",GroupNum.ToString(),MemberNum.ToString());
            return new GroupMember(Obj);
        }

        public GroupMember Raid(string RaidName)
        {
            LavishScriptObject Obj = GetMember("Raid", RaidName);
            return new GroupMember(Obj);
        }

        public int Arcane
        {
            get
            {
                return GetMember<int>("Arcane");
            }
        }

        public int Noxious
        {
            get
            {
                return GetMember<int>("Noxious");
            }
        }

        public bool Cursed
        {
            get
            {
                return GetMember<bool>("Cursed");
            }
        }

        public int Elemental
        {
            get
            {
                return GetMember<int>("Elemental");
            }
        }

        public int Trauma
        {
            get
            {
                return GetMember<int>("Trauma");
            }
        }

        public bool IsAfflicted
        {
            get
            {
                return GetMember<bool>("IsAfflicted");
            }
        }

        public float APExp
        {
            get
            {
                return GetMember<float>("APExp");
            }
        }

        public int TotalEarnedAPs
        {
            get
            {
                return GetMember<int>("TotalEarnedAPs");
            }
        }

        public int MaxAPs
        {
            get
            {
                return GetMember<int>("MaxAPs");
            }
        }

        public Achievement Achievement(int AchievementNum)
        {
            LavishScriptObject Obj = GetMember("Achievement", AchievementNum.ToString());
            return new Achievement(Obj);
        }

        public Achievement Achievement(string AchievementName)
        {
            LavishScriptObject Obj = GetMember("Achievement", AchievementName);
            return new Achievement(Obj);
        }

        public VendingContainer Vending(int VendingNum)
        {
            LavishScriptObject Obj = GetMember("Vending", VendingNum.ToString());
            return new VendingContainer(Obj);
        }

        public VendingContainer Vending(string VendingName)
        {
            LavishScriptObject Obj = GetMember("Vending", VendingName);
            return new VendingContainer(Obj);
        }

        public int TotalVendingCapacity
        {
            get
            {
                return GetMember<int>("TotalVendingCapacity");
            }
        }

        public int VendingCapacityUsed
        {
            get
            {
                return GetMember<int>("VendingCapacityUsed");
            }
        }

        public int VendingCapacityFree
        {
            get
            {
                return GetMember<int>("VendingCapacityFree");
            }
        }

        public bool IgnoringAll
        {
            get
            {
                return GetMember<bool>("IgnoringAll");
            }
        }

        /* TODO: GetInventory
         *       GetInventoryAtHand
         *       GetEquipment
         */

        public int NumVendingContainers
        {
            get
            {
                return GetMember<int>("NumVendingContainers");
            }
        }

        public List<Ability> GetAbilities()
        {
            LavishScriptObject Index = LavishScript.Objects.NewObject("index:ability");

            int Count = GetMember<int>("GetAbilities", Index.GetLSReference());
            List<Ability> List = new List<Ability>(Count);

            for (int i = 1; i < Count; i++)
            {
                List.Add(new Ability(Index.GetIndex(i.ToString())));
            }

            return List;
        }

        public int InventorySlotsFree
        {
            get
            {
                return GetMember<int>("InventorySlotsFree");
            }
        }

        public int BankSlotsFree
        {
            get
            {
                return GetMember<int>("BankSlotsFree");
            }
        }

        public int SharedBankSlotsFree
        {
            get
            {
                return GetMember<int>("SharedBankSlotsFree");
            }
        }

        public Actor Pet()
        {
            LavishScriptObject Obj = GetMember("Pet");
            return new Actor(Obj);
        }

        public bool IsInPVP
        {
            get
            {
                return GetMember<bool>("IsInPVP");
            }
        }

        public bool IsHated
        {
            get
            {
                return GetMember<bool>("IsHated");
            }
        }

        public int PowerRegen
        {
            get
            {
                return GetMember<int>("PowerRegen");
            }
        }

        public int HealthRegen
        {
            get
            {
                return GetMember<int>("HealthRegen");
            }
        }

        public bool CheckCollision(float X, float Y, float Z)
        {
            return GetMember<bool>("CheckCollision",X.ToString(),Y.ToString(),Z.ToString());
        }

        public float HeadingTo(float X, float Y, float Z)
        {
            return GetMember<float>("HeadingTo",X.ToString(),Y.ToString(),Z.ToString());
        }

        public int RaidGroupNum
        {
            get
            {
                return GetMember<int>("RaidGroupNum");
            }
        }

        public bool IsDecliningGuildInvites
        {
            get
            {
                return GetMember<bool>("IsDecliningGuildInvites");
            }
        }

        public bool IsDecliningRaidInvites
        {
            get
            {
                return GetMember<bool>("IsDecliningRaidInvites");
            }
        }

        public bool Face()
        {
            return ExecuteMethod("Face");
        }

        public bool Face(float Angle)
        {
            return ExecuteMethod("Face", Angle.ToString());
        }

        public bool CreateCustomInventoryArray()
        {
            return ExecuteMethod("CreateCustomInventoryArray");
        }

        public enum InventoryType
        {
            nonbankonly,
            bankonly
        }

        public bool CreateCustomInventoryArray(InventoryType Bank)
        {
            return ExecuteMethod("CreateCustomInventoryArray", Bank.ToString());
        }

        public bool TakeAllVendingCoin()
        {
            return ExecuteMethod("TakeAllVendingCoin");
        }
/*
        public bool BankDeposit()
        {
            return false;
        }

        public bool BankWithdraw()
        {
            return false;
        }

        public bool GuildBankWithdraw()
        {
            return false;
        }
*/
        public bool InitializeEffects()
        {
            return ExecuteMethod("InitializeEffects");
        }
/* gone?
        public int NumConsignmentItems
        {
            get
            {
                return GetMember<int>("NumConsignmentItems");
            }
        }

        public Consignment Consignment(int ConsignmentNum)
        {
            LavishScriptObject Obj = GetMember("Consignment", ConsignmentNum.ToString());
            return new Consignment(Obj);
        }

        public Consignment Consignment(string ConsignmentName)
        {
            LavishScriptObject Obj = GetMember("Consignment", ConsignmentName);
            return new Consignment(Obj);
        }
*/
    }
}
