using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related 
    /// to information about the classes that can use abilities or items.
    /// </summary>
    public class Class : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Class(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of Level
        /// </summary>
        private int? _level;

        /// <summary>
        /// Required level of this class
        /// </summary>
        public int Level
        {
            get
            {
                Trace.WriteLine(String.Format("Class:Level"));
                if(!_level.HasValue)
                    _level = this.GetIntFromLSO("Level");
                return _level.Value;
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Class name
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Class:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        #endregion

    }
}
