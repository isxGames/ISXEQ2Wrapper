using System;
using System.Diagnostics;
using LavishScriptAPI;
using EQ2.ISXEQ2.Extensions;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to the current zone. 
    /// </summary>
    public class Zone : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Zone(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of ID
        /// </summary>
        private int? _iD;

        /// <summary>
        /// The ID of the zone
        /// </summary>
        public int ID
        {
            get
            {
                Trace.WriteLine(String.Format("Zone:ID"));
                if(!_iD.HasValue)
                    _iD = this.GetIntFromLSO("ID");
                return _iD.Value;
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// The name of the zone
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Zone:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Cache of ShortName
        /// </summary>
        private string _shortName;

        /// <summary>
        /// The short name of the zone
        /// </summary>
        public string ShortName
        {
            get
            {
                Trace.WriteLine(String.Format("Zone:ShortName"));
                return _shortName ?? (_shortName = this.GetStringFromLSO("ShortName"));
            }
        }

        #endregion
       
    }


}
