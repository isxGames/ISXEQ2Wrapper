using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2datasourcecontainer' datatype. Inherits directly from
    /// EQ2BaseObject (NOT from EQ2Widget). Returned by the EQ2DataSourceContainer TLO.
    /// </summary>
    public class EQ2DataSourceContainer : EQ2BaseObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2DataSourceContainer(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns the dynamic-data entry at the given dotted path
        /// (e.g. "Self.ZoneLocaleName", "Stats.Haste").
        /// </summary>
        /// <param name="name">dotted path name</param>
        /// <returns>EQ2DynamicData at the given path</returns>
        public EQ2DynamicData GetDynamicData(string name)
        {
            Trace.WriteLine(String.Format("EQ2DataSourceContainer:GetDynamicData({0})", name));
            return new EQ2DynamicData(this.GetMember("GetDynamicData", name));
        }

        #endregion

    }
}
