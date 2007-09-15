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

        public int ID
        {
            get
            {
                return GetMember<int>("ID");
            }
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

        public string Class
        {
            get
            {
                return GetMember<string>("Class");
            }
        }

        public string Archetype
        {
            get
            {
                return GetMember<string>("Archetype");
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

        public string Gender
        {
            get
            {
                return GetMember<string>("Gender");
            }
        }

        public string PetName
        {
            get
            {
                return GetMember<string>("PetName");
            }
        }

        public float X
        {
            get
            {
                return GetMember<float>("X");
            }
        }

        public float Y
        {
            get
            {
                return GetMember<float>("Y");
            }
        }

        public float Z
        {
            get
            {
                return GetMember<float>("Z");
            }
        }

        public float Heading
        {
            get
            {
                return GetMember<float>("Heading");
            }
        }

        public bool IsMoving
        {
            get
            {
                return GetMember<bool>("IsMoving");
            }
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

        public string BindLocation
        {
            get
            {
                return GetMember<string>("BindLocation");
            }
        }

        public string HouseLocation
        {
            get
            {
                return GetMember<string>("HouseLocation");
            }
        }

        public float WaterDepth
        {
            get
            {
                return GetMember<float>("WaterDepth");
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

        public int Level
        {
            get
            {
                return GetMember<int>("Level");
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

        public int CurrentStatus
        {
            get
            {
                return GetMember<int>("CurrentStatus");
            }
        }

        public int LifetimeGuildStatus
        {
            get
            {
                return GetMember<int>("LifetimeGuildStatus");
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

        public int AC
        {
            get
            {
                return GetMember<int>("AC");
            }
        }

        public int BaseAC
        {
            get
            {
                return GetMember<int>("BaseAC");
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

        public float Breath
        {
            get
            {
                return GetMember<float>("Breath");
            }
        }

        public int CountMaintained
        {
            get
            {
                return GetMember<int>("CountMaintained");
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

        public int CountEffects
        {
            get
            {
                return GetMember<int>("CountEffects");
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

        public bool IsAfflicted
        {
            get
            {
                return GetMember<bool>("IsAfflicted");
            }
        }

        public int Noxious
        {
            get
            {
                return GetMember<int>("Noxious");
            }
        }

        public int Trauma
        {
            get
            {
                return GetMember<int>("Trauma");
            }
        }

        public int Elemental
        {
            get
            {
                return GetMember<int>("Elemental");
            }
        }

        public int Arcane
        {
            get
            {
                return GetMember<int>("Arcane");
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

        public int Strength
        {
            get
            {
                return GetMember<int>("Strength");
            }
        }

        public int BaseStrength
        {
            get
            {
                return GetMember<int>("BaseStrength");
            }
        }

        public int Stamina
        {
            get
            {
                return GetMember<int>("Stamina");
            }
        }

        public int BaseStamina
        {
            get
            {
                return GetMember<int>("BaseStamina");
            }
        }

        public int Agility
        {
            get
            {
                return GetMember<int>("Agility");
            }
        }

        public int BaseAgility
        {
            get
            {
                return GetMember<int>("BaseAgility");
            }
        }

        public int Wisdom
        {
            get
            {
                return GetMember<int>("Wisdom");
            }
        }

        public int BaseWisdom
        {
            get
            {
                return GetMember<int>("BaseWisdom");
            }
        }

        public int Intelligence
        {
            get
            {
                return GetMember<int>("Intelligence");
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

        public int BaseHeatRes
        {
            get
            {
                return GetMember<int>("BaseHeatRes");
            }
        }

        public int ColdRes
        {
            get
            {
                return GetMember<int>("ColdRes");
            }
        }

        public int BaseColdRes
        {
            get
            {
                return GetMember<int>("BaseColdRes");
            }
        }

        public int MagicRes
        {
            get
            {
                return GetMember<int>("MagicRes");
            }
        }

        public int BaseMagicRes
        {
            get
            {
                return GetMember<int>("BaseMagicRes");
            }
        }

        public int MentalRes
        {
            get
            {
                return GetMember<int>("MentalRes");
            }
        }

        public int BaseMentalRes
        {
            get
            {
                return GetMember<int>("BaseMentalRes");
            }
        }

        public int DivineRes
        {
            get
            {
                return GetMember<int>("DivineRes");
            }
        }

        public int BaseDivineRes
        {
            get
            {
                return GetMember<int>("BaseDivineRes");
            }
        }

        public int DiseaseRes
        {
            get
            {
                return GetMember<int>("DiseaseRes");
            }
        }

        public int BaseDiseaseRes
        {
            get
            {
                return GetMember<int>("BaseDiseaseRes");
            }
        }

        public int PoisonRes
        {
            get
            {
                return GetMember<int>("PoisonRes");
            }
        }

        public int BasePoisonRes
        {
            get
            {
                return GetMember<int>("BasePoisonRes");
            }
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

        public int RaidCount
        {
            get
            {
                return GetMember<int>("RaidCount");
            }
        }

        public RaidMember Raid(int RaidNum)
        {
            LavishScriptObject Obj = GetMember("Raid", RaidNum.ToString());
            return new RaidMember(Obj);
        }

        public RaidMember Raid(string RaidName)
        {
            LavishScriptObject Obj = GetMember("Raid", RaidName);
            return new RaidMember(Obj);
        }

        public Actor ToActor()
        {
            LavishScriptObject Obj = GetMember("ToActor");
            return new Actor(Obj);
        }

        public Actor CursorActor()
        {
            LavishScriptObject Obj = GetMember("CursorActor");
            return new Actor(Obj);
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

        public int NumAbilities
        {
            get
            {
                return GetMember<int>("NumAbilities");
            }
        }

        public Recipe Recipe(int RecipeNum)
        {
            LavishScriptObject Obj = GetMember("Recipe", RecipeNum.ToString());
            return new Recipe(Obj);
        }

        public Recipe Recipe(string Recipename)
        {
            LavishScriptObject Obj = GetMember("Recipe", Recipename);
            return new Recipe(Obj);
        }

        public int NumRecipes
        {
            get
            {
                return GetMember<int>("NumRecipes");
            }
        }

        public bool AutoAttackOn
        {
            get
            {
                return GetMember<bool>("AutoAttackOn");
            }
        }

        public bool CastingSpell
        {
            get
            {
                return GetMember<bool>("CastingSpell");
            }
        }

        public bool RangedAutoAttackOn
        {
            get
            {
                return GetMember<bool>("RangedAutoAttackOn");
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

        public bool InCombat
        {
            get
            {
                return GetMember<bool>("InCombat");
            }
        }

        public bool InRaid
        {
            get
            {
                return GetMember<bool>("InRaid");
            }
        }

        public bool InWater
        {
            get
            {
                return GetMember<bool>("InWater");
            }
        }

        public bool IsCamping
        {
            get
            {
                return GetMember<bool>("IsCamping");
            }
        }

        public bool IsSitting
        {
            get
            {
                return GetMember<bool>("IsSitting");
            }
        }

        public bool IsAFK
        {
            get
            {
                return GetMember<bool>("IsAFK");
            }
        }

        public bool IsLFG
        {
            get
            {
                return GetMember<bool>("IsLFG");
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

        public bool TargetLOS
        {
            get
            {
                return GetMember<bool>("TargetLOS");
            }
        }

        public float TimeToCampOut
        {
            get
            {
                return GetMember<float>("TimeToCampOut");
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

        public bool TakeAllVendingCoin()
        {
            return ExecuteMethod("TakeAllVendingCoin");
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


    }
}
