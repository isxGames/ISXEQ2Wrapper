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
        /// Class
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
        /// Retrieves the effect of the given type at the specified index (1-30). (Beneficial, Detrimental, All)
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
                return GetMember<bool>("IsDecliningTradeInvites");
            }
        }

 
        #endregion

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

        

        public int TSLevel
        {
            get
            {
                return GetMember<int>("TSLevel");
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

        

        public int Wisdom
        {
            get
            {
                return GetMember<int>("Wisdom");
            }
        }

        

        

        

        public int NoxiousResist
        {
            get
            {
                return GetMember<int>("NoxiousResist");
            }
        }

        

        

        public int NoxiousResistPct
        {
            get
            {
                return GetMember<int>("NoxiousResistPct");
            }
        }

        

        

        public int Silver
        {
            get
            {
                return GetMember<int>("Silver");
            }
        }

        

        public int Platinum
        {
            get
            {
                return GetMember<int>("Platinum");
            }
        }

        public string PetName
        {
            get
            {
                return GetGameData("PetName").Label;
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

        public float VeteranBonus
        {
            get
            {
                return GetMember<int>("VeteranBonus");
            }
        }

        

        

        public float TSExpPoints
        {
            get
            {
                return GetMember<float>("TSExpPoints");
            }
        }

        public float TSExpPointsToLevel
        {
            get
            {
                return GetMember<float>("TSExpPointsToLevel");
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

        

        public float PetHealth
        {
            get
            {
                return Convert.ToSingle(GetGameData("PetHealth").ShortLabel.Remove(' ').Remove('%'));
            }
        }

        public float PetPower
        {
            get
            {
                return Convert.ToSingle(GetGameData("PetPower").ShortLabel.Remove(' ').Remove('%'));
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

        

        public bool RangedAutoAttackOn
        {
            get
            {
                return GetMember<bool>("RangedAutoAttackOn");
            }
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

        

        

        public bool IsSitting
        {
            get
            {
                return GetMember<bool>("IsSitting");
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

        

        public bool IsLFW
        {
            get
            {
                return GetMember<bool>("IsLFW");
            }
        }

        

        public bool IsRolePlaying
        {
            get
            {
                return GetMember<bool>("IsRolePlaying");
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

        



        public int NumVendingContainers
        {
            get
            {
                return GetMember<int>("NumVendingContainers");
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

        


        

        public int RaidGroupNum
        {
            get
            {
                return GetMember<int>("RaidGroupNum");
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

        public bool ResetZoneTimer(string ZoneName)
        {
            return ExecuteMethod("ResetZoneTimer", ZoneName.ToString());
        }


        public bool BankDeposit(string CoinType, int Amount)
        {
            return ExecuteMethod("BankDeposit", CoinType.ToString(), Amount.ToString());
        }

        /// <summary>
        /// August 31, 2011 -- By Amadeus
        /// Updated the 'BankDeposit' METHOD of the "character" datatype to utilize an *optional* 3rd parameter "FromShared"
        /// </summary>
        /// <param name="CoinType"></param>
        /// <param name="Amount"></param>
        /// <param name="Source"></param>
        /// <returns></returns>
        public bool BankDeposit(string CoinType, int Amount, string Source)
        {
            return ExecuteMethod("BankDeposit", CoinType.ToString(), Amount.ToString(), Source.ToString());
        }

        public bool SharedBankDeposit(string CoinType, int Amount)
        {
            return ExecuteMethod("SharedBankDeposit", CoinType.ToString(), Amount.ToString());
        }

        public bool SharedBankDeposit(string CoinType, int Amount, string Source)
        {
            return ExecuteMethod("SharedBankDeposit", CoinType.ToString(), Amount.ToString(), Source.ToString());
        }

        public bool BankWithdrawl(string CoinType, int Amount)
        {
            return ExecuteMethod("BankWithdrawl", CoinType.ToString(), Amount.ToString());
        }

        public bool SharedBankWithdrawl(string CoinType, int Amount)
        {
            return ExecuteMethod("SharedBankWithdrawl", CoinType.ToString(), Amount.ToString());
        }

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

        public void DepositIntoHouseEscrow(int copper, int status)
        {
            ExecuteMethod("DepositIntoHouseEscrow", copper.ToString(), status.ToString());
        }

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

        #endregion


    }
}
