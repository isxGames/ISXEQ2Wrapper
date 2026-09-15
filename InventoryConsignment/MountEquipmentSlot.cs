using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// Wraps the ISXEQ2 'mountequipmentslot' datatype -- a single slot on the Mount page
    /// (Saddle, Hackamore, Reins, Breeching, Stirrup, Shoes, Martingale and Barding1 .. Barding13).
    /// Retrieved from the character via Me.MountEquipment[#] / Me.MountEquipment["slot name"].
    /// </summary>
    /// <remarks>
    /// A slot reads empty (see <see cref="IsEmpty"/>) when no mount is currently summoned. When a slot
    /// holds an item, its detailed info resolves ASYNCHRONOUSLY, exactly like the 'item' datatype:
    /// read <see cref="IsItemInfoAvailable"/> -- that read is what triggers the examine request to the
    /// server. Poll it until it returns TRUE, then read <see cref="ToItemInfo"/> (and any other iteminfo detail).
    /// </remarks>
    public class MountEquipmentSlot : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public MountEquipmentSlot(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Name of the item currently in this slot (empty when the slot is empty).
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("MountEquipmentSlot:Name"));
                return this.GetStringFromLSO("Name");
            }
        }

        /// <summary>
        /// ID of the item currently in this slot.
        /// </summary>
        public int ID
        {
            get
            {
                Trace.WriteLine(String.Format("MountEquipmentSlot:ID"));
                return this.GetIntFromLSO("ID");
            }
        }

        /// <summary>
        /// The slot number this mount-equipment slot occupies.
        /// </summary>
        public int Slot
        {
            get
            {
                Trace.WriteLine(String.Format("MountEquipmentSlot:Slot"));
                return this.GetIntFromLSO("Slot");
            }
        }

        /// <summary>
        /// Returns TRUE when this slot holds no item (for example when no mount is summoned).
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                Trace.WriteLine(String.Format("MountEquipmentSlot:IsEmpty"));
                return this.GetBoolFromLSO("IsEmpty");
            }
        }

        /// <summary>
        /// Returns TRUE once this slot's detailed (examine) info is available client-side.
        /// The first read of this member triggers the examine request to the server; poll it until TRUE
        /// before reading <see cref="ToItemInfo"/>.
        /// </summary>
        public bool IsItemInfoAvailable
        {
            get
            {
                Trace.WriteLine(String.Format("MountEquipmentSlot:IsItemInfoAvailable"));
                return this.GetBoolFromLSO("IsItemInfoAvailable");
            }
        }

        /// <summary>
        /// Returns the ItemInfo (examine data) for the item in this slot. Check <see cref="IsItemInfoAvailable"/> first.
        /// </summary>
        public ItemInfo ToItemInfo
        {
            get
            {
                Trace.WriteLine(String.Format("MountEquipmentSlot:ToItemInfo"));
                return new ItemInfo(this.GetMember("ToItemInfo"));
            }
        }

        /// <summary>
        /// Returns TRUE when this slot is locked (not yet unlocked for the current mount).
        /// </summary>
        public bool IsLocked
        {
            get
            {
                Trace.WriteLine(String.Format("MountEquipmentSlot:IsLocked"));
                return this.GetBoolFromLSO("IsLocked");
            }
        }

        /// <summary>
        /// The mount training rank required to unlock this slot.
        /// </summary>
        public int RequiredRank
        {
            get
            {
                Trace.WriteLine(String.Format("MountEquipmentSlot:RequiredRank"));
                return this.GetIntFromLSO("RequiredRank");
            }
        }

        /// <summary>
        /// Returns TRUE when this slot has an unlock path (i.e. it can be unlocked through mount training).
        /// </summary>
        public bool HasUnlockPath
        {
            get
            {
                Trace.WriteLine(String.Format("MountEquipmentSlot:HasUnlockPath"));
                return this.GetBoolFromLSO("HasUnlockPath");
            }
        }

        #endregion

    }
}
