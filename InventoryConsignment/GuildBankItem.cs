using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// Wraps the ISXEQ2 'guildbankitem' datatype -- a single item sitting in the guild (or coalition) bank.
    /// Retrieved from the character via Me.GuildBank[#] / Me.GuildBank[name].
    /// </summary>
    /// <remarks>
    /// A guild-bank item's detailed info resolves ASYNCHRONOUSLY, exactly like the 'item' datatype.
    /// Open the guild-bank window, then read <see cref="IsItemInfoAvailable"/> -- that read is what triggers
    /// the examine request to the server. Poll it until it returns TRUE, then read <see cref="ToItemInfo"/>
    /// (and any other iteminfo detail).
    /// </remarks>
    public class GuildBankItem : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public GuildBankItem(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The 1-based guild-bank page the item is on (1-4).
        /// </summary>
        public int Page
        {
            get
            {
                Trace.WriteLine(String.Format("GuildBankItem:Page"));
                return this.GetIntFromLSO("Page");
            }
        }

        /// <summary>
        /// The 1-based slot within the page (1-80).
        /// </summary>
        public int Slot
        {
            get
            {
                Trace.WriteLine(String.Format("GuildBankItem:Slot"));
                return this.GetIntFromLSO("Slot");
            }
        }

        /// <summary>
        /// The item LinkID.
        /// </summary>
        public uint LinkID
        {
            get
            {
                Trace.WriteLine(String.Format("GuildBankItem:LinkID"));
                return this.GetUIntFromLSO("LinkID");
            }
        }

        /// <summary>
        /// The item ExamineID.
        /// </summary>
        public uint ExamineID
        {
            get
            {
                Trace.WriteLine(String.Format("GuildBankItem:ExamineID"));
                return this.GetUIntFromLSO("ExamineID");
            }
        }

        /// <summary>
        /// The quantity in the stack.
        /// </summary>
        public int Quantity
        {
            get
            {
                Trace.WriteLine(String.Format("GuildBankItem:Quantity"));
                return this.GetIntFromLSO("Quantity");
            }
        }

        /// <summary>
        /// Returns TRUE if the item is in the COALITION bank (as opposed to the guild bank).
        /// </summary>
        public bool IsCoalition
        {
            get
            {
                Trace.WriteLine(String.Format("GuildBankItem:IsCoalition"));
                return this.GetBoolFromLSO("IsCoalition");
            }
        }

        /// <summary>
        /// Returns TRUE if the item can be deposited.
        /// </summary>
        public bool CanDeposit
        {
            get
            {
                Trace.WriteLine(String.Format("GuildBankItem:CanDeposit"));
                return this.GetBoolFromLSO("CanDeposit");
            }
        }

        /// <summary>
        /// Returns TRUE once this guild-bank item's detailed (examine) info is available client-side.
        /// The first read of this member triggers the examine request to the server; poll it until TRUE
        /// before reading <see cref="ToItemInfo"/>.
        /// </summary>
        public bool IsItemInfoAvailable
        {
            get
            {
                Trace.WriteLine(String.Format("GuildBankItem:IsItemInfoAvailable"));
                return this.GetBoolFromLSO("IsItemInfoAvailable");
            }
        }

        /// <summary>
        /// Returns the ItemInfo (examine data) for this guild-bank item. Check <see cref="IsItemInfoAvailable"/> first.
        /// </summary>
        public ItemInfo ToItemInfo
        {
            get
            {
                Trace.WriteLine(String.Format("GuildBankItem:ToItemInfo"));
                return new ItemInfo(this.GetMember("ToItemInfo"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Withdraws this item from the guild/coalition bank into a specific inventory slot.
        /// The entire stack is withdrawn.
        /// </summary>
        /// <remarks>
        /// Guild vs. coalition is selected automatically from the item (see <see cref="IsCoalition"/>).
        /// </remarks>
        /// <param name="destContainerID">The target inventory slot's InContainerID.</param>
        /// <param name="destSlot">The 1-based slot index within that container.</param>
        /// <returns>call success</returns>
        public bool MoveToInventory(int destContainerID, int destSlot)
        {
            Trace.WriteLine(String.Format("GuildBankItem:MoveToInventory({0}, {1})",
                destContainerID.ToString(CultureInfo.InvariantCulture), destSlot.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("MoveToInventory", destContainerID.ToString(CultureInfo.InvariantCulture),
                destSlot.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Withdraws a quantity of this item from the guild/coalition bank into a specific inventory slot.
        /// </summary>
        /// <remarks>
        /// Guild vs. coalition is selected automatically from the item (see <see cref="IsCoalition"/>).
        /// A quantity of 0 withdraws the entire stack.
        /// </remarks>
        /// <param name="destContainerID">The target inventory slot's InContainerID.</param>
        /// <param name="destSlot">The 1-based slot index within that container.</param>
        /// <param name="quantity">Quantity to withdraw (0 = the entire stack).</param>
        /// <returns>call success</returns>
        public bool MoveToInventory(int destContainerID, int destSlot, int quantity)
        {
            Trace.WriteLine(String.Format("GuildBankItem:MoveToInventory({0}, {1}, {2})",
                destContainerID.ToString(CultureInfo.InvariantCulture), destSlot.ToString(CultureInfo.InvariantCulture),
                quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("MoveToInventory", destContainerID.ToString(CultureInfo.InvariantCulture),
                destSlot.ToString(CultureInfo.InvariantCulture), quantity.ToString(CultureInfo.InvariantCulture));
        }

        #endregion

    }
}
