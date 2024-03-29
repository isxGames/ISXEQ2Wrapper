using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.AbilityEffect;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to inventory and equipped items.
    /// </summary>
    public class Item : LavishScriptObject
    {

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Item(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns the RewardWindow as an EQ2Window
        /// </summary>
        public ItemInfo ToItemInfo
        {
            get
            {
                Trace.WriteLine(String.Format("Item:ToItemInfo"));
                return new ItemInfo(this.GetMember("ToItemInfo"));
            }
        }

        /// <summary>
        /// Returns TRUE if the collectible has already been collected.
        /// </summary>
        public bool AlreadyCollected
        {
            get
            {
                Trace.WriteLine(String.Format("Item:AlreadyCollected"));
                return this.GetBoolFromLSO("AlreadyCollected");
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
                Trace.WriteLine(String.Format("Item:AppearanceOnly"));
                if (!_appearanceOnly.HasValue)
                    _appearanceOnly = this.GetBoolFromLSO("AppearanceOnly");
                return _appearanceOnly.Value;
            }
        }

        /// <summary>
        /// Cache of Artifact
        /// </summary>
        private bool? _artifact;

        /// <summary>
        /// Returns TRUE if the item is an artifact
        /// </summary>
        public bool Artifact
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Artifact"));
                if (!_artifact.HasValue)
                    _artifact = this.GetBoolFromLSO("Artifact");
                return _artifact.Value;
            }
        }

        /// <summary>
        /// Cache of Attuneable
        /// </summary>
        private bool? _attuneable;

        /// <summary>
        /// Returns TRUE if the item is attuneable
        /// </summary>
        public bool Attuneable
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Attuneable"));
                if (!_attuneable.HasValue)
                    _attuneable = this.GetBoolFromLSO("Attuneable");
                return _attuneable.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the item is attuned
        /// </summary>
        public bool Attuned
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Attuned"));
                return this.GetBoolFromLSO("Attuned");
            }
        }

        /// <summary>
        /// Returns TRUE if Auto Consume is on
        /// </summary>
        public bool AutoConsumeOn
        {
            get
            {
                Trace.WriteLine(String.Format("Item:AutoConsumeOn"));
                return this.GetBoolFromLSO("AutoConsumeOn");
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
                Trace.WriteLine(String.Format("Item:BaseMaxDamage"));
                if (!_baseMaxDamage.HasValue)
                    _baseMaxDamage = this.GetIntFromLSO("BaseMaxDamage");
                return _baseMaxDamage.Value;
            }
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
                Trace.WriteLine(String.Format("Item:BaseMinDamage"));
                if (!_baseMinDamage.HasValue)
                    _baseMinDamage = this.GetIntFromLSO("BaseMinDamage");
                return _baseMinDamage.Value;
            }
        }

        /// <summary>
        /// Cache of CanBeRedeemed
        /// </summary>
        private bool? _canBeRedeemed;

        /// <summary>
        /// Returns TRUE if the item can be redeemed
        /// </summary>
        public bool CanBeRedeemed
        {
            get
            {
                Trace.WriteLine(String.Format("Item:CanBeRedeemed"));
                if (!_canBeRedeemed.HasValue)
                    _canBeRedeemed = this.GetBoolFromLSO("CanBeRedeemed");
                return _canBeRedeemed.Value;
            }
        }

        

        /// <summary>
        /// Item casting time
        /// </summary>
        public float CastingTime
        {
            get
            {
                Trace.WriteLine(String.Format("Item:CastingTime"));
                return this.GetFloatFromLSO("CastingTime");
            }
        }

        /// <summary>
        /// Item Charges (-1 indicates unlimited)
        /// </summary>
        public int Charges
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Charges"));
                return this.GetIntFromLSO("Charges");
            }
        }

        /// <summary>
        /// Returns a 'class' datatype -- # is the class number within the array 
        /// Abilities that are usable by ALL will have one class in the array, which will have the name "commoner".
        /// Remember, 'commoner' is a class of which everyone is a member 
        /// </summary>
        /// <param name="index">class index</param>
        /// <returns>class at index</returns>
        public Class Class(int index)
        {
            Trace.WriteLine(String.Format("Item:Class({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Class(GetMember("Class", index.ToString(CultureInfo.InvariantCulture)));
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
                Trace.WriteLine(String.Format("Item:Condition"));
                if (!_condition.HasValue)
                    _condition = this.GetIntFromLSO("Condition");
                return _condition.Value;
            }
        }

        /// <summary>
        /// Cache of ContainerID
        /// </summary>
        private int? _containerID;

        /// <summary>
        /// The Container ID of the container
        /// </summary>
        public int ContainerID
        {
            get
            {
                Trace.WriteLine(String.Format("Item:ContainerID"));
                if (!_containerID.HasValue)
                    _containerID = this.GetIntFromLSO("ContainerID");
                return _containerID.Value;
            }
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
            get
            {
                Trace.WriteLine(String.Format("Item:Crafter"));
                return _crafter ?? (_crafter = this.GetStringFromLSO("Crafter"));
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
                Trace.WriteLine(String.Format("Item:DamageRating"));
                if (!_damageRating.HasValue)
                    _damageRating = this.GetFloatFromLSO("DamageRating");
                return _damageRating.Value;
            }
        }

        /// <summary>
        /// Cache of DamageType
        /// </summary>
        private string _damageType;

        /// <summary>
        /// Weapon Damage Type
        /// </summary>
        public string DamageType
        {
            get
            {
                Trace.WriteLine(String.Format("Item:DamageType"));
                return _damageType ?? (_damageType = this.GetStringFromLSO("DamageType"));
            }
        }

        /// <summary>
        /// Cache of DamageTypeVerb
        /// </summary>
        private string _damageTypeVerb;

        /// <summary>
        /// Weapon Damage Type Verb (Slashing, etc...)
        /// </summary>
        public string DamageTypeVerb
        {
            get
            {
                Trace.WriteLine(String.Format("Item:DamageTypeVerb"));
                return _damageTypeVerb ?? (_damageTypeVerb = this.GetStringFromLSO("DamageTypeVerb"));
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
                Trace.WriteLine(String.Format("Item:Delay"));
                if (!_delay.HasValue)
                    _delay = this.GetFloatFromLSO("Delay");
                return _delay.Value;
            }
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
            get
            {
                Trace.WriteLine(String.Format("Item:Description"));
                return _description ?? (_description = this.GetStringFromLSO("Description"));
            }
        }

        /// <summary>
        /// Food or Drink Duration
        /// </summary>
        public float Duration
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Duration"));
                return this.GetFloatFromLSO("Duration");
            }
        }

        /// <summary>
        /// Name of Effect at index
        /// </summary>
        /// <param name="index">effect index</param>
        /// <returns>effect name</returns>
        public string EffectName(int index)
        {
            Trace.WriteLine(String.Format("Item:EffectName({0})", index.ToString(CultureInfo.InvariantCulture)));
            return this.GetStringFromLSO("EffectName", index.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Description of the effect at index
        /// </summary>
        /// <param name="index">effect index</param>
        /// <returns>effect description</returns>
        public string EffectDescription(int index)
        {
            Trace.WriteLine(String.Format("Item:EffectDescription({0})", index.ToString(CultureInfo.InvariantCulture)));
            return this.GetStringFromLSO("EffectDescription", index.ToString(CultureInfo.InvariantCulture));
        }

        

        /// <summary>
        /// Returns the name of the equipslot at the index
        /// </summary>
        /// <param name="index">equipslot index</param>
        /// <returns>equipslot name</returns>
        public string EquipSlot(int index)
        {
            Trace.WriteLine(String.Format("Item:EquipSlot({0})", index.ToString(CultureInfo.InvariantCulture)));
            return this.GetStringFromLSO("EquipSlot", index.ToString(CultureInfo.InvariantCulture));
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
                Trace.WriteLine(String.Format("Item:Evil"));
                if (!_evil.HasValue)
                    _evil = this.GetBoolFromLSO("Evil");
                return _evil.Value;
            }
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
            get
            {
                Trace.WriteLine(String.Format("Item:ExamineText"));
                return _examineText ?? (_examineText = this.GetStringFromLSO("ExamineText"));
            }
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
                Trace.WriteLine(String.Format("Item:Good"));
                if (!_good.HasValue)
                    _good = this.GetBoolFromLSO("Good");
                return _good.Value;
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
                Trace.WriteLine(String.Format("Item:Heirloom"));
                if (!_heirloom.HasValue)
                    _heirloom = this.GetBoolFromLSO("Heirloom");
                return _heirloom.Value;
            }
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
                Trace.WriteLine(String.Format("Item:ID"));
                if (!_iD.HasValue)
                    _iD = this.GetIntFromLSO("ID");
                return _iD.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the item is in the bank
        /// </summary>
        public bool InBank
        {
            get
            {
                Trace.WriteLine(String.Format("Item:InBank"));
                return this.GetBoolFromLSO("InBank");
            }
        }

        /// <summary>
        /// Returns TRUE if the item is in a container
        /// </summary>
        public bool InContainer
        {
            get
            {
                Trace.WriteLine(String.Format("Item:InContainer"));
                return this.GetBoolFromLSO("InContainer");
            }
        }

        /// <summary>
        /// ID of parent container
        /// </summary>
        public int InContainerID
        {
            get
            {
                Trace.WriteLine(String.Format("Item:InContainerID"));
                return this.GetIntFromLSO("InContainerID");
            }
        }

        /// <summary>
        /// Cache of Index
        /// </summary>
        private int? _index;

        /// <summary>
        /// A number that represents a unique item number for an item.
        /// e.g. eq2execute "inventory equip 'ItemIndex' 'SlotNumber'"
        /// </summary>
        public int Index
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Index"));
                if (!_index.HasValue)
                    _index = this.GetIntFromLSO("Index");
                return _index.Value;
            }
        }

        /// <summary>
        /// Identifies if the item is in a bag or actual inventory slot
        /// </summary>
        public bool InInventory
        {
            get
            {
                Trace.WriteLine(String.Format("Item:InInventory"));
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
                Trace.WriteLine(String.Format("Item:InInventorySlot"));
                return this.GetBoolFromLSO("InInventorySlot");
            }
        }

        /// <summary>
        /// Returns TRUE if the item is in a nosale container
        /// </summary>
        public bool InNoSaleContainer
        {
            get
            {
                Trace.WriteLine(String.Format("Item:InNoSaleContainer"));
                return this.GetBoolFromLSO("InNoSaleContainer");
            }
        }

        /// <summary>
        /// Returns TRUE if the item is in the shared bank
        /// </summary>
        public bool InSharedBank
        {
            get
            {
                Trace.WriteLine(String.Format("Item:InSharedBank"));
                return this.GetBoolFromLSO("InSharedBank");
            }
        }

        

        /// <summary>
        /// Cache of IsAutoConsumeable
        /// </summary>
        private bool? _isAutoConsumeable;

        /// <summary>
        /// Returns TRUE if the item is auto consumeable
        /// </summary>
        public bool IsAutoConsumeable
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsAutoConsumeable"));
                if (!_isAutoConsumeable.HasValue)
                    _isAutoConsumeable = this.GetBoolFromLSO("IsAutoConsumeOn");
                return _isAutoConsumeable.Value;
            }
        }

        /// <summary>
        /// Identifies if the item is a container placed in one of your 12 actual bank slots
        /// </summary>
        public bool IsBankContainer
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsBankContainer"));
                return this.GetBoolFromLSO("IsBankContainer");
            }
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
                Trace.WriteLine(String.Format("Item:IsCollectible"));
                if (!_isCollectible.HasValue)
                    _isCollectible = this.GetBoolFromLSO("IsCollectible");
                return _isCollectible.Value;
            }
        }

        /// <summary>
        /// Cache of IsContainer
        /// </summary>
        private bool? _isContainer;

        /// <summary>
        /// Returns TRUE if the item is a container
        /// </summary>
        public bool IsContainer
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsContainer"));
                if(!_isContainer.HasValue)
                    _isContainer = this.GetBoolFromLSO("IsContainer");
                return _isContainer.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the item is equipped
        /// </summary>
        public bool IsEquipped
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsEquipped"));
                return this.GetBoolFromLSO("IsEquipped");
            }
        }

        /// <summary>
        /// Cache of IsItemFoodOrDrink
        /// </summary>
        private bool? _isFoodOrDrink;

        /// <summary>
        /// Returns TRUE if the item is a food or drink
        /// </summary>
        public bool IsFoodOrDrink
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsFoodOrDrink"));
                if (!_isFoodOrDrink.HasValue)
                    _isFoodOrDrink = this.GetBoolFromLSO("IsFoodOrDrink");
                return _isFoodOrDrink.Value;
            }
        }

        /// <summary>
        /// Returns true if all of this item's datatype members are available
        /// (i.e., if information has been cached from the server.)
        /// </summary>
        public bool IsInitialized
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsInitialized"));
                return this.GetBoolFromLSO("IsInitialized");
            }
        }

        /// <summary>
        /// Returns true if all of this item's datatype members are available
        /// (i.e., if information has been cached from the server.)
        /// </summary>
        public bool IsItemInfoAvailable
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsItemInfoAvailable"));
                return this.GetBoolFromLSO("IsItemInfoAvailable");
            }
        }

        /// <summary>
        /// Identifies if the item is a container placed in one of your 6 actual inventory slots
        /// </summary>
        public bool IsInventoryContainer
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsInventoryContainer"));
                return this.GetBoolFromLSO("IsInventoryContainer");
            }
        }

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
                Trace.WriteLine(String.Format("Item:IsQuestItemUsable"));
                if (!_isQuestItemUsable.HasValue)
                    _isQuestItemUsable = this.GetBoolFromLSO("IsQuestItemUsable");
                return _isQuestItemUsable.Value;
            }
        }

        /// <summary>
        /// Returns true if the IsActivatable == TRUE and the item is ready for use
        /// </summary>
        public bool IsReady
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsReady"));
                return this.GetBoolFromLSO("IsReady");
            }
        }

        /// <summary>
        /// Cache of IsScribeable
        /// </summary>
        private bool? _isScribeable;

        /// <summary>
        /// Returns TRUE if the item is scribeable
        /// </summary>
        public bool IsScribeable
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsScribeable"));
                if (!_isScribeable.HasValue)
                    _isScribeable = this.GetBoolFromLSO("IsScribeable");
                return _isScribeable.Value;
            }
        }

        /// <summary>
        /// Identifies if the item is a container placed in one of your 8 actual shared bank slots
        /// </summary>
        public bool IsSharedBankContainer
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsSharedBankContainer"));
                return this.GetBoolFromLSO("IsSharedBankContainer");
            }
        }

        /// <summary>
        /// Returns TRUE if the slot is open
        /// </summary>
        /// <param name="slot">slot number</param>
        /// <returns>TRUE if the slot is open</returns>
        public bool IsSlotOpen(int slot)
        {
            Trace.WriteLine(String.Format("Item:IsOpenSlot({0})", slot.ToString(CultureInfo.InvariantCulture)));
            return this.GetBoolFromLSO("IsSlotOpen", slot.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Returns the item in the slot
        /// </summary>
        /// <param name="slot">slot number</param>
        /// <returns>item in the slot</returns>
        public Item ItemInSlot(int slot)
        {
            Trace.WriteLine(String.Format("Item:ItemInSlot({0})", slot.ToString(CultureInfo.InvariantCulture)));
            return new Item(this.GetMember("ItemInSlot", slot.ToString(CultureInfo.InvariantCulture)));
        }

        

        /// <summary>
        /// Cache of Level
        /// </summary>
        private int? _level;

        /// <summary>
        /// Food/Drink Level
        /// </summary>
        public int Level
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Level"));
                if (!_level.HasValue)
                    _level = this.GetIntFromLSO("Level");
                return _level.Value;
            }
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
                Trace.WriteLine(String.Format("Item:LinkID"));
                if (!_linkID.HasValue)
                    _linkID = this.GetIntFromLSO("LinkID");
                return _linkID.Value;
            }
        }

        /// <summary>
        /// Cache of Lore
        /// </summary>
        private bool? _lore;

        /// <summary>
        /// Returns TRUE if the item is lore
        /// </summary>
        public bool Lore
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Lore"));
                if (!_lore.HasValue)
                    _lore = this.GetBoolFromLSO("Lore");
                return _lore.Value;
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
                Trace.WriteLine(String.Format("Item:LoreOnEquip"));
                if (!_loreOnEquip.HasValue)
                    _loreOnEquip = this.GetBoolFromLSO("LoreOnEquip");
                return _loreOnEquip.Value;
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
                Trace.WriteLine(String.Format("Item:MasteryMinDamage"));
                if (!_masteryMinDamage.HasValue)
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
                Trace.WriteLine(String.Format("Item:MasteryMaxDamage"));
                if (!_masteryMaxDamage.HasValue)
                    _masteryMaxDamage = this.GetIntFromLSO("MasteryMaxDamage");
                return _masteryMaxDamage.Value;
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
                Trace.WriteLine(String.Format("Item:MaxCharges"));
                if (!_maxCharges.HasValue)
                    _maxCharges = this.GetIntFromLSO("MaxCharges");
                return _maxCharges.Value;
            }
        }

        /// <summary>
        /// Cache of MaxMitigation
        /// </summary>
        private int? _maxMitigation;

        /// <summary>
        /// Max Mitigation
        /// </summary>
        public int MaxMitigation
        {
            get
            {
                Trace.WriteLine(String.Format("Item:MaxMitigation"));
                if (!_maxMitigation.HasValue)
                    _maxMitigation = this.GetIntFromLSO("MaxMitigation");
                return _maxMitigation.Value;
            }
        }

        /// <summary>
        /// Cache of MaxProtection
        /// </summary>
        private int? _maxProtection;

        /// <summary>
        /// MaxProtection
        /// </summary>
        public int MaxProtection
        {
            get
            {
                Trace.WriteLine(String.Format("Item:MaxProtection"));
                if (!_maxProtection.HasValue)
                    _maxProtection = this.GetIntFromLSO("MaxProtection");
                return _maxProtection.Value;
            }
        }

        /// <summary>
        /// Cache of MaxRange
        /// </summary>
        private int? _maxRange;

        /// <summary>
        /// Max Weapon Range
        /// </summary>
        public int MaxRange
        {
            get
            {
                Trace.WriteLine(String.Format("Item:MaxRange"));
                if (!_maxRange.HasValue)
                    _maxRange = this.GetIntFromLSO("MaxRange");
                return _maxRange.Value;
            }
        }

        /// <summary>
        /// Cache of MinRange
        /// </summary>
        private int? _minRange;

        /// <summary>
        /// Min Weapon Range
        /// </summary>
        public int MinRange
        {
            get
            {
                Trace.WriteLine(String.Format("Item:MinRange"));
                if (!_minRange.HasValue)
                    _minRange = this.GetIntFromLSO("MinRange");
                return _minRange.Value;
            }
        }

        /// <summary>
        /// Cache of Mitigation
        /// </summary>
        private int? _mitigation;

        /// <summary>
        /// Mitigation
        /// </summary>
        public int Mitigation
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Mitigation"));
                if (!_mitigation.HasValue)
                    _mitigation = this.GetIntFromLSO("Mitigation");
                return _mitigation.Value;
            }
        }

        /// <summary>
        /// Retrieves the modifier at index between 1 and NumModifiers
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>item modifier</returns>
        public ItemModifier Modifier(int index)
        {
            Trace.WriteLine(String.Format("Item:Modifier({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new ItemModifier(this.GetMember("Modifier", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Weapon Min Damage
        /// </summary>
        public int MyMinDamage
        {
            get
            {
                Trace.WriteLine(String.Format("Item:MyMinDamage"));
                return this.GetIntFromLSO("MyMinDamage");
            }
        }

        /// <summary>
        /// Weapon Max Damage
        /// </summary>
        public int MyMaxDamage
        {
            get
            {
                Trace.WriteLine(String.Format("Item:MyMaxDamage"));
                return this.GetIntFromLSO("MyMaxDamage");
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
            get
            {
                Trace.WriteLine(String.Format("Item:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// The next open slot in the container
        /// </summary>
        public int NextSlotOpen
        {
            get
            {
                Trace.WriteLine(String.Format("Item:NextSlotOpen"));
                return this.GetIntFromLSO("NextSlotOpen");
            }
        }

        /// <summary>
        /// Cache of NoDestroy
        /// </summary>
        private bool? _noDestroy;

        /// <summary>
        /// Returns TRUE if the item is no destroy
        /// </summary>
        public bool NoDestroy
        {
            get
            {
                Trace.WriteLine(String.Format("Item:NoDestroy"));
                if (!_noDestroy.HasValue)
                    _noDestroy = this.GetBoolFromLSO("NoDestroy");
                return _noDestroy.Value;
            }
        }

        /// <summary>
        /// Cache of NoTrade
        /// </summary>
        private bool? _noTrade;

        /// <summary>
        /// Returns TRUE if the item is no trade
        /// </summary>
        public bool NoTrade
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Notrade"));
                if (!_noTrade.HasValue)
                    _noTrade = this.GetBoolFromLSO("NoTrade");
                return _noTrade.Value;
            }
        }

        /// <summary>
        /// Cache of NoValue
        /// </summary>
        private bool? _noValue;

        /// <summary>
        /// Returns TRUE if the item is no value
        /// </summary>
        public bool NoValue
        {
            get
            {
                Trace.WriteLine(String.Format("Item:NoValue"));
                if (!_noValue.HasValue)
                    _noValue = this.GetBoolFromLSO("NoValue");
                return _noValue.Value;
            }
        }

        /// <summary>
        /// Cache of NoZone
        /// </summary>
        private bool? _noZone;

        /// <summary>
        /// Returns TRUE if the item is no zone
        /// </summary>
        public bool NoZone
        {
            get
            {
                Trace.WriteLine(String.Format("Item:NoZone"));
                if (!_noZone.HasValue)
                    _noZone = this.GetBoolFromLSO("NoZone");
                return _noZone.Value;
            }
        }

        /// <summary>
        /// Cache of NumClasses
        /// </summary>
        private int? _numClasses;

        /// <summary>
        /// Returns the number of classes that can use the item
        /// </summary>
        public int NumClasses
        {
            get
            {
                Trace.WriteLine(String.Format("Item:NumClasses"));
                if (!_numClasses.HasValue)
                    _numClasses = this.GetIntFromLSO("NumClasses");
                return _numClasses.Value;
            }
        }

        /// <summary>
        /// The number of effects on the item
        /// </summary>
        public int NumEffects
        {
            get
            {
                Trace.WriteLine(String.Format("Item:NumEffects"));
                return this.GetIntFromLSO("NumEffects");
            }
        }

        /// <summary>
        /// Cache of NumEquipSlots
        /// </summary>
        private int? _numEquipSlots;

        /// <summary>
        /// Returns the number of slots in which this item can be equipped 
        /// </summary>
        public int NumEquipSlots
        {
            get
            {
                Trace.WriteLine(String.Format("Item:NumEquipSlots"));
                if (!_numEquipSlots.HasValue)
                    _numEquipSlots = this.GetIntFromLSO("NumEquipSlots");
                return _numEquipSlots.Value;
            }
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
                Trace.WriteLine(String.Format("Item:NumModifiers"));
                if (!_numModifiers.HasValue)
                    _numModifiers = this.GetIntFromLSO("NumModifiers");
                return _numModifiers.Value;
            }
        }

        /// <summary>
        /// Cache for NumSlots
        /// </summary>
        private int? _numSlots;

        /// <summary>
        /// The number of slots in the container
        /// </summary>
        public int NumSlots
        {
            get
            {
                Trace.WriteLine(String.Format("Item:NumSlots"));
                if (!_numSlots.HasValue)
                    _numSlots = this.GetIntFromLSO("NumSlots");
                return _numSlots.Value;
            }
        }

        /// <summary>
        /// Identifies the number of free slots in a container
        /// </summary>
        public int NumSlotsFree
        {
            get
            {
                Trace.WriteLine(String.Format("Item:NumSlotsFree"));
                return this.GetIntFromLSO("NumSlotsFree");
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
                Trace.WriteLine(String.Format("Item:OffersQuest"));
                if (!_offersQuest.HasValue)
                    _offersQuest = this.GetBoolFromLSO("OffersQuest");
                return _offersQuest.Value;
            }
        }

        /// <summary>
        /// Cache of Ornate
        /// </summary>
        private bool? _ornate;

        /// <summary>
        /// Returns TRUE if the item is Ornate
        /// </summary>
        public bool Ornate
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Ornate"));
                if (!_ornate.HasValue)
                    _ornate = this.GetBoolFromLSO("Ornate");
                return _ornate.Value;
            }
        }

        /// <summary>
        /// Cache of Protection
        /// </summary>
        private int? _protection;

        /// <summary>
        /// Protection
        /// </summary>
        public int Protection
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Protection"));
                if (!_protection.HasValue)
                    _protection = this.GetIntFromLSO("Protection");
                return _protection.Value;
            }
        }

        /// <summary>
        /// Item Quantity
        /// </summary>
        public int Quantity
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Quantity"));
                return this.GetIntFromLSO("Quantity");
            }
        }

        /// <summary>
        /// Return MaxRange
        /// </summary>
        public int Range
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Range"));
                return this.MaxRange;
            }
        }

        /// <summary>
        /// Item Recast Time
        /// </summary>
        public float RecastTime
        {
            get
            {
                Trace.WriteLine(String.Format("Item:RecastTime"));
                return this.GetFloatFromLSO("RecastTime");
            }
        }

        /// <summary>
        /// Item Recovery Time
        /// </summary>
        public float RecoveryTime
        {
            get
            {
                Trace.WriteLine(String.Format("Item:RecoveryTime"));
                return this.GetFloatFromLSO("RecoveryTime");
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
                Trace.WriteLine(String.Format("Item:RentStatusReduction"));
                if (!_rentStatusReduction.HasValue)
                    _rentStatusReduction = this.GetIntFromLSO("RentStatusReduction");
                return _rentStatusReduction.Value;
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
                Trace.WriteLine(String.Format("Item:RequiredByQuest"));
                if (!_requiredByQuest.HasValue)
                    _requiredByQuest = this.GetBoolFromLSO("RequiredByQuest");
                return _requiredByQuest.Value;
            }
        }

        /// <summary>
        /// Cache of Satiation
        /// </summary>
        private string _satiation;

        /// <summary>
        /// Food or Drink satiation level
        /// </summary>
        public string Satiation
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Satiation"));
                return _satiation ?? (_satiation = this.GetStringFromLSO("Satiation"));
            }
        }

        /// <summary>
        /// Cache of SerialNumber
        /// </summary>
        private long? _serialNumber;

        /// <summary>
        /// Item Serial Number
        /// </summary>
        public long SerialNumber
        {
            get
            {
                Trace.WriteLine(String.Format("Item:SerialNumber"));
                if (!_serialNumber.HasValue)
                    _serialNumber = this.GetInt64FromLSO("SerialNumber");
                return _serialNumber.Value;
            }
        }

        /// <summary>
        /// Returns the current slot position for the item within its container, or within your inventory.
        /// So, if the item is in a bag that has 20 slots, it will return a number between 0 and 19.
        /// If the item (or container) is sitting in one of your six "real" inventory slots, it will return 0 to 5.
        /// </summary>
        public int Slot
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Slot"));
                return this.GetIntFromLSO("Slot");
            }
        }

        /// <summary>
        /// Cache of SubType
        /// </summary>
        private string _subType;

        /// <summary>
        /// Weapon Sub Type
        /// </summary>
        public string SubType
        {
            get
            {
                Trace.WriteLine(String.Format("Item:SubType"));
                return _subType ?? (_subType = this.GetStringFromLSO("SubType"));
            }
        }

        /// <summary>
        /// Cache of Temporary
        /// </summary>
        private bool? _temporary;

        /// <summary>
        /// Returns TRUE if the item is Temporary
        /// </summary>
        public bool Temporary
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Temporary"));
                if (!_temporary.HasValue)
                    _temporary = this.GetBoolFromLSO("Temporary");
                return _temporary.Value;
            }
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
            get
            {
                Trace.WriteLine(String.Format("Item:Tier"));
                return _tier ?? (_tier = this.GetStringFromLSO("Tier"));
            }
        }

        /// <summary>
        /// Returns the time in seconds until the item is ready for use
        /// </summary>
        public float TimeUntilReady
        {
            get
            {
                Trace.WriteLine(String.Format("Item:TimeUntilReady"));
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
                Trace.WriteLine(String.Format("Item:ToLink"));
                return this.GetStringFromLSO("ToLink");
            }
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
            get
            {
                Trace.WriteLine(String.Format("Item:Type"));
                return _type ?? (_type = this.GetStringFromLSO("Type"));
            }
        }

        /// <summary>
        /// Cache of WieldStyle
        /// </summary>
        private string _wieldStyle;

        /// <summary>
        /// Wield Style (Returns: Dual Wield, Two-Handed, or One-Handed.)
        /// </summary>
        public string WieldStyle
        {
            get
            {
                Trace.WriteLine(String.Format("Item:WieldStyle"));
                return _wieldStyle ?? (_wieldStyle = this.GetStringFromLSO("WieldStyle"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Activates the item
        /// </summary>
        /// <returns>call success</returns>
        public bool Activate()
        {
            Trace.WriteLine(String.Format("Item:Activate()"));
            return this.ExecuteMethod("Activate");
        }

        /// <summary>
        /// Moves the entire item/stack to the first available vendor 
        /// </summary>
        /// <returns>call success</returns>
        public bool AddToConsignment()
        {
            Trace.WriteLine(String.Format("Item:AddToConsignment()"));
            return this.ExecuteMethod("AddToConsignment");
        }

        /// <summary>
        /// Moves the quantity of the stack to the first available vendor 
        /// </summary>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool AddToConsignment(int quantity)
        {
            Trace.WriteLine(String.Format("Item:AddToConsignment({0}", quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddToConsignment", quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Moves the quantity of the stack to the vendor/vending container (1 to 6)
        /// </summary>
        /// <param name="quantity">quantity</param>
        /// <param name="vendorindex">index</param>
        /// <returns>call success</returns>
        public bool AddToConsignment(int quantity, int vendorindex)
        {
            Trace.WriteLine(String.Format("Item:AddToConsignment({0}, {1})", 
                quantity.ToString(CultureInfo.InvariantCulture), vendorindex.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddToConsignment", quantity.ToString(CultureInfo.InvariantCulture), 
                vendorindex.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Moves the quantity of the stack to the vendor/vending container (1 to 6) to the stack with
        /// the stack serial number consignment
        /// </summary>
        /// <param name="quantity">quantity</param>
        /// <param name="vendorindex">index</param>
        /// <param name="stackwithserialnumber">serial number of target stack</param>
        /// <returns>call success</returns>
        public bool AddToConsignment(int quantity, int vendorindex, long stackwithserialnumber)
        {
            Trace.WriteLine(String.Format("Item:AddToConsignment({0}, {1}, {2})",
                quantity.ToString(CultureInfo.InvariantCulture), vendorindex.ToString(CultureInfo.InvariantCulture), 
                stackwithserialnumber.ToString(CultureInfo.InvariantCulture)));
            return ExecuteMethod("AddToConsignment", quantity.ToString(CultureInfo.InvariantCulture), 
                vendorindex.ToString(CultureInfo.InvariantCulture), stackwithserialnumber.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Adds the item to a depot
        /// </summary>
        /// <param name="depotID">depot ID</param>
        /// <returns>call success</returns>
        public bool AddToDepot(int depotID)
        {
            Trace.WriteLine(String.Format("Item:AddToDepot({0})", depotID.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddToDepot", depotID.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Adds the quantity of the item to the depot
        /// </summary>
        /// <param name="depotID">depot ID</param>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool AddToDepot(int depotID, int quantity)
        {
            Trace.WriteLine(String.Format("Item:AddToDepot({0}, {1})", depotID.ToString(CultureInfo.InvariantCulture), 
                quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddToDepot", depotID.ToString(CultureInfo.InvariantCulture), 
                quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Used to apply an item to another item
        /// </summary>
        /// <param name="itemID">target item id</param>
        /// <returns>call success</returns>
        public bool ApplyToItem(int itemID)
        {
            Trace.WriteLine(String.Format("Item:AppltToItem({0})", itemID.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("ApplyToItem", itemID.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Consumes the item (Food/Drink)
        /// </summary>
        /// <returns>call success</returns>
        public bool Consume()
        {
            Trace.WriteLine(String.Format("Item:Consume"));
            return this.ExecuteMethod("Consume");
        }

        /// <summary>
        /// Destroys Item
        /// </summary>
        /// <returns>call success</returns>
        public bool Destroy()
        {
            Trace.WriteLine(String.Format("Item:Destroy"));
            return this.ExecuteMethod("Destroy");
        }

        /// <summary>
        /// Destroys the quantity of an item if it is in a stack
        /// </summary>
        /// <returns>call success</returns>
        public bool Destroy(int quantity)
        {
            Trace.WriteLine(String.Format("Item:Destroy({0})", quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("Destroy", quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Destroys Item with Confirm On
        /// </summary>
        /// <returns>call success</returns>
        public bool DestroyWithConf()
        {
            Trace.WriteLine(String.Format("Item:DestroyWithConf"));
            return this.ExecuteMethod("DestroyWithConf");
        }

        /// <summary>
        /// Applies temporary enchantments after use
        /// </summary>
        /// <param name="itemID">target item ID</param>
        /// <returns>call success</returns>
        public bool EnchantItem(int itemID)
        {
            Trace.WriteLine(String.Format("Item:EnchantItem({0})", itemID.ToString(CultureInfo.InvariantCulture)));
            return ExecuteMethod("EnchantITem", itemID.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Auto Equips the item
        /// </summary>
        /// <returns>call success</returns>
        public bool Equip()
        {
            Trace.WriteLine(String.Format("Item:Equip()"));
            return this.ExecuteMethod("Equip");
        }

        /// <summary>
        /// Examines the item
        /// </summary>
        /// <returns>call success</returns>
        public bool Examine()
        {
            Trace.WriteLine(String.Format("Item:Examine()"));
            return this.ExecuteMethod("Examine");
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
            Trace.WriteLine(String.Format("Item:Initialize()"));
            return this.ExecuteMethod("Initialize");
        }

        /// <summary>
        /// Adds the item (which must be a vending container and must be in your inventory) to 
        /// your consignment system.  It will place the vending container into the first 
        /// free slot that is available.
        /// </summary>
        /// <returns>call success</returns>
        public bool InstallAsVendingContainer()
        {
            Trace.WriteLine(String.Format("Item:InstallAsVendingContainer()"));
            return this.ExecuteMethod("InstallAsVendingContainer");
        }

        /// <summary>
        /// Moves an item to a particular slot in a bag
        /// </summary>
        /// <param name="bagslot">slot</param>
        /// <param name="bagID">bag id</param>
        /// <returns>call success</returns>
        public bool Move(int bagslot, int bagID)
        {
            Trace.WriteLine(String.Format("Item:Move({0}, {1})", bagslot.ToString(CultureInfo.InvariantCulture),
                bagID.ToString(CultureInfo.InvariantCulture)));
            return ExecuteMethod("Move", bagslot.ToString(CultureInfo.InvariantCulture), 
                bagID.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Moves a quantity of a stackable item to a particular slot in a container
        /// </summary>
        /// <param name="bagslot">slot</param>
        /// <param name="bagID">bag id</param>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool Move(int bagslot, int bagID, int quantity)
        {
            Trace.WriteLine(String.Format("Item:Move({0}, {1}, {2}", bagslot.ToString(CultureInfo.InvariantCulture),
                bagID.ToString(CultureInfo.InvariantCulture), quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("Move", bagslot.ToString(CultureInfo.InvariantCulture),
                bagID.ToString(CultureInfo.InvariantCulture), quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Moves the item(s) to the next free inventory slot of the selected type.
        /// (Use quantity = 0 for non-stackable items.)
        /// </summary>
        /// <param name="invtype">inventory type</param>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool Move(NextFreeType invtype, int quantity)
        {
            Trace.WriteLine(String.Format("Item:Move({0}, {1})", invtype.ToString(),
                quantity.ToString(CultureInfo.InvariantCulture)));
            return ExecuteMethod("Move", invtype.ToString(),
                quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Opens a container
        /// </summary>
        /// <returns>call success</returns>
        public bool Open()
        {
            Trace.WriteLine(String.Format("Item:Open()"));
            return this.ExecuteMethod("Open");
        }

        /// <summary>
        /// Sacrifices the item
        /// </summary>
        /// <param name="withconfirm">with confirmation</param>
        /// <returns>call success</returns>
        public bool Sacrifice(bool withconfirm)
        {
            Trace.WriteLine(String.Format("Item:Sacrifice({0})", withconfirm.ToString(CultureInfo.InvariantCulture)));
            return withconfirm ? this.ExecuteMethod("Sacrifice", "With Confirmation") : this.ExecuteMethod("Sacrifice");
        }

        /// <summary>
        /// Scribes the item
        /// </summary>
        /// <returns>call success</returns>
        public bool Scribe()
        {
            Trace.WriteLine(String.Format("Item:Scribe()"));
            return this.ExecuteMethod("Scribe");
        }

        /// <summary>
        /// Attaches the item as a gift. Must be in a mail transaction.
        /// </summary>
        /// <returns>call success</returns>
        public bool SendAsGift()
        {
            Trace.WriteLine(String.Format("Item:SendAsGift()"));
            return this.ExecuteMethod("SendAsGift");
        }

        /// <summary>
        /// Attaches the quantity of a stackable item as a gift. Must be in a mail transaction.
        /// </summary>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool SendAsGift(int quantity)
        {
            Trace.WriteLine(String.Format("Item:SendAsGift({0})", quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("SendAsGift", quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Toggles auto consume on and off. Check with AutoConsumeOn
        /// </summary>
        /// <returns>call success</returns>
        public bool ToggleAutoConsume()
        {
            Trace.WriteLine(String.Format("Item:ToggleAutoConsume()"));
            return this.ExecuteMethod("ToggleAutoConsume");
        }

        /// <summary>
        /// Transmutes the item
        /// </summary>
        /// <param name="withconfirm">with confirmation</param>
        /// <returns>call success</returns>
        public bool Transmute(bool withconfirm)
        {
            Trace.WriteLine(String.Format("Item:Transmute({0})", withconfirm.ToString(CultureInfo.InvariantCulture)));
            return withconfirm ? this.ExecuteMethod("Transmute", "askmefirst") : this.ExecuteMethod("Transmute");
        }

        /// <summary>
        /// UnEquips the item
        /// </summary>
        /// <returns>call success</returns>
        public bool UnEquip()
        {
            Trace.WriteLine(String.Format("Item:UnEquip"));
            return this.ExecuteMethod("UnEquip");
        }

        /// <summary>
        /// Uses the item
        /// </summary>
        /// <returns>call success</returns>
        public bool Use()
        {
            Trace.WriteLine(String.Format("Item:Use()"));
            return this.ExecuteMethod("Use");
        }

        #endregion

        #region Enums

        /// <summary>
        /// Inventory Types for the Move() Method
        /// </summary>
        public enum NextFreeType
        {
            /// <summary>
            /// Non Bank Inventory
            /// </summary>
            NextFreeNonBank,
            /// <summary>
            /// Bank Inventory
            /// </summary>
            NextFreeInBank
        }

        #endregion

    }
}
