using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2listbox' datatype. EQ2ListBoxType inherits from
    /// EQ2WidgetType (INHERITDIRECT(pEQ2WidgetType)) and registers Label as a
    /// member and GetOptions as a method. Almost identical to EQ2DropDownBox.
    /// </summary>
    public class EQ2ListBox : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2ListBox(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Label of the currently selected list-box entry (falls back to the
        /// entry's Localtext / text properties if Name is empty).
        /// Source: DT-Widgets.cpp:1407-1441.
        /// </summary>
        public new string Label
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2ListBox:Label"));
                return this.GetStringFromLSO("Label");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Snapshots every list-box option into a list of LavishScript maps.
        /// Each returned map has a 'Name' key plus every property the source CUIData
        /// exposes for that option (read with entry.GetStringFromLSO("key")).
        /// Source: DT-Widgets.cpp:1467-1518 — populates a caller-provided
        /// index:map[string,string]; the wrapper manages the LS-side index.
        /// </summary>
        /// <returns>list of option maps, or null on failure</returns>
        public List<LavishScriptObject> GetOptions()
        {
            Trace.WriteLine(String.Format("EQ2ListBox:GetOptions()"));

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
