using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2tabbedpane' datatype. EQ2TabbedPaneType inherits from
    /// EQ2UIPageType (INHERITDIRECT(pEQ2UIPageType)) and registers ActiveTab,
    /// LastTab, TargetPage, DataSource as members.
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
        /// Index of the currently active tab. Source: DT-Widgets.cpp:1272-1276.
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
        /// Index of the previously active tab. Source: DT-Widgets.cpp:1278-1282.
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
        /// The target page of the active tab. Source (DT-Widgets.cpp:1284-1288)
        /// sets Dest.Type to pEQ2UIPageType.
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
        /// The data source backing the tabbed pane. Source (DT-Widgets.cpp:1290-1294)
        /// sets Dest.Type to pEQ2BaseObjectType.
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
