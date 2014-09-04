using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// Represents an item in a ContainerWindow (Supply Depot Items). Only available when the ContainerWindow is open.
    /// </summary>
    public class ContainerWindowItem : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public ContainerWindowItem(LavishScriptObject copy) : base(copy) { }


        #endregion

        #region Members

        /// <summary>
        /// Cache of ID
        /// </summary>
        private int? _iD;

        /// <summary>
        /// Item ID. Note: The 'ID' MEMBER of the 'containerwindowitem' datatype is used 
        /// exlusively for the "RemoveItem" METHOD of the 'containerwindow' datatype.  
        /// </summary>
        public int ID
        {
            get
            {
                Trace.WriteLine(String.Format("ContainerWindowItem:ID"));
                if(!_iD.HasValue)
                    _iD = this.GetIntFromLSO("ID");
                return _iD.Value;
            }
        }

        /// <summary>
        /// Cache of Level
        /// </summary>
        private int? _level;

        /// <summary>
        /// Item Level (Tier?)
        /// </summary>
        public int Level
        {
            get
            {
                Trace.WriteLine(String.Format("ContainerWindowItem:Level"));
                if(!_level.HasValue)
                    _level = this.GetIntFromLSO("Level");
                return _level.Value;
            }
        }

        /// <summary>
        /// Item Quantity
        /// </summary>
        public int LinkID
        {
            get
            {
                Trace.WriteLine(String.Format("ContainerWindowItem:LinkID"));
                return this.GetIntFromLSO("LinkID");
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Item Name
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("ContainerWindowItem:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Item Quantity
        /// </summary>
        public int Quantity
        {
            get
            {
                Trace.WriteLine(String.Format("ContainerWindowItem:Quantity"));
                return this.GetIntFromLSO("Quantity");
            }
        }

        #endregion
     
    }
}