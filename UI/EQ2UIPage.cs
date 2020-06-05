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

        /// <summary>
        /// Constructor - Constructs a EQ2Window object based on the LavishScript object EQ2Window
        /// </summary>
        public EQ2Window() : base(LavishScript.Objects.GetObject("EQ2Window")) { }

        #endregion

        #region Members

        /// <summary>
        /// The Child UI Element
        /// </summary>
        /// <param name="type">type</param>
        /// <param name="name">name</param>
        /// <returns>EQ2UIElement</returns>
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

        #endregion

    }
}
