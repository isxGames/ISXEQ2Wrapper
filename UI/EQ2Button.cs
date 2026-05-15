using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2button' datatype. Inherits from EQ2Widget. Exposes a
    /// single Text member. All other useful surface comes from EQ2Widget.
    /// </summary>
    public class EQ2Button : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2Button(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The button's display text. Convenience for GetProperty("Text").
        /// </summary>
        public new string Text
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Button:Text"));
                return this.GetStringFromLSO("Text");
            }
        }

        #endregion

    }
}
