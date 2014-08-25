using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Extensions;
using System;
using System.Collections.Generic;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This Data Type includes all of the data available to ISXEQ2 that can be gathered from the character Information structure. 
    /// </summary>
    public class Character : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy"></param>
        public Character(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns an ability based on ID
        /// </summary>
        /// <param name="id">ID</param>
        public Ability Ability(uint id)
        {
            Trace.WriteLine(String.Format("Character:Ability({0})", id.ToString(CultureInfo.InvariantCulture)));
            return new Ability(this.GetMember("Ability", "id", id.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Retrieves an ability based on name.
        /// </summary>
        /// <param name="name">name</param>
        public Ability Ability(string name)
        {
            Trace.WriteLine(String.Format("Character:Ability({0})", name));
            return new Ability(this.GetMember("Ability", name));
        }

        /// <summary>
        /// Agility
        /// </summary>
        public int Agility
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Agility"));
                return this.GetIntFromLSO("Agility");
            }
        }

        /// <summary>
        /// Achievement Point Experience
        /// </summary>
        public float APExp
        {
            get
            {
                Trace.WriteLine(String.Format("Character:APExp"));
                return this.GetFloatFromLSO("APExp");
            }
        }

        /// <summary>
        /// Arcane Affliction Counter
        /// </summary>
        public int Arcane
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Arcane"));
                return this.GetIntFromLSO("Arcane");
            }
        }

        /// <summary>
        /// Arcane Resist
        /// </summary>
        public int ArcaneResist
        {
            get
            {
                Trace.WriteLine(String.Format("Character:ArcaneResist"));
                return this.GetIntFromLSO("ArcaneResist");
            }
        }

        /// <summary>
        /// Arcane Resist Percentage
        /// </summary>
        public float ArcaneResistPct
        {
            get
            {
                Trace.WriteLine(String.Format("Character:ArcaneResistPct"));
                return this.GetFloatFromLSO("ArcaneResistPct");
            }
        }

        /// <summary>
        /// Cache of Archetype
        /// </summary>
        private string _archetype;

        /// <summary>
        /// Archetype (fighter, priest, scout, mage)
        /// </summary>
        public string Archetype
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Archetype"));
                return _archetype ?? (_archetype = this.GetStringFromLSO("Archetype"));
            }
        }

        /// <summary>
        /// Returns TRUE if at the Character Select Screen. Only works
        /// after logging all the way in once.
        /// </summary>
        public bool AtCharSelect
        {
            get
            {
                Trace.WriteLine(String.Format("Character:AtCharSelect"));
                return this.GetBoolFromLSO("AtCharSelect");
            }
        }

        /// <summary>
        /// Returns TRUE if auto attack is on.
        /// </summary>
        public bool AutoAttackOn
        {
            get
            {
                Trace.WriteLine(String.Format("Character:AutoAttackOn"));
                return this.GetBoolFromLSO("AutoAttackOn");
            }
        }

        /// <summary>
        /// Actual bank slots free and bank container slots free 
        /// </summary>
        public int BankSlotsFree
        {
            get
            {
                Trace.WriteLine(String.Format("Character:BankSlotsFree"));
                return this.GetIntFromLSO("BankSlotsFree");
            }
        }

        /// <summary>
        /// Cache of BaseAgility
        /// </summary>
        private int? _baseAgility;

        /// <summary>
        /// Base Agility
        /// </summary>
        public int BaseAgility
        {
            get
            {
                Trace.WriteLine(String.Format("Character:BaseAgility"));
                if(!_baseAgility.HasValue)
                    _baseAgility = this.GetIntFromLSO("BaseAgility");
                return _baseAgility.Value;
            }
        }

        /// <summary>
        /// Cache of BaseIntelligence
        /// </summary>
        private int? _baseIntelligence;

        /// <summary>
        /// Base Intelligence
        /// </summary>
        public int BaseIntelligence
        {
            get
            {
                Trace.WriteLine(String.Format("Character:BaseIntelligence"));
                if(!_baseIntelligence.HasValue)
                    _baseIntelligence = this.GetIntFromLSO("BaseIntelligence");
                return _baseIntelligence.Value;
            }
        }

        /// <summary>
        /// Cache of BaseStamina
        /// </summary>
        private int? _baseStamina;

        /// <summary>
        /// Base Stamina
        /// </summary>
        public int BaseStamina
        {
            get
            {
                Trace.WriteLine(String.Format("Character:BaseStamina"));
                if(!_baseStamina.HasValue)
                    _baseStamina = this.GetIntFromLSO("BaseStamina");
                return _baseStamina.Value;
            }
        }

        /// <summary>
        /// Cache of BaseStrength
        /// </summary>
        private int? _baseStrength;

        /// <summary>
        /// Base Strength
        /// </summary>
        public int BaseStrength
        {
            get
            {
                Trace.WriteLine(String.Format("Character:BaseStrength"));
                if(!_baseStrength.HasValue)
                    _baseStrength = this.GetIntFromLSO("BaseStrength");
                return _baseStrength.Value;
            }
        }

        /// <summary>
        /// Cache of BaseWisdom
        /// </summary>
        private int? _baseWisdom;

        /// <summary>
        /// Base Wisdom
        /// </summary>
        public int BaseWisdom
        {
            get
            {
                Trace.WriteLine(String.Format("Character:BaseWisdom"));
                if(!_baseWisdom.HasValue)
                    _baseWisdom = this.GetIntFromLSO("BaseWisdom");
                return _baseWisdom.Value;
            }
        }

        /// TODO: Find out what Me.Breath is.
        /// <summary>
        /// Breath
        /// </summary>
        public float Breath
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Breath"));
                return this.GetFloatFromLSO("Breath");
            }
        }

        /// <summary>
        /// Returns TRUE if casting a spell.
        /// </summary>
        public bool CastingSpell
        {
            get
            {
                Trace.WriteLine(String.Format("Character:CastingSpell"));
                return this.GetBoolFromLSO("CastingSpell");
            }
        }

        /// <summary>
        /// Checks between the character and the given point.
        /// </summary>
        /// <param name="toX">X</param>
        /// <param name="toY">Y</param>
        /// <param name="toZ">Z</param>
        public bool CheckCollision(float toX, float toY, float toZ)
        {
            Trace.WriteLine(String.Format("Character:CheckCollision({0}, {1}, {2})", toX.ToString(CultureInfo.InvariantCulture),
                toY.ToString(CultureInfo.InvariantCulture), toZ.ToString(CultureInfo.InvariantCulture)));
            return this.GetBoolFromLSO("CheckCollision", toX.ToString(CultureInfo.InvariantCulture),
                toY.ToString(CultureInfo.InvariantCulture), toZ.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Cache of Class
        /// </summary>
        private string _class;

        /// <summary>
        /// Class (warrior, brawler, crusader, sorcerer, enchanter, summoner, druid,
        /// cleric, shaman, shaper, bard, predator, rogue, animalist)
        /// </summary>
        public string Class
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Class"));
                return _class ?? (_class = this.GetStringFromLSO("Class"));
            }
        }

        /// <summary>
        /// Returns TRUE if Combat Experience is enabled.
        /// </summary>
        public bool CombatExpEnabled
        {
            get
            {
                Trace.WriteLine(String.Format("Character:CombatExpEnabled"));
                return this.GetBoolFromLSO("CombatExpEnabled");
            }
        }

        /// <summary>
        /// Copper
        /// </summary>
        public int Copper
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Copper"));
                return this.GetIntFromLSO("Copper");
            }
        }

        /// <summary>
        /// The number of effects. (Beneficial, Detrimental, All)
        /// </summary>
        /// <param name="type">effect type</param>
        public int CountEffects(EffectType type = EffectType.All)
        {
            Trace.WriteLine(String.Format("Character:CountEffects({0})", type));
            switch (type)
            {
                case EffectType.Beneficial:
                case EffectType.Detrimental:
                    return this.GetIntFromLSO("CountEffects", type.ToString());
                default:
                    return this.GetIntFromLSO("CountEffects");
            }
        }

        /// <summary>
        /// The number of maintained effects.
        /// </summary>
        public int CountMaintained
        {
            get
            {
                Trace.WriteLine(String.Format("Character:CountMaintained"));
                return this.GetIntFromLSO("CountMaintained");
            }
        }

        /// <summary>
        /// Cursed Counter
        /// </summary>
        public bool Cursed
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Cursed"));
                return GetMember<bool>("Cursed");
            }
        }

        /// <summary>
        /// This member will return an 'actor' object of whatever is currently underneath your mouse cursor.
        /// </summary>
        public Actor CursorActor
        {
            get
            {
                Trace.WriteLine(String.Format("Character:CursorActor"));
                return new Actor(this.GetMember("CursorActor"));
            }           
        }

        /// <summary>
        /// Retrieves the item at the specified index of the CustomInventoryArray
        /// </summary>
        /// <param name="index">index</param>
        public Item CustomInventory(int index)
        {
            Trace.WriteLine(String.Format("Character:CustomInventory({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Item(this.GetMember("CustomInventory", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Retrieves the item based on the search arguments from the CustomInventoryArray
        /// </summary>
        /// <param name="args">search arguments</param>
        public Item CustomInventory(params string[] args)
        {
            Trace.WriteLine(String.Format("Character:CustomInventory({0})", String.Join(", ", args)));
            return new Item(this.GetMember("CustomInventory", args));
        }

        /// <summary>
        /// Returns the size of the CustomInventoryArray
        /// </summary>
        public int CustomInventoryArraySize
        {
            get
            {
                Trace.WriteLine(String.Format("Character:CustomInventoryArraySize"));
                return this.GetIntFromLSO("CustomInventoryArraySize");
            }
        }

        /// <summary>
        /// Dissipation
        /// </summary>
        public int Dissipation
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Dissipation"));
                return this.GetIntFromLSO("Dissipation");
            }
        }

        /// <summary>
        /// Dissonance
        /// </summary>
        public int Dissonance
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Dissonance"));
                return this.GetIntFromLSO("Dissonance");
            }
        }

        /// <summary>
        /// Dissonance Remaining
        /// </summary>
        public int DissonanceRemaining
        {
            get
            {
                Trace.WriteLine(String.Format("Character:DissonanceRemaining"));
                return this.GetIntFromLSO("DissonanceRemaining");
            }
        }

        /// <summary>
        /// Retrieves the effect of the given type at the specified index. (Beneficial, Detrimental, All)
        /// </summary>
        /// <param name="type">effect type</param>
        /// <param name="index">index</param>
        public Effect Effect(int index, EffectType type = EffectType.All)
        {
            Trace.WriteLine(String.Format("Character:CountEffects({0}, {1})", type, index.ToString(CultureInfo.InvariantCulture)));
            switch (type)
            {
                case EffectType.Beneficial:
                case EffectType.Detrimental:
                    return new Effect(this.GetMember("Effect", type.ToString(), index.ToString(CultureInfo.InvariantCulture)));
                default:
                    return new Effect(this.GetMember("Effect", index.ToString(CultureInfo.InvariantCulture)));
            }
        }

        /// <summary>
        /// Retrieves the effect of the given type at the specified index. (Beneficial, Detrimental, All(
        /// </summary>
        /// <param name="type">type</param>
        /// <param name="name">name</param>
        public Effect Effect(string name, EffectType type = EffectType.All)
        {
            Trace.WriteLine(String.Format("Character:CountEffects({0}, {1})", type, name));
            switch (type)
            {
                case EffectType.Beneficial:
                case EffectType.Detrimental:
                    return new Effect(this.GetMember("Effect", type.ToString(), name));
                default:
                    return new Effect(this.GetMember("Effect", name));
            }
        }

        /// <summary>
        /// Effective Level (Mentored or Chrono)
        /// </summary>
        public int EffectiveLevel
        {
            get
            {
                Trace.WriteLine(String.Format("Character:EffectiveLevel"));
                return this.GetIntFromLSO("EffectiveLevel");
            }
        }

        /// <summary>
        /// Elemental Affliction Counter
        /// </summary>
        public int Elemental
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Elemental"));
                return GetMember<int>("Elemental");
            }
        }

        /// <summary>
        /// Elemental Resist
        /// </summary>
        public int ElementalResist
        {
            get
            {
                Trace.WriteLine(String.Format("Character:ElementalResist"));
                return GetMember<int>("ElementalResist");
            }
        }

        /// <summary>
        /// Elemental Resist Percent
        /// </summary>
        public int ElementalResistPct
        {
            get
            {
                Trace.WriteLine(String.Format("Character:ElementalResistPct"));
                return GetMember<int>("ElementalResistPct");
            }
        }

        /// <summary>
        /// Retrieves an equipped item that matches the search criteria
        /// </summary>
        /// <param name="args">search criteria</param>
        public Item Equipment(params string[] args)
        {
            Trace.WriteLine(String.Format("Character:Equipment({0})", String.Join(", ", args)));
            return new Item(this.GetMember("Equipment", args));
        }

        /// <summary>
        /// Experience
        /// </summary>
        public int Exp
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Exp"));
                return this.GetIntFromLSO("Exp");
            }
        }

        /// TODO: Find out why Me.ExpDebt returns NULL
        /// <summary>
        /// Experience Debt
        /// </summary>
        public float ExpDebt
        {
            get
            {
                Trace.WriteLine(String.Format("Character:ExpDebt"));
                return this.GetFloatFromLSO("ExpDebt");
            }
        }

        /// <summary>
        /// Experience Points
        /// </summary>
        public float ExpPoints
        {
            get
            {
                Trace.WriteLine(String.Format("Character:ExpPoints"));
                return this.GetFloatFromLSO("ExpPoints");
            }
        }

        /// <summary>
        /// Experience Points Needed to Reach the Next Level
        /// </summary>
        public float ExpPointsToLevel
        {
            get
            {
                Trace.WriteLine(String.Format("Character:ExpPointsToLevel"));
                return this.GetFloatFromLSO("ExpPointsToLevel");
            }
        }

        /// <summary>
        /// Cache of Gender
        /// </summary>
        private string _gender;

        /// <summary>
        /// Gender
        /// </summary>
        public string Gender
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Gender"));
                return _gender ?? (_gender = this.GetStringFromLSO("Gender"));
            }
        }

        /// <summary>
        /// Returns an IEnumerable of all abilities.
        /// </summary>
        public IEnumerable<Ability> GetAbilities()
        {
            Trace.WriteLine(String.Format("Character:GetAbilities()"));
            return Util.GetListFromMember<Ability>(this, "GetAbilities", "ability");
        }

        /// <summary>
        /// Returns an IEnumerable of all equipped items.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Item> GetEquipment()
        {
            Trace.WriteLine(String.Format("Character:GetEquipment()"));
            return Util.GetListFromMember<Item>(this, "GetEquipment", "item");
        }

        /// TODO: Research Me.GetGameData
        /// <summary>
        /// Returns the EQ2UIElement at the specified path.
        /// </summary>
        /// <param name="path">path</param>
        public EQ2UIElement GetGameData(string path)
        {
            Trace.WriteLine(String.Format("Character:GetGameData({0})", path));
            return new EQ2UIElement(this.GetMember("GetGameData", path));
        }

        /// <summary>
        /// Returns an IEnumerable of all items (including bank) NOT EQUIPPED.
        /// </summary>
        public IEnumerable<Item> GetInventory()
        {
            Trace.WriteLine(String.Format("Character:GetInventory()"));
            return Util.GetListFromMember<Item>(this, "GetInventory", "item");
        }

        /// <summary>
        /// Returns an IEnumerable of all items (excluding bank) NOT EQUIPPED
        /// </summary>
        public IEnumerable<Item> GetInventoryAtHand()
        {
            Trace.WriteLine(String.Format("Character:GetInventory()"));
            return Util.GetListFromMember<Item>(this, "GetInventory", "item");
        }

        /// <summary>
        /// Gold
        /// </summary>
        public int Gold
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Gold"));
                return this.GetIntFromLSO("Gold");
            }
        }

        /// <summary>
        /// Returns the group member at the specified index between 1 and 5.
        /// The player is at index 0. Me.Group(0) is the same as Me.ToActor
        /// </summary>
        /// <param name="index">index</param>
        public GroupMember Group(int index)
        {
            Trace.WriteLine(String.Format("Character:Group({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new GroupMember(this.GetMember("Group", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns the group member matching the name provided.
        /// </summary>
        /// <param name="name">name</param>
        public GroupMember Group(string name)
        {
            Trace.WriteLine(String.Format("Character:Group({0})", name));
            return new GroupMember(this.GetMember("Group", name));
        }

        /// <summary>
        /// Returns the number of members in the group from 1 to 6.
        /// </summary>
        public int GroupCount
        {
            get
            {
                Trace.WriteLine(String.Format("Character:GroupCount"));
                return this.GetIntFromLSO("GroupCount");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is Grouped
        /// </summary>
        public bool Grouped
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Grouped"));
                return this.GetBoolFromLSO("Grouped");
            }
        }

        /// <summary>
        /// Returns TRUE if guild privacy is on
        /// </summary>
        public bool GuildPrivacyOn
        {
            get
            {
                Trace.WriteLine(String.Format("Character:GuildPrivacyOn"));
                return GetMember<bool>("GuildPrivacyOn");
            }
        }

        /// <summary>
        /// Heading. Returns heading as degrees (think compass), to a precision of 2 decimal places.
        /// </summary>
        public float Heading
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Heading"));
                return this.GetFloatFromLSO("Heading");
            }
        }

        /// <summary>
        /// Returns the heading you would need to face to reach the target point. Better known as bearing. 
        /// </summary>
        /// <param name="toX">X</param>
        /// <param name="toY">Y</param>
        /// <param name="toZ">Z</param>
        public float HeadingTo(float toX, float toY, float toZ)
        {
            Trace.WriteLine(String.Format("Character:HeadingTo({0}, {1}, {2})", toX.ToString(CultureInfo.InvariantCulture),
                toY.ToString(CultureInfo.InvariantCulture), toZ.ToString(CultureInfo.InvariantCulture)));
            return this.GetFloatFromLSO("HeadingTo", toX.ToString(CultureInfo.InvariantCulture),
                toY.ToString(CultureInfo.InvariantCulture), toZ.ToString(CultureInfo.InvariantCulture));
        }


        /// <summary>
        /// Returns health as a percentage.
        /// </summary>
        public int Health
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Health"));
                return GetMember<int>("Health");
            }
        }

        /// <summary>
        /// Health Regeneration
        /// </summary>
        public int HealthRegen
        {
            get
            {
                Trace.WriteLine(String.Format("Character:HealthRegen"));
                return this.GetIntFromLSO("HealthRegen");
            }
        }

        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            get
            {
                Trace.WriteLine(String.Format("Character:ID"));
                return this.GetIntFromLSO("ID");
            }
        }

        /// <summary>
        /// Returns TRUE if user is "ignoring all" as toggled with the 'eq2ignore all' command.
        /// </summary>
        public bool IgnoringAll
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IgnoringAll"));
                return this.GetBoolFromLSO("IgnoringAll");
            }
        }

        /// <summary>
        /// Returns TRUE if the camera is in First Person
        /// </summary>
        public bool InFirstPersonView
        {
            get
            {
                Trace.WriteLine(String.Format("Character:In1stPersonView"));
                return this.GetBoolFromLSO("In1stPersonView");
            }
        }

        /// <summary>
        /// Returns TRUE if the camera is in Third Person
        /// </summary>
        public bool InThirdPersonView
        {
            get
            {
                Trace.WriteLine(String.Format("Character:In3rdPersonView"));
                return this.GetBoolFromLSO("In3rdPersonView");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is in combat
        /// </summary>
        public bool InCombat
        {
            get
            {
                Trace.WriteLine(String.Format("Character:InCombat"));
                return this.GetBoolFromLSO("InCombat");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is in the game world. Only
        /// works if you have logged in completely once.
        /// </summary>
        public bool InGameWorld
        {
            get
            {
                Trace.WriteLine(String.Format("Character:InGameWorld"));
                return this.GetBoolFromLSO("InGameWorld");
            }
        }

        /// <summary>
        /// Returns TRUE if Initializing Effects on the character.
        /// </summary>
        public bool InitializingEffects
        {
            get
            {
                Trace.WriteLine(String.Format("Character:InitializingEffects"));
                return this.GetBoolFromLSO("InitializingEffects");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is in a raid.
        /// </summary>
        public bool InRaid
        {
            get
            {
                Trace.WriteLine(String.Format("Character:InRaid"));
                return this.GetBoolFromLSO("InRaid");
            }
        }

        /// <summary>
        /// Intelligence
        /// </summary>
        public int Intelligence
        {
            get
            {
                Trace.WriteLine(String.Format("Character:InRaid"));
                return this.GetIntFromLSO("Intelligence");
            }
        }

        /// <summary>
        /// Retrieves the inventory item based on the search criteria
        /// </summary>
        /// <param name="args">criteria</param>
        public Item Inventory(params string[] args)
        {
            Trace.WriteLine(String.Format("Character:Inventory({0})", String.Join(", ", args)));
            return new Item(this.GetMember("Inventory", args));
        }

        /// <summary>
        /// Actual inventory slots free and inventory container slots free 
        /// </summary>
        public int InventorySlotsFree
        {
            get
            {
                Trace.WriteLine(String.Format("Character:InventorySlotsFree"));
                return this.GetIntFromLSO("InventorySlotsFree");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is in the water
        /// </summary>
        public bool InWater
        {
            get
            {
                Trace.WriteLine(String.Format("Character:InWater"));
                return this.GetBoolFromLSO("InWater");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is afflicted by arcane, noxious, etc.
        /// </summary>
        public bool IsAfflicted
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsAfflicted"));
                return this.GetBoolFromLSO("IsAfflicted");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is flagged AFK
        /// </summary>
        public bool IsAFK
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsAfflicted"));
                return this.GetBoolFromLSO("IsAFK");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is flagged anonymous
        /// </summary>
        public bool IsAnonymous
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsAnonymous"));
                return this.GetBoolFromLSO("IsAnonymous");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is camping
        /// </summary>
        public bool IsCamping
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsCamping"));
                return this.GetBoolFromLSO("IsCamping");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is declining duel invites
        /// </summary>
        public bool IsDecliningDuelInvites
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsDecliningDuelInvites"));
                return this.GetBoolFromLSO("IsDecliningDuelInvites");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is declining group invites
        /// </summary>
        public bool IsDecliningGroupInvites
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsDecliningGroupInvites"));
                return this.GetBoolFromLSO("IsDecliningGroupInvites");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is declining guild invites
        /// </summary>
        public bool IsDecliningGuildInvites
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsDecliningGuildInvites"));
                return this.GetBoolFromLSO("IsDecliningGuildInvites");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is declining raid invites
        /// </summary>
        public bool IsDecliningRaidInvites
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsDecliningRaidInvites"));
                return this.GetBoolFromLSO("IsDecliningRaidInvites");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is declining trade invites
        /// </summary>
        public bool IsDecliningTradeInvites
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsDecliningTradeInvites"));
                return this.GetBoolFromLSO("IsDecliningTradeInvites");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is on a hate list
        /// </summary>
        public bool IsHated
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsHated"));
                return this.GetBoolFromLSO("IsHated");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is engaged in PvP combat
        /// </summary>
        public bool IsInPVP
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsInPvP"));
                return this.GetBoolFromLSO("IsInPVP");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is looking for group
        /// </summary>
        public bool IsLFG
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsLFG"));
                return this.GetBoolFromLSO("IsLFG");
            }
        }


        /// <summary>
        /// Returns TRUE if the character is looking for work
        /// </summary>
        public bool IsLFW
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsLFW"));
                return this.GetBoolFromLSO("IsLFW");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is moving
        /// </summary>
        public bool IsMoving
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsMoving"));
                return this.GetBoolFromLSO("IsMoving");
            }
        }


        /// <summary>
        /// Returns TRUE if the character is roleplaying
        /// </summary>
        public bool IsRolePlaying
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsRoleplaying"));
                return this.GetBoolFromLSO("IsRolePlaying");
            }
        }

        /// <summary>
        /// Returns TRUE if the character is sitting
        /// </summary>
        public bool IsSitting
        {
            get
            {
                Trace.WriteLine(String.Format("Character:IsSitting"));
                return this.GetBoolFromLSO("IsSitting");
            }
        }

        /// <summary>
        /// Cache of Level
        /// </summary>
        private int? _level;

        /// <summary>
        /// Level
        /// </summary>
        public int Level
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Level"));
                if(!_level.HasValue)
                    _level = this.GetIntFromLSO("Level");
                return _level.Value;
            }
        }

        /// <summary>
        /// Returns the maintained effect at the index
        /// </summary>
        /// <param name="index">index</param>
        public Maintained Maintained(int index)
        {
            Trace.WriteLine(String.Format("Character:Maintained({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Maintained(this.GetMember("Maintained", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns the maintained effect by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Maintained Maintained(string name)
        {
            Trace.WriteLine(String.Format("Character:Maintained({0})", name));
            return new Maintained(this.GetMember("Maintained", name));
        }

        /// <summary>
        /// Maximum Achievement Points
        /// </summary>
        public int MaxAPs
        {
            get
            {
                Trace.WriteLine(String.Format("Character:MaxAPs"));
                return this.GetIntFromLSO("MaxAPs");
            }
        }

        /// <summary>
        /// Cache of MaxConc
        /// </summary>
        private int? _maxConc;

        /// <summary>
        /// Max Concentration
        /// </summary>
        public int MaxConc
        {
            get
            {
                Trace.WriteLine(String.Format("Character:MaxConc"));
                if(!_maxConc.HasValue)
                    _maxConc = this.GetIntFromLSO("MaxConc");
                return _maxConc.Value;
            }
        }

        /// <summary>
        /// Cache of MaxDissonance
        /// </summary>
        private int? _maxDissonance;

        /// <summary>
        /// Max Dissonance
        /// </summary>
        public int MaxDissonance
        {
            get
            {
                Trace.WriteLine(String.Format("Character:MaxDissonance"));
                if (!_maxDissonance.HasValue)
                    _maxDissonance = this.GetIntFromLSO("MaxDissonance");
                return _maxDissonance.Value;
            }
        }

        /// <summary>
        /// Max Health
        /// </summary>
        public int MaxHealth
        {
            get
            {
                Trace.WriteLine(String.Format("Character:MaxHealth"));
                return this.GetIntFromLSO("MaxHealth");
            }
        }

        /// <summary>
        /// Max Power
        /// </summary>
        public int MaxPower
        {
            get
            {
                Trace.WriteLine(String.Format("Character:MaxPower"));
                return this.GetIntFromLSO("MaxPower");
            }
        }

        /// <summary>
        /// Cache of MentoringXPAdj
        /// </summary>
        private float? _mentoringXPAdj;

        /// <summary>
        /// Mentoring XP Adjustment
        /// </summary>
        public float MentoringXPAdj
        {
            get
            {
                Trace.WriteLine(String.Format("Character:MentoringXPAdj"));
                if(!_mentoringXPAdj.HasValue)
                    _mentoringXPAdj = this.GetFloatFromLSO("MentoringXPAdj");
                return _mentoringXPAdj.Value;
            }
        }

        /// <summary>
        /// Returns the object the character is capable of selling at the specified index. (1 to NumItemsICanSell)
        /// </summary>
        /// <param name="index">index</param>

        public Merchandise Merchandise(int index)
        {
            Trace.WriteLine(String.Format("Character:Merchandise({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Merchandise(this.GetMember("Merchandise", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns the object the character is capable of selling based on name.
        /// </summary>
        /// <param name="name">name</param>
        public Merchandise Merchandise(string name)
        {
            Trace.WriteLine(String.Format("Character:Merchandise({0})", name));
            return new Merchandise(this.GetMember("Merchandise", name));
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Returns an integer which is the ID of the first available container in the inventory that has an open slot 
        /// </summary>
        public int NextFreeInvContainer
        {
            get
            {
                Trace.WriteLine(String.Format("Character:NextFreeInvContainer"));
                return this.GetIntFromLSO("NextFreeInvContainer");
            }
        }

        /// <summary>
        /// Noxious Affliction Counter
        /// </summary>
        public int Noxious
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Noxious"));
                return this.GetIntFromLSO("Noxious");
            }
        }

        /// <summary>
        /// Noxious Resist
        /// </summary>
        public int NoxiousResist
        {
            get
            {
                Trace.WriteLine(String.Format("Character:NoxiousResist"));
                return this.GetIntFromLSO("NoxiousResist");
            }
        }

        /// <summary>
        /// Noxious Resist Percent
        /// </summary>
        public float NoxiousResistPct
        {
            get
            {
                Trace.WriteLine(String.Format("Character:NoxiousResistPct"));
                return this.GetFloatFromLSO("NoxiousResistPct");
            }
        }

        /// <summary>
        /// Returns the number of abilities your character currently has in his/her knowledge book. 
        /// </summary>
        public int NumAbilities
        {
            get
            {
                Trace.WriteLine(String.Format("Character:NumAbilities"));
                return this.GetIntFromLSO("NumAbilities");
            }
        }

        /// <summary>
        /// The number of effects. (Beneficial, Detrimental, All)
        /// </summary>
        /// <param name="type">type</param>
        public int NumEffects(EffectType type = EffectType.All)
        {
            Trace.WriteLine(String.Format("Character:NumEffects({0})", type));
            switch (type)
            {
                case EffectType.Beneficial:
                case EffectType.Detrimental:
                    return this.GetIntFromLSO("NumEffects", type.ToString());
                default:
                    return this.GetIntFromLSO("NumEffects");
            }
        }

        /// <summary>
        /// Returns the number of items that the character is capable of selling 
        /// (ie, the number of items in the inventory minus the number of NO VALUE and NO TRADE items.) 
        /// </summary>
        public int NumItemsICanSell
        {
            get
            {
                Trace.WriteLine(String.Format("Character:NumItemsICanSell"));
                return this.GetIntFromLSO("NumItemsICanSell");
            }
        }

        /// <summary>
        /// Returns the number of recipes your character currently has in his/her recipe book. 
        /// </summary>
        public int NumRecipes
        {
            get
            {
                Trace.WriteLine(String.Format("Character:NumRecipes"));
                return this.GetIntFromLSO("NumRecipes");
            }
        }

        /// <summary>
        /// Returns the number of vending containers
        /// </summary>
        public int NumVendingContainers
        {
            get
            {
                Trace.WriteLine(String.Format("Character:NumVendingContainers"));
                return this.GetIntFromLSO("NumVendingContainers");
            }
        }

        /// <summary>
        /// Returns the number of vending containers
        /// </summary>
        public int NumVendors
        {
            get
            {
                Trace.WriteLine(String.Format("Character:NumVendors"));
                return this.GetIntFromLSO("NumVendors");
            }
        }

        /// <summary>
        /// Returns the character's pet, if any.
        /// </summary>
        public Actor Pet
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Pet"));
                return new Actor(this.GetMember("Pet"));
            }
        }

        /// <summary>
        /// Platinum
        /// </summary>
        public int Platinum
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Platinum"));
                return this.GetIntFromLSO("Platinum");
            }
        }

        /// <summary>
        /// Power
        /// </summary>
        public int Power
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Power"));
                return this.GetIntFromLSO("Power");
            }
        }

        /// <summary>
        /// Power Regen
        /// </summary>
        public int PowerRegen
        {
            get
            {
                Trace.WriteLine(String.Format("Character:PowerRegen"));
                return this.GetIntFromLSO("PowerRegen");
            }
        }

        /// <summary>
        /// Cache of Race
        /// </summary>
        private string _race;

        /// <summary>
        /// Race
        /// </summary>
        public string Race
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Race"));
                return _race ?? (_race = this.GetStringFromLSO("Race"));
            }
        }

        /// <summary>
        /// Number of people in the raid. If you are not in a raid, this returns 0.
        /// </summary>
        public int Raid()
        {
            Trace.WriteLine(String.Format("Character:Raid()"));
            return this.GetIntFromLSO("Raid");
        }

        /// <summary>
        /// Returns the raid member by Actor ID or Raid Member number
        /// </summary>
        /// <param name="number">ID or member number</param>
        public GroupMember Raid(int number)
        {
            Trace.WriteLine(String.Format("Character:Raid({0})", number.ToString(CultureInfo.InvariantCulture)));
            return number < 25 ? new GroupMember(this.GetMember("Raid", number.ToString(CultureInfo.InvariantCulture))) 
                : new GroupMember(this.GetMember("Raid", "id", number.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns the raid member by group and member numbers
        /// </summary>
        /// <param name="group">group number</param>
        /// <param name="member">member number</param>
        public GroupMember Raid(int group, int member)
        {
            Trace.WriteLine(String.Format("Character:Raid({0}, {1})", group.ToString(CultureInfo.InvariantCulture),
                member.ToString(CultureInfo.InvariantCulture)));
            return new GroupMember(this.GetMember("Raid", group.ToString(CultureInfo.InvariantCulture),
                member.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Number of people in the raid. If you are not in a raid, this returns 0.
        /// </summary>
        public int RaidCount
        {
            get
            {
                Trace.WriteLine(String.Format("Character:RaidCount"));
                return this.GetIntFromLSO("RaidCount");
            }
        }

        /// <summary>
        /// Returns the character's raid group number
        /// </summary>
        public int RaidGroupNum
        {
            get
            {
                Trace.WriteLine(String.Format("Character:RaidGroupNum"));
                return this.GetIntFromLSO("RaidGroupNum");
            }
        }

        /// <summary>
        /// Returns TRUE if the ranged auto attack is on
        /// </summary>
        public bool RangedAutoAttackOn
        {
            get
            {
                Trace.WriteLine(String.Format("Character:RangedAutoAttackOn"));
                return this.GetBoolFromLSO("RangedAutoAttackOn");
            }
        }

        /// <summary>
        /// Returns the recipe at the specified index
        /// </summary>
        /// <param name="index">index</param>
        public Recipe Recipe(int index)
        {
            Trace.WriteLine(String.Format("Character:Recipe({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Recipe(this.GetMember("Recipe", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns the recipe with the ID provided
        /// </summary>
        /// <param name="id">ID</param>
        public Recipe Recipe(uint id)
        {
            Trace.WriteLine(String.Format("Character:Recipe({0})", id.ToString(CultureInfo.InvariantCulture)));
            return new Recipe(this.GetMember("Recipe", "id", id.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns the recipe with the name provided
        /// </summary>
        /// <param name="name"></param>
        public Recipe Recipe(string name)
        {
            Trace.WriteLine(String.Format("Character:Recipe({0})", name));
            return new Recipe(this.GetMember("Recipe", name));
        }

        /// <summary>
        /// Returns the number of shared bank slots free
        /// </summary>
        public int SharedBankSlotsFree
        {
            get
            {
                Trace.WriteLine(String.Format("Character:SharedBankSlotsFree)"));
                return this.GetIntFromLSO("SharedBankSlotsFree");
            }
        }

        /// <summary>
        /// Silver
        /// </summary>
        public int Silver
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Silver)"));
                return this.GetIntFromLSO("Silver");
            }
        }

        /// <summary>
        /// Stamina
        /// </summary>
        public int Stamina
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Stamina)"));
                return this.GetIntFromLSO("Stamina");
            }
        }

        /// <summary>
        /// Strength
        /// </summary>
        public int Strength
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Strength)"));
                return this.GetIntFromLSO("Strength");
            }
        }

        /// <summary>
        /// Cache of SubClass
        /// </summary>
        private string _subClass;

        /// <summary>
        /// Sub Class. What we normally think of as Class. (Guardian, Mystic, etc...)
        /// </summary>
        public string SubClass
        {
            get
            {
                Trace.WriteLine(String.Format("Character:SubClass)"));
                return _subClass ?? (_subClass = this.GetStringFromLSO("SubClass"));
            }
        }

        /// <summary>
        /// Returns TRUE if you have Line of Sight to your current target.
        /// </summary>
        public bool TargetLOS
        {
            get
            {
                Trace.WriteLine(String.Format("Character:TargetLOS"));
                return this.GetBoolFromLSO("TargetLOS");
            }
        }

        /// <summary>
        /// Returns the time until camp out. Starts at 20, and updates every 5 seconds.
        /// </summary>
        public float TimeToCampOut
        {
            get
            {
                Trace.WriteLine(String.Format("Character:TimeToCampout"));
                return this.GetFloatFromLSO("TimeToCampOut");
            }
        }


        /// <summary>
        /// Returns as Actor
        /// </summary>
        public Actor ToActor
        {
            get
            {
                Trace.WriteLine(String.Format("Character:ToActor"));
                return new Actor(this.GetMember("ToActor"));
            }
            
        }

        /// <summary>
        /// Total Earned APs
        /// </summary>
        public int TotalEarnedAPs
        {
            get
            {
                Trace.WriteLine(String.Format("Character:TotalEarnedAPs"));
                return this.GetIntFromLSO("TotalEarnedAPs");
            }
        }

        /// <summary>
        /// Total slot capacity of all the characters vending containers combined. 
        /// </summary>
        public int TotalVendingCapacity
        {
            get
            {
                Trace.WriteLine(String.Format("Character:TotalVendingCapacity"));
                return this.GetIntFromLSO("TotalVendingCapacity");
            }
        }


        /// <summary>
        /// Trauma Affliction Counter
        /// </summary>
        public int Trauma
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Trauma"));
                return this.GetIntFromLSO("Trauma");
            }
        }

        /// <summary>
        /// Cache of TSArchetype
        /// </summary>
        private string _tSArchetype;

        /// <summary>
        /// Trade Skill Archetype (artisan, etc.)
        /// </summary>
        public string TSArchetype
        {
            get
            {
                Trace.WriteLine(String.Format("Character:TSArcheype"));
                return _tSArchetype ?? (_tSArchetype = this.GetStringFromLSO("TSArchetype"));
            }
        }

        /// <summary>
        /// Cache of TSClass
        /// </summary>
        private string _tSClass;

        /// <summary>
        /// Trade Skill Class (outfitter, etc.)
        /// </summary>
        public string TSClass
        {
            get
            {
                Trace.WriteLine(String.Format("Character:TSClass"));
                return _tSClass ?? (_tSClass = this.GetStringFromLSO("TSClass"));
            }
        }

        /// <summary>
        /// Trade Skill Experience
        /// </summary>
        public float TSExp
        {
            get
            {
                Trace.WriteLine(String.Format("Character:TSExp"));
                return this.GetFloatFromLSO("TSExp");
            }
        }

        /// <summary>
        /// Trade Skill Experience Debt
        /// </summary>
        public float TSExpDebt
        {
            get
            {
                Trace.WriteLine(String.Format("Character:TSExpDebt"));
                return this.GetFloatFromLSO("TSExpDebt");
            }
        }

        /// <summary>
        /// Trade Skill Experience Points
        /// </summary>
        public float TSExpPoints
        {
            get
            {
                Trace.WriteLine(String.Format("Character:TSExpPoints"));
                return this.GetFloatFromLSO("TSExpPoints");
            }
        }

        /// <summary>
        /// Trade Skill Experience Points Needed to Reach the Next Level
        /// </summary>
        public float TSExpPointsToLevel
        {
            get
            {
                Trace.WriteLine(String.Format("Character:TSExpPointsToLevel"));
                return this.GetFloatFromLSO("TSExpPointsToLevel");
            }
        }

        /// <summary>
        /// Trade Skill Level
        /// </summary>
        public int TSLevel
        {
            get
            {
                Trace.WriteLine(String.Format("Character:TSLevel"));
                return this.GetIntFromLSO("TSLevel");
            }
        }

        /// <summary>
        /// Trade Skill SubClass (armorer, etc.)
        /// </summary>
        public string TSSubClass
        {
            get
            {
                Trace.WriteLine(String.Format("Character:TSSubClass"));
                return this.GetStringFromLSO("TSSubClass");
            }
        }

        /// <summary>
        /// Trade Skill Vitality
        /// </summary>
        public float TSVitality
        {
            get
            {
                Trace.WriteLine(String.Format("Character:TSVitality"));
                return this.GetFloatFromLSO("TSVitality");
            }
        }

        /// <summary>
        /// Amount of Concentration Used
        /// </summary>
        public int UsedConc
        {
            get
            {
                Trace.WriteLine(String.Format("Character:UsedConc"));
                return this.GetIntFromLSO("UsedConc");
            }
        }

        /// <summary>
        /// Retrieves the vending container at the index (1 to 6)
        /// </summary>
        /// <param name="index">index</param>
        public VendingContainer Vending(int index)
        {
            Trace.WriteLine(String.Format("Character:Vending({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new VendingContainer(this.GetMember("Vending", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Retrieves the vending container by exact name
        /// </summary>
        /// <param name="name">name</param>
        public VendingContainer Vending(string name)
        {
            Trace.WriteLine(String.Format("Character:Vending({0})", name));
            return new VendingContainer(this.GetMember("Vending", name));
        }

        /// <summary>
        /// Number of vending container slots currently free for use 
        /// </summary>
        public int VendingCapacityFree
        {
            get
            {
                Trace.WriteLine(String.Format("Character:VendingCapacityFree"));
                return this.GetIntFromLSO("VendingCapacityFree");
            }
        }

        /// <summary>
        /// Number of vending container slots currently being used 
        /// </summary>
        public int VendingCapacityUsed
        {
            get
            {
                Trace.WriteLine(String.Format("Character:VendingCapacityUsed"));
                return this.GetIntFromLSO("VendingCapacityUsed");
            }
        }

        /// <summary>
        /// Experience Vitality
        /// </summary>
        public float Vitality
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Vitality"));
                return this.GetFloatFromLSO("Vitality");
            }
        }

        /// <summary>
        /// Water Depth
        /// </summary>
        public float WaterDepth
        {
            get
            {
                Trace.WriteLine(String.Format("Character:WaterDepth"));
                return this.GetFloatFromLSO("WaterDepth");
            }
        }

        /// <summary>
        /// Wisdom
        /// </summary>
        public int Wisdom
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Wisdom"));
                return this.GetIntFromLSO("Wisdom");
            }
        }

        /// <summary>
        /// X-coordinate
        /// </summary>
        public float X
        {
            get
            {
                Trace.WriteLine(String.Format("Character:X"));
                return GetMember<float>("X");
            }
        }

        /// <summary>
        /// Y-coordinate
        /// </summary>
        public float Y
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Y"));
                return this.GetFloatFromLSO("Y");
            }
        }


        /// <summary>
        /// Z-coordinate
        /// </summary>
        public float Z
        {
            get
            {
                Trace.WriteLine(String.Format("Character:Z"));
                return this.GetFloatFromLSO("Z");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Deposits the specified quantity of coin into the player's bank. May be used
        /// to transfer money from the shared bank as well.
        /// </summary>
        /// <param name="type">type of coin</param>
        /// <param name="quantity">amount of coin</param>
        /// <param name="sharedBank">from the shared bank</param>
        /// <returns>call success</returns>
        public bool BankDeposit(CoinType type, int quantity, bool sharedBank = false)
        {
            Trace.WriteLine(String.Format("Character:BankDeposit({0}, {1}, {2})", type,
                quantity.ToString(CultureInfo.InvariantCulture), sharedBank));
            return ExecuteMethod("BankDeposit", type.ToString()[0].ToString(CultureInfo.InvariantCulture), 
                quantity.ToString(CultureInfo.InvariantCulture), sharedBank.ToString());
        }



        /// <summary>
        /// Withdraws the selected quantity of coin from the player's bank.
        /// </summary>
        /// <param name="type">type of coin</param>
        /// <param name="quantity">amount of coin</param>
        /// <returns>call success</returns>
        public bool BankWithdraw(CoinType type, int quantity)
        {
            Trace.WriteLine(String.Format("Character:BankDeposit({0}, {1})", type,
               quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("BankWithdraw", type.ToString()[0].ToString(CultureInfo.InvariantCulture),
                quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Creates a custom inventory array of the specified type.
        /// </summary>
        /// <param name="type">inventory type</param>
        /// <returns>call success</returns>
        public bool CreateCustomInventoryArray(InvType type = InvType.All)
        {

            return ExecuteMethod("CreateCustomInventoryArray", type.ToString().ToLower());
        }

        /// <summary>
        /// Deposits the specified amount of copper and status into house escrow
        /// </summary>
        /// <param name="coin">copper</param>
        /// <param name="status">status</param>
        public void DepositIntoHouseEscrow(int coin, int status)
        {
            Trace.WriteLine(String.Format("Character:DepositIntoHouseEscrow({0}, {1})", coin.ToString(CultureInfo.InvariantCulture),
                status.ToString(CultureInfo.InvariantCulture)));
            ExecuteMethod("DepositIntoHouseEscrow", coin.ToString(CultureInfo.InvariantCulture),
                status.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Rotates the character to face the supplied heading (0 to 360)
        /// </summary>
        /// <param name="heading"></param>
        /// <returns></returns>
        public bool Face(float heading)
        {
            Trace.WriteLine(String.Format("Character:Face({0})", heading.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("Face", heading.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Deposits the specified amount of silver in the designated guild bank
        /// </summary>
        /// <param name="bank">bank number (1-4)</param>
        /// <param name="amount">amount to deposit in silver</param>
        /// <returns>call success</returns>
        public bool GuildBankDeposit(int bank, int amount)
        {
            Trace.WriteLine(String.Format("Character:GuildBankDeposit({0}, {1})", bank.ToString(CultureInfo.InvariantCulture),
                amount.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("GuildBankDeposit", bank.ToString(CultureInfo.InvariantCulture),
                amount.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Withdraws the specified amount of silver from the designated guild bank
        /// </summary>
        /// <param name="bank">bank number (1-4)</param>
        /// <param name="amount">amount to withdraw in silver</param>
        /// <returns>call success</returns>
        public bool GuildBankWithdraw(int bank, int amount)
        {
            Trace.WriteLine(String.Format("Character:GuildBankWithdraw({0}, {1})", bank.ToString(CultureInfo.InvariantCulture),
                amount.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("GuildBankWithdraw", bank.ToString(CultureInfo.InvariantCulture),
                amount.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Initializes character effects
        /// </summary>
        /// <returns>call success</returns>
        public bool InitializeEffects()
        {
            Trace.WriteLine(String.Format("Character:InitializeEffects()"));
            return this.ExecuteMethod("InitializeEffects");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool ResetZoneTimer(string name)
        {
            Trace.WriteLine(String.Format("Character:ResetZoneTimer({0})", name));
            return this.ExecuteMethod("ResetZoneTimer", name);
        }

        public bool TakeAllVendingCoin()
        {
            return ExecuteMethod("TakeAllVendingCoin");
        }

        


        

        

        public bool SharedBankDeposit(string CoinType, int Amount)
        {
            return ExecuteMethod("SharedBankDeposit", CoinType.ToString(), Amount.ToString());
        }

        public bool SharedBankDeposit(string CoinType, int Amount, string Source)
        {
            return ExecuteMethod("SharedBankDeposit", CoinType.ToString(), Amount.ToString(), Source.ToString());
        }

        

        public bool SharedBankWithdrawl(string CoinType, int Amount)
        {
            return ExecuteMethod("SharedBankWithdrawl", CoinType.ToString(), Amount.ToString());
        }

        

        

        #endregion

        #region Enums

        /// <summary>
        /// Effect Types
        /// </summary>
        public enum EffectType
        {
            /// <summary>
            /// Beneficial
            /// </summary>
            Beneficial,
            /// <summary>
            /// Detrimental
            /// </summary>
            Detrimental,
            /// <summary>
            /// All
            /// </summary>
            All
        }

        /// <summary>
        /// Coin Types
        /// </summary>
        public enum CoinType
        {
            /// <summary>
            /// Coin Type Copper
            /// </summary>
            Copper,
            /// <summary>
            /// Coin Type Silver
            /// </summary>
            Silver,
            /// <summary>
            /// Coin Type Gold
            /// </summary>
            Gold,
            /// <summary>
            /// Coin Type Platinum
            /// </summary>
            Platinum
        }

        /// <summary>
        /// Inventory Types
        /// </summary>
        public enum InvType
        {
            /// <summary>
            /// Not in bank or shared bank
            /// </summary>
            NonBankOnly,
            /// <summary>
            /// Only in bank or shared bank
            /// </summary>
            BankOnly,
            /// <summary>
            /// All items
            /// </summary>
            All
        }

        #endregion


    }
}
