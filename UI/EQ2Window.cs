using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to User Interface Pages.
    /// Many times, this refers to UI Windows; however, it is not restricted to that.
    /// </summary>
    public class EQ2Window : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2Window(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns the EQ2UIPage that is the base page of the window.
        /// </summary>
        public EQ2UIPage BasePage
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Window:BasePage"));
                return new EQ2UIPage(this.GetMember("BasePage"));
            }
        }

        /// <summary>
        /// The Child UI Element
        /// </summary>
        /// <param name="type">type</param>
        /// <param name="name">name</param>
        /// <returns>EQ2Widget</returns>
        public EQ2Widget Child(EQ2Widget.ElementType type, string name)
        {
            Trace.WriteLine(String.Format("EQ2Window:Child({0}, {1})", type.ToString(), name));
            return new EQ2Widget(this.GetMember("Child", type.ToString(), name));
        }

        /// <summary>
        /// Returns TRUE if the window is visible
        /// </summary>
        public bool IsVisible
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Window:IsVisible"));
                return this.GetBoolFromLSO("IsVisible");
            }
        }

        /// <summary>
        /// Returns the EQ2UIPage that is the root page of the window.
        /// </summary>
        public EQ2UIPage RootPage
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Window:RootPage"));
                return new EQ2UIPage(this.GetMember("RootPage"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Closes the window.
        /// </summary>
        /// <returns>call success</returns>
        public bool Close()
        {
            Trace.WriteLine(String.Format("EQ2Window:Close()"));
            return this.ExecuteMethod("Close");
        }

        #endregion

    }
}
