using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.InventoryConsignment
{
    /// <summary>
    /// Represents one line of an item's effect-string description block, with an indentation level.
    /// </summary>
    public class ItemEffectString : LavishScriptObject
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public ItemEffectString(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of Text
        /// </summary>
        private string _text;

        /// <summary>
        /// The text of this effect-string line.
        /// </summary>
        public string Text
        {
            get
            {
                Trace.WriteLine(String.Format("ItemEffectString:Text"));
                return _text ?? (_text = this.GetStringFromLSO("Text"));
            }
        }

        /// <summary>
        /// Cache of IndentLevel
        /// </summary>
        private int? _indentLevel;

        /// <summary>
        /// The indentation level of this effect-string line.
        /// </summary>
        public int IndentLevel
        {
            get
            {
                Trace.WriteLine(String.Format("ItemEffectString:IndentLevel"));
                if (!_indentLevel.HasValue)
                    _indentLevel = this.GetIntFromLSO("IndentLevel");
                return _indentLevel.Value;
            }
        }

        #endregion
    }
}
