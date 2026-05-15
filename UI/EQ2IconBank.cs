using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2iconbank' datatype. Inherits from EQ2Widget. Exposes
    /// NumIcons and Icon[#] as members.
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
        /// Total number of icons in the bank.
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
