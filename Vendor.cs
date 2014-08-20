using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to vendors within the game. 
    /// For the purposes of ISXEQ2, a vendor is any actor that is capable of selling and/or buying items. 
    /// </summary>
    public class Vendor : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Vendor(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// This member returns a 'consignment' object that the broker is currently capable of selling (on the current 'Search
        /// Page' only) based upon the index of its location within the array.
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>Consignment</returns>
        public Consignment Broker(int index)
        {
            Trace.WriteLine(String.Format("Vendor:Broker({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Consignment(this.GetMember("Broker", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// This member returns a 'consignment' object that the broker is currently capable of selling (on the current 'Search
        /// Page' only) based upon a substring of the item's name.
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>Consignment</returns>
        public Consignment Broker(string name)
        {
            Trace.WriteLine(String.Format("Vendor:Broker({0})", name));
            return new Consignment(this.GetMember("Broker", name));
        }

        /// <summary>
        /// Percent commission. Brokers Only. Non-Brokers will be zero.
        /// </summary>
        public float Commission
        {
            get
            {
                Trace.WriteLine(String.Format("Vendor:Commission"));
                return this.GetFloatFromLSO("Commission");
            }
        }

        /// <summary>
        /// Current Search Page. Brokers only.
        /// </summary>
        public int CurrentSearchPage
        {
            get
            {
                Trace.WriteLine(String.Format("Vendor:CurrentSearchPage"));
                return this.GetIntFromLSO("CurrentSearchPage");
            }
        }

        /// <summary>
        /// Cache of IsBroker
        /// </summary>
        private bool? _isBroker;

        /// <summary>
        /// Returns TRUE if the vendor is a broker (PC)
        /// </summary>
        public bool IsBroker
        {
            get
            {
                Trace.WriteLine(String.Format("Vendor:IsBroker"));
                if(!_isBroker.HasValue)
                    _isBroker = this.GetBoolFromLSO("IsBroker");
                return _isBroker.Value;
            }
        }

        /// <summary>
        /// Cache of IsMerchant
        /// </summary>
        private bool? _isMerchant;

        /// <summary>
        /// Returns TRUE if the vendor is a merchant (NPC)
        /// </summary>
        public bool IsMerchant
        {
            get
            {
                Trace.WriteLine(String.Format("Vendor:IsMerchant"));
                if(!_isMerchant.HasValue)
                    _isMerchant = this.GetBoolFromLSO("IsMerchant");
                return _isMerchant.Value;
            }
        }

        /// <summary>
        /// This member returns either a 'consignment' or 'merchandise' object that the 
        /// broker or vendor is currently capable of selling (on the current 'Search Page' 
        /// only, for broker) based upon the index. Only the members and methods they have
        /// in common are available.
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>call success</returns>
        public VendorItem Item(int index)
        {
            Trace.WriteLine(String.Format("Vendor:Item({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new VendorItem(this.GetMember("Item", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// This member returns either a 'consignment' or 'merchandise' object that the 
        /// broker or vendor is currently capable of selling (on the current 'Search Page' 
        /// only, for broker) based upon an exact match of the item name. Only the members
        /// and methods they have in common are available.
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>call success</returns>
        public VendorItem Item(string name)
        {
            Trace.WriteLine(String.Format("Vendor:Item({0})", name));
            return new VendorItem(this.GetMember("Item", name));
        }

        /// <summary>
        /// Number of items for sale (use with Broker or Merchant 1 to NumItemsForSale)
        /// </summary>
        public int NumItemsForSale
        {
            get
            {
                Trace.WriteLine(String.Format("Vendor:NumItemsForSale"));
                return this.GetIntFromLSO("NumItemsForSale");
            }
        }

        /// <summary>
        /// This member returns a 'merchandise' object that the merchant is currently capable of selling 
        /// (on the current 'Search Page' only) based upon the index of its location within the array. 
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>Merchandise</returns>
        public Merchandise Merchant(int index)
        {
            Trace.WriteLine(String.Format("Vendor:Merchant({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Merchandise(this.GetMember("Merchant", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// This member returns a 'merchandise' object that the merchant is currently capable of selling 
        /// (on the current 'Search Page' only) based upon a substring of the item's name.
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>Merchandise</returns>
        public Merchandise Merchant(string name)
        {
            Trace.WriteLine(String.Format("Vendor:Merchant({0})", name));
            return new Merchandise(this.GetMember("Merchant", name));
        }

        /// <summary>
        /// Total Number of Search Pages (Broker Only)
        /// </summary>
        public int TotalSearchPages
        {
            get
            {
                Trace.WriteLine(String.Format("Vendor:TotalSearchPages"));
                return this.GetIntFromLSO("TotalSearchPages");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Selects the indicated page between 1 and TotalSearchPages (Broker Only)
        /// </summary>
        /// <param name="page">page</param>
        /// <returns>call success</returns>
        public bool GoToSearchPage(int page)
        {
            Trace.WriteLine(String.Format("Vendor:GoToSearchPage({0})", page.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("GoToSearchPage", page.ToString(CultureInfo.InvariantCulture));
        }

        #endregion

    }
}
