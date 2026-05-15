using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2questjournalwindow' datatype. Inherits from EQ2Window.
    /// Exposed via the QuestJournalWindow TLO. Members are stubbed empty in this
    /// batch and will be filled in by a dedicated QuestJournalWindow audit batch.
    /// </summary>
    public class QuestJournalWindow : EQ2Window
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public QuestJournalWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
