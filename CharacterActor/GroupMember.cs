using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.CharacterActor
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to group members. 
    /// </summary>
    public class GroupMember : LavishScriptObject
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public GroupMember(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Arcane Affliction counter. A value of -1 indicates that the affliction is incurable.
        /// </summary>
        public int Arcane
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:Arcane"));
                return this.GetIntFromLSO("Arcane");
            }
        }

        private string _class;

        /// <summary>
        /// Class
        /// </summary>
        public string Class
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:Class"));
                return _class ?? (_class = this.GetStringFromLSO("Class"));
            }
        }

        /// <summary>
        /// Cursed Counter. A value of -1 indicates that the affliction is incurable.
        /// </summary>
        public int Cursed
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:Cursed"));
                return this.GetIntFromLSO("Cursed");
            }
        }

        /// <summary>
        /// Cache of EffectiveLevel
        /// </summary>
        private int? _effectiveLevel;

        /// <summary>
        /// Effective Level (mentored or chrono)
        /// </summary>
        public int EffectiveLevel
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:EffectiveLevel"));
                if(!_effectiveLevel.HasValue)
                    _effectiveLevel = this.GetIntFromLSO("EffectiveLevel");
                return _effectiveLevel.Value;
            }
        }

        /// <summary>
        /// Elemental Affliction Counter. A value of -1 indicates that the affliction is incurable.
        /// </summary>
        public int Elemental
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:Elemental"));
                return this.GetIntFromLSO("Elemental");
            }
        }

        /// <summary>
        /// Hit Points
        /// </summary>
        public int HitPoints
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:HitPoints"));
                return this.GetIntFromLSO("HitPoints");
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
                Trace.WriteLine(String.Format("GroupMember:ID"));
                if(!_iD.HasValue)
                    _iD = this.GetIntFromLSO("ID");
                return _iD.Value;
            }
        }


        /// <summary>
        /// Returns true if actor is afflicted by arcane, noxious, etc.
        /// </summary>
        public bool IsAfflicted
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:IsAfflicted"));
                return this.GetBoolFromLSO("IsAfflicted");
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
                Trace.WriteLine(String.Format("GroupMember:Level"));
                if(!_level.HasValue)
                    _level = this.GetIntFromLSO("Level");
                return _level.Value;
            }
        }

        /// <summary>
        /// Max Hit Points
        /// </summary>
        public int MaxHitPoints
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:MaxHitPoints"));
                return this.GetIntFromLSO("MaxHitPoints");
            }
        }

        /// <summary>
        /// Max Power
        /// </summary>
        public int MaxPower
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:MaxPower"));
                return this.GetIntFromLSO("MaxPower");
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
                Trace.WriteLine(String.Format("GroupMember:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Noxious Affliction Counter. A value of -1 indicates that the affliction is incurable.
        /// </summary>
        public int Noxious
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:Noxious"));
                return this.GetIntFromLSO("Noxious");
            }
        }

        /// <summary>
        /// Cache of PetID
        /// </summary>
        private int? _petID;

        /// <summary>
        /// ID of the members pet, if any. A value of -1 indicates that there is no pet.
        /// </summary>
        public int PetID
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:PetID"));
                if(!_petID.HasValue)
                    _petID = this.GetIntFromLSO("PetID");
                return _petID.Value;
            }
        }

        /// <summary>
        /// Power
        /// </summary>
        public int Power
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:Power"));
                return this.GetIntFromLSO("Power");
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
                Trace.WriteLine(String.Format("GroupMember:Race"));
                return _race ?? (_race = this.GetStringFromLSO("Race"));
            }
        }

        /// <summary>
        /// If in a raid, the group number 1-4. Otherwise NULL. 
        /// </summary>
        public int RaidGroupNum
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:RaidGroupNum"));
                return GetMember<int>("RaidGroupNum");
            }
        }

        /// TODO: Test GroupMember.RaidRole
        /// <summary>
        /// Raid Role Assigned
        /// </summary>
        public int RaidRole
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:RaidRole"));
                return this.GetIntFromLSO("RaidRole");
            }
        }

        /// <summary>
        /// Accesses the Actor class of the GroupMember
        /// </summary>
        public Actor ToActor
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:ToActor"));
                return new Actor(this.GetMember("ToActor"));
            }
        }

        /// <summary>
        /// Trauma Affliction Counter. A value of -1 indicates that the affliction is incurable.
        /// </summary>
        public int Trauma
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:Trauma"));
                return this.GetIntFromLSO("Trauma");
            }
        }

        /// <summary>
        /// Current Zone name
        /// </summary>
        public string ZoneName
        {
            get
            {
                Trace.WriteLine(String.Format("GroupMember:ZoneName"));
                return this.GetStringFromLSO("ZoneName");
            }
        }

        #endregion        

    }
}
