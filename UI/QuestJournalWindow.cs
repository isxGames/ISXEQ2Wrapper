using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2questjournalwindow' datatype. Inherits from EQ2Window.
    /// Exposed via the QuestJournalWindow TLO.
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

        #region Methods

        /// <summary>
        /// Fast bulk retrieval of an ACTIVE quest's ID by its 1-based position in the active-quest list.
        /// </summary>
        /// <param name="index">1-based index into the active-quest list.</param>
        /// <returns>The quest ID at the given index.</returns>
        public uint GetActiveQuestIDs(uint index)
        {
            Trace.WriteLine(String.Format("QuestJournalWindow:GetActiveQuestIDs({0})", index.ToString(CultureInfo.InvariantCulture)));
            return this.GetUIntFromLSO("GetActiveQuestIDs", index.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Fast bulk retrieval of a COMPLETED quest's ID by its 1-based position in the completed-quest list.
        /// </summary>
        /// <param name="index">1-based index into the completed-quest list.</param>
        /// <returns>The quest ID at the given index.</returns>
        public uint GetCompletedQuestIDs(uint index)
        {
            Trace.WriteLine(String.Format("QuestJournalWindow:GetCompletedQuestIDs({0})", index.ToString(CultureInfo.InvariantCulture)));
            return this.GetUIntFromLSO("GetCompletedQuestIDs", index.ToString(CultureInfo.InvariantCulture));
        }

        #endregion

    }
}
