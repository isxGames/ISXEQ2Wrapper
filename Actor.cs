// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Actor : LavishScriptObject
    {
        public Actor(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Actor(params string[] Args)
            : base(LavishScript.Objects.GetObject("Actor", Args))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public string LastName
        {
            get
            {
                return GetMember<string>("LastName");
            }
        }

        public string Gender
        {
            get
            {
                return GetMember<string>("Gender");
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

        public int ID
        {
            get
            {
                return GetMember<int>("ID");
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

        public float Distance
        {
            get
            {
                return GetMember<float>("Distance");
            }
        }

        public float HeadingTo
        {
            get
            {
                return GetMember<float>("HeadingTo");
            }
        }

        public float Heading
        {
            get
            {
                return GetMember<float>("Heading");
            }
        }

        public string Type
        {
            get
            {
                return GetMember<string>("Type");
            }
        }

        public bool IsAggro
        {
            get
            {
                return GetMember<bool>("IsAggro");
            }
        }

        public bool IsSolo
        {
            get
            {
                return GetMember<bool>("IsSolo");
            }
        }

        public bool IsHeroic
        {
            get
            {
                return GetMember<bool>("IsHeroic");
            }
        }

        public bool IsEpic
        {
            get
            {
                return GetMember<bool>("IsEpic");
            }
        }

        public bool IsEncounterBroken
        {
            get
            {
                return GetMember<bool>("IsEncounterBroken");
            }
        }

        public string FactionStanding
        {
            get
            {
                return GetMember<string>("FactionStanding");
            }
        }

        public string ConColor(bool RGB)
        {
            if (RGB)
                return GetMember<string>("ConColor", "raw");
            return GetMember<string>("ConColor");
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

        public bool IsAFK
        {
            get
            {
                return GetMember<bool>("IsAFK");
            }
        }

        public bool IsLinkdead
        {
            get
            {
                return GetMember<bool>("IsLinkdead");
            }
        }

        public bool IsCamping
        {
            get
            {
                return GetMember<bool>("IsCamping");
            }
        }

        public Actor Target()
        {
            LavishScriptObject Obj = GetMember("Target");
            return new Actor(Obj);
        }

        public bool IsLocked
        {
            get
            {
                return GetMember<bool>("IsLocked");
            }
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

        public string Guild
        {
            get
            {
                return GetMember<string>("Guild");
            }
        }

        public string SuffixTitle
        {
            get
            {
                return GetMember<string>("SuffixTitle");
            }
        }

        public bool IsAPet
        {
            get
            {
                return GetMember<bool>("IsAPet");
            }
        }

        public bool IsMyPet
        {
            get
            {
                return GetMember<bool>("IsMyPet");
            }
        }

        public bool IsNamed
        {
            get
            {
                return GetMember<bool>("IsNamed");
            }
        }

        public bool IsSwimming
        {
            get
            {
                return GetMember<bool>("IsSwimming");
            }
        }

        public float SwimmingSpeedMod
        {
            get
            {
                return GetMember<float>("SwimmingSpeedMod");
            }
        }

        public int EncounterSize
        {
            get
            {
                return GetMember<int>("EncounterSize");
            }
        }

        public int Difficulty
        {
            get
            {
                return GetMember<int>("Difficulty");
            }
        }

        public bool InCombatMode
        {
            get
            {
                return GetMember<bool>("InCombatMode");
            }
        }

        public bool IsCrouching
        {
            get
            {
                return GetMember<bool>("IsCrouching");
            }
        }

        public bool IsSitting
        {
            get
            {
                return GetMember<bool>("IsSitting");
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

        public bool IsRunning
        {
            get
            {
                return GetMember<bool>("IsRunning");
            }
        }

        public bool IsWalking
        {
            get
            {
                return GetMember<bool>("IsWalking");
            }
        }

        public bool IsSprinting
        {
            get
            {
                return GetMember<bool>("IsSprinting");
            }
        }

        public bool IsBackingUp
        {
            get
            {
                return GetMember<bool>("IsBackingUp");
            }
        }

        public bool IsStrafingLeft
        {
            get
            {
                return GetMember<bool>("IsStrafingLeft");
            }
        }

        public bool IsStrafingRight
        {
            get
            {
                return GetMember<bool>("IsStrafingRight");
            }
        }

        public bool IsIdle
        {
            get
            {
                return GetMember<bool>("IsIdle");
            }
        }

        public bool IsInSameEncounter(int ActorID)
        {
            return GetMember<bool>("IsInSameEncounter", ActorID.ToString());
        }

        public Actor Pet()
        {
            LavishScriptObject Obj = GetMember("Pet");
            return new Actor(Obj);
        }

        public int NumEffects
        {
            get
            {
                return GetMember<int>("NumEffects");
            }
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

        public bool IsInvis
        {
            get
            {
                return GetMember<bool>("IsInvis");
            }
        }

        public bool IsStealthed
        {
            get
            {
                return GetMember<bool>("IsStealthed");
            }
        }

        public bool IsBanker
        {
            get
            {
                return GetMember<bool>("IsBanker");
            }
        }

        public bool IsMerchant
        {
            get
            {
                return GetMember<bool>("IsMerchant");
            }
        }

        public bool IsChest
        {
            get
            {
                return GetMember<bool>("IsChest");
            }
        }

        public bool IsClimbing
        {
            get
            {
                return GetMember<bool>("IsClimbing");
            }
        }

        public bool IsJumping
        {
            get
            {
                return GetMember<bool>("IsJumping");
            }
        }

        public bool IsFalling
        {
            get
            {
                return GetMember<bool>("IsFalling");
            }
        }

        public Point3f Velocity
        {
            get
            {
                LavishScriptObject Obj = GetMember("Velocity");
                return new Point3f(Obj);
            }
        }

        public Point3f Loc
        {
            get
            {
                LavishScriptObject Obj = GetMember("Loc");
                return new Point3f(Obj);
            }
        }

        public bool IsDead
        {
            get
            {
                return GetMember<bool>("IsDead");
            }
        }

        public int Faction
        {
            get
            {
                return GetMember<int>("Faction");
            }
        }

        public bool IsRooted
        {
            get
            {
                return GetMember<bool>("IsRooted");
            }
        }

        public bool CanTurn
        {
            get
            {
                return GetMember<bool>("CanTurn");
            }
        }

        public bool IsFD
        {
            get
            {
                return GetMember<bool>("IsFD");
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

        public bool CheckCollision()
        {
            return GetMember<bool>("CheckCollision");
        }

        public bool CheckCollision(float To_X, float To_Y, float To_Z)
        {
            return GetMember<bool>("CheckCollision",To_X.ToString(),To_Y.ToString(),To_Z.ToString());
        }

        public float TargetRingRadius
        {
            get
            {
                return GetMember<float>("TargetRingRadius");
            }
        }

        public float CollisionRadius
        {
            get
            {
                return GetMember<float>("CollisionRadius");
            }
        }

        public float CollisionScale
        {
            get
            {
                return GetMember<float>("CollisionScale");
            }
        }

        public float Distance2D
        {
            get
            {
                return GetMember<float>("Distance2D");
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
