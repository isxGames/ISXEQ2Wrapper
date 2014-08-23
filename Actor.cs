using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to entities within the world.
    /// </summary>
    public class Actor : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Actor(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns TRUE if the actor can turn. NOTE: If you're 'mezzed' you are 
        /// both rooted and you cannot turn. Use similar logic to determine other 
        /// situations such as being 'stunned' etc.
        /// </summary>
        public bool CanTurn
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:CanTurn"));
                return this.GetBoolFromLSO("CanTurn");
            }
        }

        /// <summary>
        /// Checks collision between you and this actor
        /// </summary>
        public bool CheckCollision()
        {
            Trace.WriteLine(String.Format("Actor:CheckCollision"));
            return this.GetBoolFromLSO("CheckCollision");
        }

        /// <summary>
        /// Checks between the actor and the given point.
        /// </summary>
        /// <param name="toX">X</param>
        /// <param name="toY">Y</param>
        /// <param name="toZ">Z</param>
        public bool CheckCollision(float toX, float toY, float toZ)
        {
            Trace.WriteLine(String.Format("Actor:CheckCollision({0}, {1}, {2})", toX.ToString(CultureInfo.InvariantCulture),
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
                return _class ?? (_class = this.GetStringFromLSO("Class"));
            }
        }

        /// <summary>
        /// Cache of CollisionRadius
        /// </summary>
        private float? _collisionRadius;

        /// <summary>
        /// Collision Radius
        /// </summary>
        public float CollisionRadius
        {
            get
            {
                if(!_collisionRadius.HasValue)
                    _collisionRadius = this.GetFloatFromLSO("CollisionRadius");
                return _collisionRadius.Value;
            }
        }

        /// <summary>
        /// Collision Scale
        /// </summary>
        private float? _collisionScale;

        /// <summary>
        /// 
        /// </summary>
        public float CollisionScale
        {
            get
            {
                if(!_collisionScale.HasValue)
                    _collisionScale = this.GetFloatFromLSO("CollisionScale");
                return _collisionScale.Value;
            }
        }

        /// <summary>
        /// Con Color
        /// </summary>
        /// <param name="asRGB">as RGB</param>
        /// <returns>Con Color</returns>
        public string ConColor(bool asRGB)
        {
            return asRGB ? this.GetStringFromLSO("ConColor", "raw") : this.GetStringFromLSO("ConColor");
        }

        
        private int? _difficulty;

        /// <summary>
        /// Returns the encounter difficulty as a range of -3 to 3. 
        /// -3 == three down arrows, 0 == no arrows, 3 == three up arrows
        /// </summary>
        public int Difficulty
        {
            get
            {
                if(!_difficulty.HasValue)
                    _difficulty = this.GetIntFromLSO("Difficulty");
                return _difficulty.Value;
            }
        }

        /// <summary>
        /// 3D Distance to this actor
        /// </summary>
        public float Distance
        {
            get
            {
                return this.GetFloatFromLSO("Distance");
            }
        }

        /// <summary>
        /// Distance to this actor
        /// </summary>
        public float Distance2D
        {
            get
            {
                return this.GetFloatFromLSO("Distance2D");
            }
        }

        /// <summary>
        /// Retrieves the Effect at the index (1 to NumEffects). Must InitializeEffects()
        /// if effects may have changed.
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>Effect</returns>
        public Effect Effect(int index)
        {
            Trace.WriteLine(String.Format("Actor:Effect({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Effect(this.GetMember("Effect", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Retireves the Effect by name.
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>Effect</returns>
        public Effect Effect(string name)
        {
            Trace.WriteLine(String.Format("Actor:Effect({0})", name));
            return new Effect(this.GetMember("Effect", name));
        }

        /// <summary>
        /// Cache of EffectiveLevel
        /// </summary>
        private int? _effectiveLevel;

        /// <summary>
        /// Mentored Level
        /// </summary>
        public int EffectiveLevel
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:EffectiveLevel"));
                if(!_effectiveLevel.HasValue)
                    _effectiveLevel = this.GetIntFromLSO("EffectiveLevel");
                return _effectiveLevel.Value;
            }
        }

        /// <summary>
        /// Cache of EncounterSize
        /// </summary>
        private int? _encounterSize;

        /// <summary>
        /// Returns the size of the encounter. This number will not change throughout the fight.
        /// </summary>
        public int EncounterSize
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:EncounterSize"));
                if(!_encounterSize.HasValue)
                    _encounterSize = this.GetIntFromLSO("EncounterSize");
                return _encounterSize.Value;
            }
        }

        /// <summary>
        /// Cache of Faction
        /// </summary>
        private int? _faction;
        
        /// <summary>
        /// Less than -4 is KOS, -3 is threatening, -2 is dubious, -1 is apprehensive, etc. 
        /// </summary>
        public int Faction
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:Faction"));
                if(!_faction.HasValue)
                    _faction = this.GetIntFromLSO("Faction");
                return _faction.Value;
            }
        }

        /// <summary>
        /// Cache of Faction Standing
        /// </summary>
        private string _factionStanding;

        /// <summary>
        /// Possible Faction Standings are: Ally, Warmly, Kindly, Amiable, Indifferent, Apprehensive, Dubious, Threatening, and KOS.
        /// </summary>
        public string FactionStanding
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:FactionStanding"));
                return _factionStanding ?? (_factionStanding = this.GetStringFromLSO("FactionStanding"));
            }
        }

        /// <summary>
        /// Cache of OnFlyingMount
        /// </summary>
        private bool? _onFlyingMount;

        /// <summary>
        /// Returns TRUE if currently on a flying mount, whether on the ground or in the air
        /// </summary>
        public bool OnFlyingMount
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:OnFlyingMount"));
                if (!_onFlyingMount.HasValue)
                    _onFlyingMount = this.GetBoolFromLSO("OnFlyingMount");
                return _onFlyingMount.Value;
            }
        }

        /// <summary>
        /// Cache of FlyingUsingMount
        /// </summary>
        private bool? _flyingUseMount;

        /// <summary>
        /// Returns TRUE if currently flying in the air using a flying mount (the mount is visible)
        /// </summary>
        public bool FlyingUsingMount
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:FlyingUsingMount"));
                if (!_flyingUseMount.HasValue)
                    _flyingUseMount = this.GetBoolFromLSO("FlyingUsingMount");
                return _flyingUseMount.Value;
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
                Trace.WriteLine(String.Format("Actor:Gender"));
                return _gender ?? (_gender = this.GetStringFromLSO("Gender"));
            }
        }

        /// <summary>
        /// Cache of Guild
        /// </summary>
        private string _guild;

        /// <summary>
        /// Guild
        /// </summary>
        public string Guild
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:Guild"));
                return _guild ?? (_guild = this.GetStringFromLSO("Guild"));
            }
        }

        /// <summary>
        /// Heading. Returns heading as degrees (think compass), to a precision of 2 decimal places.
        /// </summary>
        public float Heading
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:Heading"));
                return this.GetFloatFromLSO("Heading");
            }
        }

        /// <summary>
        /// Better known as bearing.
        /// </summary>
        public float HeadingTo
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:Heading"));
                return this.GetFloatFromLSO("HeadingTo");
            }
        }

        /// <summary>
        /// Returns health as a percentage.
        /// </summary>
        public int Health
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:Health"));
                return this.GetIntFromLSO("Health");
            }
        }

        /// <summary>
        /// Cache on HighlightOnMouseHover
        /// </summary>
        private bool? _highlightOnMouseHover;

        /// <summary>
        /// Interactable
        /// </summary>
        public bool HighlightOnMouseHover
        {

            get
            {
                Trace.WriteLine(String.Format("Actor:HighlightOnMouseHover"));
                if(!_highlightOnMouseHover.HasValue)
                    _highlightOnMouseHover = this.GetBoolFromLSO("HighlightOnMouseHover");
                return _highlightOnMouseHover.Value;
            }
        }

        /// <summary>
        /// Cache of ID
        /// </summary>
        private int? _iD;

        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:ID"));
                if(!_iD.HasValue)
                    _iD = this.GetIntFromLSO("ID");
                return _iD.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is in combat. Mutually exclusive with
        /// IsCrouching and IsSitting
        /// </summary>
        public bool InCombatMode
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:InCombatMode"));
                return this.GetBoolFromLSO("InCombatMode");
            }
        }

        /// <summary>
        /// Cache of InMyGroup
        /// </summary>
        private bool? _inMyGroup;

        /// <summary>
        /// Return TRUE if the actor is in the players group
        /// </summary>
        public bool InMyGroup
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:InMyGroup"));
                if (!_inMyGroup.HasValue)
                    _inMyGroup = this.GetBoolFromLSO("InMyGroup");
                return _inMyGroup.Value;
            }
        }

        /// <summary>
        /// Cache of Interactable
        /// </summary>
        private bool? _interactable;

        /// <summary>
        /// Interactable
        /// </summary>
        public bool Interactable
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:Interactable"));
                if(!_interactable.HasValue)
                    _interactable = this.GetBoolFromLSO("Interactable");
                return _interactable.Value;
            }
        }

        /// <summary>
        /// Cache of ISAFK
        /// </summary>
        private bool? _isAFK;

        /// <summary>
        /// Returns TRUE if the actor is AFK
        /// </summary>
        public bool IsAFK
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsAFK"));
                if(!_isAFK.HasValue)
                    _isAFK = this.GetBoolFromLSO("IsAFK");
                return _isAFK.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is a aggro
        /// </summary>
        public bool IsAggro
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsAFK"));
                return this.GetBoolFromLSO("IsAggro");
            }
        }

        /// <summary>
        /// Cache of IsAPet
        /// </summary>
        private bool? _isAPet;

        /// <summary>
        /// Returns TRUE if the actor is a pet
        /// </summary>
        public bool IsAPet
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsAPet"));
                if(!_isAPet.HasValue)
                    _isAPet = this.GetBoolFromLSO("IsAPet");
                return _isAPet.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is backing up. Mutually exclusive with IsStrafingLeft,
        /// IsStrafingRight, and IsIdle.
        /// </summary>
        public bool IsBackingUp
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsAPet"));
                return this.GetBoolFromLSO("IsBackingUp");
            }
        }

        /// <summary>
        /// Cache of IsBanker
        /// </summary>
        private bool? _isBanker;

        /// <summary>
        /// Returns TRUE if the actor is a banker
        /// </summary>
        public bool IsBanker
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsBanker"));
                if(!_isBanker.HasValue)
                    _isBanker = this.GetBoolFromLSO("IsBanker");
                return _isBanker.Value;
            }
        }

        /// <summary>
        /// Cache of IsCamping
        /// </summary>
        private bool? _isCamping;

        /// <summary>
        /// Returns TRUE if the actor is camping
        /// </summary>
        public bool IsCamping
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsCamping"));
                if(!_isCamping.HasValue)
                    _isCamping = this.GetBoolFromLSO("IsCamping");
                return _isCamping.Value;
            }
        }

        /// <summary>
        /// Cache of IsChest
        /// </summary>
        private bool? _isChest;

        /// <summary>
        /// Returns TRUE if the actor is a chest
        /// </summary>
        public bool IsChest
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsChest"));
                if(!_isChest.HasValue)
                    _isChest = this.GetBoolFromLSO("IsChest");
                return _isChest.Value;
            }
        }

        /// <summary>
        /// Cache of IsClimbing
        /// </summary>
        private bool? _isClimbing;

        /// <summary>
        /// Returns TRUE if the actor is climbing
        /// </summary>
        public bool IsClimbing
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsClimbing"));
                if(!_isClimbing.HasValue)
                    _isClimbing = this.GetBoolFromLSO("IsClimbing");
                return _isClimbing.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is crouching. Mutually exclusive with
        /// InCombatMode and IsSitting 
        /// </summary>
        public bool IsCrouching
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsCrouching"));
                return this.GetBoolFromLSO("IsCrouching");
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is dead
        /// </summary>
        public bool IsDead
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsDead"));
                return this.GetBoolFromLSO("IsDead");
            }
        }

        /// <summary>
        /// Returns TRUE if the encounter is broken.
        /// </summary>
        public bool IsEncounterBroken
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsEncounterBroken"));
                return this.GetBoolFromLSO("IsEncounterBroken");
            }
        }

        /// <summary>
        /// Cache of IsEpic
        /// </summary>
        private bool? _isEpic;

        /// <summary>
        /// Returns TRUE if the actor is Epic.
        /// </summary>
        public bool IsEpic
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsEpic"));
                if(!_isEpic.HasValue)
                    _isEpic = this.GetBoolFromLSO("IsEpic");
                return _isEpic.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is falling or jumping.
        /// </summary>
        public bool IsFalling
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsFalling"));
                return this.GetBoolFromLSO("IsFalling");
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is feign death.
        /// </summary>
        public bool IsFD
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsFD"));
                return this.GetBoolFromLSO("IsFD");
            }
        }

        /// <summary>
        /// Cache of IsHeroic
        /// </summary>
        private bool? _isHeroic;

        /// <summary>
        /// Returns TRUE if the actor is Heroic.
        /// </summary>
        public bool IsHeroic
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsHeroic"));
                if(!_isHeroic.HasValue)
                    _isHeroic = this.GetBoolFromLSO("IsHeroic");
                return _isHeroic.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is idle. Mutually exclusive with
        /// IsBackingUp, IsStrafingLeft, and IsStrafingRight.
        /// </summary>
        public bool IsIdle
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsIdle"));
                return this.GetBoolFromLSO("IsIdle");
            }
        }

        /// <summary>
        /// Returns TRUE if the actor with the give ID is in the same encounter.
        /// </summary>
        /// <param name="id"></param>
        public bool IsInSameEncounter(int id)
        {
            Trace.WriteLine(String.Format("Actor:IsInSameEncounter({0})", id.ToString(CultureInfo.InvariantCulture)));
            return this.GetBoolFromLSO("IsInSameEncounter", id.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Return TRUE if the actor is invis. (alias for IsStealthed)
        /// </summary>
        public bool IsInvis
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsInvis"));
                return this.GetBoolFromLSO("IsInvis");
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is jumping.
        /// </summary>
        public bool IsJumping
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsJumping"));
                return this.GetBoolFromLSO("IsJumping");
            }
        }

        /// <summary>
        /// Cache of IsLFG
        /// </summary>
        private bool? _isLFG;

        /// <summary>
        /// Returns TRUE if the actor is Looking for Group.
        /// </summary>
        public bool IsLFG
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsLFG"));
                if (!_isLFG.HasValue)
                    _isLFG = this.GetBoolFromLSO("IsLFG");
                return _isLFG.Value;
            }
        }

        /// <summary>
        /// Cache of IsLFW
        /// </summary>
        private bool? _isLFW;

        /// <summary>
        /// Returns TRUE is the actor is Looking for Work.
        /// </summary>
        public bool IsLFW
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsLFW"));
                if(!_isLFW.HasValue)
                    _isLFW = this.GetBoolFromLSO("IsLFW");
                return _isLFW.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is linkdead.
        /// </summary>
        public bool IsLinkdead
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsLinkdead"));
                return this.GetBoolFromLSO("IsLinkdead");
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is engaged in a locked encounter.
        /// </summary>
        public bool IsLocked
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsLocked"));
                return this.GetBoolFromLSO("IsLocked");
            }
        }

        /// <summary>
        /// Cache of IsMerchant
        /// </summary>
        private bool? _isMerchant;


        /// <summary>
        /// Returns TRUE if the actor is a merchant. (includes Mender)
        /// </summary>
        public bool IsMerchant
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsMerchant"));
                if(!_isMerchant.HasValue)
                    _isMerchant = this.GetBoolFromLSO("IsMerchant");
                return _isMerchant.Value;
            }
        }

        /// <summary>
        /// Cache of IsMyPet
        /// </summary>
        private bool? _isMyPet;

        /// <summary>
        /// Returns TRUE if the actor is my pet.
        /// </summary>
        public bool IsMyPet
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsMyPet"));
                if(!_isMyPet.HasValue)
                    _isMyPet = this.GetBoolFromLSO("IsMyPet");
                return _isMyPet.Value;
            }
        }

        /// <summary>
        /// Cache of IsNamed
        /// </summary>
        private bool? _isNamed;

        /// <summary>
        /// Returns TRUE if the actor is a Named.
        /// </summary>
        public bool IsNamed
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsNamed"));
                if(!_isNamed.HasValue)
                    _isNamed = this.GetBoolFromLSO("IsNamed");
                return _isNamed.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is rooted. NOTE: If you're 'mezzed' you are 
        /// both rooted and you cannot turn. Use similar logic to determine other 
        /// situations such as being 'stunned' etc.
        /// </summary>
        public bool IsRooted
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsRooted"));
                return this.GetBoolFromLSO("IsRooted");
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is running. Mutually exclusive with
        /// IsWalking and IsSprinting.
        /// </summary>
        public bool IsRunning
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsRunning"));
                return GetMember<bool>("IsRunning");
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is sitting. Mutually exclusive with
        /// InCombatMode and IsCrouching.
        /// </summary>
        public bool IsSitting
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsSitting"));
                return GetMember<bool>("IsSitting");
            }
        }

        /// <summary>
        /// Cache of IsSolo
        /// </summary>
        private bool? _isSolo;

        /// <summary>
        /// Returns TRUE if the actor is solo. (NOT an encounter)
        /// </summary>
        public bool IsSolo
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsSolo"));
                if(!_isSolo.HasValue)
                    _isSolo = this.GetBoolFromLSO("IsSolo");
                return _isSolo.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is sprinting. Mutually exclusive
        /// with IsRunning and IsWalking.
        /// </summary>
        public bool IsSprinting
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsSprinting"));
                return this.GetBoolFromLSO("IsSprinting");
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is stealthed. (alias for IsInvis)
        /// </summary>
        public bool IsStealthed
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsStealthed"));
                return this.GetBoolFromLSO("IsStealthed");
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is strafing left. Mutually exclusive 
        /// with IsBackingUp, IsStrafingRight, and IsIdle.
        /// </summary>
        public bool IsStrafingLeft
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsStrafingLeft"));
                return this.GetBoolFromLSO("IsStrafingLeft");
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is strafing right. Mutually exclusive
        /// with IsBackingUp, IsStrafingLeft, and IsIdle.
        /// </summary>
        public bool IsStrafingRight
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsStrafingRight"));
                return GetMember<bool>("IsStrafingRight");
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is swimming.
        /// </summary>
        public bool IsSwimming
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsSwimming"));
                return GetMember<bool>("IsSwimming");
            }
        }

        /// <summary>
        /// Returns TRUE if the actor is walking. Mutually exclusive
        /// with IsRunning and IsSprinting.
        /// </summary>
        public bool IsWalking
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsWalking"));
                return this.GetBoolFromLSO("IsWalking");
            }
        }

        /// <summary>
        /// Cache of LastName
        /// </summary>
        private string _lastName;

        public string LastName
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:IsLastName"));
                return _lastName ?? (_lastName = this.GetStringFromLSO("LastName"));
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
                Trace.WriteLine(String.Format("Actor:Level"));
                if(!_level.HasValue)
                    _level = this.GetIntFromLSO("Level");
                return _level.Value;
            }
        }

        /// <summary>
        /// Location (or position in Point3f)
        /// </summary>
        public Point3f Loc
        {
            get
            {
                Trace.WriteLine(String.Format("Actor:Loc"));
                return new Point3f(this.GetMember("Loc"));
            }
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
                Trace.WriteLine(String.Format("Actor:Name"));
                return GetMember<string>("Name");
            }
        }

        /// <summary>
        /// The number of effects on the actor. Use with Effects(int).
        /// </summary>
        public int NumEffects
        {
            get
            {
                return GetMember<int>("NumEffects");
            }
        }














        #endregion







        

        

        

        public string Race
        {
            get
            {
                return GetMember<string>("Race");
            }
        }

        

        

        public int Power
        {
            get
            {
                return GetMember<int>("Power");
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

        

        

        

        public string Type
        {
            get
            {
                return GetMember<string>("Type");
            }
        }

        

        

        

        



        

        

        

        

        

        

        public Actor Target()
        {
            LavishScriptObject Obj = GetMember("Target");
            return new Actor(Obj);
        }

        

        public int WhoFollowingID
        {
            get
            {
                return GetMember<int>("WhoFollowingID");
            }
        }

        public string WhoFollowing
        {
            get
            {
                return GetMember<string>("WhoFollowing");
            }
        }

        public float Speed
        {
            get
            {
                return GetMember<float>("Speed");
            }
        }

        

        public string SuffixTitle
        {
            get
            {
                return GetMember<string>("SuffixTitle");
            }
        }

        

        

        

        

        public float SwimmingSpeedMod
        {
            get
            {
                return GetMember<float>("SwimmingSpeedMod");
            }
        }

        

        

        



        

        public bool OnCarpet
        {
            get
            {
                return GetMember<bool>("OnCarpet");
            }
        }

        public bool OnHorse
        {
            get
            {
                return GetMember<bool>("OnHorse");
            }
        }

        public bool OnGriffin
        {
            get
            {
                return GetMember<bool>("OnGriffin");
            }
        }

        public bool OnGriffon
        {
            get
            {
                return GetMember<bool>("OnGriffon");
            }
        }

        

        

        

        

        

        

        

        public Actor Pet()
        {
            LavishScriptObject Obj = GetMember("Pet");
            return new Actor(Obj);
        }

        



        

        

        




        public Point3f Velocity
        {
            get
            {
                LavishScriptObject Obj = GetMember("Velocity");
                return new Point3f(Obj);
            }
        }

        

        

        

        



        

        public Actor ToActor
        {
            get
            {
                LavishScriptObject Obj = GetMember("ToActor");
                return new Actor(Obj);
            }
        }


        

        public float TargetRingRadius
        {
            get
            {
                return GetMember<float>("TargetRingRadius");
            }
        }

        

        

        

        public int ThreatToMe
        {
            get
            {
                return GetMember<int>("ThreatToMe");
            }
        }

        public int ThreatToNext
        {
            get
            {
                return GetMember<int>("ThreatToNext");
            }
        }

        public bool DoubleClick()
        {
            return ExecuteMethod("DoubleClick");
        }

        public bool WaypointTo()
        {
            return ExecuteMethod("WaypointTo");
        }

        public bool DoFace()
        {
            return ExecuteMethod("DoFace");
        }

        public bool DoTarget()
        {
            return ExecuteMethod("DoTarget");
        }

        public enum CommandType
        {
            Add,
            Delete
        }

        public bool Location(CommandType Action)
        {
            return ExecuteMethod("Location", Action.ToString());
        }

        public bool Location(string AddNotes)
        {
            return ExecuteMethod("Location", "Add", AddNotes);
        }

        public bool InitializeEffects()
        {
            return ExecuteMethod("InitializeEffects");
        }

        

    }
}
