using System;
using System.Collections.Generic;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using EQ2.ISXEQ2.UI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.Quest
{
    /// <summary>
    /// Wraps the ISXEQ2 'journalcurrentquest' datatype, which exposes the
    /// quest-journal panel's currently-displayed quest as a set of UI text
    /// widgets (each member returns an EQ2Text bound to the live UI element)
    /// plus a single GetDetails method that snapshots the journal's per-step
    /// detail tree into a caller-provided index of maps.
    /// </summary>
    public class CurrentQuest : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public CurrentQuest(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// EQ2Text widget for the quest's body / objectives panel
        /// </summary>
        public EQ2Text Body
        {
            get
            {
                Trace.WriteLine(String.Format("CurrentQuest:Body"));
                return new EQ2Text(this.GetMember("Body"));
            }
        }

        /// <summary>
        /// EQ2Text widget for the quest's journal category
        /// </summary>
        public EQ2Text Category
        {
            get
            {
                Trace.WriteLine(String.Format("CurrentQuest:Category"));
                return new EQ2Text(this.GetMember("Category"));
            }
        }

        /// <summary>
        /// EQ2Text widget for the quest's current-step zone
        /// </summary>
        public EQ2Text CurrentZone
        {
            get
            {
                Trace.WriteLine(String.Format("CurrentQuest:CurrentZone"));
                return new EQ2Text(this.GetMember("CurrentZone"));
            }
        }

        /// <summary>
        /// EQ2Text widget for the quest's expiration time (where applicable)
        /// </summary>
        public EQ2Text ExpirationTime
        {
            get
            {
                Trace.WriteLine(String.Format("CurrentQuest:ExpirationTime"));
                return new EQ2Text(this.GetMember("ExpirationTime"));
            }
        }

        /// <summary>
        /// EQ2Text widget for the quest's level (journal-displayed level)
        /// </summary>
        public EQ2Text Level
        {
            get
            {
                Trace.WriteLine(String.Format("CurrentQuest:Level"));
                return new EQ2Text(this.GetMember("Level"));
            }
        }

        /// <summary>
        /// EQ2Text widget for the quest's mission-group label (where applicable)
        /// </summary>
        public EQ2Text MissionGroup
        {
            get
            {
                Trace.WriteLine(String.Format("CurrentQuest:MissionGroup"));
                return new EQ2Text(this.GetMember("MissionGroup"));
            }
        }

        /// <summary>
        /// EQ2Text widget for the quest's name
        /// </summary>
        public EQ2Text Name
        {
            get
            {
                Trace.WriteLine(String.Format("CurrentQuest:Name"));
                return new EQ2Text(this.GetMember("Name"));
            }
        }

        /// <summary>
        /// EQ2Text widget for the quest's status text
        /// </summary>
        public EQ2Text Status
        {
            get
            {
                Trace.WriteLine(String.Format("CurrentQuest:Status"));
                return new EQ2Text(this.GetMember("Status"));
            }
        }

        /// <summary>
        /// EQ2Text widget for the quest's timestamp display
        /// </summary>
        public EQ2Text TimeStamp
        {
            get
            {
                Trace.WriteLine(String.Format("CurrentQuest:TimeStamp"));
                return new EQ2Text(this.GetMember("TimeStamp"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Snapshots the journal's per-step detail tree for the current quest.
        /// Each returned object is a LavishScript map (keyed by 'Text' plus the
        /// per-row property keys produced by the journal UI). Use member access
        /// like obj.GetStringFromLSO("Text") on each entry to read individual fields.
        /// </summary>
        /// <returns>list of detail-row maps, or null on failure</returns>
        public List<LavishScriptObject> GetDetails()
        {
            Trace.WriteLine(String.Format("CurrentQuest:GetDetails()"));

            using (var index = LavishScript.Objects.NewObject("index:string"))
            {
                if (!this.ExecuteMethod("GetDetails", index.LSReference))
                    return null;

                using (var used = index.GetMember("Used"))
                {
                    if (LavishScriptObject.IsNullOrInvalid(used))
                        return null;
                }

                var count = index.GetMember<int>("Used");
                var list = new List<LavishScriptObject>(count);
                for (var i = 1; i <= count; i++)
                {
                    list.Add(index.GetIndex(i.ToString(System.Globalization.CultureInfo.InvariantCulture)));
                }
                return list;
            }
        }

        #endregion

    }
}
