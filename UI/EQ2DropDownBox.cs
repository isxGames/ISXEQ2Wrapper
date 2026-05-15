using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2dropdownbox' datatype. Inherits from EQ2Widget. Exposes
    /// Label as a member and Set / GetOptions as methods.
    /// </summary>
    public class EQ2DropDownBox : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2DropDownBox(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Label of the currently selected drop-down entry (falls back to the
        /// entry's Localtext / text properties if Name is empty).
        /// </summary>
        public new string Label
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2DropDownBox:Label"));
                return this.GetStringFromLSO("Label");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sets the selected entry to the given 0-based index.
        /// </summary>
        /// <param name="index">0-based selection index</param>
        /// <returns>call success</returns>
        public bool Set(int index)
        {
            Trace.WriteLine(String.Format("EQ2DropDownBox:Set({0})", index.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("Set", index.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Snapshots every drop-down option into a list of LavishScript maps.
        /// Each returned map has a 'Name' key plus every property the underlying UI
        /// data exposes for that option (read with entry.GetStringFromLSO("key")).
        /// Internally populates a caller-provided index:map[string,string]; the
        /// wrapper manages the LS-side index.
        /// </summary>
        /// <returns>list of option maps, or null on failure</returns>
        public List<LavishScriptObject> GetOptions()
        {
            Trace.WriteLine(String.Format("EQ2DropDownBox:GetOptions()"));

            using (var index = LavishScript.Objects.NewObject("index:string"))
            {
                if (!this.ExecuteMethod("GetOptions", index.LSReference))
                    return null;

                using (var used = index.GetMember("Used"))
                {
                    if (LavishScriptObject.IsNullOrInvalid(used))
                        return null;
                }

                var count = index.GetMember<int>("Used");
                var list = new List<LavishScriptObject>(count);
                for (var i = 1; i <= count; i++)
                {
                    list.Add(index.GetIndex(i.ToString(CultureInfo.InvariantCulture)));
                }
                return list;
            }
        }

        #endregion

    }
}
