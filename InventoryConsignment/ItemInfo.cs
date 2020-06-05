using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// Although this datatype is used natively in some parts of EQ2, its primary function is to
    /// store and return item "details".  The client does not need to know these details all of the time,
    /// so when the player examines an item, or when ISXEQ2 requests it, the details are downloaded from
    /// the server and stored in a cache.
    /// </summary>
    public class ItemInfo : LavishScriptObject
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public ItemInfo(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns TRUE if the item can be scribed right now.
        /// It is the responsibility of scripts to check item.IsScribeable
        /// </summary>
        public bool CanScribeNow
        {
            get
            {
                Trace.WriteLine(String.Format("Item:CanScribeNow"));
                return this.GetBoolFromLSO("CanScribeNow");
            }
        }

        /// <summary>
        /// Containers Only. Returns TRUE if the contents of the container are for sale.
        /// It is the responsibility of scripts to check item.IsContainer.
        /// </summary>
        public bool ContentsForSale
        {
            get
            {
                Trace.WriteLine(String.Format("Item:ContentsForSale"));
                return this.GetBoolFromLSO("ContentsForSale");
            }
        }

        /// <summary>
        /// Containers only. The number of empty slots in the container.
        /// It is the responsibility of scripts to check item.IsContainer.
        /// </summary>
        public int EmptySlots
        {
            get
            {
                Trace.WriteLine(String.Format("Item:EmptySlots"));
                return this.GetIntFromLSO("EmptySlots");
            }
        }

        /// <summary>
        /// Cache of Label
        /// </summary>
        private string _label;

        /// <summary>
        /// Item Label (Container).
        /// It is the responsibility of scripts to check item.IsContainer.
        /// </summary>
        public string Label
        {
            get
            {
                Trace.WriteLine(String.Format("Item:Label"));
                return _label ?? (_label = this.GetStringFromLSO("Label"));
            }
        }

        /// <summary>
        /// Cache of IsActivatable
        /// </summary>
        private bool? _isActivatable;

        /// <summary>
        /// Returns TRUE if the item is activatable.
        /// It is the responsibility of scripts to check item.IsUsable
        /// </summary>
        public bool IsActivatable
        {
            get
            {
                Trace.WriteLine(String.Format("Item:IsActivatable"));
                if (!_isActivatable.HasValue)
                    _isActivatable = this.GetBoolFromLSO("IsActivatable");
                return _isActivatable.Value;
            }
        }

        #endregion

    }
}
