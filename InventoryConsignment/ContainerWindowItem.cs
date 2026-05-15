using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// Represents an item in a ContainerWindow (Supply Depot Items). Only available
    /// when the ContainerWindow is open. Wraps the ISXEQ2 'containerwindowitem'
    /// datatype.
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
        /// Item ID. Used as the index argument for the 'RemoveItem' METHOD on the
        /// 'containerwindow' datatype. Semantically the slot/item index within the
        /// container; it is NOT the item template ItemID. For the link-side identifier,
        /// see <see cref="LinkID"/>.
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
        /// Item link identifier.
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
        /// Returns a chat-link string for this item in the form <c>\aITEM linkid linkhash 0 0 0:Name\/a</c>.
        /// </summary>
        public string ToLink
        {
            get
            {
                Trace.WriteLine(String.Format("ContainerWindowItem:ToLink"));
                return this.GetStringFromLSO("ToLink");
            }
        }

        /// <summary>
        /// Cache of IconID
        /// </summary>
        private int? _iconID;

        /// <summary>
        /// Item Icon ID.
        /// </summary>
        public int IconID
        {
            get
            {
                Trace.WriteLine(String.Format("ContainerWindowItem:IconID"));
                if (!_iconID.HasValue)
                    _iconID = this.GetIntFromLSO("IconID");
                return _iconID.Value;
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
        /// True if the underlying ItemInfo is loaded and valid for this container item.
        /// </summary>
        public bool IsItemInfoAvailable
        {
            get
            {
                Trace.WriteLine(String.Format("ContainerWindowItem:IsItemInfoAvailable"));
                return this.GetBoolFromLSO("IsItemInfoAvailable");
            }
        }

        /// <summary>
        /// Returns the underlying <see cref="ItemInfo"/> for this container item, or null if unavailable/invalid.
        /// </summary>
        public ItemInfo ToItemInfo
        {
            get
            {
                Trace.WriteLine(String.Format("ContainerWindowItem:ToItemInfo"));
                return new ItemInfo(this.GetMember("ToItemInfo"));
            }
        }

        #endregion

    }
}
