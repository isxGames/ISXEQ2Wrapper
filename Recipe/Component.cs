using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.Recipe
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to tradeskill recipe components.
    /// </summary>
    public class Component : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Component(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of Length
        /// </summary>
        private int? _length;

        /// <summary>
        /// String length of the component name. Only meaningful for primary components;
        /// returns 0 for build components and fuel (only the primarycomponent datatype
        /// registers this member).
        /// </summary>
        public int Length
        {
            get
            {
                Trace.WriteLine(String.Format("Component:Length"));
                if(!_length.HasValue)
                    _length = this.GetIntFromLSO("Length");
                return _length.Value;
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Component name
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Component:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Cache of Quantity
        /// </summary>
        private uint? _quantity;

        /// <summary>
        /// Quantity of component required.
        /// </summary>
        public uint Quantity
        {
            get
            {
                Trace.WriteLine(String.Format("Component:Quantity"));
                if(!_quantity.HasValue)
                    _quantity = this.GetUIntFromLSO("Quantity");
                return _quantity.Value;
            }
        }

        /// <summary>
        /// The quantity of the component on hand.
        /// </summary>
        public uint QuantityOnHand
        {
            get
            {
                Trace.WriteLine(String.Format("Component:QuantityOnHand"));
                return this.GetUIntFromLSO("QuantityOnHand");
            }
        }

        #endregion

    }
}
