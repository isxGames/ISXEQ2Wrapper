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
/*
        public Item()
            : base(LavishScript.Objects.GetObject("Item"))
        {
        }
*/
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

        public bool RequiredByQuest
        {
            get
            {
                return GetMember<bool>("RequiredByQuest");
            }
        }

        public bool OffersQuest
        {
            get
            {
                return GetMember<bool>("OffersQuest");
            }
        }

        public bool AlreadyCollected
        {
            get
            {
                return GetMember<bool>("AlreadyCollected");
            }
        }

        public bool IsCollectible
        {
            get
            {
                return GetMember<bool>("IsCollectible");
            }
        }

        public int Index
        {
            get
            {
                return GetMember<int>("Index");
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

        public bool IsContainer
        {
            get
            {
                return GetMember<bool>("IsContainer");
            }
        }

        public int NumSlots
        {
            get
            {
                return GetMember<int>("NumSlots");
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

        public bool InContainer
        {
            get
            {
                return GetMember<bool>("InContainer");
            }
        }

        public int InContainerID
        {
            get
            {
                return GetMember<int>("InContainerID");
            }
        }

        public int ContainerID
        {
            get
            {
                return GetMember<int>("ContainerID");
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

        public Item ItemInSlot(int ItemInSlotNum)
        {
            LavishScriptObject Obj = GetMember("ItemInSlot", ItemInSlotNum.ToString());
            return new Item(Obj);
        }

        public bool IsSlotOpen(int SlotNum)
        {
            return GetMember<bool>("IsSlotOpen", SlotNum.ToString());
        }

        public int NextSlotOpen
        {
            get
            {
                return GetMember<int>("NextSlotOpen");
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

        public string WieldStyle
        {
            get
            {
                return GetMember<string>("WieldStyle");
            }
        }

        public int WeightReduction
        {
            get
            {
                return GetMember<int>("WeightReduction");
            }
        }

        public string Type
        {
            get
            {
                return GetMember<string>("Type");
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

        public int RentStatusReduction
        {
            get
            {
                return GetMember<int>("RentStatusReduction");
            }
        }

        public string Crafter
        {
            get
            {
                return GetMember<string>("Crafter");
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

        public int LinkID
        {
            get
            {
                return GetMember<int>("LinkID");
            }
        }

        public string ToLink(string LinkName)
        {
            return GetMember<string>("ToLink", LinkName);
        }

        public ulong SerialNumber
        {
            get
            {
                return GetMember<ulong>("SerialNumber");
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

        public float Duration
        {
            get
            {
                return GetMember<float>("Duration");
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

        public int MaxRange
        {
            get
            {
                return GetMember<int>("MaxRange");
            }
        }

        public int MinRange
        {
            get
            {
                return GetMember<int>("MinRange");
            }
        }

        public int Range
        {
            get
            {
                return GetMember<int>("Range");
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

        public int NumModifiers
        {
            get
            {
                return GetMember<int>("NumModifiers");
            }
        }

        public ItemModifier Modifier(int Index)
        {
            LavishScriptObject Obj = GetMember("Modifier", Index.ToString());
            return new ItemModifier(Obj);
        }

        public bool Attuned
        {
            get
            {
                return GetMember<bool>("Attuned");
            }
        }

        public bool Attuneable
        {
            get
            {
                return GetMember<bool>("Attuneable");
            }
        }

        public bool Artifact
        {
            get
            {
                return GetMember<bool>("Artifact");
            }
        }

        public bool Lore
        {
            get
            {
                return GetMember<bool>("Lore");
            }
        }

        public bool Temporary
        {
            get
            {
                return GetMember<bool>("Temporary");
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

        public bool NoDestroy
        {
            get
            {
                return GetMember<bool>("NoDestroy");
            }
        }

        public int Health
        {
            get
            {
                return GetMember<int>("Health");
            }
        }

        public int Power
        {
            get
            {
                return GetMember<int>("Power");
            }
        }

        public int Strength
        {
            get
            {
                return GetMember<int>("Strength");
            }
        }

        public int Intelligence
        {
            get
            {
                return GetMember<int>("Intelligence");
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

        public int Stamina
        {
            get
            {
                return GetMember<int>("Stamina");
            }
        }

        public int vsCold
        {
            get
            {
                return GetMember<int>("vsCold");
            }
        }

        public int vsMagic
        {
            get
            {
                return GetMember<int>("vsMagic");
            }
        }

        public int vsDisease
        {
            get
            {
                return GetMember<int>("vsDisease");
            }
        }

        public int vsMental
        {
            get
            {
                return GetMember<int>("vsMental");
            }
        }

        public int vsDivine
        {
            get
            {
                return GetMember<int>("vsDivine");
            }
        }

        public int vsPoison
        {
            get
            {
                return GetMember<int>("vsPoison");
            }
        }

        public int vsHeat
        {
            get
            {
                return GetMember<int>("vsHeat");
            }
        }

        public int vsCrushing
        {
            get
            {
                return GetMember<int>("vsCrushing");
            }
        }

        public int vsSlashing
        {
            get
            {
                return GetMember<int>("vsSlashing");
            }
        }

        public int vsPiercing
        {
            get
            {
                return GetMember<int>("vsPiercing");
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

        public int vsPainAndSuffering
        {
            get
            {
                return GetMember<int>("vsPainAndSuffering");
            }
        }

        public int Focus
        {
            get
            {
                return GetMember<int>("Focus");
            }
        }

        public int Defense
        {
            get
            {
                return GetMember<int>("Defense");
            }
        }

        public int Disruption
        {
            get
            {
                return GetMember<int>("Disruption");
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

        public int Subjugation
        {
            get
            {
                return GetMember<int>("Subjugation");
            }
        }

        public int Crushing
        {
            get
            {
                return GetMember<int>("Crushing");
            }
        }

        public int Piercing
        {
            get
            {
                return GetMember<int>("Piercing");
            }
        }

        public int Slashing
        {
            get
            {
                return GetMember<int>("Slashing");
            }
        }

        public int Deflection
        {
            get
            {
                return GetMember<int>("Deflection");
            }
        }

        public int ID
        {
            get
            {
                return GetMember<int>("ID");
            }
        }

        public bool IsReady
        {
            get
            {
                return GetMember<bool>("IsReady");
            }
        }

        public bool IsActivatable
        {
            get
            {
                return GetMember<bool>("IsActivatable");
            }
        }

        public float TimeUntilReady
        {
            get
            {
                return GetMember<float>("TimeUntilReady");
            }
        }

        public string SubType
        {
            get
            {
                return GetMember<string>("SubType");
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

        public float Weight
        {
            get
            {
                return GetMember<float>("Weight");
            }
        }

        public int Parry
        {
            get
            {
                return GetMember<int>("Parry");
            }
        }

        public string AdornmentDescription
        {
            get
            {
                return GetMember<string>("AdornmentDescription");
            }
        }

        public bool Ornate
        {
            get
            {
                return GetMember<bool>("Ornate");
            }
        }

        public bool RequiresQeynosCitizenship
        {
            get
            {
                return GetMember<bool>("RequiresQeynosCitizenship");
            }
        }

        public bool RequiresFreeportCitizenship
        {
            get
            {
                return GetMember<bool>("RequiresFreeportCitizenship");
            }
        }

        public bool RequiresKelethinCitizenship
        {
            get
            {
                return GetMember<bool>("RequiresKelethinCitizenship");
            }
        }

        public bool RequiresNeriakCitizenship
        {
            get
            {
                return GetMember<bool>("RequiresNeriakCitizenship");
            }
        }

        public bool IsReserved
        {
            get
            {
                return GetMember<bool>("IsReserved");
            }
        }

        public bool IsScribeable
        {
            get
            {
                return GetMember<bool>("IsScribable");
            }
        }

        public bool CanScribeNow
        {
            get
            {
                return GetMember<bool>("CanScribeNow");
            }
        }

        public bool AutoConsumeOn
        {
            get
            {
                return GetMember<bool>("AutoConsumeOn");
            }
        }

        public bool IsAutoConsumeable
        {
            get
            {
                return GetMember<bool>("IsAutoConsumeOn");
            }
        }

        public bool IsFoodOrDrink
        {
            get
            {
                return GetMember<bool>("IsFoodOrDrink");
            }
        }

        public bool CanBeRedeemed
        {
            get
            {
                return GetMember<bool>("CanBeRedeemed");
            }
        }

        public bool IsEquipped
        {
            get
            {
                return GetMember<bool>("IsEquipped");
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

        public bool Use()
        {
            return ExecuteMethod("Use");
        }

        public bool Open()
        {
            return ExecuteMethod("Open");
        }

        public bool SendAsGift()
        {
            return ExecuteMethod("SendAsGift");
        }

        public bool SendAsGift(int Quantity)
        {
            return ExecuteMethod("SendAsGift", Quantity.ToString());
        }

        public bool InstallAsVendingContainer()
        {
            return ExecuteMethod("InstallAsVendingContainer");
        }

        public bool AddToConsignment()
        {
            return ExecuteMethod("AddToConsignment");
        }

        public bool AddToConsignment(int Quantity)
        {
            return ExecuteMethod("AddToConsignment", Quantity.ToString());
        }

        public bool AddToConsignment(int Quantity, int VendorIndex)
        {
            return ExecuteMethod("AddToConsignment", Quantity.ToString(), VendorIndex.ToString());
        }

        public bool Transmute(bool Ask)
        {
            if (Ask)
                return ExecuteMethod("Transmute", "askmefirst");
            return ExecuteMethod("Transmute");
        }

        public bool Sacrifice(bool Ask)
        {
            if (Ask)
                return ExecuteMethod("Sacrifice", "With Confirmation");
            return ExecuteMethod("Sacrifice");
        }

        public bool Scribe()
        {
            return ExecuteMethod("Scribe");
        }

        public bool ToggleAutoConsume()
        {
            return ExecuteMethod("ToggleAutoConsume");
        }

    }
}
