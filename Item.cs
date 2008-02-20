using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Item : LavishScriptObject
    {
        public Item(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Item()
            : base(LavishScript.Objects.GetObject("Item"))
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

        public string Tier
        {
            get
            {
                return GetMember<string>("Tier");
            }
        }

        public string Description
        {
            get
            {
                return GetMember<string>("Description");
            }
        }

        public string ExamineText
        {
            get
            {
                return GetMember<string>("ExamineText");
            }
        }

        public string Type
        {
            get
            {
                return GetMember<string>("Type");
            }
        }

        public string Crafter
        {
            get
            {
                return GetMember<string>("Crafter");
            }
        }

        public int LinkID
        {
            get
            {
                return GetMember<int>("LinkID");
            }
        }

        public int WeightReduction
        {
            get
            {
                return GetMember<int>("WeightReduction");
            }
        }

        public int RentStatusReduction
        {
            get
            {
                return GetMember<int>("RentStatusReduction");
            }
        }

        public int Condition
        {
            get
            {
                return GetMember<int>("Condition");
            }
        }

        public int Charges
        {
            get
            {
                return GetMember<int>("Charges");
            }
        }

        public int MaxCharges
        {
            get
            {
                return GetMember<int>("MaxCharges");
            }
        }

        public int Index
        {
            get
            {
                return GetMember<int>("Index");
            }
        }

        public int Quantity
        {
            get
            {
                return GetMember<int>("Quantity");
            }
        }

        public int Slot
        {
            get
            {
                return GetMember<int>("Slot");
            }
        }

        public bool IsReady
        {
            get
            {
                return GetMember<bool>("IsReady");
            }
        }

        public float TimeUntilReady
        {
            get
            {
                return GetMember<float>("TimeUntilReady");
            }
        }

        public bool InBank
        {
            get
            {
                return GetMember<bool>("InBank");
            }
        }

        public bool InSharedBank
        {
            get
            {
                return GetMember<bool>("InSharedBank");
            }
        }

        public bool IsCollectible
        {
            get
            {
                return GetMember<bool>("IsCollectible");
            }
        }

        public bool AlreadyCollected
        {
            get
            {
                return GetMember<bool>("AlreadyCollected");
            }
        }

        public bool OffersQuest
        {
            get
            {
                return GetMember<bool>("OffersQuest");
            }
        }

        public bool RequiredByQuest
        {
            get
            {
                return GetMember<bool>("RequiredByQuest");
            }
        }

        public float DamageRating
        {
            get
            {
                return GetMember<float>("DamageRating");
            }
        }

        public int MyMinDamage
        {
            get
            {
                return GetMember<int>("MyMinDamage");
            }
        }

        public int MyMaxDamage
        {
            get
            {
                return GetMember<int>("MyMaxDamage");
            }
        }

        public int BaseMinDamage
        {
            get
            {
                return GetMember<int>("BaseMinDamage");
            }
        }

        public int BaseMaxDamage
        {
            get
            {
                return GetMember<int>("BaseMaxDamage");
            }
        }

        public int MasteryMinDamage
        {
            get
            {
                return GetMember<int>("MasteryMinDamage");
            }
        }

        public int MasteryMaxDamage
        {
            get
            {
                return GetMember<int>("MasteryMaxDamage");
            }
        }

        public float Delay
        {
            get
            {
                return GetMember<float>("Delay");
            }
        }

        public int Range
        {
            get
            {
                return GetMember<int>("Range");
            }
        }

        public int MinRange
        {
            get
            {
                return GetMember<int>("MinRange");
            }
        }

        public int MaxRange
        {
            get
            {
                return GetMember<int>("MaxRange");
            }
        }

        public string WieldStyle
        {
            get
            {
                return GetMember<string>("WieldStyle");
            }
        }

        public string SubType
        {
            get
            {
                return GetMember<string>("SubType");
            }
        }

        public string DamageType
        {
            get
            {
                return GetMember<string>("DamageType");
            }
        }

        public string DamageTypeVerb
        {
            get
            {
                return GetMember<string>("DamageTypeVerb");
            }
        }

        public int ShieldFactor
        {
            get
            {
                return GetMember<int>("ShieldFactor");
            }
        }

        public int MaxShieldFactor
        {
            get
            {
                return GetMember<int>("MaxShieldFactor");
            }
        }

        public int Mitigation
        {
            get
            {
                return GetMember<int>("Mitigation");
            }
        }

        public int MaxMitigation
        {
            get
            {
                return GetMember<int>("MaxMitigation");
            }
        }

        public string Label
        {
            get
            {
                return GetMember<string>("Label");
            }
        }

        public int NextSlotOpen
        {
            get
            {
                return GetMember<int>("NextSlotOpen");
            }
        }

        public bool IsSlotOpen(int SlotNum)
        {
            return GetMember<bool>("IsSlotOpen", SlotNum.ToString());
        }

        public Item ItemInSlot(int ItemInSlotNum)
        {
            LavishScriptObject Obj = GetMember("ItemInSlot", ItemInSlotNum.ToString());
            return new Item(Obj);
        }

        public ItemModifier Modifier(int Index)
        {
            LavishScriptObject Obj = GetMember("Modifier", Index.ToString());
            return new ItemModifier(Obj);
        }

        public int NumModifiers
        {
            get
            {
                return GetMember<int>("NumModifiers");
            }
        }

        public int InContainerID
        {
            get
            {
                return GetMember<int>("InContainerID");
            }
        }

        public bool IsContainer
        {
            get
            {
                return GetMember<bool>("IsContainer");
            }
        }

        public bool InContainer
        {
            get
            {
                return GetMember<bool>("InContainer");
            }
        }

        public int NumSlots
        {
            get
            {
                return GetMember<int>("NumSlots");
            }
        }

        public string Satiation
        {
            get
            {
                return GetMember<string>("Satiation");
            }
        }

        public int Level
        {
            get
            {
                return GetMember<int>("Level");
            }
        }

        public bool IsActivatable
        {
            get
            {
                return GetMember<bool>("IsActivatable");
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

        public int NumEffects
        {
            get
            {
                return GetMember<int>("NumEffects");
            }
        }

        public bool EffectName(int EffectNum)
        {
            return GetMember<bool>("EffectName", EffectNum.ToString());
        }

        public bool EffectDescription(int EffectNum)
        {
            return GetMember<bool>("EffectDescription", EffectNum.ToString());
        }

        public float Duration
        {
            get
            {
                return GetMember<float>("Duration");
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

        public int NumEquipSlots
        {
            get
            {
                return GetMember<int>("NumEquipSlots");
            }
        }

        public string EquipSlot(int EquipSlotNum)
        {
            return GetMember<string>("EquipSlot", EquipSlotNum.ToString());
        }

        public bool Artifact
        {
            get
            {
                return GetMember<bool>("Artifact");
            }
        }

        public bool Attuneable
        {
            get
            {
                return GetMember<bool>("Attuneable");
            }
        }

        public bool Attuned
        {
            get
            {
                return GetMember<bool>("Attuned");
            }
        }

        public bool Lore
        {
            get
            {
                return GetMember<bool>("Lore");
            }
        }

        public bool NoDestroy
        {
            get
            {
                return GetMember<bool>("NoDestroy");
            }
        }

        public bool NoTrade
        {
            get
            {
                return GetMember<bool>("NoTrade");
            }
        }

        public bool NoValue
        {
            get
            {
                return GetMember<bool>("NoValue");
            }
        }

        public bool NoZone
        {
            get
            {
                return GetMember<bool>("NoZone");
            }
        }

        public bool Temporary
        {
            get
            {
                return GetMember<bool>("Temporary");
            }
        }

        public int Agility
        {
            get
            {
                return GetMember<int>("Agility");
            }
        }

        public int Crushing
        {
            get
            {
                return GetMember<int>("Crushing");
            }
        }

        public int Defense
        {
            get
            {
                return GetMember<int>("Defense");
            }
        }

        public int Deflection
        {
            get
            {
                return GetMember<int>("Deflection");
            }
        }

        public int Disruption
        {
            get
            {
                return GetMember<int>("Disruption");
            }
        }

        public int Focus
        {
            get
            {
                return GetMember<int>("Focus");
            }
        }

        public int Health
        {
            get
            {
                return GetMember<int>("Health");
            }
        }

        public int Intelligence
        {
            get
            {
                return GetMember<int>("Intelligence");
            }
        }

        public int Ministration
        {
            get
            {
                return GetMember<int>("Ministration");
            }
        }

        public int Ordination
        {
            get
            {
                return GetMember<int>("Ordination");
            }
        }
        public int Piercing
        {
            get
            {
                return GetMember<int>("Piercing");
            }
        }

        public int Power
        {
            get
            {
                return GetMember<int>("Power");
            }
        }

        public int Slashing
        {
            get
            {
                return GetMember<int>("Slashing");
            }
        }

        public int Stamina
        {
            get
            {
                return GetMember<int>("Stamina");
            }
        }

        public int Strength
        {
            get
            {
                return GetMember<int>("Strength");
            }
        }

        public int Subjugation
        {
            get
            {
                return GetMember<int>("Subjugation");
            }
        }

        public int Wisdom
        {
            get
            {
                return GetMember<int>("Wisdom");
            }
        }

        public int vsCold
        {
            get
            {
                return GetMember<int>("vsCold");
            }
        }

        public int vsCrushing
        {
            get
            {
                return GetMember<int>("vsCrushing");
            }
        }

        public int vsDisease
        {
            get
            {
                return GetMember<int>("vsDisease");
            }
        }

        public int vsDivine
        {
            get
            {
                return GetMember<int>("vsDivine");
            }
        }

        public int vsDrowning
        {
            get
            {
                return GetMember<int>("vsDrowning");
            }
        }

        public int vsFalling
        {
            get
            {
                return GetMember<int>("vsFalling");
            }
        }

        public int vsHeat
        {
            get
            {
                return GetMember<int>("vsHeat");
            }
        }

        public int vsMagic
        {
            get
            {
                return GetMember<int>("vsMagic");
            }
        }

        public int vsMental
        {
            get
            {
                return GetMember<int>("vsMental");
            }
        }

        public int vsPainAndSuffering
        {
            get
            {
                return GetMember<int>("vsPainAndSuffering");
            }
        }

        public int vsPiercing
        {
            get
            {
                return GetMember<int>("vsPiercing");
            }
        }

        public int vsPoison
        {
            get
            {
                return GetMember<int>("vsPoison");
            }
        }

        public int vsSlashing
        {
            get
            {
                return GetMember<int>("vsSlashing");
            }
        }

        public bool DestroyWithConf()
        {
            return ExecuteMethod("DestroyWithConf");
        }

        public bool Destroy()
        {
            return ExecuteMethod("Destroy");
        }

        public bool Destroy(int Quantity)
        {
            return ExecuteMethod("Destroy", Quantity.ToString());
        }

        public bool Equip()
        {
            return ExecuteMethod("Equip");
        }

        public bool UnEquip()
        {
            return ExecuteMethod("UnEquip");
        }

        public bool Consume()
        {
            return ExecuteMethod("Consume");
        }

        public bool Examine()
        {
            return ExecuteMethod("Examine");
        }

        public bool Open()
        {
            return ExecuteMethod("Open");
        }

        public bool Use()
        {
            return ExecuteMethod("Use");
        }

        public bool Move(int BagSlotNum, int BagID)
        {
            return ExecuteMethod("Move", BagSlotNum.ToString(), BagID.ToString());
        }

        public enum NextFreeType
        {
            NextFreeNonBank,
            NextFreeInBank
        }

        public bool Move(NextFreeType NextFree, int Quantity)
        {
            return ExecuteMethod("Move", NextFree.ToString(), Quantity.ToString());
        }

        public bool Move(int BagSlotNum, int BagID, int Quantity)
        {
            return ExecuteMethod("Move", BagSlotNum.ToString(), BagID.ToString(), Quantity.ToString());
        }

        public bool RemoveFlag(int BitFlag)
        {
            return ExecuteMethod("RemoveFlag", BitFlag.ToString());
        }

        public string ToLink(string LinkName)
        {
            return GetMember<string>("ToLink", LinkName);
        }

        public bool SendAsGift()
        {
            return ExecuteMethod("SendAsGift");
        }

        public bool SendAsGift(int Quantity)
        {
            return ExecuteMethod("SendAsGift", Quantity.ToString());
        }

        public bool AddToConsignment()
        {
            return ExecuteMethod("AddToConsignment");
        }

        public bool AddToConsignment(int Quantity)
        {
            return ExecuteMethod("AddToConsignment", Quantity.ToString());
        }

        public bool AddToConsignment(int Quantity,int VendorIndex)
        {
            return ExecuteMethod("AddToConsignment", Quantity.ToString(), VendorIndex.ToString());
        }

        public bool InstallAsVendingContainer()
        {
            return ExecuteMethod("InstallAsVendingContainer");
        }

        public bool InInventory
        {
            get
            {
                return GetMember<bool>("InInventory");
            }
        }

        public bool InInventorySlot
        {
            get
            {
                return GetMember<bool>("InInventorySlot");
            }
        }

        public bool IsInventoryContainer
        {
            get
            {
                return GetMember<bool>("IsInventoryContainer");
            }
        }

        public bool IsBankContainer
        {
            get
            {
                return GetMember<bool>("IsBankContainer");
            }
        }

        public bool IsSharedBankContainer
        {
            get
            {
                return GetMember<bool>("IsSharedBankContainer");
            }
        }

        public int NumSlotsFree
        {
            get
            {
                return GetMember<int>("NumSlotsFree");
            }
        }
    }
}
