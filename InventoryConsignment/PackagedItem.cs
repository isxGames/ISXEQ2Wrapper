using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// Represents a single packaged item entry on a container/package ItemInfo.
    /// </summary>
    public class PackagedItem : LavishScriptObject
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public PackagedItem(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Packaged item name.
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("PackagedItem:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Cache of IconID
        /// </summary>
        private int? _iconID;

        /// <summary>
        /// Icon ID of the packaged item.
        /// </summary>
        public int IconID
        {
            get
            {
                Trace.WriteLine(String.Format("PackagedItem:IconID"));
                if (!_iconID.HasValue)
                    _iconID = this.GetIntFromLSO("IconID");
                return _iconID.Value;
            }
        }

        /// <summary>
        /// Quantity of the packaged item.
        /// </summary>
        public int Quantity
        {
            get
            {
                Trace.WriteLine(String.Format("PackagedItem:Quantity"));
                return this.GetIntFromLSO("Quantity");
            }
        }

        #endregion
    }
}
