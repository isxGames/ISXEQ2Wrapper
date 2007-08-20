using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class RaidMember : LavishScriptObject
    {
        public RaidMember(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public RaidMember()
            : base(LavishScript.Objects.GetObject("RaidMember"))
        {
        }

        public int ID
        {
            get
            {
                return GetMember<int>("ID");
            }
        }

        public Actor ToActor()
        {
            LavishScriptObject Obj = GetMember("ToActor");
            return new Actor(Obj);
        }

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

        public string Class
        {
            get
            {
                return GetMember<string>("Class");
            }
        }

        public bool InMyZone
        {
            get
            {
                return GetMember<bool>("InMyZone");
            }
        }

        public string ZoneName
        {
            get
            {
                return GetMember<string>("ZoneName");
            }
        }

        public int PetID
        {
            get
            {
                return GetMember<int>("PetID");
            }
        }

        public int HitPoints
        {
            get
            {
                return GetMember<int>("HitPoints");
            }
        }

        public int MaxHitPoints
        {
            get
            {
                return GetMember<int>("MaxHitPoints");
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

        public bool IsAfflicted
        {
            get
            {
                return GetMember<bool>("IsAfflicted");
            }
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

        public int Elemental
        {
            get
            {
                return GetMember<int>("Elemental");
            }
        }

        public int Arcane
        {
            get
            {
                return GetMember<int>("Arcane");
            }
        }
    }
}
