using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2dynamicdata' datatype. Inherits directly from
    /// EQ2BaseObject (NOT from EQ2Widget). Exposes Label, Tooltip, IsSet, Percent.
    /// Returned by EQ2DataSourceContainer.GetDynamicData and by character.GetGameData.
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
        /// Tooltip text.
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
        /// Label text.
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
        /// Percent value. Already scaled ×100 by the runtime; caller does NOT need to
        /// multiply again.
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
        /// True when the underlying dynamic-data IsSet flag is set.
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
