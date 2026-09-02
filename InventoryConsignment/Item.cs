using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.AbilityEffect;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to inventory and equipped items.
    /// </summary>
    public class Item : LavishScriptObject
    {

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Item(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns the RewardWindow as an EQ2Window
        /// </summary>
        public ItemInfo ToItemInfo
        {
            get
            {
                Trace.WriteLine(String.Format("Item:ToItemInfo"));
                return new ItemInfo(this.GetMember("ToItemInfo"));
            }
        }

        /// <summary>
        /// Returns TRUE if Auto Consume is on
        /// </summary>
        public bool AutoConsumeOn
        {
            get
            {
                Trace.WriteLine(String.Format("Item:AutoConsumeOn"));
                return this.GetBoolFromLSO("AutoConsumeOn");
            }
        }

        /// <summary>
        /// Returns the 1-based bag number of the container that holds this item (1 for the first bag, 2 for
        /// the second, and so on), or -1 if the item is not inside a bag.
        /// </summary>
        /// <remarks>
        /// This member is 1-based, matching ISXEQ2's 1-based scripter convention (previously it was 0-based).
        /// "Not in a bag" is still reported as -1 (equipped items, top-level inventory/bank items, items on
        /// the cursor, etc.), so the -1 "no bag" sentinel can never be confused with a real 1-based index.
        /// </remarks>
        public int Bag
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Bag"));
                return this.GetIntFromLSO("Bag");
            }
        }

        /// <summary>
        /// Cache of CanBeRedeemed
        /// </summary>
        private bool? _canBeRedeemed;

        /// <summary>
        /// Returns TRUE if the item can be redeemed
        /// </summary>
        public bool CanBeRedeemed
        {
            get
            {
                Trace.WriteLine(String.Format("Item:CanBeRedeemed"));
                if (!_canBeRedeemed.HasValue)
                    _canBeRedeemed = this.GetBoolFromLSO("CanBeRedeemed");
                return _canBeRedeemed.Value;
            }
        }

        

        /// <summary>
        /// Cache of ContainerID
        /// </summary>
        private int? _containerID;

        /// <summary>
        /// The Container ID of the container
        /// </summary>
        public int ContainerID
        {
            get
            {
                Trace.WriteLine(String.Format("Item:ContainerID"));
                if (!_containerID.HasValue)
                    _containerID = this.GetIntFromLSO("ContainerID");
                return _containerID.Value;
            }
        }

        

        /// <summary>
        /// The effective level of the item.
        /// </summary>
        public int EffectiveLevel
        {
            get
            {
                Trace.WriteLine(String.Format("Item:EffectiveLevel"));
                return this.GetIntFromLSO("EffectiveLevel");
            }
        }

        /// <summary>
        /// The complete name of the item, even for items with very long names whose <see cref="Name"/> can
        /// come back shortened. Falls back to the same value as <see cref="Name"/> if the item's examine info
        /// is not yet available, so it never returns empty.
        /// </summary>
        public string FullName
        {
            get
            {
                Trace.WriteLine(String.Format("Item:FullName"));
                return this.GetStringFromLSO("FullName");
            }
        }

        /// <summary>
        /// Cache of ID
        /// </summary>
        private uint? _iD;

        /// <summary>
        /// The ID of the item.
        /// </summary>
        public uint ID
        {
            get
            {
                Trace.WriteLine(String.Format("Item:ID"));
                if (!_iD.HasValue)
                    _iD = this.GetUIntFromLSO("ID");
                return _iD.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the item currently has one or more adornments attached.
        /// </summary>
        public bool HasAdornments
        {
            get
            {
                Trace.WriteLine(String.Format("Item:HasAdornments"));
                return this.GetBoolFromLSO("HasAdornments");
            }
        }

        /// <summary>
        /// The icon ID of the item.
        /// </summary>
        public int IconID
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IconID"));
                return this.GetIntFromLSO("IconID");
            }
        }

        /// <summary>
        /// Returns TRUE if the item is in a container
        /// </summary>
        public bool InContainer
        {
            get
            {
                Trace.WriteLine(String.Format("Item:InContainer"));
                return this.GetBoolFromLSO("InContainer");
            }
        }

        /// <summary>
        /// ID of parent container
        /// </summary>
        public int InContainerID
        {
            get
            {
                Trace.WriteLine(String.Format("Item:InContainerID"));
                return this.GetIntFromLSO("InContainerID");
            }
        }

        /// <summary>
        /// Cache of Index
        /// </summary>
        private int? _index;

        /// <summary>
        /// A number that represents a unique item number for an item.
        /// e.g. eq2execute "inventory equip 'ItemIndex' 'SlotNumber'"
        /// </summary>
        /// <remarks>
        /// Index is the raw inventory array position used by the move/equip commands, not a slot number, and
        /// stays 0-based (it is NOT affected by the item slot API's move to 1-based indexing).
        /// </remarks>
        public int Index
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Index"));
                if (!_index.HasValue)
                    _index = this.GetIntFromLSO("Index");
                return _index.Value;
            }
        }

        /// <summary>
        /// Identifies if the item is in one of your 6 actual inventory slots
        /// </summary>
        public bool InInventorySlot
        {
            get
            {
                Trace.WriteLine(String.Format("Item:InInventorySlot"));
                return this.GetBoolFromLSO("InInventorySlot");
            }
        }

        /// <summary>
        /// Returns TRUE if the item is an agent.
        /// </summary>
        public bool IsAgent
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsAgent"));
                return this.GetBoolFromLSO("IsAgent");
            }
        }

        /// <summary>
        /// Cache of IsAutoConsumeable
        /// </summary>
        private bool? _isAutoConsumeable;

        /// <summary>
        /// Returns TRUE if the item is auto consumeable
        /// </summary>
        public bool IsAutoConsumeable
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsAutoConsumeable"));
                if (!_isAutoConsumeable.HasValue)
                    _isAutoConsumeable = this.GetBoolFromLSO("IsAutoConsumeable");
                return _isAutoConsumeable.Value;
            }
        }

        /// <summary>
        /// Identifies if the item is a container placed in one of your 12 actual bank slots
        /// </summary>
        public bool IsBankContainer
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsBankContainer"));
                return this.GetBoolFromLSO("IsBankContainer");
            }
        }

        /// <summary>
        /// Cache of IsContainer
        /// </summary>
        private bool? _isContainer;

        /// <summary>
        /// Returns TRUE if the item is a container
        /// </summary>
        public bool IsContainer
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsContainer"));
                if(!_isContainer.HasValue)
                    _isContainer = this.GetBoolFromLSO("IsContainer");
                return _isContainer.Value;
            }
        }

        /// <summary>
        /// Returns TRUE if the item is a familiar.
        /// </summary>
        public bool IsFamiliar
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsFamiliar"));
                return this.GetBoolFromLSO("IsFamiliar");
            }
        }

        /// <summary>
        /// Cache of IsItemFoodOrDrink
        /// </summary>
        private bool? _isFoodOrDrink;

        /// <summary>
        /// Returns TRUE if the item is a food or drink
        /// </summary>
        public bool IsFoodOrDrink
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsFoodOrDrink"));
                if (!_isFoodOrDrink.HasValue)
                    _isFoodOrDrink = this.GetBoolFromLSO("IsFoodOrDrink");
                return _isFoodOrDrink.Value;
            }
        }

        /// <summary>
        /// Returns true if all of this item's datatype members are available
        /// (i.e., if information has been cached from the server.)
        /// </summary>
        /// <remarks>
        /// Emits a deprecation warning at runtime and forwards to
        /// <see cref="IsItemInfoAvailable"/>. Use <see cref="IsItemInfoAvailable"/> instead.
        /// </remarks>
        [Obsolete("Use IsItemInfoAvailable instead. IsInitialized emits a deprecation warning at runtime and forwards to IsItemInfoAvailable.")]
        public bool IsInitialized
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsInitialized"));
                return this.GetBoolFromLSO("IsInitialized");
            }
        }

        /// <summary>
        /// Returns true if all of this item's datatype members are available
        /// (i.e., if information has been cached from the server.)
        /// </summary>
        public bool IsItemInfoAvailable
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsItemInfoAvailable"));
                return this.GetBoolFromLSO("IsItemInfoAvailable");
            }
        }

        /// <summary>
        /// Identifies if the item is a container placed in one of your 6 actual inventory slots
        /// </summary>
        public bool IsInventoryContainer
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsInventoryContainer"));
                return this.GetBoolFromLSO("IsInventoryContainer");
            }
        }

        /// <summary>
        /// Returns TRUE only while the name currently being read (via <see cref="Name"/>) is STILL shortened.
        /// </summary>
        /// <remarks>
        /// This answers "is what I'm reading right now still short?" rather than "was this name ever shortened?".
        /// Check it before comparing <see cref="Name"/> against a name you already know -- if it's TRUE, an
        /// equality test against the full name will fail. Use <see cref="FullName"/> for the complete name.
        /// </remarks>
        public bool IsNameTruncated
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsNameTruncated"));
                return this.GetBoolFromLSO("IsNameTruncated");
            }
        }

        /// <summary>
        /// Returns true if the IsActivatable == TRUE and the item is ready for use
        /// </summary>
        public bool IsReady
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsReady"));
                return this.GetBoolFromLSO("IsReady");
            }
        }

        /// <summary>
        /// Cache of IsScribeable
        /// </summary>
        private bool? _isScribeable;

        /// <summary>
        /// Returns TRUE if the item is scribeable
        /// </summary>
        public bool IsScribeable
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsScribeable"));
                if (!_isScribeable.HasValue)
                    _isScribeable = this.GetBoolFromLSO("IsScribeable");
                return _isScribeable.Value;
            }
        }

        /// <summary>
        /// Identifies if the item is a container placed in one of your 8 actual shared bank slots
        /// </summary>
        public bool IsSharedBankContainer
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsSharedBankContainer"));
                return this.GetBoolFromLSO("IsSharedBankContainer");
            }
        }

        /// <summary>
        /// Returns TRUE if the given 1-based slot is open (IsSlotOpen(1) tests the first slot).
        /// </summary>
        /// <remarks>
        /// This method was ALREADY 1-based and is unchanged by the item slot API's move to 1-based indexing.
        /// </remarks>
        /// <param name="slot">1-based slot number</param>
        /// <returns>TRUE if the slot is open</returns>
        public bool IsSlotOpen(int slot)
        {
            Trace.WriteLine(String.Format("Item:IsOpenSlot({0})", slot.ToString(CultureInfo.InvariantCulture)));
            return this.GetBoolFromLSO("IsSlotOpen", slot.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Returns TRUE if the item is unpackable.
        /// </summary>
        public bool IsUnpackable
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsUnpackable"));
                return this.GetBoolFromLSO("IsUnpackable");
            }
        }

        /// <summary>
        /// Returns TRUE if the item is usable (either useable, or useable when equipped).
        /// </summary>
        public bool IsUsable
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsUsable"));
                return this.GetBoolFromLSO("IsUsable");
            }
        }

        /// <summary>
        /// Returns the item in the given 1-based slot (ItemInSlot(1) returns the item in the first slot).
        /// </summary>
        /// <remarks>
        /// This member is now 1-based, matching ISXEQ2's 1-based scripter convention (previously slot 0 was
        /// the first slot). A slot number below 1 matches nothing.
        /// </remarks>
        /// <param name="slot">1-based slot number</param>
        /// <returns>item in the slot</returns>
        public Item ItemInSlot(int slot)
        {
            Trace.WriteLine(String.Format("Item:ItemInSlot({0})", slot.ToString(CultureInfo.InvariantCulture)));
            return new Item(this.GetMember("ItemInSlot", slot.ToString(CultureInfo.InvariantCulture)));
        }

        

        /// <summary>
        /// Cache of LinkID
        /// </summary>
        private int? _linkID;

        /// <summary>
        /// The item LinkID
        /// </summary>
        public int LinkID
        {
            get
            {
                Trace.WriteLine(String.Format("Item:LinkID"));
                if (!_linkID.HasValue)
                    _linkID = this.GetIntFromLSO("LinkID");
                return _linkID.Value;
            }
        }

        /// <summary>
        /// The display location of the item (e.g., "Inventory", "Bank", or the parent container's name).
        /// </summary>
        public string Location
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Location"));
                return this.GetStringFromLSO("Location");
            }
        }

        /// <summary>
        /// The LocationID of the item. (Equivalent to InContainerID.)
        /// </summary>
        public int LocationID
        {
            get
            {
                Trace.WriteLine(String.Format("Item:LocationID"));
                return this.GetIntFromLSO("LocationID");
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// The name of the item
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// The next open slot in the container, as a 1-based slot number (1 for the first open slot, 2 for the
        /// second, and so on).
        /// </summary>
        /// <remarks>
        /// This member is now 1-based, matching ISXEQ2's 1-based scripter convention (previously the first open
        /// slot was 0). When the container has no open slot (or the item is not a container) the underlying
        /// member returns NULL, which surfaces here as -1.
        /// </remarks>
        public int NextSlotOpen
        {
            get
            {
                Trace.WriteLine(String.Format("Item:NextSlotOpen"));
                return this.GetIntFromLSO("NextSlotOpen");
            }
        }

        /// <summary>
        /// Cache for NumSlots
        /// </summary>
        private int? _numSlots;

        /// <summary>
        /// The number of slots in the container
        /// </summary>
        public int NumSlots
        {
            get
            {
                Trace.WriteLine(String.Format("Item:NumSlots"));
                if (!_numSlots.HasValue)
                    _numSlots = this.GetIntFromLSO("NumSlots");
                return _numSlots.Value;
            }
        }

        /// <summary>
        /// Identifies the number of free slots in a container
        /// </summary>
        public int NumSlotsFree
        {
            get
            {
                Trace.WriteLine(String.Format("Item:NumSlotsFree"));
                return this.GetIntFromLSO("NumSlotsFree");
            }
        }

        /// <summary>
        /// Item Quantity
        /// </summary>
        public int Quantity
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Quantity"));
                return this.GetIntFromLSO("Quantity");
            }
        }

        /// <summary>
        /// Cache of SerialNumber
        /// </summary>
        private long? _serialNumber;

        /// <summary>
        /// Item Serial Number
        /// </summary>
        public long SerialNumber
        {
            get
            {
                Trace.WriteLine(String.Format("Item:SerialNumber"));
                if (!_serialNumber.HasValue)
                    _serialNumber = this.GetInt64FromLSO("SerialNumber");
                return _serialNumber.Value;
            }
        }

        /// <summary>
        /// Returns the current 1-based slot position for the item within its container, or within your inventory.
        /// So, if the item is in a bag that has 20 slots, it will return a number between 1 and 20.
        /// </summary>
        /// <remarks>
        /// This member is now 1-based, matching ISXEQ2's 1-based scripter convention (previously it was 0-based).
        /// Any negative value (e.g. the -1 "no bag" sentinel from <see cref="Bag"/>) is passed straight through,
        /// so a negative slot can never be confused with a real 1-based index.
        /// </remarks>
        public int Slot
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Slot"));
                return this.GetIntFromLSO("Slot");
            }
        }

        /// <summary>
        /// Returns the time in seconds until the item is ready for use
        /// </summary>
        public float TimeUntilReady
        {
            get
            {
                Trace.WriteLine(String.Format("Item:TimeUntilReady"));
                return this.GetFloatFromLSO("TimeUntilReady");
            }
        }

        /// <summary>
        /// This will recreate the actual link used with in game chat channels (used typically with eq2echo or eq2execute).
        /// </summary>
        /// <returns>link</returns>
        public string ToLink
        {
            get
            {
                Trace.WriteLine(String.Format("Item:ToLink"));
                return this.GetStringFromLSO("ToLink");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Activates the item
        /// </summary>
        /// <returns>call success</returns>
        public bool Activate()
        {
            Trace.WriteLine(String.Format("Item:Activate()"));
            return this.ExecuteMethod("Activate");
        }

        /// <summary>
        /// Adds the item as an agent (without confirmation).
        /// </summary>
        /// <remarks>
        /// Dispatches <c>add_agent_item %1%, 0</c> with an extraneous comma — this is
        /// an intentional EQ2-side typo (an annotation in the upstream changelog notes
        /// "there is a typo in the EQ2 client as of January 2020"). The comma matches
        /// the game's expected format; do not attempt to remove it.
        /// </remarks>
        /// <returns>call success</returns>
        public bool AddAgent()
        {
            Trace.WriteLine(String.Format("Item:AddAgent()"));
            return this.ExecuteMethod("AddAgent");
        }

        /// <summary>
        /// Adds the item as an agent.
        /// </summary>
        /// <remarks>
        /// Dispatches <c>add_agent_item %1%, 0</c> with an extraneous comma — this is
        /// an intentional EQ2-side typo (an annotation in the upstream changelog notes
        /// "there is a typo in the EQ2 client as of January 2020"). The comma matches
        /// the game's expected format; do not attempt to remove it.
        /// </remarks>
        /// <param name="withconfirm">with confirmation</param>
        /// <returns>call success</returns>
        public bool AddAgent(bool withconfirm)
        {
            Trace.WriteLine(String.Format("Item:AddAgent({0})", withconfirm.ToString(CultureInfo.InvariantCulture)));
            return withconfirm ? this.ExecuteMethod("AddAgent", "askmefirst") : this.ExecuteMethod("AddAgent");
        }

        /// <summary>
        /// Adds the item as a familiar (without confirmation).
        /// </summary>
        /// <returns>call success</returns>
        public bool AddFamiliar()
        {
            Trace.WriteLine(String.Format("Item:AddFamiliar()"));
            return this.ExecuteMethod("AddFamiliar");
        }

        /// <summary>
        /// Adds the item as a familiar.
        /// </summary>
        /// <param name="withconfirm">with confirmation</param>
        /// <returns>call success</returns>
        public bool AddFamiliar(bool withconfirm)
        {
            Trace.WriteLine(String.Format("Item:AddFamiliar({0})", withconfirm.ToString(CultureInfo.InvariantCulture)));
            return withconfirm ? this.ExecuteMethod("AddFamiliar", "askmefirst") : this.ExecuteMethod("AddFamiliar");
        }

        /// <summary>
        /// Moves the entire item/stack to the first available vendor
        /// </summary>
        /// <returns>call success</returns>
        public bool AddToConsignment()
        {
            Trace.WriteLine(String.Format("Item:AddToConsignment()"));
            return this.ExecuteMethod("AddToConsignment");
        }

        /// <summary>
        /// Moves the quantity of the stack to the first available vendor 
        /// </summary>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool AddToConsignment(int quantity)
        {
            Trace.WriteLine(String.Format("Item:AddToConsignment({0}", quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddToConsignment", quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Moves the quantity of the stack to the vendor/vending container (1 to 6).
        /// </summary>
        /// <remarks>
        /// The second argument accepts EITHER a 1-6 vendor index OR a vendor SerialNumber:
        /// if the value is &lt;= 6 it is treated as an index; otherwise as a SerialNumber.
        /// Use the (int, long) overload when you have a SerialNumber, since high SerialNumbers will overflow int.
        /// </remarks>
        /// <param name="quantity">quantity</param>
        /// <param name="vendorindex">index 1-6</param>
        /// <returns>call success</returns>
        public bool AddToConsignment(int quantity, int vendorindex)
        {
            Trace.WriteLine(String.Format("Item:AddToConsignment({0}, {1})",
                quantity.ToString(CultureInfo.InvariantCulture), vendorindex.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddToConsignment", quantity.ToString(CultureInfo.InvariantCulture),
                vendorindex.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Moves the quantity of the stack to the vendor/vending container identified by SerialNumber (or 1-6 index, if &lt;= 6).
        /// </summary>
        /// <remarks>
        /// The second argument's value determines its mode: &lt;= 6 = vendor index;
        /// otherwise = vendor SerialNumber. Use this long overload to avoid signed-int overflow on high SerialNumbers.
        /// </remarks>
        /// <param name="quantity">quantity</param>
        /// <param name="vendorOrSerial">vendor index 1-6, or vendor SerialNumber</param>
        /// <returns>call success</returns>
        public bool AddToConsignment(int quantity, long vendorOrSerial)
        {
            Trace.WriteLine(String.Format("Item:AddToConsignment({0}, {1})",
                quantity.ToString(CultureInfo.InvariantCulture), vendorOrSerial.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddToConsignment", quantity.ToString(CultureInfo.InvariantCulture),
                vendorOrSerial.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Moves the quantity of the stack to the vendor/vending container (1 to 6) to the stack with
        /// the stack serial number consignment
        /// </summary>
        /// <param name="quantity">quantity</param>
        /// <param name="vendorindex">index</param>
        /// <param name="stackwithserialnumber">serial number of target stack</param>
        /// <returns>call success</returns>
        public bool AddToConsignment(int quantity, int vendorindex, long stackwithserialnumber)
        {
            Trace.WriteLine(String.Format("Item:AddToConsignment({0}, {1}, {2})",
                quantity.ToString(CultureInfo.InvariantCulture), vendorindex.ToString(CultureInfo.InvariantCulture), 
                stackwithserialnumber.ToString(CultureInfo.InvariantCulture)));
            return ExecuteMethod("AddToConsignment", quantity.ToString(CultureInfo.InvariantCulture), 
                vendorindex.ToString(CultureInfo.InvariantCulture), stackwithserialnumber.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Adds the item to a depot
        /// </summary>
        /// <param name="depotID">depot ID</param>
        /// <returns>call success</returns>
        public bool AddToDepot(int depotID)
        {
            Trace.WriteLine(String.Format("Item:AddToDepot({0})", depotID.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddToDepot", depotID.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Adds the quantity of the item to the depot
        /// </summary>
        /// <param name="depotID">depot ID</param>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool AddToDepot(int depotID, int quantity)
        {
            Trace.WriteLine(String.Format("Item:AddToDepot({0}, {1})", depotID.ToString(CultureInfo.InvariantCulture), 
                quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddToDepot", depotID.ToString(CultureInfo.InvariantCulture), 
                quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Used to apply an item to another item
        /// </summary>
        /// <param name="itemID">target item id</param>
        /// <returns>call success</returns>
        public bool ApplyToItem(int itemID)
        {
            Trace.WriteLine(String.Format("Item:AppltToItem({0})", itemID.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("ApplyToItem", itemID.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Consumes the item (Food/Drink)
        /// </summary>
        /// <returns>call success</returns>
        public bool Consume()
        {
            Trace.WriteLine(String.Format("Item:Consume"));
            return this.ExecuteMethod("Consume");
        }

        /// <summary>
        /// Converts the item as an agent (without confirmation).
        /// </summary>
        /// <remarks>
        /// Dispatches <c>convert_agent_item %1%, 0</c> with an extraneous comma — this is
        /// an intentional EQ2-side typo (an annotation in the upstream changelog notes
        /// "there is a typo in the EQ2 client as of January 2020"). The comma matches
        /// the game's expected format; do not attempt to remove it.
        /// </remarks>
        /// <returns>call success</returns>
        public bool ConvertAgent()
        {
            Trace.WriteLine(String.Format("Item:ConvertAgent()"));
            return this.ExecuteMethod("ConvertAgent");
        }

        /// <summary>
        /// Converts the item as an agent.
        /// </summary>
        /// <remarks>
        /// Dispatches <c>convert_agent_item %1%, 0</c> with an extraneous comma — this is
        /// an intentional EQ2-side typo (an annotation in the upstream changelog notes
        /// "there is a typo in the EQ2 client as of January 2020"). The comma matches
        /// the game's expected format; do not attempt to remove it.
        /// </remarks>
        /// <param name="withconfirm">with confirmation</param>
        /// <returns>call success</returns>
        public bool ConvertAgent(bool withconfirm)
        {
            Trace.WriteLine(String.Format("Item:ConvertAgent({0})", withconfirm.ToString(CultureInfo.InvariantCulture)));
            return withconfirm ? this.ExecuteMethod("ConvertAgent", "askmefirst") : this.ExecuteMethod("ConvertAgent");
        }

        /// <summary>
        /// Destroys Item
        /// </summary>
        /// <returns>call success</returns>
        public bool Destroy()
        {
            Trace.WriteLine(String.Format("Item:Destroy"));
            return this.ExecuteMethod("Destroy");
        }

        /// <summary>
        /// Destroys the quantity of an item if it is in a stack
        /// </summary>
        /// <returns>call success</returns>
        public bool Destroy(int quantity)
        {
            Trace.WriteLine(String.Format("Item:Destroy({0})", quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("Destroy", quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Destroys Item with Confirm On
        /// </summary>
        /// <returns>call success</returns>
        public bool DestroyWithConf()
        {
            Trace.WriteLine(String.Format("Item:DestroyWithConf"));
            return this.ExecuteMethod("DestroyWithConf");
        }

        /// <summary>
        /// Applies temporary enchantments after use
        /// </summary>
        /// <param name="itemID">target item ID</param>
        /// <returns>call success</returns>
        public bool EnchantItem(int itemID)
        {
            Trace.WriteLine(String.Format("Item:EnchantItem({0})", itemID.ToString(CultureInfo.InvariantCulture)));
            return ExecuteMethod("EnchantItem", itemID.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Auto Equips the item
        /// </summary>
        /// <returns>call success</returns>
        public bool Equip()
        {
            Trace.WriteLine(String.Format("Item:Equip()"));
            return this.ExecuteMethod("Equip");
        }

        /// <summary>
        /// Equips the item as a familiar.
        /// </summary>
        /// <returns>call success</returns>
        public bool EquipFamiliar()
        {
            Trace.WriteLine(String.Format("Item:EquipFamiliar()"));
            return this.ExecuteMethod("EquipFamiliar");
        }

        /// <summary>
        /// Examines the item
        /// </summary>
        /// <returns>call success</returns>
        public bool Examine()
        {
            Trace.WriteLine(String.Format("Item:Examine()"));
            return this.ExecuteMethod("Examine");
        }

        /// <summary>
        /// Extracts the item using the currently selected target item key (without confirmation).
        /// </summary>
        /// <returns>call success</returns>
        public bool Extract()
        {
            Trace.WriteLine(String.Format("Item:Extract()"));
            return this.ExecuteMethod("Extract");
        }

        /// <summary>
        /// Extracts the item using the currently selected target item key.
        /// </summary>
        /// <param name="withconfirm">with confirmation</param>
        /// <returns>call success</returns>
        public bool Extract(bool withconfirm)
        {
            Trace.WriteLine(String.Format("Item:Extract({0})", withconfirm.ToString(CultureInfo.InvariantCulture)));
            return withconfirm ? this.ExecuteMethod("Extract", "askmefirst") : this.ExecuteMethod("Extract");
        }

        /// <summary>
        /// Adds the item (which must be a vending container and must be in your inventory) to 
        /// your consignment system.  It will place the vending container into the first 
        /// free slot that is available.
        /// </summary>
        /// <returns>call success</returns>
        public bool InstallAsVendingContainer()
        {
            Trace.WriteLine(String.Format("Item:InstallAsVendingContainer()"));
            return this.ExecuteMethod("InstallAsVendingContainer");
        }

        /// <summary>
        /// Moves an item to a particular slot in a bag.
        /// </summary>
        /// <remarks>
        /// The first argument (destination slot within the target container) is now 1-based, matching
        /// ISXEQ2's 1-based scripter convention (previously it was 0-based) -- pass 1 for the first slot.
        /// A value below 1 is rejected; -1 still means "auto-slot" (let the server choose). The second
        /// argument (destination ContainerID / region code) and the optional quantity are NOT indices and
        /// are unchanged. The common pattern still works: Move(item.NextSlotOpen, bag.ContainerID).
        /// </remarks>
        /// <param name="bagslot">1-based destination slot (-1 = auto-slot)</param>
        /// <param name="bagID">bag id / ContainerID</param>
        /// <returns>call success</returns>
        public bool Move(int bagslot, int bagID)
        {
            Trace.WriteLine(String.Format("Item:Move({0}, {1})", bagslot.ToString(CultureInfo.InvariantCulture),
                bagID.ToString(CultureInfo.InvariantCulture)));
            return ExecuteMethod("Move", bagslot.ToString(CultureInfo.InvariantCulture), 
                bagID.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Moves a quantity of a stackable item to a particular slot in a container.
        /// </summary>
        /// <remarks>
        /// The first argument (destination slot) is 1-based (pass 1 for the first slot; -1 = auto-slot;
        /// a value below 1 is rejected). The bag id and quantity are NOT indices and are unchanged.
        /// </remarks>
        /// <param name="bagslot">1-based destination slot (-1 = auto-slot)</param>
        /// <param name="bagID">bag id / ContainerID</param>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool Move(int bagslot, int bagID, int quantity)
        {
            Trace.WriteLine(String.Format("Item:Move({0}, {1}, {2}", bagslot.ToString(CultureInfo.InvariantCulture),
                bagID.ToString(CultureInfo.InvariantCulture), quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("Move", bagslot.ToString(CultureInfo.InvariantCulture),
                bagID.ToString(CultureInfo.InvariantCulture), quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Moves the item(s) to the next free inventory slot of the selected type.
        /// (Use quantity = 0 for non-stackable items.)
        /// </summary>
        /// <param name="invtype">inventory type</param>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool Move(NextFreeType invtype, int quantity)
        {
            Trace.WriteLine(String.Format("Item:Move({0}, {1})", invtype.ToString(),
                quantity.ToString(CultureInfo.InvariantCulture)));
            return ExecuteMethod("Move", invtype.ToString(),
                quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Auto-deposits this item to a region's auto pad (the same as dropping it on the
        /// "auto-inventory"/"auto-bank" pad). The entire stack is moved.
        /// </summary>
        /// <remarks>
        /// GuildBank has no auto pad, so it is not a valid region for MoveAuto -- use <see cref="MoveToBag(int,int)"/>
        /// (the page/slot overload) for the guild bank instead.
        /// </remarks>
        /// <param name="region">Inventory, Bank, or SharedBank.</param>
        /// <returns>call success</returns>
        public bool MoveAuto(MoveRegion region)
        {
            Trace.WriteLine(String.Format("Item:MoveAuto({0})", region.ToString()));
            return this.ExecuteMethod("MoveAuto", region.ToString());
        }

        /// <summary>
        /// Auto-deposits a quantity of this item to a region's auto pad.
        /// </summary>
        /// <remarks>
        /// GuildBank has no auto pad, so it is not a valid region for MoveAuto.
        /// </remarks>
        /// <param name="region">Inventory, Bank, or SharedBank.</param>
        /// <param name="quantity">Quantity to move (0 = the entire stack).</param>
        /// <returns>call success</returns>
        public bool MoveAuto(MoveRegion region, int quantity)
        {
            Trace.WriteLine(String.Format("Item:MoveAuto({0}, {1})", region.ToString(),
                quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("MoveAuto", region.ToString(),
                quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Moves this item into a specific bag of a region (Inventory, Bank, or SharedBank). The entire stack is moved.
        /// </summary>
        /// <param name="region">Inventory, Bank, or SharedBank.</param>
        /// <param name="bag">1-based bag number within the region.</param>
        /// <returns>call success</returns>
        public bool MoveToBag(MoveRegion region, int bag)
        {
            Trace.WriteLine(String.Format("Item:MoveToBag({0}, {1})", region.ToString(),
                bag.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("MoveToBag", region.ToString(), bag.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Moves a quantity of this item into a specific bag of a region (Inventory, Bank, or SharedBank).
        /// </summary>
        /// <param name="region">Inventory, Bank, or SharedBank.</param>
        /// <param name="bag">1-based bag number within the region.</param>
        /// <param name="quantity">Quantity to move (0 = the entire stack).</param>
        /// <returns>call success</returns>
        public bool MoveToBag(MoveRegion region, int bag, int quantity)
        {
            Trace.WriteLine(String.Format("Item:MoveToBag({0}, {1}, {2})", region.ToString(),
                bag.ToString(CultureInfo.InvariantCulture), quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("MoveToBag", region.ToString(), bag.ToString(CultureInfo.InvariantCulture),
                quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Moves this item to a specific page and slot in the GUILD BANK. The entire stack is moved.
        /// </summary>
        /// <remarks>
        /// This is the guild-bank form of MoveToBag (the underlying region is "GuildBank"). The guild bank has
        /// no auto pad, so a page and slot are required.
        /// </remarks>
        /// <param name="page">1-based guild-bank page (1-4).</param>
        /// <param name="slot">1-based slot within the page (1-80).</param>
        /// <returns>call success</returns>
        public bool MoveToBag(int page, int slot)
        {
            Trace.WriteLine(String.Format("Item:MoveToBag(GuildBank, {0}, {1})", page.ToString(CultureInfo.InvariantCulture),
                slot.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("MoveToBag", "GuildBank", page.ToString(CultureInfo.InvariantCulture),
                slot.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Moves a quantity of this item to a specific page and slot in the GUILD BANK.
        /// </summary>
        /// <remarks>
        /// This is the guild-bank form of MoveToBag (the underlying region is "GuildBank").
        /// </remarks>
        /// <param name="page">1-based guild-bank page (1-4).</param>
        /// <param name="slot">1-based slot within the page (1-80).</param>
        /// <param name="quantity">Quantity to move (0 = the entire stack).</param>
        /// <returns>call success</returns>
        public bool MoveToBag(int page, int slot, int quantity)
        {
            Trace.WriteLine(String.Format("Item:MoveToBag(GuildBank, {0}, {1}, {2})", page.ToString(CultureInfo.InvariantCulture),
                slot.ToString(CultureInfo.InvariantCulture), quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("MoveToBag", "GuildBank", page.ToString(CultureInfo.InvariantCulture),
                slot.ToString(CultureInfo.InvariantCulture), quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Opens a container
        /// </summary>
        /// <returns>call success</returns>
        public bool Open()
        {
            Trace.WriteLine(String.Format("Item:Open()"));
            return this.ExecuteMethod("Open");
        }

        /// <summary>
        /// Reads a readable item (e.g., a book).
        /// </summary>
        /// <returns>call success</returns>
        public bool Read()
        {
            Trace.WriteLine(String.Format("Item:Read()"));
            return this.ExecuteMethod("Read");
        }

        /// <summary>
        /// Reclaims adornments from the item using the currently selected target item key (without confirmation).
        /// </summary>
        /// <returns>call success</returns>
        public bool ReclaimAdornments()
        {
            Trace.WriteLine(String.Format("Item:ReclaimAdornments()"));
            return this.ExecuteMethod("ReclaimAdornments");
        }

        /// <summary>
        /// Reclaims adornments from the item using the currently selected target item key.
        /// </summary>
        /// <param name="withconfirm">with confirmation</param>
        /// <returns>call success</returns>
        public bool ReclaimAdornments(bool withconfirm)
        {
            Trace.WriteLine(String.Format("Item:ReclaimAdornments({0})", withconfirm.ToString(CultureInfo.InvariantCulture)));
            return withconfirm ? this.ExecuteMethod("ReclaimAdornments", "askmefirst") : this.ExecuteMethod("ReclaimAdornments");
        }

        /// <summary>
        /// Refines the item using the currently selected target item key (without confirmation).
        /// </summary>
        /// <returns>call success</returns>
        public bool Refine()
        {
            Trace.WriteLine(String.Format("Item:Refine()"));
            return this.ExecuteMethod("Refine");
        }

        /// <summary>
        /// Refines the item using the currently selected target item key.
        /// </summary>
        /// <param name="withconfirm">with confirmation</param>
        /// <returns>call success</returns>
        public bool Refine(bool withconfirm)
        {
            Trace.WriteLine(String.Format("Item:Refine({0})", withconfirm.ToString(CultureInfo.InvariantCulture)));
            return withconfirm ? this.ExecuteMethod("Refine", "askmefirst") : this.ExecuteMethod("Refine");
        }

        /// <summary>
        /// Sacrifices the item.
        /// When <paramref name="withConfirm"/> is true, the in-game client prompts the player for confirmation before the sacrifice is performed.
        /// When false (the default), the sacrifice is performed without any confirmation prompt.
        /// Internally: no-arg form dispatches deity_offer_confirm (with confirmation); the with-arg form dispatches deity_offer (no confirmation).
        /// </summary>
        /// <param name="withConfirm">true to ask the player for confirmation; false (default) to sacrifice without confirmation.</param>
        /// <returns>call success</returns>
        public bool Sacrifice(bool withConfirm = false)
        {
            Trace.WriteLine(String.Format("Item:Sacrifice({0})", withConfirm.ToString(CultureInfo.InvariantCulture)));
            // withConfirm == true  -> no-arg path  (deity_offer_confirm) -> call with NO argument
            // withConfirm == false -> with-arg path (deity_offer)        -> call WITH any argument
            return withConfirm ? this.ExecuteMethod("Sacrifice") : this.ExecuteMethod("Sacrifice", "noConfirm");
        }

        /// <summary>
        /// Salvages the item using the currently selected target item key (without confirmation).
        /// </summary>
        /// <returns>call success</returns>
        public bool Salvage()
        {
            Trace.WriteLine(String.Format("Item:Salvage()"));
            return this.ExecuteMethod("Salvage");
        }

        /// <summary>
        /// Salvages the item using the currently selected target item key.
        /// </summary>
        /// <param name="withconfirm">with confirmation</param>
        /// <returns>call success</returns>
        public bool Salvage(bool withconfirm)
        {
            Trace.WriteLine(String.Format("Item:Salvage({0})", withconfirm.ToString(CultureInfo.InvariantCulture)));
            return withconfirm ? this.ExecuteMethod("Salvage", "askmefirst") : this.ExecuteMethod("Salvage");
        }

        /// <summary>
        /// Scribes the item
        /// </summary>
        /// <returns>call success</returns>
        public bool Scribe()
        {
            Trace.WriteLine(String.Format("Item:Scribe()"));
            return this.ExecuteMethod("Scribe");
        }

        /// <summary>
        /// Attaches the item as a gift. Must be in a mail transaction.
        /// </summary>
        /// <returns>call success</returns>
        public bool SendAsGift()
        {
            Trace.WriteLine(String.Format("Item:SendAsGift()"));
            return this.ExecuteMethod("SendAsGift");
        }

        /// <summary>
        /// Attaches the quantity of a stackable item as a gift. Must be in a mail transaction.
        /// </summary>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool SendAsGift(int quantity)
        {
            Trace.WriteLine(String.Format("Item:SendAsGift({0})", quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("SendAsGift", quantity.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Rebinds this Item variable to the supplied Item ID. Useful for dynamic Item lookups.
        /// </summary>
        /// <param name="itemID">item ID</param>
        /// <returns>call success</returns>
        public bool Set(long itemID)
        {
            Trace.WriteLine(String.Format("Item:Set({0})", itemID.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("Set", itemID.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Sets the equipped familiar's appearance to this familiar.
        /// </summary>
        /// <returns>call success</returns>
        public bool SetAppearanceFamiliar()
        {
            Trace.WriteLine(String.Format("Item:SetAppearanceFamiliar()"));
            return this.ExecuteMethod("SetAppearanceFamiliar");
        }

        /// <summary>
        /// Toggles auto consume on and off. Check with AutoConsumeOn
        /// </summary>
        /// <returns>call success</returns>
        public bool ToggleAutoConsume()
        {
            Trace.WriteLine(String.Format("Item:ToggleAutoConsume()"));
            return this.ExecuteMethod("ToggleAutoConsume");
        }

        /// <summary>
        /// Transmutes the item
        /// </summary>
        /// <param name="withconfirm">with confirmation</param>
        /// <returns>call success</returns>
        public bool Transmute(bool withconfirm)
        {
            Trace.WriteLine(String.Format("Item:Transmute({0})", withconfirm.ToString(CultureInfo.InvariantCulture)));
            return withconfirm ? this.ExecuteMethod("Transmute", "askmefirst") : this.ExecuteMethod("Transmute");
        }

        /// <summary>
        /// UnEquips the item
        /// </summary>
        /// <returns>call success</returns>
        public bool UnEquip()
        {
            Trace.WriteLine(String.Format("Item:UnEquip"));
            return this.ExecuteMethod("UnEquip");
        }

        /// <summary>
        /// Unequips the currently equipped familiar.
        /// </summary>
        /// <returns>call success</returns>
        public bool UnequipFamiliar()
        {
            Trace.WriteLine(String.Format("Item:UnequipFamiliar()"));
            return this.ExecuteMethod("UnequipFamiliar");
        }

        /// <summary>
        /// Unpacks an unpackable item.
        /// </summary>
        /// <returns>call success</returns>
        public bool Unpack()
        {
            Trace.WriteLine(String.Format("Item:Unpack()"));
            return this.ExecuteMethod("Unpack");
        }

        /// <summary>
        /// Clears the appearance-familiar selection.
        /// </summary>
        /// <returns>call success</returns>
        public bool UnsetAppearanceFamiliar()
        {
            Trace.WriteLine(String.Format("Item:UnsetAppearanceFamiliar()"));
            return this.ExecuteMethod("UnsetAppearanceFamiliar");
        }

        /// <summary>
        /// Uses the item
        /// </summary>
        /// <returns>call success</returns>
        public bool Use()
        {
            Trace.WriteLine(String.Format("Item:Use()"));
            return this.ExecuteMethod("Use");
        }

        #endregion

        #region Enums

        /// <summary>
        /// Inventory Types for the Move() Method
        /// </summary>
        public enum NextFreeType
        {
            /// <summary>
            /// Non Bank Inventory
            /// </summary>
            NextFreeNonBank,
            /// <summary>
            /// Bank Inventory
            /// </summary>
            NextFreeInBank
        }

        /// <summary>
        /// Region targets for the MoveToBag() and MoveAuto() Methods. (The guild bank is targeted via the
        /// page/slot MoveToBag overloads, not this enum, since it has no auto pad.)
        /// </summary>
        public enum MoveRegion
        {
            /// <summary>
            /// Personal inventory
            /// </summary>
            Inventory,
            /// <summary>
            /// Personal bank
            /// </summary>
            Bank,
            /// <summary>
            /// Shared bank
            /// </summary>
            SharedBank
        }

        #endregion

    }
}
