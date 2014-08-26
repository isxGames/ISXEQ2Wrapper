using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// This class is a hybrid of the common members and methods of the Merchandise
    /// and Consignment DataTypes to allow the Item() Member of Vendor to work
    /// </summary>
    public class VendorItem : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public VendorItem(LavishScriptObject copy) : base(copy) {}

        #endregion

        #region Members

        /// <summary>
        /// Level
        /// </summary>
        public int Level
        {
            get
            {
                Trace.WriteLine(String.Format("VendorItem:Level"));
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
                Trace.WriteLine(String.Format("VendorItem:LinkID"));
                return this.GetIntFromLSO("LinkID");
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
                Trace.WriteLine(String.Format("VendorItem:Name"));
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
                Trace.WriteLine(String.Format("VendorItem:Price"));
                return this.GetFloatFromLSO("Price");
            }
        }

        /// <summary>
        /// Quantity Available
        /// </summary>
        public int Quantity
        {
            get
            {
                Trace.WriteLine(String.Format("VendorItem:Quantity"));
                return this.GetIntFromLSO("Quantity");
            }
        }

        /// <summary>
        /// This will recreate the actual link used with in game chat channels (used typically with eq2echo or eq2execute).
        /// </summary>
        public string ToLink
        {
            get
            {
                Trace.WriteLine(String.Format("VendorItem:ToLink"));
                return this.GetStringFromLSO("ToLink");
            }
        }

        #endregion

        #region Method

        /// <summary>
        /// Will try to buy 1 of an item
        /// </summary>
        /// <returns>call success</returns>
        public bool Buy()
        {
            Trace.WriteLine(String.Format("VendorItem:Buy()"));
            return this.ExecuteMethod("Buy");
        }

        /// <summary>
        /// Will try to buy the quantity of an item.
        /// Quantity only works for items that are stackable. 
        /// Tf you try to buy more than a stack can hold, Quantity will default to max.
        /// </summary>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool Buy(int quantity)
        {
            Trace.WriteLine(String.Format("VendorItem:Buy({0})", quantity.ToString(CultureInfo.InvariantCulture)));
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

        #endregion

    }
}
