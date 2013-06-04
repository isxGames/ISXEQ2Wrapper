// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Text;
using EQ2.ISXEQ2.Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Item : LavishScriptObject
    {
        #region Constructor

        public Item(LavishScriptObject obj)
            : base(obj)
        {
        }

        #endregion

        /// <summary>
        /// Identifies if the item is in a bag or actual inventory slot
        /// </summary>
        public bool InInventory
        {
            get
            {
                return this.GetBoolFromLSO("InInventory");
            }
        }

        /// <summary>
        /// Identifies if the item is in one of your 6 actual inventory slots
        /// </summary>
        public bool InInventorySlot
        {
            get
            {
                return this.GetBoolFromLSO("InInventorySlot");
            }
        }

        /// <summary>
        /// Identifies if the item is a container placed in one of your 6 actual inventory slots
        /// </summary>
        public bool IsInventoryContainer
        {
            get
            {
                return this.GetBoolFromLSO("IsInventoryContainer");
            }
        }

        /// <summary>
        /// Identifies if the item is a container placed in one of your 8 actual bank slots
        /// </summary>
        public bool IsBankContainer
        {
            get
            {
                return this.GetBoolFromLSO("IsBankContainer");
            }
        }

        /// <summary>
        /// Identifies if the item is a container placed in one of your 4 actual shared bank slots
        /// </summary>
        public bool IsSharedBankContainer
        {
            get
            {
                return this.GetBoolFromLSO("IsSharedBankContainer");
            }
        }

        /// <summary>
        /// Identifies the number of free slots in a container
        /// </summary>
        public int NumSlotsFree
        {
            get
            {
                return this.GetIntFromLSO("NumSlotsFree");
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

        /// <summary>
        /// The name of the item
        /// </summary>
        public string Name
        {
            get
            {
                return this.GetStringFromLSO("Name");
            }
        }

        /// <summary>
        /// The tier of the item
        /// </summary>
        public string Tier
        {
            get
            {
                return this.GetStringFromLSO("Tier");
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

        /// <summary>
        /// The description of the item. Not all items have a description.
        /// </summary>
        public string Description
        {
            get
            {
                return this.GetStringFromLSO("Description");
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

        public string Type
        {
            get
            {
                return GetMember<string>("Type");
            }
        }

        public int Protection
        {
            get
            {
                return GetMember<int>("Protection");
            }
        }

        public int MaxProtection
        {
            get
            {
                return GetMember<int>("MaxProtection");
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

        public long SerialNumber
        {
            get
            {
                return GetMember<long>("SerialNumber");
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

        /// <summary>
        /// The ID of the item
        /// </summary>
        public int ID
        {
            get
            {
                return this.GetIntFromLSO("ID");
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

        public string AdornmentDescription
        {
            get
            {
                return GetMember<string>("AdornmentDescription");
            }
        }

        public bool InNoSaleContainer
        {
            get
            {
                return GetMember<bool>("InNoSaleContainer");
            }
        }

        public bool ContentsForSale
        {
            get
            {
                return GetMember<bool>("ContentsForSale");
            }
        }

        public int EmptySlots
        {
            get
            {
                return GetMember<int>("EmptySlots");
            }
        }

        public bool Ornate
        {
            get
            {
                return GetMember<bool>("Ornate");
            }
        }

        public bool Good
        {
            get
            {
                return GetMember<bool>("Good");
            }
        }

        public bool Evil
        {
            get
            {
                return GetMember<bool>("Evil");
            }
        }

        public bool Heirloom
        {
            get
            {
                return GetMember<bool>("Heirloom");
            }
        }

        public bool AppearanceOnly
        {
            get
            {
                return GetMember<bool>("AppearanceOnly");
            }
        }

        public bool LoreOnEquip
        {
            get
            {
                return GetMember<bool>("LoreOnEquip");
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

        public bool AddToConsignment(int Quantity, long VendorSerialNumber)
        {
            return ExecuteMethod("AddToConsignment", Quantity.ToString(), VendorSerialNumber.ToString());
        }

        public bool AddToConsignment(int Quantity, int VendorIndex, long StackWithSerialNumber)
        {
            return ExecuteMethod("AddToConsignment", Quantity.ToString(), VendorIndex.ToString(), StackWithSerialNumber.ToString());
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

        public bool AddToDepot(int DepotID)
        {
            return ExecuteMethod("AddToDepot", DepotID.ToString());
        }

        public bool AddToDepot(int DepotID, int Quantity)
        {
            return ExecuteMethod("AddToDepot", DepotID.ToString(), Quantity.ToString());
        }

        public bool EnchantItem(int ItemID)
        {
            return ExecuteMethod("EnchantITem", ItemID.ToString());
        }

    }
}
