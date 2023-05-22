using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using EQ2.ISXEQ2.UI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// This TLO returns a new datatype: 'eq2brokerwindow'. This new datatype inherits all members/methods of the 'eq2window' type.
    /// </summary>
    public class BrokerWindow : EQ2Window
    {
        #region Constructor

        /// <summary>
        /// Constructor - Copies the LavishScript object
        /// </summary>
        /// <param name="Obj">LS Object</param>
        public BrokerWindow(LavishScriptObject Obj) : base(Obj) { }

        /// <summary>
        /// Constructor - Constructs a BrokerWindow object based on the LavishScript object BrokerWindow
        /// </summary>
        public BrokerWindow() : base(LavishScript.Objects.GetObject("BrokerWindow")) { }

        #endregion

        #region Members
        /// <summary>
        /// number of items returned by search (usually 0 to 8)
        /// </summary>
        public int NumSearchResults
        {
            get
            {
                Trace.WriteLine(String.Format("BrokerWindow:NumSearchResults"));
                return this.GetIntFromLSO("NumSearchResults");
            }
        }

        
        /// <summary>
        /// number of the current search page
        /// </summary>
        public int CurrentSearchPage
        {
            get
            {
                Trace.WriteLine(String.Format("BrokerWindow:CurrentSearchPage"));
                return this.GetIntFromLSO("CurrentSearchPage");
            }
        }

        /// <summary>
        /// number of total search pages
        /// </summary>
        public int TotalSearchPages
        {
            get
            {
                Trace.WriteLine(String.Format("BrokerWindow:TotalSearchPages"));
                return this.GetIntFromLSO("TotalSearchPages");
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
        public Consignment SearchResult(int index)
        {
            Trace.WriteLine(String.Format("BrokerWindow:SearchResult({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Consignment(this.GetMember("SearchResult", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// This member returns either a 'consignment' or 'merchandise' object that the 
        /// broker or vendor is currently capable of selling (on the current 'Search Page' 
        /// only, for broker) based upon an exact match of the item name. Only the members
        /// and methods they have in common are available.
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>call success</returns>
        public Consignment SearchResult(string name)
        {
            Trace.WriteLine(String.Format("BrokerWindow:SearchResult({0})", name));
            return new Consignment(this.GetMember("SearchResult", name));
        }


        /// <summary>
        /// Number of your vending containers
        /// </summary>
        public int NumVendingContainers
        {
            get
            {
                Trace.WriteLine(String.Format("BrokerWindow:NumVendingContainers"));
                return this.GetIntFromLSO("NumVendingContainers");
            }
        }

        /// <summary>
        /// Number of items for sale (use with Broker or Merchant 1 to NumItemsForSale)
        /// </summary>
        public int NumItemsForSale
        {
            get
            {
                Trace.WriteLine(String.Format("BrokerWindow:NumItemsForSale"));
                return this.GetIntFromLSO("NumItemsForSale");
            }
        }

        /// <summary>
        /// total capacity for the current selected vendor container
        /// </summary>
        public int TotalVendingCapacity
        {
            get
            {
                Trace.WriteLine(String.Format("BrokerWindow:TotalVendingCapacity"));
                return this.GetIntFromLSO("TotalVendingCapacity");
            }
        }

        /// <summary>
        /// free slots left in the current selected vendor container
        /// </summary>
        public int VendingCapacityFree
        {
            get
            {
                Trace.WriteLine(String.Format("BrokerWindow:VendingCapacityFree"));
                return this.GetIntFromLSO("VendingCapacityFree");
            }
        }

        /// <summary>
        /// slots currently used in the current selected vendor container
        /// </summary>
        public int VendingCapacityUsed
        {
            get
            {
                Trace.WriteLine(String.Format("BrokerWindow:VendingCapacityUsed"));
                return this.GetIntFromLSO("VendingCapacityUsed");
            }
        }

        /// <summary>
        /// # is between 1 and NumVendingContainers (or 6, if you prefer to use the maximum)
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>call success</returns>
        public VendingContainer VendingContainer(int index)
        {
            Trace.WriteLine(String.Format("BrokerWindow:VendingContainer({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new VendingContainer(this.GetMember("VendingContainer", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// name is the name of the vending container
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>call success</returns>
        public VendingContainer VendingContainer(string name)
        {
            Trace.WriteLine(String.Format("BrokerWindow:VendingContainer({0})", name));
            return new VendingContainer(this.GetMember("VendingContainer", name));
        }
        #endregion

        #region Methods
        /// <summary>
        /// Selects the indicated page between 1 and TotalSearchPages (Broker Only)
        /// </summary>
        /// <param name="page">page</param>
        /// <returns>call success</returns>
        public bool GotoSearchPage(int page)
        {
            Trace.WriteLine(String.Format("BrokerWindow:GotoSearchPage({0})", page.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("GotoSearchPage", page.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Changes the active vendor container (Broker Only)
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>call success</returns>
        public bool ChangeActiveVendingContainer(int index)
        {
            Trace.WriteLine(String.Format("BrokerWindow:ChangeActiveVendingContainer({0})", index.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("ChangeActiveVendingContainer", index.ToString(CultureInfo.InvariantCulture));
        }
        #endregion
    }
}
