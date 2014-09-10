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
	public class LootWindow : LavishScriptObject
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
        /// Returns TRUE if Lotto Loot
        /// </summary>
        public bool IsLotto
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:IsLotto"));
                return this.GetBoolFromLSO("IsLotto");
            }
        }

        /// <summary>
        /// Returns the item at the index provided. (From 1 to NumItems)
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>Item</returns>
        public Item Item(int index)
        {
            Trace.WriteLine(String.Format("LootWindow:Item({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Item(this.GetMember("Item", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns the item that matches the substring name
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>call success</returns>
        public Item Item(string name)
        {
            Trace.WriteLine(String.Format("LootWindow:Item({0})", name));
            return new Item(this.GetMember("Item", name));
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
        /// Returns the LootWindow as an EQ2UIPage
        /// </summary>
        public EQ2UIPage ToEQ2UIPage
        {
            get
            {
                Trace.WriteLine(String.Format("LootWindow:ToEQ2UIPage"));
                return new EQ2UIPage(this.GetMember("ToEQ2UIPage"));
            }
        }

        /// <summary>
        /// Returns "Free For All" "Lottery" "Need Before Greed" or "Unknown" 
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
        /// Loots the single item in the loot window. This method does
        /// not work for Lotto loot window, only for FreeForAll, LeaderOnly, or Solo.
        /// </summary>
        /// <returns></returns>
        public bool LootItem()
        {
            Trace.WriteLine(String.Format("LootWindow:LootItem()"));
            return this.ExecuteMethod("LootItem");
        }

        /// <summary>
        /// Attempts to loot the item with ID provided
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="lootNoTrade">Loot No Trade Items</param>
        /// <returns>call success</returns>
        public bool LootItem(int id, bool lootNoTrade = false)
        {
            Trace.WriteLine(String.Format("LootWindow:LootItem({0}, {1})", id.ToString(CultureInfo.InvariantCulture),
                lootNoTrade.ToString(CultureInfo.InvariantCulture)));
            return lootNoTrade
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
