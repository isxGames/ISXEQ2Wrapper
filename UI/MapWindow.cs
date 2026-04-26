using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source datatype 'eq2mapwindow' (MapWindowType, declared at
    /// DataTypes.h:4000; INHERITDIRECT(pEQ2CloneWindowType) — pEQ2CloneWindowType
    /// itself inherits from pEQ2WindowType, so pEQ2WindowType is the closest
    /// practical wrapper-side base). Note that MapWindowType is one of the
    /// few window types declared as plain LSType rather than LSTypeDef_Ptr.
    /// Exposed via the MapWindow TLO. Members are stubbed empty in this batch
    /// and will be filled in by the dedicated MapWindow audit batch.
    /// </summary>
    public class MapWindow : EQ2Window
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
