using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2list' datatype. Source EQ2ListType inherits from
    /// EQ2WidgetType (INHERITDIRECT(pEQ2WidgetType)) and registers HighlightRow
    /// and GetOptions as methods (no members of its own). HighlightRow currently
    /// lives on the base EQ2Widget for legacy reasons; a future batch will
    /// migrate it here.
    /// </summary>
    public class EQ2List : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2List(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Methods

        /// <summary>
        /// Snapshots every list row into a list of LavishScript maps.
        /// Each returned map has a 'Name' key plus every property the source CUIData
        /// exposes for that row (read with entry.GetStringFromLSO("key")).
        /// Source: DT-Widgets.cpp:961-1012 — populates a caller-provided
        /// index:map[string,string]; the wrapper manages the LS-side index.
        /// </summary>
        /// <returns>list of row maps, or null on failure</returns>
        public List<LavishScriptObject> GetOptions()
        {
            Trace.WriteLine(String.Format("EQ2List:GetOptions()"));

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
