using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using EQ2.ISXEQ2.InventoryConsignment;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to Item Examine windows. 
    /// </summary>
    public class ExamineItemWindow : EQ2CloneWindow
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public ExamineItemWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members
        /// <summary>
        /// Returns the base checkbox of the examine item window.
        /// </summary>
        public EQ2CheckBox GetBaseCheckbox
        {
            get
            {
                Trace.WriteLine(String.Format("ExamineItemWindow:GetBaseCheckbox"));
                return new EQ2CheckBox(this.GetMember("GetBaseCheckbox"));
            }
        }

        /// <summary>
        /// Returns the item being examined as an iteminfo datatype object.
        /// (Note: All members of the iteminfo should be available without
        /// initialization when accessed via the examineitemwindow.)
        /// </summary>
        public ItemInfo ToItem
        {
            get
            {
                Trace.WriteLine(String.Format("ExamineItemWindow:ToItem"));
                return new ItemInfo(this.GetMember("ToItem"));
            }
        }

        /// <summary>
        /// Number of "Texts" in the TextVector. Reads the arg-zero form of the
        /// TextVector member (which returns the count when invoked with no index).
        /// </summary>
        public int TextVectorCount
        {
            get
            {
                Trace.WriteLine(String.Format("ExamineItemWindow:TextVectorCount"));
                return this.GetIntFromLSO("TextVector");
            }
        }

        /// <summary>
        /// Returns the text widget at the specified index in the examine
        /// window's text vector. (1 to TextVectorCount).
        /// </summary>
        /// <param name="index">index (1-based)</param>
        /// <returns>EQ2Text</returns>
        public EQ2Text TextVector(int index)
        {
            Trace.WriteLine(String.Format("ExamineItemWindow:TextVector({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new EQ2Text(this.GetMember("TextVector", index.ToString(CultureInfo.InvariantCulture)));
        }


        #endregion

    }
}
