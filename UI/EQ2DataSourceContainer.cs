using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2datasourcecontainer' datatype. EQ2DataSourceContainerType
    /// inherits directly from EQ2BaseObjectType (INHERITDIRECT(pEQ2BaseObjectType)) —
    /// NOT from EQ2WidgetType — so this class derives from EQ2BaseObject. Returned
    /// by the EQ2DataSourceContainer TLO.
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
        /// (e.g. "Self.ZoneLocaleName", "Stats.Haste"). Source: DT-Widgets.cpp:1636-1647
        /// (Dest.Type = pEQ2DynamicDataType).
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
