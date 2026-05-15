using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2tabbedpane' datatype. Inherits from EQ2UIPage. Exposes
    /// ActiveTab, LastTab, TargetPage, DataSource.
    /// </summary>
    public class EQ2TabbedPane : EQ2UIPage
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2TabbedPane(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Index of the currently active tab.
        /// </summary>
        public int ActiveTab
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2TabbedPane:ActiveTab"));
                return this.GetIntFromLSO("ActiveTab");
            }
        }

        /// <summary>
        /// Index of the previously active tab.
        /// </summary>
        public int LastTab
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2TabbedPane:LastTab"));
                return this.GetIntFromLSO("LastTab");
            }
        }

        /// <summary>
        /// The target page of the active tab.
        /// </summary>
        public EQ2UIPage TargetPage
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2TabbedPane:TargetPage"));
                return new EQ2UIPage(this.GetMember("TargetPage"));
            }
        }

        /// <summary>
        /// The data source backing the tabbed pane.
        /// </summary>
        public EQ2BaseObject DataSource
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2TabbedPane:DataSource"));
                return new EQ2BaseObject(this.GetMember("DataSource"));
            }
        }

        #endregion

    }
}
