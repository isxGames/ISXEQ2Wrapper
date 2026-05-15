using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// Represents a single entry from the CreatesItem array of an ItemInfo (recipe item).
    /// Wraps the ISXEQ2 'createditem' datatype. The datatype coerces to a string when
    /// accessed with no member (yielding the item name), so legacy scripts that treat
    /// CreatesItem(index) as a plain string continue to function unchanged.
    /// </summary>
    public class CreatedItem : LavishScriptObject
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public CreatedItem(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of LinkID
        /// </summary>
        private int? _linkID;

        /// <summary>
        /// The LinkID of the created item.
        /// </summary>
        public int LinkID
        {
            get
            {
                Trace.WriteLine(String.Format("CreatedItem:LinkID"));
                if (!_linkID.HasValue)
                    _linkID = this.GetIntFromLSO("LinkID");
                return _linkID.Value;
            }
        }

        /// <summary>
        /// Cache of LinkID2
        /// </summary>
        private int? _linkID2;

        /// <summary>
        /// The secondary LinkID of the created item.
        /// </summary>
        public int LinkID2
        {
            get
            {
                Trace.WriteLine(String.Format("CreatedItem:LinkID2"));
                if (!_linkID2.HasValue)
                    _linkID2 = this.GetIntFromLSO("LinkID2");
                return _linkID2.Value;
            }
        }

        /// <summary>
        /// Recreates the in-game chat hyperlink for this created item (used typically
        /// with eq2echo or eq2execute).
        /// </summary>
        public string ToLink
        {
            get
            {
                Trace.WriteLine(String.Format("CreatedItem:ToLink"));
                return this.GetStringFromLSO("ToLink");
            }
        }

        /// <summary>
        /// Cache of IconID
        /// </summary>
        private int? _iconID;

        /// <summary>
        /// Icon ID of the created item.
        /// </summary>
        public int IconID
        {
            get
            {
                Trace.WriteLine(String.Format("CreatedItem:IconID"));
                if (!_iconID.HasValue)
                    _iconID = this.GetIntFromLSO("IconID");
                return _iconID.Value;
            }
        }

        /// <summary>
        /// Quantity of the created item produced by the recipe.
        /// </summary>
        public int Quantity
        {
            get
            {
                Trace.WriteLine(String.Format("CreatedItem:Quantity"));
                return this.GetIntFromLSO("Quantity");
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Name of the created item.
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("CreatedItem:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        #endregion
    }
}
