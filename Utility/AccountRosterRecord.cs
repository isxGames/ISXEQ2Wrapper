using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.Utility
{
    /// <summary>
    /// Represents a single character entry from the account roster, accessed via
    /// EQ2.AccountRoster(index) for index 1 to EQ2.AccountRosterCount.
    /// Wraps the ISXEQ2 'accountrosterrecord' datatype.
    /// </summary>
    public class AccountRosterRecord : LavishScriptObject
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public AccountRosterRecord(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Character name.
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("AccountRosterRecord:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Cache of CharacterID
        /// </summary>
        private ulong? _characterID;

        /// <summary>
        /// Unique character ID.
        /// </summary>
        public ulong CharacterID
        {
            get
            {
                Trace.WriteLine(String.Format("AccountRosterRecord:CharacterID"));
                if (!_characterID.HasValue)
                    _characterID = this.GetUInt64FromLSO("CharacterID");
                return _characterID.Value;
            }
        }

        /// <summary>
        /// Cache of DatabaseID
        /// </summary>
        private uint? _databaseID;

        /// <summary>
        /// Character database ID.
        /// </summary>
        public uint DatabaseID
        {
            get
            {
                Trace.WriteLine(String.Format("AccountRosterRecord:DatabaseID"));
                if (!_databaseID.HasValue)
                    _databaseID = this.GetUIntFromLSO("DatabaseID");
                return _databaseID.Value;
            }
        }

        /// <summary>
        /// Cache of SubClassID
        /// </summary>
        private uint? _subClassID;

        /// <summary>
        /// Adventure subclass ID.
        /// </summary>
        public uint SubClassID
        {
            get
            {
                Trace.WriteLine(String.Format("AccountRosterRecord:SubClassID"));
                if (!_subClassID.HasValue)
                    _subClassID = this.GetUIntFromLSO("SubClassID");
                return _subClassID.Value;
            }
        }

        /// <summary>
        /// Cache of SubClass
        /// </summary>
        private string _subClass;

        /// <summary>
        /// Adventure subclass name.
        /// </summary>
        public string SubClass
        {
            get
            {
                Trace.WriteLine(String.Format("AccountRosterRecord:SubClass"));
                return _subClass ?? (_subClass = this.GetStringFromLSO("SubClass"));
            }
        }

        /// <summary>
        /// Cache of TSSubClassID
        /// </summary>
        private uint? _tsSubClassID;

        /// <summary>
        /// Tradeskill subclass ID.
        /// </summary>
        public uint TSSubClassID
        {
            get
            {
                Trace.WriteLine(String.Format("AccountRosterRecord:TSSubClassID"));
                if (!_tsSubClassID.HasValue)
                    _tsSubClassID = this.GetUIntFromLSO("TSSubClassID");
                return _tsSubClassID.Value;
            }
        }

        /// <summary>
        /// Cache of TSSubClass
        /// </summary>
        private string _tsSubClass;

        /// <summary>
        /// Tradeskill subclass name.
        /// </summary>
        public string TSSubClass
        {
            get
            {
                Trace.WriteLine(String.Format("AccountRosterRecord:TSSubClass"));
                return _tsSubClass ?? (_tsSubClass = this.GetStringFromLSO("TSSubClass"));
            }
        }

        /// <summary>
        /// Cache of Server
        /// </summary>
        private string _server;

        /// <summary>
        /// Server name.
        /// </summary>
        public string Server
        {
            get
            {
                Trace.WriteLine(String.Format("AccountRosterRecord:Server"));
                return _server ?? (_server = this.GetStringFromLSO("Server"));
            }
        }

        /// <summary>
        /// Cache of Zone
        /// </summary>
        private string _zone;

        /// <summary>
        /// Last zone name.
        /// </summary>
        public string Zone
        {
            get
            {
                Trace.WriteLine(String.Format("AccountRosterRecord:Zone"));
                return _zone ?? (_zone = this.GetStringFromLSO("Zone"));
            }
        }

        /// <summary>
        /// Cache of Level
        /// </summary>
        private uint? _level;

        /// <summary>
        /// Adventure level.
        /// </summary>
        public uint Level
        {
            get
            {
                Trace.WriteLine(String.Format("AccountRosterRecord:Level"));
                if (!_level.HasValue)
                    _level = this.GetUIntFromLSO("Level");
                return _level.Value;
            }
        }

        /// <summary>
        /// Cache of TSLevel
        /// </summary>
        private uint? _tsLevel;

        /// <summary>
        /// Tradeskill level.
        /// </summary>
        public uint TSLevel
        {
            get
            {
                Trace.WriteLine(String.Format("AccountRosterRecord:TSLevel"));
                if (!_tsLevel.HasValue)
                    _tsLevel = this.GetUIntFromLSO("TSLevel");
                return _tsLevel.Value;
            }
        }

        #endregion
    }
}
