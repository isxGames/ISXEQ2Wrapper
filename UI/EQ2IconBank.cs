using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2iconbank' datatype. EQ2IconBankType inherits from
    /// EQ2WidgetType (INHERITDIRECT(pEQ2WidgetType)) and registers NumIcons and
    /// Icon[#] as members. (The 'Test' member is #if MYCOPY-gated and excluded.)
    /// </summary>
    public class EQ2IconBank : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2IconBank(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Total number of icons in the bank. Source: DT-Widgets.cpp:1542-1547.
        /// </summary>
        public int NumIcons
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2IconBank:NumIcons"));
                return this.GetIntFromLSO("NumIcons");
            }
        }

        /// <summary>
        /// Returns the icon at the given 1-based index (1..NumIcons).
        /// Source: DT-Widgets.cpp:1548-1571 (Dest.Type = pEQ2IconType).
        /// </summary>
        /// <param name="index">1-based icon index</param>
        /// <returns>EQ2Icon at the given slot</returns>
        public EQ2Icon Icon(int index)
        {
            Trace.WriteLine(String.Format("EQ2IconBank:Icon({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new EQ2Icon(this.GetMember("Icon", index.ToString(CultureInfo.InvariantCulture)));
        }

        #endregion

    }
}
