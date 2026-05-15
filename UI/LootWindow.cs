using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using EQ2.ISXEQ2.InventoryConsignment;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to the "loot" window. 
    /// </summary>
	public class LootWindow : EQ2CloneWindow
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public LootWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns the dropdown box of group members (loot leader assignment).
        /// </summary>
        public EQ2DropDownBox GroupMembers
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:GroupMembers"));
                return new EQ2DropDownBox(this.GetMember("GroupMembers"));
            }
        }

        /// <summary>
        /// Returns the item at the index provided. (From 1 to NumItems)
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>ItemInfo</returns>
        public ItemInfo Item(int index)
        {
            Trace.WriteLine(String.Format("LootWindow:Item({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new ItemInfo(this.GetMember("Item", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns the item that matches the substring name
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>ItemInfo</returns>
        public ItemInfo Item(string name)
        {
            Trace.WriteLine(String.Format("LootWindow:Item({0})", name));
            return new ItemInfo(this.GetMember("Item", name));
        }

        /// <summary>
        /// Returns the EQ2UIPage that contains the loot items table.
        /// </summary>
        public EQ2UIPage ItemsPage
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:ItemsPage"));
                return new EQ2UIPage(this.GetMember("ItemsPage"));
            }
        }

        /// <summary>
        /// Returns the "Leader Assign" button (group-leader-assigned-loot mode).
        /// </summary>
        public EQ2Button LeaderAssign
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:LeaderAssign"));
                return new EQ2Button(this.GetMember("LeaderAssign"));
            }
        }

        /// <summary>
        /// Returns the "Loot All" button.
        /// </summary>
        public EQ2Button LootAllButton
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:LootAllButton"));
                return new EQ2Button(this.GetMember("LootAllButton"));
            }
        }

        /// <summary>
        /// Returns the "Loot Selected" button.
        /// </summary>
        public EQ2Button LootSelected
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:LootSelected"));
                return new EQ2Button(this.GetMember("LootSelected"));
            }
        }

        /// <summary>
        /// Returns the unique ID of the loot source actor (e.g. corpse).
        /// </summary>
        public uint LootSourceID
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:LootSourceID"));
                return this.GetUIntFromLSO("LootSourceID");
            }
        }

        /// <summary>
        /// Returns the "Decline" button for Lotto loot windows.
        /// </summary>
        public EQ2Button LottoDecline
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:LottoDecline"));
                return new EQ2Button(this.GetMember("LottoDecline"));
            }
        }

        /// <summary>
        /// Returns the Need-Before-Greed "Decline" button.
        /// </summary>
        public EQ2Button NBG_Decline
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:NBG_Decline"));
                return new EQ2Button(this.GetMember("NBG_Decline"));
            }
        }

        /// <summary>
        /// Returns the Need-Before-Greed "Greed" button.
        /// </summary>
        public EQ2Button NBG_Greed
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:NBG_Greed"));
                return new EQ2Button(this.GetMember("NBG_Greed"));
            }
        }

        /// <summary>
        /// Returns the Need-Before-Greed "Need" button.
        /// </summary>
        public EQ2Button NBG_Need
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:NBG_Need"));
                return new EQ2Button(this.GetMember("NBG_Need"));
            }
        }

        /// <summary>
        /// The number of items in the loot window
        /// </summary>
        public int NumItems
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:NumItems"));
                return this.GetIntFromLSO("NumItems");
            }
        }

        /// <summary>
        /// Returns the "Request Selected" button.
        /// </summary>
        public EQ2Button RequestSelected
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:RequestSelected"));
                return new EQ2Button(this.GetMember("RequestSelected"));
            }
        }

        /// <summary>
        /// Returns one of "Leader Only", "Free for all", "Lotto", "Need before Greed",
        /// or "Unknown".
        /// </summary>
        public string Type
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:Type"));
                return this.GetStringFromLSO("Type");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Declines the Lotto
        /// </summary>
        /// <returns>call success</returns>
        public bool DeclineLotto()
        {
            Trace.WriteLine(String.Format("LootWindow:DeclineLotto()"));
            return this.ExecuteMethod("DeclineLotto");
        }

        /// <summary>
        /// Decline Need Before Greed
        /// </summary>
        /// <returns>call success</returns>
        public bool DeclineNBG()
        {
            Trace.WriteLine(String.Format("LootWindow:DeclineLotto()"));
            return this.ExecuteMethod("DeclineNBG");
        }

        /// <summary>
        /// Loots all items in loot window
        /// </summary>
        /// <returns>call success</returns>
        public bool LootAll()
        {
            Trace.WriteLine(String.Format("LootWindow:LootAll()"));
            return this.ExecuteMethod("LootAll");
        }

        /// <summary>
        /// Attempts to loot the item with the specified ID.
        /// </summary>
        /// <param name="id">item ID to loot</param>
        /// <param name="autoConfirmNoTrade">
        /// When true, dispatches the 1-arg form (<c>loot_item id</c>), which
        /// auto-confirms via <c>loot_confirmation</c> if the item has the NoTrade
        /// modifier. When false (default), dispatches the 2-arg form
        /// (<c>loot_item id 0</c>), which leaves NoTrade-confirmation to the player.
        /// </param>
        /// <returns>call success</returns>
        public bool LootItem(int id, bool autoConfirmNoTrade = false)
        {
            Trace.WriteLine(String.Format("LootWindow:LootItem({0}, {1})", id.ToString(CultureInfo.InvariantCulture),
                autoConfirmNoTrade.ToString(CultureInfo.InvariantCulture)));
            return autoConfirmNoTrade
                ? this.ExecuteMethod("LootItem", id.ToString(CultureInfo.InvariantCulture))
                : this.ExecuteMethod("LootItem", id.ToString(CultureInfo.InvariantCulture),
                0.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Click Request All Button. Defaults to LootAll if no RequestAll button.
        /// </summary>
        /// <returns>call success</returns>
        public bool RequestAll()
        {
            Trace.WriteLine(String.Format("LootWindow:RequestAll()"));
            return this.ExecuteMethod("RequestAll");
        }

        /// <summary>
        /// Selects the greed button
        /// </summary>
        /// <returns>call success</returns>
        public bool SelectGreed()
        {
            Trace.WriteLine(String.Format("LootWindow:SelectGreed()"));
            return this.ExecuteMethod("SelectGreed");
        }

        /// <summary>
        /// Selects the need button
        /// </summary>
        /// <returns>call success</returns>
        public bool SelectNeed()
        {
            Trace.WriteLine(String.Format("LootWindow:SelectNeed()"));
            return this.ExecuteMethod("SelectNeed");
        }

        #endregion	

	}
}
