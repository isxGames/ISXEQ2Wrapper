using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// *** Notes: 
    /// *** 1.  A "ContainerWindow" is any window that says 'Container' on it's name tab.  As of right now, it refers most often to the
    /// ***     'Harvest Supply Depot'.
    /// *** 2.  You may only have one "ContainerWindow" open at a time.
    /// *** 3.  The "ContainerWindow" TLO and related datatypes are only available when the container window is OPEN.  (However, it does 
    /// ***     not matter how far away you are from said container.)
    /// </summary>
    public class ContainerWindow : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public ContainerWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns the ContainerWindowItem at the specified index. (1 to NumItems)
        /// </summary>
        /// <param name="index">index</param>
        public ContainerWindowItem Item(int index)
        {
            Trace.WriteLine(String.Format("ContainerWindow:Item({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new ContainerWindowItem(this.GetMember("Item", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns the ContainerWindowItem by name.
        /// </summary>
        /// <param name="name">name</param>
        public ContainerWindowItem Item(string name)
        {
            Trace.WriteLine(String.Format("ContainerWindow:Item({0})", name));
            return new ContainerWindowItem(this.GetMember("Item", name));
        }

        /// <summary>
        /// The number of ContainerWindowItems in the ContainerWindow
        /// </summary>
        public int NumItems
        {
            get
            {
                Trace.WriteLine(String.Format("ContainerWindow:NumItems"));
                return this.GetIntFromLSO("NumItems");
            }
        }
 
        #endregion

        #region Methods

        /// <summary>
        /// Removes the quantity of the ContainerWindowItem from the ContainerWindow 
        /// </summary>
        /// <param name="itemID">ContainerWindowItem ID</param>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool RemoveItem(int itemID, int quantity)
        {
            Trace.WriteLine(String.Format("ContainerWindow:RemoveItem({0}, {1})", 
                itemID.ToString(CultureInfo.InvariantCulture), quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("RemoveItem",itemID.ToString(CultureInfo.InvariantCulture), 
                quantity.ToString(CultureInfo.InvariantCulture));
        }

        #endregion

    }
}
