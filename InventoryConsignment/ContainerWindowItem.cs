using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// Represents an item in a ContainerWindow (Supply Depot Items). Only available when the ContainerWindow is open.
    /// Source: ContainerWindowItemType (DataTypes.h:3741-3776, DT-Eq2GuiWindows.cpp:1192-1304).
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
        /// Item ID. Used as the index argument for the 'RemoveItem' METHOD on the 'containerwindow' datatype.
        /// Source maps this to <c>pItem-&gt;Unknown1</c> (DT-Eq2GuiWindows.cpp:1212-1217), which is semantically the slot/item index within
        /// the container; it is NOT the item template ItemID. For the link-side identifier, see <see cref="LinkID"/>.
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
        /// Item link identifier (source: <c>pItem-&gt;LinkID</c>, DT-Eq2GuiWindows.cpp:1218-1223).
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
        /// Source: DT-Eq2GuiWindows.cpp:1224-1230.
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
        /// Item Icon ID (source: <c>pItem-&gt;IconID</c>, DT-Eq2GuiWindows.cpp:1231-1236).
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
        /// True if the underlying ItemInfo (CExamineItemNode) is loaded and valid for this container item.
        /// Source: DT-Eq2GuiWindows.cpp:1255-1264.
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
        /// Source: DT-Eq2GuiWindows.cpp:1265-1287 (returns <c>pItemInfoType</c>).
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
