using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to items that can be bought from brokers. 
    /// </summary>
    public class Consignment : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Consignment(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members
        /// <summary>
        /// The price of the item, without broker commission, in silver pieces.
        /// </summary>
        public float BasePrice
        {
            get
            {
                Trace.WriteLine(String.Format("Consignment:BasePrice"));
                return this.GetFloatFromLSO("BasePrice");
            }
        }

        /// <summary>
        /// The price of the item, without broker commission, in the following format: #p,#g,#s,#c
        /// </summary>
        public string BasePriceString
        {
            get
            {
                Trace.WriteLine(String.Format("Consignment:BasePriceString"));
                return this.GetStringFromLSO("BasePriceString");
            }
        }

        /// <summary>
        /// Returns TRUE is the item is listed
        /// </summary>
        public bool IsListed
        {
            get
            {
                Trace.WriteLine(String.Format("Consignment:IsListed"));
                return this.GetBoolFromLSO("IsListed");
            }
        }

        /// <summary>
        /// Cache of Level
        /// </summary>
        private int? _level;

        /// <summary>
        /// Level of the consignment
        /// </summary>
        public int Level
        {
            get
            {
                Trace.WriteLine(String.Format("Consignment:Level"));
                if(!_level.HasValue)
                    _level = this.GetIntFromLSO("Level");
                return _level.Value;
            }
        }

        /// <summary>
        /// Link ID
        /// </summary>
        public int LinkID
        {
            get
            {
                Trace.WriteLine(String.Format("Consignment:LinkID"));
                return this.GetIntFromLSO("LinkID");
            }
        }

        /// <summary>
        /// Possible values: "Qeynos" "Freeport" "Kelethin" "Haven" "Neriak" (or "Unknown" which should not be possible) 
        /// </summary>
        public string Market
        {
            get
            {
                Trace.WriteLine(String.Format("Consignment:Market"));
                return this.GetStringFromLSO("Market");
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Consignment name
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Consignment:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// he price of the item, including broker commission, in silver pieces. 
        /// </summary>
        public float Price
        {
            get
            {
                Trace.WriteLine(String.Format("Consignment:Price"));
                return this.GetFloatFromLSO("Price");
            }
        }

        /// <summary>
        /// Item quantity in consignment
        /// </summary>
        public int Quantity
        {
            get
            {
                Trace.WriteLine(String.Format("Consignment:Quantity"));
                return this.GetIntFromLSO("Quantity");
            }
        }

        /// <summary>
        /// Consignment Serial Number
        /// </summary>
        public long SerialNumber
        {
            get
            {
                Trace.WriteLine(String.Format("Consignment:SerialNumber"));
                return this.GetInt64FromLSO("SerialNumber");
            }
        }

        /// <summary>
        /// This will recreate the actual link used with in game chat channels (used typically with eq2echo or eq2execute).
        /// </summary>
        public string ToLink
        {
            get
            {
                Trace.WriteLine(String.Format("Consignment:ToLink"));
                return this.GetStringFromLSO("ToLink");
            }
        }

        /// <summary>
        /// Cache of Value
        /// </summary>
        private float? _value;

        /// <summary>
        /// This is the price (in silver pieces) that an NPC merchant would buy this item from you. 
        /// </summary>
        public float Value
        {
            get
            {
                Trace.WriteLine(String.Format("Consignment:Value"));
                if(!_value.HasValue)
                    _value = this.GetFloatFromLSO("Value");
                return _value.Value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Buys 1 of the items in consignment
        /// </summary>
        /// <returns>call success</returns>
        public bool Buy()
        {
            Trace.WriteLine(String.Format("Consignment:Buy()"));
            return this.ExecuteMethod("Buy");
        }

        /// <summary>
        /// Buys the quantity specified from the consignment.
        /// If # is specified, it is assumed to be the quantity of items to buy.
        /// If the value is large, it will buy as many as are in the selected stack. 
        /// </summary>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool Buy(int quantity)
        {
            Trace.WriteLine(String.Format("Consignment:Buy({0})", quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("Buy", quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// This brings up the 'examine window' for the given item. 
        /// </summary>
        /// <returns>call success</returns>
        public bool Examine()
        {
            Trace.WriteLine(String.Format("Consignment:Examine()"));
            return this.ExecuteMethod("Examine");
        }

        /// <summary>
        /// Lists any item for sale that is currently in your consignment listing. 
        /// </summary>
        /// <returns>call success</returns>
        public bool List()
        {
            Trace.WriteLine(String.Format("Consignment:List()"));
            return this.ExecuteMethod("List");
        }

        /// <summary>
        /// Removes a consignment item from the vendor and places it in your inventory.
        /// </summary>
        /// <returns></returns>
        public bool Remove()
        {
            Trace.WriteLine(String.Format("Consignment:Remove()"));
            return this.ExecuteMethod("Remove");
        }

        /// <summary>
        /// Removes the quantity of a consignment item from the vendor and places it in your inventory.
        /// </summary>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool Remove(int quantity)
        {
            Trace.WriteLine(String.Format("Consignment:Remove({0})", quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("Remove", Quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Sets the price of any consignment item that is currently in your consignment listing. 
        /// The price is one value in silver pieces and it CAN be a float value (eg, 1.20 == 1 silver, 20 copper).
        /// </summary>
        /// <param name="price">price in silver as float</param>
        /// <returns>call success</returns>
        public bool SetPrice(float price)
        {
            Trace.WriteLine(String.Format("Consignment:SetPrice({0})", price.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("SetPrice", price.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Sets the price of any consignment item that is currently in your consignment listing.
        /// The price is one value in silver pieces.
        /// </summary>
        /// <param name="price">price in silver</param>
        /// <returns>call success</returns>
        public bool SetPrice(int price)
        {
            Trace.WriteLine(String.Format("Consignment:SetPrice({0})", price.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("SetPrice", price.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Unlists any consignment item that is currently for sale. 
        /// </summary>
        /// <returns>call success</returns>
        public bool Unlist()
        {
            Trace.WriteLine(String.Format("Consignment:Unlist()"));
            return this.ExecuteMethod("Unlist");
        }

        #endregion
        
    }
}
