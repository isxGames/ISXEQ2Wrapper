using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to items that can be either bought from or sold to NPC or PC merchants.
    /// </summary>
    public class Merchandise : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Merchandise(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns FALSE if the "not for sale" checkbox/flag is selected for this item 
        /// </summary>
        public bool IsForSale
        {
            get
            {
                Trace.WriteLine(String.Format("Merchandise:IsForSale"));
                return this.GetBoolFromLSO("IsForSale");
            }
        }

        /// <summary>
        /// Merchandise Level
        /// </summary>
        public int Level
        {
            get
            {
                Trace.WriteLine(String.Format("Merchandise:Level"));
                return this.GetIntFromLSO("Level");
            }
        }

        /// <summary>
        /// Link ID
        /// </summary>
        public int LinkID
        {
            get
            {
                Trace.WriteLine(String.Format("Merchandise:LinkID"));
                return this.GetIntFromLSO("LinkID");
            }
        }

        /// <summary>
        /// For stackable items, this number will be the maximum number that a stack can hold. 
        /// Therefore, it is the maximum quantity of said item that can be bought at once.
        /// </summary>
        public int MaxQuantity
        {
            get
            {
                Trace.WriteLine(String.Format("Merchandise:MaxQuantity"));
                return this.GetIntFromLSO("MaxQuantity");
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Merchandise:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// The price of the item in silver pieces.
        /// </summary>
        public float Price
        {
            get
            {
                Trace.WriteLine(String.Format("Merchandise:Price"));
                return this.GetFloatFromLSO("Price");
            }
        }

        /// <summary>
        /// If the item has a status cost, then the format of this string will be #SP,#p,#g,#s,#c. 
        /// Otherwise, the format will be #p,#g,#s,#c
        /// </summary>
        public string PriceString
        {
            get
            {
                Trace.WriteLine(String.Format("Merchandise:PriceString"));
                return GetMember<string>("PriceString");
            }
        }

        /// <summary>
        /// Quantity Available
        /// </summary>
        public int Quantity
        {
            get
            {
                Trace.WriteLine(String.Format("Merchandise:Quantity"));
                return this.GetIntFromLSO("Quantity");
            }
        }

        /// <summary>
        /// Status Cost
        /// </summary>
        public int StatusCost
        {
            get
            {
                Trace.WriteLine(String.Format("Merchandise:StatusCost"));
                return this.GetIntFromLSO("StatusCost");
            }
        }

        /// <summary>
        /// This will recreate the actual link used with in game chat channels (used typically with eq2echo or eq2execute).
        /// </summary>
        public string ToLink
        {
            get
            {
                Trace.WriteLine(String.Format("Merchandise:ToLink"));
                return this.GetStringFromLSO("ToLink");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Will try to buy 1 of an item
        /// </summary>
        /// <returns>call success</returns>
        public bool Buy()
        {
            Trace.WriteLine(String.Format("Merchandise:Buy()"));
            return this.ExecuteMethod("Buy");
        }

        /// <summary>
        /// Will try to buy the quantity of an item.
        /// Quantity only works for items that are stackable. 
        /// f you try to buy more than MaxQuantity, Quantity will default to MaxQuantity.
        /// </summary>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool Buy(int quantity)
        {
            Trace.WriteLine(String.Format("Merchandise:Buy({0})", quantity.ToString(CultureInfo.InvariantCulture)));
            return ExecuteMethod("Buy", quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// This brings up the 'examine window' for the given item. 
        /// </summary>
        /// <returns>call success</returns>
        public bool Examine()
        {
            Trace.WriteLine(String.Format("Merchandise:Examine()"));
            return this.ExecuteMethod("Examine");
        }

        /// <summary>
        /// This datatype method is used to set a piece of store merchandise to be 'for sale'. 
        /// Please note that you should test to see if the merchandise's bool IsForSale is
        ///  already set or not before using this method in order to avoid sending bogus messages 
        /// to the server asking to set an item for sale that's already 'for sale'.
        /// </summary>
        /// <returns>call success</returns>
        public bool ListForSale()
        {
            Trace.WriteLine(String.Format("Merchandise:ListForSale"));
            return this.ExecuteMethod("ListForSale");
        }

        /// <summary>
        /// Will try to buy 1 of the item
        /// </summary>
        /// <returns>call success</returns>
        public bool Sell()
        {
            Trace.WriteLine(String.Format("Merchandise:Sell"));
            return this.ExecuteMethod("Sell");
        }

        /// <summary>
        /// Will try to sell the quantity of the item.
        /// If you try sell more than the current quantity of that stack, 
        /// "Quantity#" will default to the current quantity of the stack. 
        /// </summary>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool Sell(int quantity)
        {
            Trace.WriteLine(String.Format("Merchandise:Sell({0})", quantity.ToString(CultureInfo.InvariantCulture)));
            return ExecuteMethod("Sell", quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// This datatype method is used in conjunction with player stores in order to set the price of a piece of merchandise.
        /// The format is SetPrice[platinum,gold,silver,copper]. 
        /// </summary>
        /// <param name="platinum">platinum</param>
        /// <param name="gold">gold</param>
        /// <param name="silver">silver</param>
        /// <param name="copper">copper</param>
        /// <returns></returns>
        public bool SetPrice(int platinum, int gold, int silver, int copper)
        {
            Trace.WriteLine(String.Format("Merchandise:SetPrice({0}, {1}, {2}, {3})", 
                platinum.ToString(CultureInfo.InvariantCulture), gold.ToString(CultureInfo.InvariantCulture), 
                silver.ToString(CultureInfo.InvariantCulture), copper.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("SetPrice", platinum.ToString(CultureInfo.InvariantCulture),
                gold.ToString(CultureInfo.InvariantCulture), silver.ToString(CultureInfo.InvariantCulture),
                copper.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// This datatype method is used to unlist a piece of store merchandise from the market.
        /// Please note that you should test to see if the merchandise's bool IsForSale is already
        /// set or not before using this method in order to avoid sending bogus messages to the 
        /// server asking to unlist an item that's not currently on the market in the first place.
        /// </summary>
        /// <returns>call success</returns>
        public bool UnListForSale()
        {
            Trace.WriteLine(String.Format("Merchandise:UnListForSale()"));
            return this.ExecuteMethod("UnListForSale");
        }

        #endregion
        
    }
}
