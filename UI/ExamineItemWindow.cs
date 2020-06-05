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
        /// Returns a "checkbox" eq2uielement type.
        /// </summary>
        public EQ2Widget GetPVPCheckbox
        {
            get
            {
                Trace.WriteLine(String.Format("ExamineItemWindow:GetPVPCheckbox"));
                return new EQ2Widget(this.GetMember("GetPVPCheckBox"));
            }
        }

        /// <summary>
        /// Number of "Texts" in the TextVector
        /// </summary>
        public int NumTextVector
        {
            get
            {
                Trace.WriteLine(String.Format("ExamineItemWindow:NumTextVector"));
                return this.GetIntFromLSO("NumTextVector");
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
