using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.Quest
{
    /// <summary>
    /// This DataType wraps the ISXEQ2 'quest' datatype, which exposes a single
    /// entry from the player's quest journal (active or completed). Reach a Quest
    /// instance via the Character or Quest journal accessors. The datatype is
    /// keyed by quest ID; member access falls through to a journal lookup, so
    /// reading members on a stale ID returns invalid.
    /// </summary>
    public class Quest : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Quest(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of Category
        /// </summary>
        private string _category;

        /// <summary>
        /// The journal category this quest is filed under (e.g. "Heritage", "Tradeskill", zone-named categories)
        /// </summary>
        public string Category
        {
            get
            {
                Trace.WriteLine(String.Format("Quest:Category"));
                return _category ?? (_category = this.GetStringFromLSO("Category"));
            }
        }

        /// <summary>
        /// Cache of CurrentZone
        /// </summary>
        private string _currentZone;

        /// <summary>
        /// The zone name shown in the quest journal for the quest's current step
        /// </summary>
        public string CurrentZone
        {
            get
            {
                Trace.WriteLine(String.Format("Quest:CurrentZone"));
                return _currentZone ?? (_currentZone = this.GetStringFromLSO("CurrentZone"));
            }
        }

        /// <summary>
        /// Cache of ID
        /// </summary>
        private uint? _iD;

        /// <summary>
        /// Quest ID
        /// </summary>
        public uint ID
        {
            get
            {
                Trace.WriteLine(String.Format("Quest:ID"));
                if (!_iD.HasValue)
                    _iD = this.GetUIntFromLSO("ID");
                return _iD.Value;
            }
        }

        /// <summary>
        /// Cache of Level
        /// </summary>
        private int? _level;

        /// <summary>
        /// Quest level (the journal-displayed level of the quest)
        /// </summary>
        public int Level
        {
            get
            {
                Trace.WriteLine(String.Format("Quest:Level"));
                if (!_level.HasValue)
                    _level = this.GetIntFromLSO("Level");
                return _level.Value;
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Quest name
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Quest:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Deletes this quest from the journal. Only valid for active quests; does
        /// nothing on completed quests. Internally also picks the next-listed quest
        /// to highlight after the delete (or 0 if none follows).
        /// </summary>
        /// <returns>call success</returns>
        public bool Delete()
        {
            Trace.WriteLine(String.Format("Quest:Delete()"));
            return this.ExecuteMethod("Delete");
        }

        /// <summary>
        /// Selects this quest as the current active-tab selection in the quest journal.
        /// Only valid for active quests.
        /// </summary>
        /// <returns>call success</returns>
        public bool MakeCurrentActiveQuest()
        {
            Trace.WriteLine(String.Format("Quest:MakeCurrentActiveQuest()"));
            return this.ExecuteMethod("MakeCurrentActiveQuest");
        }

        /// <summary>
        /// Selects this quest as the current completed-tab selection in the quest journal.
        /// Only valid for active quests; completed quests are not supported by methods.
        /// </summary>
        /// <returns>call success</returns>
        public bool MakeCurrentCompletedQuest()
        {
            Trace.WriteLine(String.Format("Quest:MakeCurrentCompletedQuest()"));
            return this.ExecuteMethod("MakeCurrentCompletedQuest");
        }

        /// <summary>
        /// Shares this quest with the player's group. Only valid for active quests.
        /// </summary>
        /// <returns>call success</returns>
        public bool Share()
        {
            Trace.WriteLine(String.Format("Quest:Share()"));
            return this.ExecuteMethod("Share");
        }

        #endregion

    }
}
