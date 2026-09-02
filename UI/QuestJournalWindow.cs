using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        /// Bulk-retrieves the raw IDs of every ACTIVE quest. This wraps the LavishScript 'GetActiveQuestIDs'
        /// method, which clears and bulk-fills an index:uint container (passed by name) with each active quest's
        /// raw ID and returns bool for success. The same populate-and-enumerate idiom as EQ2:GetActors. The wrapper
        /// declares the transient index:uint, invokes the method, then reads the populated container's Used count
        /// and its 1-based elements back into the returned list. Quest IDs routinely exceed 2^31, hence uint.
        /// </summary>
        /// <returns>List of active quest IDs, or null if the underlying method fails.</returns>
        public List<uint> GetActiveQuestIDs()
        {
            Trace.WriteLine(String.Format("QuestJournalWindow:GetActiveQuestIDs()"));
            return Util.GetListFromMethod<uint>(this, "GetActiveQuestIDs", "uint");
        }

        /// <summary>
        /// Bulk-retrieves the raw IDs of every COMPLETED quest. This wraps the LavishScript 'GetCompletedQuestIDs'
        /// method, which clears and bulk-fills an index:uint container (passed by name) with each completed quest's
        /// raw ID and returns bool for success. The same populate-and-enumerate idiom as EQ2:GetActors. The wrapper
        /// declares the transient index:uint, invokes the method, then reads the populated container's Used count
        /// and its 1-based elements back into the returned list. Quest IDs routinely exceed 2^31, hence uint.
        /// </summary>
        /// <returns>List of completed quest IDs, or null if the underlying method fails.</returns>
        public List<uint> GetCompletedQuestIDs()
        {
            Trace.WriteLine(String.Format("QuestJournalWindow:GetCompletedQuestIDs()"));
            return Util.GetListFromMethod<uint>(this, "GetCompletedQuestIDs", "uint");
        }

        #endregion

    }
}
