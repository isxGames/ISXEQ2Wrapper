using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to modifiers on items. 
    /// </summary>
    public class ItemModifier : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public ItemModifier(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of SubType
        /// </summary>
        private string _subType;

        /// <summary>
        /// Modifier SubType
        /// </summary>
        public string SubType
        {
            get
            {
                Trace.WriteLine(String.Format("ItemModifier:SubType"));
                return _subType ?? (_subType = this.GetStringFromLSO("SubType"));
            }
        }

        /// <summary>
        /// Cache of Type
        /// </summary>
        private string _type;

        /// <summary>
        /// Modifier Type
        /// </summary>
        public string Type
        {
            get
            {
                Trace.WriteLine(String.Format("ItemModifier:Type"));
                return _type ?? (_type = this.GetStringFromLSO("Type"));
            }
        }

        /// <summary>
        /// Cache of Value
        /// </summary>
        private int? _value;

        /// <summary>
        /// Modifier Value
        /// </summary>
        public int Value
        {
            get
            {
                Trace.WriteLine(String.Format("ItemModifier:Value"));
                if(!_value.HasValue)
                    _value = this.GetIntFromLSO("Value");
                return _value.Value;
            }
        }

        #endregion

    }
}
