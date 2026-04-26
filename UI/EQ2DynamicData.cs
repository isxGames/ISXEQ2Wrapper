using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2dynamicdata' datatype. EQ2DynamicDataType inherits
    /// directly from EQ2BaseObjectType (INHERITDIRECT(pEQ2BaseObjectType)) — NOT
    /// from EQ2WidgetType — so this class derives from EQ2BaseObject. Registered
    /// members: Label, Tooltip, IsSet, Percent. Returned by
    /// EQ2DataSourceContainer.GetDynamicData and by character.GetGameData.
    /// </summary>
    public class EQ2DynamicData : EQ2BaseObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2DynamicData(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Tooltip text. Source: DT-Widgets.cpp:1692-1697.
        /// </summary>
        public string Tooltip
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2DynamicData:Tooltip"));
                return this.GetStringFromLSO("Tooltip");
            }
        }

        /// <summary>
        /// Label text. Source: DT-Widgets.cpp:1698-1705.
        /// </summary>
        public string Label
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2DynamicData:Label"));
                return this.GetStringFromLSO("Label");
            }
        }

        /// <summary>
        /// Percent value (already scaled ×100 by source — DT-Widgets.cpp:1706-1711
        /// returns Percent*100.0f). Caller does NOT need to multiply again.
        /// </summary>
        public float Percent
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2DynamicData:Percent"));
                return this.GetFloatFromLSO("Percent");
            }
        }

        /// <summary>
        /// True when the underlying CDynamicData's IsSet flag is set.
        /// Source: DT-Widgets.cpp:1712-1717.
        /// </summary>
        public bool IsSet
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2DynamicData:IsSet"));
                return this.GetBoolFromLSO("IsSet");
            }
        }

        #endregion

    }
}
