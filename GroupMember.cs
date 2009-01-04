using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class GroupMember : LavishScriptObject
    {
        public GroupMember(LavishScriptObject Obj)
            : base(Obj)
        {
        }
        /*
                public GroupMember()
                    : base(LavishScript.Objects.GetObject("GroupMember"))
                {
                }
        */
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

        public int MaxPower
        {
            get
            {
                return GetMember<int>("MaxPower");
            }
        }

        public int Level
        {
            get
            {
                return GetMember<int>("Level");
            }
        }

        public string ZoneName
        {
            get
            {
                return GetMember<string>("ZoneName");
            }
        }

        public int ID
        {
            get
            {
                return GetMember<int>("ID");
            }
        }

        public int PetID
        {
            get
            {
                return GetMember<int>("PetID");
            }
        }

        public Actor ToActor()
        {
            LavishScriptObject Obj = GetMember("ToActor");
            return new Actor(Obj);
        }

        public int EffectiveLevel
        {
            get
            {
                return GetMember<int>("EffectiveLevel");
            }
        }

        public int Noxious
        {
            get
            {
                return GetMember<int>("Noxious");
            }
        }

        public int Cursed
        {
            get
            {
                return GetMember<int>("Cursed");
            }
        }

        public int Arcane
        {
            get
            {
                return GetMember<int>("Arcane");
            }
        }

        public int Elemental
        {
            get
            {
                return GetMember<int>("Elemental");
            }
        }

        public int Trauma
        {
            get
            {
                return GetMember<int>("Trauma");
            }
        }

        public bool IsAfflicted
        {
            get
            {
                return GetMember<bool>("IsAfflicted");
            }
        }

        public string RaidRole
        {
            get
            {
                return GetMember<string>("RaidRole");
            }
        }

        public int RaidGroupNum
        {
            get
            {
                return GetMember<int>("RaidGroupNum");
            }
        }

    }
}
