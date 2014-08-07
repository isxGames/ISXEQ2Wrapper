// Disable all XML Comment warnings in this file // 

using System.Globalization;
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
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Item(LavishScriptObject copy) : base(copy) { }

        #endregion

        /// <summary>
        /// Cache of IsQuestItemUsable
        /// </summary>
        private bool? _isQuestItemUsable;

        /// <summary>
        /// Returns TRUE if the item is a usable quest item
        /// </summary>
        public bool IsQuestItemUsable
        {
            get
            {
                if (!_isQuestItemUsable.HasValue)
                    _isQuestItemUsable = this.GetBoolFromLSO("IsQuestItemUsable");
                return _isQuestItemUsable.Value;
            }
        }

        /// <summary>
        /// Returns true if all of this item's datatype members are available
        /// (i.e., if information has been cached from the server.)
        /// </summary>
        public bool IsInitialized
        {
            get { return this.GetBoolFromLSO("IsInitialized"); }
        }

        /// <summary>
        /// Cache of ID
        /// </summary>
        private int? _iD;

        /// <summary>
        /// The ID of the item
        /// </summary>
        public int ID
        {
            get
            {
                if(!_iD.HasValue)
                    _iD = this.GetIntFromLSO("ID");
                return _iD.Value;
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// The name of the item
        /// </summary>
        public string Name
        {
            get { return _name ?? (_name = this.GetStringFromLSO("Name")); }
        }

        /// <summary>
        /// Cache of tier
        /// </summary>
        private string _tier;

        /// <summary>
        /// The tier of the item (FABLED, LEGENDARY, TREASURED, MASTERCRAFTED, HANDCRAFTED, or UNCOMMON)
        /// </summary>
        public string Tier
        {
            get { return _tier ?? (_tier = this.GetStringFromLSO("Tier")); }
        }

        /// <summary>
        /// Cache of description
        /// </summary>
        private string _description;

        /// <summary>
        /// The description of the item. Not all items have a description.
        /// </summary>
        public string Description
        {
            get { return _description ?? (_description = this.GetStringFromLSO("Description")); }
        }

        /// <summary>
        /// Cache of Adornment Description
        /// </summary>
        private string _adornmentDescription;

        /// <summary>
        /// Adornment Description
        /// </summary>
        public string AdornmentDescription
        {
            get { return _adornmentDescription ?? (_adornmentDescription = this.GetStringFromLSO("AdornmentDescription")); }
        }

        /// <summary>
        /// Cache of NumModifiers
        /// </summary>
        private int? _numModifiers;

        /// <summary>
        /// The number of item modifiers
        /// </summary>
        public int NumModifiers
        {
            get
            {
                if(!_numModifiers.HasValue)
                    _numModifiers = this.GetIntFromLSO("NumModifiers");
                return _numModifiers.Value;
            }
        }

        /// <summary>
        /// Retrieves the modifier at index between 1 and NumModifiers
        /// </summary>
        /// <param name="Index">index</param>
        /// <returns>item modifier</returns>
        public ItemModifier Modifier(int index)
        {
            return new ItemModifier(this.GetMember("Modifier", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Cache of ExamineText
        /// </summary>
        private string _examineText;

        /// <summary>
        /// This is the text that appears in the examine window while 'examining' an item.
        /// </summary>
        public string ExamineText
        {
            get { return _examineText ?? (_examineText = this.GetStringFromLSO("ExamineText")); }
        }

        /// <summary>
        /// Cache of Type
        /// </summary>
        private string _type;

        /// <summary>
        /// Item type (Weapon, Armor, Shield, Container, Spell Scroll, Recipe Book, House Item, Food, Drink, or Activateable)
        /// </summary>
        public string Type
        {
            get { return _type ?? (_type = this.GetStringFromLSO("Type")); }
        }

        /// <summary>
        /// Cache of Crafter
        /// </summary>
        private string _crafter;

        /// <summary>
        /// The name of the crafter (if crafted item)
        /// </summary>
        public string Crafter
        {
            get { return _crafter ?? (_crafter = this.GetStringFromLSO("Crafter")); }
        }

        /// <summary>
        /// Cache of LinkID
        /// </summary>
        private int? _linkID;

        /// <summary>
        /// The item LinkID
        /// </summary>
        public int LinkID
        {
            get 
            { 
                if(!_linkID.HasValue)
                    _linkID = this.GetIntFromLSO("LinkID");
                return _linkID.Value;
            }
        }

        /// <summary>
        /// Cache of RentStatusReduction
        /// </summary>
        private int? _rentStatusReduction;

        /// <summary>
        /// Rent Status Reduction
        /// </summary>
        public int RentStatusReduction
        {
            get
            {
                if (!_rentStatusReduction.HasValue)
                    _rentStatusReduction = this.GetIntFromLSO("RentStatusReduction");
                return _rentStatusReduction.Value;
            }
        }

        /// <summary>
        /// Cache of Condition
        /// </summary>
        private int? _condition;

        /// <summary>
        /// Item condition (%)
        /// </summary>
        public int Condition
        {
            get
            {
                if(!_condition.HasValue)
                    _condition = this.GetIntFromLSO("Condition");
                return _condition.Value;
            }
        }

        /// <summary>
        /// Item Charges (-1 indicates unlimited)
        /// </summary>
        public int Charges
        {
            get
            {
                return this.GetIntFromLSO("Charges");
            }
        }

        /// <summary>
        /// Cache of MaxCharges
        /// </summary>
        private int? _maxCharges;

        /// <summary>
        /// Max Charges (-1 indicates unlimited)
        /// </summary>
        public int MaxCharges
        {
            get
            {
                if(!_maxCharges.HasValue)
                    _maxCharges = this.GetIntFromLSO("MaxCharges");
                return _maxCharges.Value;
            }
        }

        /// <summary>
        /// Cache of Index
        /// </summary>
        private int? _index;

        /// <summary>
        /// A number that represents a unique item number for an item.
        /// e.g. eq2execute "inventory equip <ItemIndex> <SlotNumber>"
        /// </summary>
        public int Index
        {
            get
            {
                if(!_index.HasValue)
                    _index = this.GetIntFromLSO("Index");
                return _index.Value;
            }
        }

        /// <summary>
        /// Item Quantity
        /// </summary>
        public int Quantity
        {
            get { return this.GetIntFromLSO("Quantity"); }
        }

        /// <summary>
        /// Returns the current slot position for the item within its container, or within your inventory.
        /// So, if the item is in a bag that has 20 slots, it will return a number between 0 and 19.
        /// If the item (or container) is sitting in one of your six "real" inventory slots, it will return 0 to 5.
        /// </summary>
        public int Slot
        {
            get { return this.GetIntFromLSO("Slot"); }
        }

        /// <summary>
        /// Returns true if the IsActivatable == TRUE and the item is ready for use
        /// </summary>
        public bool IsReady
        {
            get { return this.GetBoolFromLSO("IsReady"); }
        }

        /// <summary>
        /// Returns the time in seconds until the item is ready for use
        /// </summary>
        public float TimeUntilReady
        {
            get { return this.GetFloatFromLSO("TimeUntilReady"); }
        }

        /// <summary>
        /// Returns TRUE if the item is in the bank
        /// </summary>
        public bool InBank
        {
            get { return this.GetBoolFromLSO("InBank"); }
        }

        /// <summary>
        /// Returns TRUE if the item is in the shared bank
        /// </summary>
        public bool InSharedBank
        {
            get { return this.GetBoolFromLSO("InSharedBank"); }
        }

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
            get { return this.GetBoolFromLSO("IsInventoryContainer"); }
        }

        /// <summary>
        /// Identifies if the item is a container placed in one of your 12 actual bank slots
        /// </summary>
        public bool IsBankContainer
        {
            get { return this.GetBoolFromLSO("IsBankContainer"); }
        }

        /// <summary>
        /// Identifies if the item is a container placed in one of your 8 actual shared bank slots
        /// </summary>
        public bool IsSharedBankContainer
        {
            get { return this.GetBoolFromLSO("IsSharedBankContainer"); }
        }

        /// <summary>
        /// The item is being used in a recipe, being offered to an altar, etc.
        /// Anything that makes it "unavailable."
        /// </summary>
        public bool IsReserved
        {
            get { return this.GetBoolFromLSO("IsReserved"); }
        }

        /// <summary>
        /// Returns TRUE if the item is Ornate
        /// </summary>
        public bool Ornate
        {
            get { return this.GetBoolFromLSO("Ornate"); }
        }

        /// <summary>
        /// Cache of Good
        /// </summary>
        private bool? _good;

        /// <summary>
        /// Returns TRUE if item only usable by Good characters
        /// </summary>
        public bool Good
        {
            get
            {
                if(!_good.HasValue)
                    _good = this.GetBoolFromLSO("Good");
                return _good.Value;
            }
        }

        /// <summary>
        /// Cache of Evil
        /// </summary>
        private bool? _evil;

        /// <summary>
        /// Returns TRUE if item only usable by Evil characters
        /// </summary>
        public bool Evil
        {
            get
            {
                if(!_evil.HasValue)
                    _evil = this.GetBoolFromLSO("Evil");
                return _evil.Value;
            }
        }

        /// <summary>
        /// Cache of Heirloom
        /// </summary>
        private bool? _heirloom;

        /// <summary>
        /// Returns TRUE if the item is Heirloom
        /// </summary>
        public bool Heirloom
        {
            get
            {
                if(!_heirloom.HasValue)
                    _heirloom = this.GetBoolFromLSO("Heirloom");
                return _heirloom.Value;
            }
        }

        /// <summary>
        /// Cache of AppearanceOnly
        /// </summary>
        private bool? _appearanceOnly;

        /// <summary>
        /// Returns TRUE if the item is an Appearance Only item
        /// </summary>
        public bool AppearanceOnly
        {
            get
            {
                if(!_appearanceOnly.HasValue)
                    _appearanceOnly = this.GetBoolFromLSO("AppearanceOnly");
                return _appearanceOnly.Value;
            }
        }

        /// <summary>
        /// Cache of LoreOnEquip
        /// </summary>
        private bool? _loreOnEquip;

        /// <summary>
        /// Returns TRUE if the item becomes Lore if equipped
        /// </summary>
        public bool LoreOnEquip
        {
            get
            {
                if(!_loreOnEquip.HasValue)
                    _loreOnEquip = this.GetBoolFromLSO("LoreOnEquip");
                return _loreOnEquip.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the item is in a nosale container
        /// </summary>
        public bool InNoSaleContainer
        {
            get { return this.GetBoolFromLSO("InNoSaleContainer"); }
        }

        /// <summary>
        /// Containers Only. Returns TRUE if the contents of the container are for sale.
        /// </summary>
        public bool ContentsForSale
        {
            get { return this.GetBoolFromLSO("ContentsForSale"); }
        }

        /// <summary>
        /// Containers only. The number of empty slots in the container.
        /// </summary>
        public int EmptySlots
        {
            get { return this.GetIntFromLSO("EmptySlots"); }
        }

        /// <summary>
        /// Returns TRUE if the collectible has already been collected.
        /// </summary>
        public bool AlreadyCollected
        {
            get { return this.GetBoolFromLSO("AlreadyCollected"); }
        }

        /// <summary>
        /// Cache of IsCollectible
        /// </summary>
        private bool? _isCollectible;

        /// <summary>
        /// Returns TRUE if the item is a collectible
        /// </summary>
        public bool IsCollectible
        {
            get
            {
                if(!_isCollectible.HasValue)
                    _isCollectible = this.GetBoolFromLSO("IsCollectible");
                return _isCollectible.Value;
            }
        }

        /// <summary>
        /// Cache of RequiredByQuest
        /// </summary>
        private bool? _requiredByQuest;

        /// <summary>
        /// Returns TRUE if the item is required by a quest
        /// </summary>
        public bool RequiredByQuest
        {
            get
            {
                if(!_requiredByQuest.HasValue)
                    _requiredByQuest = this.GetBoolFromLSO("RequiredByQuest");
                return _requiredByQuest.Value;
            }
        }

        /// <summary>
        /// Cache of OffersQuest
        /// </summary>
        private bool? _offersQuest;

        /// <summary>
        /// Returns TRUE if the item offers a quest
        /// </summary>
        public bool OffersQuest
        {
            get
            {
                if(!_offersQuest.HasValue)
                    _offersQuest = this.GetBoolFromLSO("OffersQuest");
                return _offersQuest.Value;
            }
        }

        /// <summary>
        /// Cache of DamageRating
        /// </summary>
        private float? _damageRating;

        /// <summary>
        /// Weapon Damage Rating
        /// </summary>
        public float DamageRating
        {
            get
            {
                if(!_damageRating.HasValue)
                    _damageRating = this.GetFloatFromLSO("DamageRating");
                return _damageRating.Value;
            }
        }

        /// <summary>
        /// Weapon Min Damage
        /// </summary>
        public int MyMinDamage
        {
            get { return this.GetIntFromLSO("MyMinDamage"); }
        }

        /// <summary>
        /// Weapon Max Damage
        /// </summary>
        public int MyMaxDamage
        {
            get { return this.GetIntFromLSO("MyMaxDamage"); }
        }

        /// <summary>
        /// Cache of BaseMinDamage
        /// </summary>
        private int? _baseMinDamage;

        /// <summary>
        /// Base Minimum Weapon Damage
        /// </summary>
        public int BaseMinDamage
        {
            get
            {
                if(!_baseMinDamage.HasValue)
                    _baseMinDamage = this.GetIntFromLSO("BaseMinDamage");
                return _baseMinDamage.Value;
            }
        }

        /// <summary>
        /// Cache of BaseMaxDamage
        /// </summary>
        private int? _baseMaxDamage;

        /// <summary>
        /// Base Maximum Weapon Damage
        /// </summary>
        public int BaseMaxDamage
        {
            get
            {
                if(!_baseMaxDamage.HasValue)
                    _baseMaxDamage = this.GetIntFromLSO("BaseMaxDamage");
                return _baseMaxDamage.Value;
            }
        }

        /// <summary>
        /// Cache of MasteryMinDamage
        /// </summary>
        private int? _masteryMinDamage;

        /// <summary>
        /// Minimum Mastery Weapon Damage
        /// </summary>
        public int MasteryMinDamage
        {
            get
            {
                if(!_masteryMinDamage.HasValue)
                    _masteryMinDamage = this.GetIntFromLSO("MasteryMinDamage");
                return _masteryMinDamage.Value;
            }
        }

        /// <summary>
        /// Cache of MasteryMaxDamage
        /// </summary>
        private int? _masteryMaxDamage;

        /// <summary>
        /// Maximum Mastery Weapon Damage
        /// </summary>
        public int MasteryMaxDamage
        {
            get
            {
                if(!_masteryMaxDamage.HasValue)
                    _masteryMaxDamage = this.GetIntFromLSO("MasteryMaxDamage");
                return _masteryMaxDamage.Value;
            }
        }

        /// <summary>
        /// Cache of Delay
        /// </summary>
        private float? _delay;

        /// <summary>
        /// Weapon Delay
        /// </summary>
        public float Delay
        {
            get
            {
                if(!_delay.HasValue)
                    _delay = this.GetFloatFromLSO("Delay");
                return _delay.Value;
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

        

        

        public bool IsActivatable
        {
            get
            {
                return GetMember<bool>("IsActivatable");
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

        /// <summary>
        /// Asks the server for information about the given item. Usually takes less than a second for the information to be cached to the client.
        /// (Note:  Most of the item datatype members require this.  The only exceptions are: Name, ID, IsEquipped, LinkID,
	    /// ToLink, Index, InContainer, InContainerID, NumSlots, Slot, Quantity, IsContainer, ContainerID, InSharedBank, InBank, NumSlotsFree,
	    /// IsSlotOpen, ItemInSlot, NextSlotOpen, InInventory, InInventorySlot, IsInventoryContainer, IsBankContainer, IsSharedBankContainer,
	    /// InNoSaleContainer, IsAutoConsumeable, CanBeRedeemed, IsFoodOrDrink, CanScribeNow, IsScribeable, IsActivatable, IsReady, TimeUntilReady.)
        /// </summary>
        /// <returns>Function call success</returns>
        public bool Initialize()
        {
            return ExecuteMethod("Initialize");
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
