using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// Represents a single adornment currently attached to an item.
    /// </summary>
    public class Adornment : LavishScriptObject
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Adornment(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Adornment name.
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Adornment:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Cache of LinkID
        /// </summary>
        private uint? _linkID;

        /// <summary>
        /// Adornment LinkID.
        /// </summary>
        public uint LinkID
        {
            get
            {
                Trace.WriteLine(String.Format("Adornment:LinkID"));
                if (!_linkID.HasValue)
                    _linkID = this.GetUIntFromLSO("LinkID");
                return _linkID.Value;
            }
        }

        /// <summary>
        /// Cache of IconID
        /// </summary>
        private int? _iconID;

        /// <summary>
        /// Adornment icon ID.
        /// </summary>
        public int IconID
        {
            get
            {
                Trace.WriteLine(String.Format("Adornment:IconID"));
                if (!_iconID.HasValue)
                    _iconID = this.GetIntFromLSO("IconID");
                return _iconID.Value;
            }
        }

        /// <summary>
        /// Cache of SlotIndex
        /// </summary>
        private int? _slotIndex;

        /// <summary>
        /// The slot index that this adornment occupies on the parent item.
        /// </summary>
        public int SlotIndex
        {
            get
            {
                Trace.WriteLine(String.Format("Adornment:SlotIndex"));
                if (!_slotIndex.HasValue)
                    _slotIndex = this.GetIntFromLSO("SlotIndex");
                return _slotIndex.Value;
            }
        }

        /// <summary>
        /// Recreates the in-game chat hyperlink for this adornment (used typically with
        /// eq2echo or eq2execute).
        /// </summary>
        public string ToLink
        {
            get
            {
                Trace.WriteLine(String.Format("Adornment:ToLink"));
                return this.GetStringFromLSO("ToLink");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Opens the examine window for this adornment.
        /// </summary>
        /// <returns>call success</returns>
        public bool Examine()
        {
            Trace.WriteLine(String.Format("Adornment:Examine()"));
            return this.ExecuteMethod("Examine");
        }

        #endregion
    }
}
