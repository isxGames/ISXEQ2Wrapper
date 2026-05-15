using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using EQ2.ISXEQ2.InventoryConsignment;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2inspectplayerwindow' datatype. Inherits from EQ2Window.
    /// Exposed via the InspectPlayerWindow TLO. Provides access to the equipped and
    /// appearance items shown in the inspect-player window via slot indices.
    /// </summary>
    public class InspectPlayerWindow : EQ2Window
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public InspectPlayerWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns the iteminfo for the equipped item in the given slot (1 to 27).
        /// Returns NULL if the slot is empty or the index is out of range.
        /// </summary>
        /// <param name="slot">equipment slot (1-27)</param>
        /// <returns>ItemInfo</returns>
        public ItemInfo EquippedItem(int slot)
        {
            Trace.WriteLine(String.Format("InspectPlayerWindow:EquippedItem({0})", slot.ToString(CultureInfo.InvariantCulture)));
            return new ItemInfo(this.GetMember("EquippedItem", slot.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns the iteminfo for the appearance item in the given slot (1 to 26).
        /// Returns NULL if the slot is empty or the index is out of range.
        /// </summary>
        /// <param name="slot">appearance slot (1-26)</param>
        /// <returns>ItemInfo</returns>
        public ItemInfo AppearanceItem(int slot)
        {
            Trace.WriteLine(String.Format("InspectPlayerWindow:AppearanceItem({0})", slot.ToString(CultureInfo.InvariantCulture)));
            return new ItemInfo(this.GetMember("AppearanceItem", slot.ToString(CultureInfo.InvariantCulture)));
        }

        #endregion

    }
}
