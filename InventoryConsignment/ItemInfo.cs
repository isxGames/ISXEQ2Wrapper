using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.AbilityEffect;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// Although this datatype is used natively in some parts of EQ2, its primary function is to
    /// store and return item "details".  The client does not need to know these details all of the time,
    /// so when the player examines an item, or when ISXEQ2 requests it, the details are downloaded from
    /// the server and stored in a cache.
    /// </summary>
    public class ItemInfo : LavishScriptObject
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public ItemInfo(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns the adornment at the given index (1 to NumAdornmentsAttached).
        /// </summary>
        /// <param name="index">adornment index</param>
        /// <returns>Adornment</returns>
        public Adornment Adornment(int index)
        {
            Trace.WriteLine(String.Format("ItemInfo:Adornment({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Adornment(this.GetMember("Adornment", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns TRUE if the collectible has already been collected.
        /// </summary>
        public bool AlreadyCollected
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:AlreadyCollected"));
                return this.GetBoolFromLSO("AlreadyCollected");
            }
        }

        /// <summary>
        /// Cache of AppearanceOnly
        /// </summary>
        private bool? _appearanceOnly;

        /// <summary>
        /// Returns TRUE if the item is an Appearance Only item.
        /// </summary>
        public bool AppearanceOnly
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:AppearanceOnly"));
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
        /// Returns TRUE if the item is an artifact.
        /// </summary>
        public bool Artifact
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Artifact"));
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
        /// Returns TRUE if the item is attuneable.
        /// </summary>
        public bool Attuneable
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Attuneable"));
                if (!_attuneable.HasValue)
                    _attuneable = this.GetBoolFromLSO("Attuneable");
                return _attuneable.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the item is attuned.
        /// </summary>
        public bool Attuned
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Attuned"));
                return this.GetBoolFromLSO("Attuned");
            }
        }

        /// <summary>
        /// Returns TRUE if the item is a building block.
        /// </summary>
        public bool BuildingBlock
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:BuildingBlock"));
                return this.GetBoolFromLSO("BuildingBlock");
            }
        }

        /// <summary>
        /// Returns TRUE if the item can be scribed right now.
        /// It is the responsibility of scripts to check item.IsScribeable.
        /// </summary>
        public bool CanScribeNow
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:CanScribeNow"));
                return this.GetBoolFromLSO("CanScribeNow");
            }
        }

        /// <summary>
        /// Casting time of the item (Activateable).
        /// </summary>
        public float CastingTime
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:CastingTime"));
                return this.GetFloatFromLSO("CastingTime");
            }
        }

        /// <summary>
        /// Item charges (Activateable). -1 indicates unlimited.
        /// </summary>
        public int Charges
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Charges"));
                return this.GetIntFromLSO("Charges");
            }
        }

        /// <summary>
        /// Returns the class at the given index (1 to NumClasses).
        /// Items usable by ALL classes will have one entry: "commoner".
        /// </summary>
        /// <param name="index">class index</param>
        /// <returns>Class</returns>
        public Class Class(int index)
        {
            Trace.WriteLine(String.Format("ItemInfo:Class({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Class(this.GetMember("Class", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Cache of Condition
        /// </summary>
        private int? _condition;

        /// <summary>
        /// Item condition (%).
        /// </summary>
        public int Condition
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Condition"));
                if (!_condition.HasValue)
                    _condition = this.GetIntFromLSO("Condition");
                return _condition.Value;
            }
        }

        /// <summary>
        /// Containers Only. Returns TRUE if the contents of the container are for sale.
        /// It is the responsibility of scripts to check item.IsContainer.
        /// </summary>
        public bool ContentsForSale
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:ContentsForSale"));
                return this.GetBoolFromLSO("ContentsForSale");
            }
        }

        /// <summary>
        /// Cache of Crafter
        /// </summary>
        private string _crafter;

        /// <summary>
        /// The name of the crafter (if crafted item).
        /// </summary>
        public string Crafter
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Crafter"));
                return _crafter ?? (_crafter = this.GetStringFromLSO("Crafter"));
            }
        }

        /// <summary>
        /// Returns the created item name at the given index (1 to NumItemsCreated).
        /// </summary>
        /// <param name="index">created item index</param>
        /// <returns>created item name</returns>
        public string CreatesItem(int index)
        {
            Trace.WriteLine(String.Format("ItemInfo:CreatesItem({0})", index.ToString(CultureInfo.InvariantCulture)));
            return this.GetStringFromLSO("CreatesItem", index.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Cache of DamageType
        /// </summary>
        private string _damageType;

        /// <summary>
        /// Weapon damage type.
        /// </summary>
        public string DamageType
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:DamageType"));
                return _damageType ?? (_damageType = this.GetStringFromLSO("DamageType"));
            }
        }

        /// <summary>
        /// Cache of DamageVerbType
        /// </summary>
        private string _damageVerbType;

        /// <summary>
        /// Weapon damage verb type (e.g. "Slashing").
        /// </summary>
        public string DamageVerbType
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:DamageVerbType"));
                return _damageVerbType ?? (_damageVerbType = this.GetStringFromLSO("DamageVerbType"));
            }
        }

        /// <summary>
        /// Cache of Delay
        /// </summary>
        private float? _delay;

        /// <summary>
        /// Weapon delay.
        /// </summary>
        public float Delay
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Delay"));
                if (!_delay.HasValue)
                    _delay = this.GetFloatFromLSO("Delay");
                return _delay.Value;
            }
        }

        /// <summary>
        /// Cache of Description
        /// </summary>
        private string _description;

        /// <summary>
        /// The description of the item. Not all items have a description.
        /// </summary>
        public string Description
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Description"));
                return _description ?? (_description = this.GetStringFromLSO("Description"));
            }
        }

        /// <summary>
        /// Food/Drink/Activateable duration (depends on item type).
        /// </summary>
        public float Duration
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Duration"));
                return this.GetFloatFromLSO("Duration");
            }
        }

        /// <summary>
        /// Description of the effect at the given index.
        /// </summary>
        /// <param name="index">effect index</param>
        /// <returns>effect description</returns>
        public string EffectDescription(int index)
        {
            Trace.WriteLine(String.Format("ItemInfo:EffectDescription({0})", index.ToString(CultureInfo.InvariantCulture)));
            return this.GetStringFromLSO("EffectDescription", index.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Name of the effect at the given index.
        /// </summary>
        /// <param name="index">effect index</param>
        /// <returns>effect name</returns>
        public string EffectName(int index)
        {
            Trace.WriteLine(String.Format("ItemInfo:EffectName({0})", index.ToString(CultureInfo.InvariantCulture)));
            return this.GetStringFromLSO("EffectName", index.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Returns the effect-string entry at the given index (1 to NumEffectStrings).
        /// </summary>
        /// <param name="index">effect-string index</param>
        /// <returns>ItemEffectString</returns>
        public ItemEffectString EffectString(int index)
        {
            Trace.WriteLine(String.Format("ItemInfo:EffectString({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new ItemEffectString(this.GetMember("EffectString", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Containers only. The number of empty slots in the container.
        /// It is the responsibility of scripts to check item.IsContainer.
        /// </summary>
        public int EmptySlots
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:EmptySlots"));
                return this.GetIntFromLSO("EmptySlots");
            }
        }

        /// <summary>
        /// Returns the equip-slot name at the given index (1 to NumEquipSlots).
        /// </summary>
        /// <param name="index">equip-slot index</param>
        /// <returns>equip-slot name</returns>
        public string EquipSlot(int index)
        {
            Trace.WriteLine(String.Format("ItemInfo:EquipSlot({0})", index.ToString(CultureInfo.InvariantCulture)));
            return this.GetStringFromLSO("EquipSlot", index.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Cache of Evil
        /// </summary>
        private bool? _evil;

        /// <summary>
        /// Returns TRUE if item is only usable by Evil characters.
        /// </summary>
        public bool Evil
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Evil"));
                if (!_evil.HasValue)
                    _evil = this.GetBoolFromLSO("Evil");
                return _evil.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the item can be reforged for free.
        /// </summary>
        public bool FreeReforge
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:FreeReforge"));
                return this.GetBoolFromLSO("FreeReforge");
            }
        }

        /// <summary>
        /// Cache of Good
        /// </summary>
        private bool? _good;

        /// <summary>
        /// Returns TRUE if item is only usable by Good characters.
        /// </summary>
        public bool Good
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Good"));
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
        /// Returns TRUE if the item is heirloom.
        /// </summary>
        public bool Heirloom
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Heirloom"));
                if (!_heirloom.HasValue)
                    _heirloom = this.GetBoolFromLSO("Heirloom");
                return _heirloom.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the item is house lore.
        /// </summary>
        public bool HouseLore
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:HouseLore"));
                return this.GetBoolFromLSO("HouseLore");
            }
        }

        /// <summary>
        /// Icon ID of the item.
        /// </summary>
        public int IconID
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:IconID"));
                return this.GetIntFromLSO("IconID");
            }
        }

        /// <summary>
        /// The ID of the item.
        /// </summary>
        public uint ID
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:ID"));
                return this.GetUIntFromLSO("ID");
            }
        }

        /// <summary>
        /// Returns TRUE if the item is indestructible.
        /// </summary>
        public bool Indestructable
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Indestructable"));
                return this.GetBoolFromLSO("Indestructable");
            }
        }

        /// <summary>
        /// Returns TRUE if the item is infusable.
        /// </summary>
        public bool Infusable
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Infusable"));
                return this.GetBoolFromLSO("Infusable");
            }
        }

        /// <summary>
        /// Cache of IsActivatable
        /// </summary>
        private bool? _isActivatable;

        /// <summary>
        /// Returns TRUE if the item is activatable.
        /// It is the responsibility of scripts to check item.IsUsable.
        /// </summary>
        public bool IsActivatable
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:IsActivatable"));
                if (!_isActivatable.HasValue)
                    _isActivatable = this.GetBoolFromLSO("IsActivatable");
                return _isActivatable.Value;
            }
        }

        /// <summary>
        /// Cache of IsCollectible
        /// </summary>
        private bool? _isCollectible;

        /// <summary>
        /// Returns TRUE if the item is a collectible.
        /// </summary>
        public bool IsCollectible
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:IsCollectible"));
                if (!_isCollectible.HasValue)
                    _isCollectible = this.GetBoolFromLSO("IsCollectible");
                return _isCollectible.Value;
            }
        }

        /// <summary>
        /// Cache of IsQuestItemUsable
        /// </summary>
        private bool? _isQuestItemUsable;

        /// <summary>
        /// Returns TRUE if the item is a usable quest item.
        /// </summary>
        public bool IsQuestItemUsable
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:IsQuestItemUsable"));
                if (!_isQuestItemUsable.HasValue)
                    _isQuestItemUsable = this.GetBoolFromLSO("IsQuestItemUsable");
                return _isQuestItemUsable.Value;
            }
        }

        /// <summary>
        /// Cache of Label
        /// </summary>
        private string _label;

        /// <summary>
        /// Item Label (Container).
        /// It is the responsibility of scripts to check item.IsContainer.
        /// </summary>
        public string Label
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Label"));
                return _label ?? (_label = this.GetStringFromLSO("Label"));
            }
        }

        /// <summary>
        /// Cache of Level
        /// </summary>
        private int? _level;

        /// <summary>
        /// Item level (or food/drink level for consumables).
        /// </summary>
        public int Level
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Level"));
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
        /// The item LinkID.
        /// </summary>
        public int LinkID
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:LinkID"));
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
        /// Returns TRUE if the item is lore.
        /// </summary>
        public bool Lore
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Lore"));
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
        /// Returns TRUE if the item becomes Lore once equipped.
        /// </summary>
        public bool LoreOnEquip
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:LoreOnEquip"));
                if (!_loreOnEquip.HasValue)
                    _loreOnEquip = this.GetBoolFromLSO("LoreOnEquip");
                return _loreOnEquip.Value;
            }
        }

        /// <summary>
        /// Cache of MaxCharges
        /// </summary>
        private int? _maxCharges;

        /// <summary>
        /// Maximum charges (Activateable). -1 indicates unlimited.
        /// </summary>
        public int MaxCharges
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:MaxCharges"));
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
        /// Maximum armor mitigation.
        /// </summary>
        public int MaxMitigation
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:MaxMitigation"));
                if (!_maxMitigation.HasValue)
                    _maxMitigation = this.GetIntFromLSO("MaxMitigation");
                return _maxMitigation.Value;
            }
        }

        /// <summary>
        /// Cache of MaxRange
        /// </summary>
        private int? _maxRange;

        /// <summary>
        /// Maximum weapon range.
        /// </summary>
        public int MaxRange
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:MaxRange"));
                if (!_maxRange.HasValue)
                    _maxRange = this.GetIntFromLSO("MaxRange");
                return _maxRange.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the item is mercenary-only.
        /// </summary>
        public bool MercOnly
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:MercOnly"));
                return this.GetBoolFromLSO("MercOnly");
            }
        }

        /// <summary>
        /// Cache of MinRange
        /// </summary>
        private int? _minRange;

        /// <summary>
        /// Minimum weapon range.
        /// </summary>
        public int MinRange
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:MinRange"));
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
        /// Armor mitigation.
        /// </summary>
        public int Mitigation
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Mitigation"));
                if (!_mitigation.HasValue)
                    _mitigation = this.GetIntFromLSO("Mitigation");
                return _mitigation.Value;
            }
        }

        /// <summary>
        /// Display string of the item's mod-flag bitfield.
        /// </summary>
        public string ModFlag
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:ModFlag"));
                return this.GetStringFromLSO("ModFlag");
            }
        }

        /// <summary>
        /// Returns the modifier at the given index (1 to NumModifiers).
        /// </summary>
        /// <param name="index">modifier index</param>
        /// <returns>ItemModifier</returns>
        public ItemModifier Modifier(int index)
        {
            Trace.WriteLine(String.Format("ItemInfo:Modifier({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new ItemModifier(this.GetMember("Modifier", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns TRUE if the item is mount-only.
        /// </summary>
        public bool MountOnly
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:MountOnly"));
                return this.GetBoolFromLSO("MountOnly");
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// The name of the item.
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Returns TRUE if the item cannot be sold to a broker.
        /// </summary>
        public bool NoBroker
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NoBroker"));
                return this.GetBoolFromLSO("NoBroker");
            }
        }

        /// <summary>
        /// Cache of NoDestroy
        /// </summary>
        private bool? _noDestroy;

        /// <summary>
        /// Returns TRUE if the item is no-destroy.
        /// </summary>
        public bool NoDestroy
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NoDestroy"));
                if (!_noDestroy.HasValue)
                    _noDestroy = this.GetBoolFromLSO("NoDestroy");
                return _noDestroy.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the item cannot be experimented with.
        /// </summary>
        public bool NoExperiment
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NoExperiment"));
                return this.GetBoolFromLSO("NoExperiment");
            }
        }

        /// <summary>
        /// Returns TRUE if the item cannot be mailed.
        /// </summary>
        public bool NoMail
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NoMail"));
                return this.GetBoolFromLSO("NoMail");
            }
        }

        /// <summary>
        /// Returns TRUE if the item cannot be repaired.
        /// </summary>
        public bool NoRepair
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NoRepair"));
                return this.GetBoolFromLSO("NoRepair");
            }
        }

        /// <summary>
        /// Returns TRUE if the item cannot be salvaged.
        /// </summary>
        public bool NoSalvage
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NoSalvage"));
                return this.GetBoolFromLSO("NoSalvage");
            }
        }

        /// <summary>
        /// Cache of NoTrade
        /// </summary>
        private bool? _noTrade;

        /// <summary>
        /// Returns TRUE if the item is no-trade.
        /// </summary>
        public bool NoTrade
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NoTrade"));
                if (!_noTrade.HasValue)
                    _noTrade = this.GetBoolFromLSO("NoTrade");
                return _noTrade.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the item cannot be transmuted.
        /// </summary>
        public bool NoTransmute
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NoTransmute"));
                return this.GetBoolFromLSO("NoTransmute");
            }
        }

        /// <summary>
        /// Cache of NoValue
        /// </summary>
        private bool? _noValue;

        /// <summary>
        /// Returns TRUE if the item is no-value.
        /// </summary>
        public bool NoValue
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NoValue"));
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
        /// Returns TRUE if the item is no-zone.
        /// </summary>
        public bool NoZone
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NoZone"));
                if (!_noZone.HasValue)
                    _noZone = this.GetBoolFromLSO("NoZone");
                return _noZone.Value;
            }
        }

        /// <summary>
        /// Number of adornments currently attached to the item.
        /// </summary>
        public int NumAdornmentsAttached
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NumAdornmentsAttached"));
                return this.GetIntFromLSO("NumAdornmentsAttached");
            }
        }

        /// <summary>
        /// Cache of NumClasses
        /// </summary>
        private int? _numClasses;

        /// <summary>
        /// Number of classes that can use the item.
        /// </summary>
        public int NumClasses
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NumClasses"));
                if (!_numClasses.HasValue)
                    _numClasses = this.GetIntFromLSO("NumClasses");
                return _numClasses.Value;
            }
        }

        /// <summary>
        /// Number of effects on the item.
        /// </summary>
        public int NumEffects
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NumEffects"));
                return this.GetIntFromLSO("NumEffects");
            }
        }

        /// <summary>
        /// Number of effect-string lines on the item.
        /// </summary>
        public int NumEffectStrings
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NumEffectStrings"));
                return this.GetIntFromLSO("NumEffectStrings");
            }
        }

        /// <summary>
        /// Cache of NumEquipSlots
        /// </summary>
        private int? _numEquipSlots;

        /// <summary>
        /// Number of slots in which this item can be equipped.
        /// </summary>
        public int NumEquipSlots
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NumEquipSlots"));
                if (!_numEquipSlots.HasValue)
                    _numEquipSlots = this.GetIntFromLSO("NumEquipSlots");
                return _numEquipSlots.Value;
            }
        }

        /// <summary>
        /// Number of items this item creates (recipes).
        /// </summary>
        public int NumItemsCreated
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NumItemsCreated"));
                return this.GetIntFromLSO("NumItemsCreated");
            }
        }

        /// <summary>
        /// Number of items packaged inside this container/package.
        /// </summary>
        public int NumItemsPackaged
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NumItemsPackaged"));
                return this.GetIntFromLSO("NumItemsPackaged");
            }
        }

        /// <summary>
        /// Cache of NumModifiers
        /// </summary>
        private int? _numModifiers;

        /// <summary>
        /// Number of item modifiers.
        /// </summary>
        public int NumModifiers
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:NumModifiers"));
                if (!_numModifiers.HasValue)
                    _numModifiers = this.GetIntFromLSO("NumModifiers");
                return _numModifiers.Value;
            }
        }

        /// <summary>
        /// Returns the name of a quest this item offers, or empty if none.
        /// </summary>
        public string OffersQuest
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:OffersQuest"));
                return this.GetStringFromLSO("OffersQuest");
            }
        }

        /// <summary>
        /// Cache of Ornate
        /// </summary>
        private bool? _ornate;

        /// <summary>
        /// Returns TRUE if the item is ornate.
        /// </summary>
        public bool Ornate
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Ornate"));
                if (!_ornate.HasValue)
                    _ornate = this.GetBoolFromLSO("Ornate");
                return _ornate.Value;
            }
        }

        /// <summary>
        /// Returns the packaged item entry at the given index (1 to NumItemsPackaged).
        /// </summary>
        /// <param name="index">packaged-item index</param>
        /// <returns>PackagedItem</returns>
        public PackagedItem PackagedItem(int index)
        {
            Trace.WriteLine(String.Format("ItemInfo:PackagedItem({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new PackagedItem(this.GetMember("PackagedItem", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns MaxRange (alias).
        /// </summary>
        public int Range
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Range"));
                return this.GetIntFromLSO("Range");
            }
        }

        /// <summary>
        /// Item recast time (Activateable).
        /// </summary>
        public float RecastTime
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:RecastTime"));
                return this.GetFloatFromLSO("RecastTime");
            }
        }

        /// <summary>
        /// Item recovery time (Activateable).
        /// </summary>
        public float RecoveryTime
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:RecoveryTime"));
                return this.GetFloatFromLSO("RecoveryTime");
            }
        }

        /// <summary>
        /// Returns TRUE if the item is refined.
        /// </summary>
        public bool Refined
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Refined"));
                return this.GetBoolFromLSO("Refined");
            }
        }

        /// <summary>
        /// Returns TRUE if the item is reforged.
        /// </summary>
        public bool Reforged
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Reforged"));
                return this.GetBoolFromLSO("Reforged");
            }
        }

        /// <summary>
        /// Cache of RentStatusReduction
        /// </summary>
        private int? _rentStatusReduction;

        /// <summary>
        /// Rent status reduction (House item).
        /// </summary>
        public int RentStatusReduction
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:RentStatusReduction"));
                if (!_rentStatusReduction.HasValue)
                    _rentStatusReduction = this.GetIntFromLSO("RentStatusReduction");
                return _rentStatusReduction.Value;
            }
        }

        /// <summary>
        /// Returns the name of a quest this item is required by, or empty if none.
        /// </summary>
        public string RequiredByQuest
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:RequiredByQuest"));
                return this.GetStringFromLSO("RequiredByQuest");
            }
        }

        /// <summary>
        /// Returns TRUE if the item must be equipped to use.
        /// </summary>
        public bool RequiresEquip
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:RequiresEquip"));
                return this.GetBoolFromLSO("RequiresEquip");
            }
        }

        /// <summary>
        /// Cache of Satiation
        /// </summary>
        private string _satiation;

        /// <summary>
        /// Food/Drink satiation level (string).
        /// </summary>
        public string Satiation
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Satiation"));
                return _satiation ?? (_satiation = this.GetStringFromLSO("Satiation"));
            }
        }

        /// <summary>
        /// Cache of SerialNumber
        /// </summary>
        private long? _serialNumber;

        /// <summary>
        /// Item serial number.
        /// </summary>
        public long SerialNumber
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:SerialNumber"));
                if (!_serialNumber.HasValue)
                    _serialNumber = this.GetInt64FromLSO("SerialNumber");
                return _serialNumber.Value;
            }
        }

        /// <summary>
        /// Cache of SubType
        /// </summary>
        private string _subType;

        /// <summary>
        /// Item subtype (e.g. weapon subtype).
        /// </summary>
        public string SubType
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:SubType"));
                return _subType ?? (_subType = this.GetStringFromLSO("SubType"));
            }
        }

        /// <summary>
        /// Cache of Temporary
        /// </summary>
        private bool? _temporary;

        /// <summary>
        /// Returns TRUE if the item is temporary.
        /// </summary>
        public bool Temporary
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Temporary"));
                if (!_temporary.HasValue)
                    _temporary = this.GetBoolFromLSO("Temporary");
                return _temporary.Value;
            }
        }

        /// <summary>
        /// Cache of Tier
        /// </summary>
        private string _tier;

        /// <summary>
        /// The tier of the item (FABLED, LEGENDARY, TREASURED, MASTERCRAFTED, HANDCRAFTED, or UNCOMMON).
        /// </summary>
        public string Tier
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Tier"));
                return _tier ?? (_tier = this.GetStringFromLSO("Tier"));
            }
        }

        /// <summary>
        /// This will recreate the actual link used with in-game chat channels (used typically with eq2echo or eq2execute).
        /// </summary>
        public string ToLink
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:ToLink"));
                return this.GetStringFromLSO("ToLink");
            }
        }

        /// <summary>
        /// Trade-restricted-until date string, or empty if not restricted.
        /// </summary>
        public string TradeRestrictedDate
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:TradeRestrictedDate"));
                return this.GetStringFromLSO("TradeRestrictedDate");
            }
        }

        /// <summary>
        /// Cache of Type
        /// </summary>
        private string _type;

        /// <summary>
        /// Item type (Weapon, Armor, Shield, Container, Spell Scroll, Recipe Book, House Item, Food, Drink, or Activateable).
        /// </summary>
        public string Type
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Type"));
                return _type ?? (_type = this.GetStringFromLSO("Type"));
            }
        }

        /// <summary>
        /// Returns TRUE if the item is unlocked.
        /// </summary>
        public bool Unlocked
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:Unlocked"));
                return this.GetBoolFromLSO("Unlocked");
            }
        }

        /// <summary>
        /// Cache of WieldStyle
        /// </summary>
        private string _wieldStyle;

        /// <summary>
        /// Wield style (Dual Wield, Two-Handed, or One-Handed).
        /// </summary>
        public string WieldStyle
        {
            get
            {
                Trace.WriteLine(String.Format("ItemInfo:WieldStyle"));
                return _wieldStyle ?? (_wieldStyle = this.GetStringFromLSO("WieldStyle"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Attaches this adornment item to a target item by ID. The target must already be selected via the adornment-application flow.
        /// </summary>
        /// <param name="adornID">target item ID</param>
        /// <returns>call success</returns>
        public bool AttachAsAdornment(int adornID)
        {
            Trace.WriteLine(String.Format("ItemInfo:AttachAsAdornment({0})", adornID.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AttachAsAdornment", adornID.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Attaches this adornment item using an explicit slot/sub-slot pair (targetaddon flow).
        /// </summary>
        /// <param name="slot">slot</param>
        /// <param name="subSlot">sub-slot</param>
        /// <returns>call success</returns>
        public bool AttachAsAdornment(int slot, int subSlot)
        {
            Trace.WriteLine(String.Format("ItemInfo:AttachAsAdornment({0}, {1})",
                slot.ToString(CultureInfo.InvariantCulture), subSlot.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AttachAsAdornment",
                slot.ToString(CultureInfo.InvariantCulture), subSlot.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Prepares this adornment item for use by issuing the apply-addon command.
        /// </summary>
        /// <returns>call success</returns>
        public bool PrepAdornmentForUse()
        {
            Trace.WriteLine(String.Format("ItemInfo:PrepAdornmentForUse()"));
            return this.ExecuteMethod("PrepAdornmentForUse");
        }

        #endregion
    }
}
