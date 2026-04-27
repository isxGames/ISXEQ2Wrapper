using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source datatype 'eq2mapwindow' (MapWindowType, declared at
    /// DataTypes.h:4000; INHERITDIRECT(pEQ2CloneWindowType)). Inherits from
    /// EQ2CloneWindow on the wrapper side to match the source inheritance chain.
    /// Note that MapWindowType is one of the few window types declared as plain
    /// LSType rather than LSTypeDef_Ptr; this is irrelevant at the wrapper level.
    /// Exposed via the MapWindow TLO. Members are stubbed empty in this batch
    /// and will be filled in by the dedicated MapWindow audit batch.
    /// </summary>
    public class MapWindow : EQ2CloneWindow
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public MapWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
