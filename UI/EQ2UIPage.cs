using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to User Interface Pages. 
    /// Many times, this refers to UI Windows; however, it is not restricted to that.
    /// </summary>
    public class EQ2UIPage : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2UIPage(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The Child UI Element
        /// </summary>
        /// <param name="type">type</param>
        /// <param name="name">name</param>
        /// <returns>EQ2UIElement</returns>
        public EQ2UIElement Child(EQ2UIElement.ElementType type, string name)
        {
            Trace.WriteLine(String.Format("EQ2UIPage:Child({0}, {1})", type.ToString(), name));
            return new EQ2UIElement(this.GetMember("Child", type.ToString(), name));
        }

        /// <summary>
        /// Returns TRUE if the window is visible
        /// </summary>
        public bool IsVisible
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2UIPage:IsVisible"));
                return this.GetBoolFromLSO("IsVisible");
            }
        }

        #endregion

    }
}
