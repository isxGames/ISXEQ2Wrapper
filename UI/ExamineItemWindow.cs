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
    public class ExamineItemWindow : LavishScriptObject
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
        /// Returns the item being examined as an item datatype object.
        /// (Note:  All members of the item should be available without initialization when accessed via the examineitemwindow.)
        /// </summary>
        public Item ToItem
        {
            get
            {
                Trace.WriteLine(String.Format("ExamineItemWindow:ToItem"));
                return new Item(this.GetMember("ToItem"));
            }
        }

        /// <summary>
        /// Number of "Texts" in the TextVector. Sourced from the source-side
        /// arg-zero form of the TextVector member (which returns the count when
        /// invoked with no index).
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
        /// Returns a "text" eq2uielement type
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>EQ2UIElement</returns>
        public EQ2Widget TextVector(int index)
        {
            Trace.WriteLine(String.Format("ExamineItemWindow:TextVector({0}})", index.ToString(CultureInfo.InvariantCulture)));
            return new EQ2Widget(this.GetMember("TextVector", index.ToString(CultureInfo.InvariantCulture)));
        }


        #endregion

    }
}
