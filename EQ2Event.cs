using System;
using System.Collections.Generic;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This contains Event Handlers and Raisers for all EQ2Events
    /// </summary>
	public class EQ2Event
    {

        #region Constructor/Deconstructor

        /// <summary>
        /// Constructor. Attaches all events.
        /// </summary>
        public EQ2Event()
        {
            Attach("EQ2_ActorSpawned", OnActorSpawned);
            Attach("EQ2_ActorDespawned", OnActorDespawned);
            Attach("EQ2_CastingStarted", OnCastingStarted);
            Attach("EQ2_CastingEnded", OnCastingEnded);
            Attach("EQ2_ActorPowerChange", OnActorPowerChange);
            Attach("EQ2_ActorHealthChange", OnActorHealthChange);
            Attach("EQ2_ActorStanceChange", OnActorStanceChange);
            Attach("EQ2_ActorTargetChange", OnActorTargetChange);
            Attach("EQ2_OnHOWindowStateChange", OnHOWindowStateChanged);
            Attach("EQ2_onQuestOffered", OnQuestOffered);
            Attach("EQ2_ReplyDialogAppeared", OnReplyDialogAppeared);
            Attach("EQ2_ExamineItemWindowAppeared", OnExamineItemWindowAppeared);
            Attach("EQ2_onLootWindowAppeared", OnLootWindowAppeared);
            Attach("EQ2_onInventoryUpdate", OnInventoryUpdate);
            Attach("EQ2_onQuestUpdate", OnQuestOffered);
            Attach("EQ2_FinishedZoning", OnFinishedZoning);
            Attach("EQ2_StartedZoning", OnStartedZoning);
            Attach("EQ2_ExamineAchievement", OnExamineAchievement);
            Attach("EQ2_onTellIgnored", OnTellIgnored);
            Attach("EQ2_onIncomingChatText", OnIncomingChatText);
            Attach("EQ2_onSendMailComplete", OnSendMailComplete);
            Attach("EQ2_onChoiceWindowAppeared", OnChoiceWindowAppeared);
            Attach("EQ2_onAnnouncement", OnAnnouncement);
            Attach("EQ2_onIncomingText", OnIncomingText);
            Attach("EQ2_onRewardWindowAppeared", OnRewardWindowAppeared);
            Attach("EQ2_onMeAfflicted", OnMeAfflicted);
            Attach("EQ2_onGroupMemberAfflicted", OnGroupMemberAfflicted);
            Attach("EQ2_onRaidMemberAfflicted", OnRaidMemberAfflicted);
        }

        /// <summary>
        /// Deconstructor. Detaches all events.
        /// </summary>
        ~EQ2Event()
        {
            Detach("EQ2_ActorSpawned", OnActorSpawned);
            Detach("EQ2_ActorDespawned", OnActorDespawned);
            Detach("EQ2_CastingStarted", OnCastingStarted);
            Detach("EQ2_CastingEnded", OnCastingEnded);
            Detach("EQ2_ActorPowerChange", OnActorPowerChange);
            Detach("EQ2_ActorHealthChange", OnActorHealthChange);
            Detach("EQ2_ActorStanceChange", OnActorStanceChange);
            Detach("EQ2_ActorTargetChange", OnActorTargetChange);
            Detach("EQ2_OnHOWindowStateChange", OnHOWindowStateChanged);
            Detach("EQ2_onQuestOffered", OnQuestOffered);
            Detach("EQ2_ReplyDialogAppeared", OnReplyDialogAppeared);
            Detach("EQ2_ExamineItemWindowAppeared", OnExamineItemWindowAppeared);
            Detach("EQ2_onLootWindowAppeared", OnLootWindowAppeared);
            Detach("EQ2_onInventoryUpdate", OnInventoryUpdate);
            Detach("EQ2_onQuestUpdate", OnQuestUpdate);
            Detach("EQ2_FinishedZoning", OnFinishedZoning);
            Detach("EQ2_StartedZoning", OnStartedZoning);
            Detach("EQ2_ExamineAchievement", OnExamineAchievement);
            Detach("EQ2_onTellIgnored", OnTellIgnored);
            Detach("EQ2_onIncomingChatText", OnIncomingChatText);
            Detach("EQ2_onSendMailComplete", OnSendMailComplete);
            Detach("EQ2_onChoiceWindowAppeared", OnChoiceWindowAppeared);
            Detach("EQ2_onAnnouncement", OnAnnouncement);
            Detach("EQ2_onIncomingText", OnIncomingText);
            Detach("EQ2_onRewardWindowAppeared", OnRewardWindowAppeared);
            Detach("EQ2_onMeAfflicted", OnMeAfflicted);
            Detach("EQ2_onGroupMemberAfflicted", OnGroupMemberAfflicted);
            Detach("EQ2_onRaidMemberAfflicted", OnRaidMemberAfflicted);
        }

        #endregion

        #region Event Handlers and Raisers

        #region EQ2_ActorSpawned

        /// <summary>
        /// EQ2_ActorSpawned Event Handler 
        /// </summary>
        public event EventHandler<ActorSpawnedEventArgs> ActorSpawned;

        /// <summary>
        /// EQ2_Actor Spawned Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnActorSpawned(object sender, LSEventArgs e)
        {
            var temp = ActorSpawned;
            if (temp != null)
                temp(sender, new ActorSpawnedEventArgs(e.Args));
        }

        /// <summary>
        /// EQ2_ActorSpawned Event Args
        /// </summary>
	    public class ActorSpawnedEventArgs : LSEventArgs
	    {
            internal ActorSpawnedEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Actor ID
            /// </summary>
	        public int ID
	        {
                get { return Convert.ToInt32(Args[0]); }
	        }

            /// <summary>
            /// Actor Name
            /// </summary>
            public string Name
            {
                get { return Args[1]; }
            }

            /// <summary>
            /// Actor Level
            /// </summary>
            public int Level
            {
                get { return Convert.ToInt32(Args[2]); }
            }

            /// <summary>
            /// Actor Type
            /// </summary>
            public string Type
            {
                get { return Args[3]; }
            }

	    }

        #endregion

        #region EQ2ActorDespawned

        /// <summary>
        /// EQ2_ActorDespawned Event Handler
        /// </summary>
        public event EventHandler<ActorDespawnedEventArgs> ActorDespawned;

        /// <summary>
        /// EQ2_ActorDespawned Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnActorDespawned(object sender, LSEventArgs e)
        {
            var temp = ActorDespawned;
            if (temp != null)
                temp(sender, new ActorDespawnedEventArgs(e.Args));
        }

        /// <summary>
        /// EQ2_ActorDespawned Event Args
        /// </summary>
	    public class ActorDespawnedEventArgs : LSEventArgs
	    {
	        internal ActorDespawnedEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Actor ID
            /// </summary>
	        public int ID
	        {
                get { return Convert.ToInt32(Args[0]); }
	        }

            /// <summary>
            /// Name
            /// </summary>
            public string Name
            {
                get { return Args[1]; }
            }
	    }


        #endregion

        #region EQ2_CastingStarted

        /// <summary>
        /// EQ2_CastingStarted Event Handler
        /// </summary>
        public event EventHandler<LSEventArgs> CastingStarted;

        /// <summary>
        /// EQ2_CastingStarted Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnCastingStarted(object sender, LSEventArgs e)
        {
            var temp = CastingStarted;
            if (temp != null)
                temp(sender, e);
        }

        #endregion

        #region EQ2_CastingEnded

        /// <summary>
        /// EQ2_CastingEnded Event Handler
        /// </summary>
        public event EventHandler<LSEventArgs> CastingEnded;

        /// <summary>
        /// EQ2_CastingEnded Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnCastingEnded(object sender, LSEventArgs e)
        {
            var temp = CastingEnded;
            if (temp != null)
                temp(sender, e);
        }

        #endregion

        #region EQ2_ActorPowerChange

        /// <summary>
        /// EQ2_ActorPowerChange Event Handler. Requires ISXEQ2.EnableActorEvents().
        /// Disabled by default.
        /// </summary>
        public event EventHandler<ActorPowerChangeEventArgs> ActorPowerChange;

        /// <summary>
        /// EQ2_ActorPowerChange Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnActorPowerChange(object sender, LSEventArgs e)
        {
            var temp = ActorPowerChange;
            if (temp != null)
                temp(sender, new ActorPowerChangeEventArgs(e.Args));
        }

        /// <summary>
        /// EQ2_ActorPowerChange Event Args
        /// </summary>
	    public class ActorPowerChangeEventArgs : LSEventArgs
	    {
            internal ActorPowerChangeEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Actor ID
            /// </summary>
	        public int ID
	        {
                get { return Convert.ToInt32(Args[0]); }
	        }

            /// <summary>
            /// Actor Name
            /// </summary>
	        public string Name
	        {
                get { return Args[1]; }
	        }

            /// <summary>
            /// Actor Type
            /// </summary>
            public string Type
            {
                get { return Args[2]; }
            }

            /// <summary>
            /// Actor Old Power
            /// </summary>
            public int OldPower
            {
                get { return Convert.ToInt32(Args[3]); }
            }

            /// <summary>
            /// Actor New Power
            /// </summary>
            public int NewPower
            {
                get { return Convert.ToInt32(Args[4]); }
            }

            /// <summary>
            /// Distance to Actor
            /// </summary>
            public float Distance
            {
                get { return Convert.ToSingle(Args[5]); }
            }

            /// <summary>
            /// Returns TRUE if the actor is in the characters group
            /// </summary>
            public bool IsInGroup
            {
                get { return Convert.ToBoolean(Args[6]); }
            }

            /// <summary>
            /// Returns TRUE if the actor is in the characters raid
            /// </summary>
            public bool IsInRaid
            {
                get { return Convert.ToBoolean(Args[7]); }
            }

	    }

        #endregion

        #region EQ2_ActorHealthChange

        /// <summary>
        /// EQ2_ActorHealthChange Event Handler. Requires ISXEQ2.EnableActorEvents().
        /// Disabled by default.
        /// </summary>
        public event EventHandler<ActorHealthChangeEventArgs> ActorHealthChange;

        /// <summary>
        /// EQ2_ActorHealthChange Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnActorHealthChange(object sender, LSEventArgs e)
        {
            var temp = ActorHealthChange;
            if (temp != null)
                temp(sender, new ActorHealthChangeEventArgs(e.Args));
        }

        /// <summary>
        /// EQ2_ActorHealthChange Event Args
        /// </summary>
        public class ActorHealthChangeEventArgs : LSEventArgs
        {
            internal ActorHealthChangeEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Actor ID
            /// </summary>
            public int ID
            {
                get { return Convert.ToInt32(Args[0]); }
            }

            /// <summary>
            /// Actor Name
            /// </summary>
            public string Name
            {
                get { return Args[1]; }
            }

            /// <summary>
            /// Actor Type
            /// </summary>
            public string Type
            {
                get { return Args[2]; }
            }

            /// <summary>
            /// Actor Old Power
            /// </summary>
            public int OldHealth
            {
                get { return Convert.ToInt32(Args[3]); }
            }

            /// <summary>
            /// Actor New Power
            /// </summary>
            public int NewHealth
            {
                get { return Convert.ToInt32(Args[4]); }
            }

            /// <summary>
            /// Distance to Actor
            /// </summary>
            public float Distance
            {
                get { return Convert.ToSingle(Args[5]); }
            }

            /// <summary>
            /// Returns TRUE if the actor is in the characters group
            /// </summary>
            public bool IsInGroup
            {
                get { return Convert.ToBoolean(Args[6]); }
            }

            /// <summary>
            /// Returns TRUE if the actor is in the characters raid
            /// </summary>
            public bool IsInRaid
            {
                get { return Convert.ToBoolean(Args[7]); }
            }

        }

        #endregion

        #region EQ2_ActorStanceChange

        /// <summary>
        /// EQ2_ActorStanceChange Event Handler. Requires ISXEQ2.EnableActorEvents().
        /// Disabled by default.
        /// </summary>
        public event EventHandler<ActorStanceChangeEventArgs> ActorStanceChange;

        /// <summary>
        /// EQ2_ActorStanceChange Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnActorStanceChange(object sender, LSEventArgs e)
        {
            var temp = ActorStanceChange;
            if (temp != null)
                temp(sender, new ActorStanceChangeEventArgs(e.Args));
        }

        /// <summary>
        /// EQ2_ActorStanceChange Event Args
        /// </summary>
	    public class ActorStanceChangeEventArgs : LSEventArgs
	    {
            internal ActorStanceChangeEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Actor ID
            /// </summary>
            public int ID
            {
                get { return Convert.ToInt32(Args[0]); }
            }

            /// <summary>
            /// Actor Name
            /// </summary>
            public string Name
            {
                get { return Args[1]; }
            }

            /// <summary>
            /// Actor Type
            /// </summary>
            public string Type
            {
                get { return Args[2]; }
            }

            /// <summary>
            /// Actor Old Stance (IN_COMBAT, AT_PEACE, DEAD)
            /// </summary>
            public int OldStance
            {
                get { return Convert.ToInt32(Args[3]); }
            }

            /// <summary>
            /// Actor New Power (IN_COMBAT, AT_PEACE, DEAD)
            /// </summary>
            public int NewStance
            {
                get { return Convert.ToInt32(Args[4]); }
            }

            /// <summary>
            /// Target ID
            /// </summary>
	        public int TargetID
	        {
                get { return Convert.ToInt32(Args[5]); }
	        }

            /// <summary>
            /// Distance to Actor
            /// </summary>
	        public float Distance
	        {
                get { return Convert.ToSingle(Args[6]); }
	        }

            /// <summary>
            /// Returns TRUE if the actor is in the characters group
            /// </summary>
            public bool IsInGroup
            {
                get { return Convert.ToBoolean(Args[7]); }
            }

            /// <summary>
            /// Returns TRUE if the actor is in the characters raid
            /// </summary>
            public bool IsInRaid
            {
                get { return Convert.ToBoolean(Args[8]); }
            }

	    }

        #endregion

        #region EQ2_ActorTargetChange

        /// <summary>
        /// EQ2_ActorTargetChange Event Handler. Requires ISXEQ2.EnableActorEvents().
        /// Disabled by default.
        /// </summary>
        public event EventHandler<ActorTargetChangeEventArgs> ActorTargetChange;

        /// <summary>
        /// EQ2_ActorTargetChange Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnActorTargetChange(object sender, LSEventArgs e)
        {
            var temp = ActorTargetChange;
            if (temp != null)
                temp(sender, new ActorTargetChangeEventArgs(e.Args));
        }

        /// <summary>
        /// EQ2_ActorTargetChange Event Args
        /// </summary>
        public class ActorTargetChangeEventArgs : LSEventArgs
        {
            internal ActorTargetChangeEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Actor ID
            /// </summary>
            public int ID
            {
                get { return Convert.ToInt32(Args[0]); }
            }

            /// <summary>
            /// Actor Name
            /// </summary>
            public string Name
            {
                get { return Args[1]; }
            }

            /// <summary>
            /// Actor Type
            /// </summary>
            public string Type
            {
                get { return Args[2]; }
            }

            /// <summary>
            /// Actor Old Power
            /// </summary>
            public int OldTargetID
            {
                get { return Convert.ToInt32(Args[3]); }
            }

            /// <summary>
            /// Actor New Power
            /// </summary>
            public int NewTargetID
            {
                get { return Convert.ToInt32(Args[4]); }
            }

            /// <summary>
            /// Distance to Actor
            /// </summary>
            public float Distance
            {
                get { return Convert.ToSingle(Args[5]); }
            }

            /// <summary>
            /// Returns TRUE if the actor is in the characters group
            /// </summary>
            public bool IsInGroup
            {
                get { return Convert.ToBoolean(Args[6]); }
            }

            /// <summary>
            /// Returns TRUE if the actor is in the characters raid
            /// </summary>
            public bool IsInRaid
            {
                get { return Convert.ToBoolean(Args[7]); }
            }

        }

        #endregion

        #region EQ2_OnHOWindowStateChanged

        /// <summary>
        /// EQ2_OnHOWindowStateChanged Event Handler
        /// </summary>
        public event EventHandler<LSEventArgs> HOWindowStateChanged;

        /// <summary>
        /// EQ2_OnHOWindowStateChanged Event Raiser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
	    protected virtual void OnHOWindowStateChanged(object sender, LSEventArgs e)
	    {
	        var temp = HOWindowStateChanged;
	        if (temp != null)
	            temp(sender, e);
	    }

        #endregion

        #region EQ2_ExamineAchievement

        /// <summary>
        /// EQ2_ExamineAchievement Event Handler
        /// </summary>
	    public event EventHandler<LSEventArgs> ExamineAchievement;

        /// <summary>
        /// EQ2_ExamineAchievement Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
	    protected virtual void OnExamineAchievement(object sender, LSEventArgs e)
	    {
	        var temp = ExamineAchievement;
	        if (temp != null)
	            temp(sender, e);
	    }

        /// <summary>
        /// EQ2_ExamineAchievement Event Args
        /// </summary>
	    public class ExamineAchievementEventArgs : LSEventArgs
	    {
            internal ExamineAchievementEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Achievement Type
            /// </summary>
	        public string Type
	        {
                get { return Args[0]; }
	        }

            /// <summary>
            /// Achievement ID
            /// </summary>
	        public string ID
	        {
                get { return Args[1]; }
	        }
	    }

        #endregion

        #region EQ2_onQuestOffered

        /// <summary>
        /// EQ2_onQuestOffered Event Handler
        /// </summary>
        public event EventHandler<QuestOfferedEventArgs> QuestOffered;

        /// <summary>
        /// EQ2_onQuestOffered Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnQuestOffered(object sender, LSEventArgs e)
        {
            var temp = QuestOffered;
            if (temp != null)
                temp(sender, new QuestOfferedEventArgs(e.Args));
        }

        /// <summary>
        /// Event Agruments for EQ2_onQuestOffered
        /// </summary>
	    public class QuestOfferedEventArgs : LSEventArgs
	    {
            internal QuestOfferedEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Quest Name
            /// </summary>
	        public string Name
	        {
                get { return Args[0]; }
	        }

            /// <summary>
            /// Quest Description
            /// </summary>
            public string Description
            {
                get { return Args[1]; }
            }

            /// <summary>
            /// Quest Level
            /// </summary>
            public int Level
            {
                get { return Convert.ToInt32(Args[2]); }
            }

            /// <summary>
            /// Status Reward
            /// </summary>
            public int Status
            {
                get { return Convert.ToInt32(Args[3]); }
            }

	    }

        #endregion

        #region EQ2_ReplyDialogAppeared

        /// <summary>
        /// EQ2_ReplyDialogAppeared Event Handler
        /// </summary>
	    public event EventHandler<ReplyDialogAppearedEventArgs> ReplyDialogAppeared;

        /// <summary>
        /// EQ2_ReplyDialogAppeared Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
	    protected virtual void OnReplyDialogAppeared(object sender, LSEventArgs e)
	    {
	        var temp = ReplyDialogAppeared;
            if(temp != null)
                temp(sender, new ReplyDialogAppearedEventArgs(e.Args));
	    }

        /// <summary>
        /// EQ2_ReplyDialogAppeared Event Args
        /// </summary>
	    public class ReplyDialogAppearedEventArgs : LSEventArgs
	    {
            internal ReplyDialogAppearedEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Window ID
            /// </summary>
            public int WindowID
            {
                get { return Convert.ToInt32(Args[0]); }
            }

	    }

        #endregion

        #region EQ2_ExamineItemWindowAppeared

        /// <summary>
        /// EQ2_ExamineItemWindowAppeared Event Handler
        /// </summary>
	    public event EventHandler<ExamineItemWindowAppearedEventArgs> ExamineItemWindowAppeared;

        /// <summary>
        /// EQ2_ExamineItemWindowAppeared Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
	    protected virtual void OnExamineItemWindowAppeared(object sender, LSEventArgs e)
	    {
	        var temp = ExamineItemWindowAppeared;
            if(temp != null)
                temp(sender, new ExamineItemWindowAppearedEventArgs(e.Args));
	    }

        /// <summary>
        /// EQ2_ExamineItemWindowAppeared Event Args
        /// </summary>
	    public class ExamineItemWindowAppearedEventArgs : LSEventArgs
	    {
            internal ExamineItemWindowAppearedEventArgs(params string[] args) { }

            /// <summary>
            /// Item Name
            /// </summary>
	        public string ItemName
	        {
                get { return Args[0]; }
	        }

            /// <summary>
            /// Window ID
            /// </summary>
	        public int WindowID
	        {
                get { return Convert.ToInt32(Args[1]); }
	        }

	    }

        #endregion

        #region EQ2_onLootWindowAppeared

        /// <summary>
        /// EQ2_onLootWindowAppeared Event Handler
        /// </summary>
        public event EventHandler<LootWindowAppearedArgs> LootWindowAppeared;

        /// <summary>
        /// EQ2_onLootWindowAppeared Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnLootWindowAppeared(object sender, LSEventArgs e)
        {
            var temp = LootWindowAppeared;
            if (temp != null)
                temp(sender, new LootWindowAppearedArgs(e.Args));
        }

        /// <summary>
        /// Event Arguments for EQ2_onLootWindowAppeared
        /// </summary>
	    public class LootWindowAppearedArgs : LSEventArgs
	    {
            internal LootWindowAppearedArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Loot Window ID
            /// </summary>
	        public int LootWindowID
	        {
                get { return Convert.ToInt32(Args[0]); }
	        }
	    }

        #endregion

        #region EQ2_onInventoryUpdate

        /// <summary>
        /// EQ2_onInventoryUpdate Event Handler
        /// </summary>
        public event EventHandler<LSEventArgs> InventoryUpdate;

        /// <summary>
        /// EQ2_onInventoryUpdate Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnInventoryUpdate(object sender, LSEventArgs e)
        {
            var temp = InventoryUpdate;
            if (temp != null)
                temp(sender, e);
        }

        #endregion

        #region EQ2_onQuestUpdate

        /// <summary>
        /// EQ2_onQuestUpdate Event Handler
        /// </summary>
        public event EventHandler<QuestUpdateEventArgs> QuestUpdate;

        /// <summary>
        /// EQ2_onQuestUpdate Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
	    protected virtual void OnQuestUpdate(object sender, LSEventArgs e)
	    {
	        var temp = QuestUpdate;
	        if (temp != null)
	            temp(sender, new QuestUpdateEventArgs(e.Args));
	    }

        /// <summary>
        /// Event Arguments for EQ2_onQuestUpdate
        /// </summary>
	    public class QuestUpdateEventArgs : LSEventArgs
	    {
            internal QuestUpdateEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Quest ID
            /// </summary>
	        public int QuestID
	        {
                get { return Convert.ToInt32(Args[0]); }
	        }

            /// <summary>
            /// Quest Name
            /// </summary>
	        public string QuestName
	        {
                get { return Args[1]; }
	        }

            /// <summary>
            /// Quest Current Zone
            /// </summary>
	        public string QuestCurrentZone
	        {
                get { return Args[2]; }
	        }

            /// <summary>
            /// Quest Category
            /// </summary>
	        public string QuestCategory
	        {
                get { return Args[3]; }
	        }

            /// <summary>
            /// Quest Description
            /// </summary>
	        public string QuestDescription
	        {
                get { return Args[4]; }
	        }

            /// TODO:Troubleshoot QuestUpdateEventArgs ProgressText
            /// <summary>
            /// Quest Progess Text
            /// </summary>
	        public string[] QuestProgressText
	        {
	            get
	            {
	                var list = new List<string>();
	                for (var i = 5; i < Args.Length; i++)
	                {
	                    list.Add(Args[i]);
	                }
	                return list.ToArray();
	            }
	        }
	    }


        #endregion

        #region EQ2_FinishedZoning

        /// <summary>
        /// EQ2_FinishedZoning Event Handler
        /// </summary>
	    public event EventHandler<FinishedZoningEventArgs> FinishedZoning;

        /// <summary>
        /// EQ2_FinishedZoning Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
	    protected virtual void OnFinishedZoning(object sender, LSEventArgs e)
	    {
	        var temp = FinishedZoning;
            if(temp != null)
                temp(sender, new FinishedZoningEventArgs(e.Args));
	    }

        /// <summary>
        /// EQ2_FinishedZoning Event Args
        /// </summary>
	    public class FinishedZoningEventArgs : LSEventArgs
	    {
            internal FinishedZoningEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Returns a string of the time in seconds required to zone
            /// </summary>
	        public float TimeInSeconds
	        {
                get { return Convert.ToSingle(Args[0]); }
	        }
	    }

        #endregion

        #region EQ2_StartedZoning

        /// <summary>
        /// EQ2_StartedZoning Event Handler
        /// </summary>
	    public event EventHandler<LSEventArgs> StartedZoning;

        /// <summary>
        /// EQ2_StartedZoning Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
	    protected virtual void OnStartedZoning(object sender, LSEventArgs e)
	    {
	        var temp = StartedZoning;
	        if (temp != null)
	            temp(sender, e);
	    }

        #endregion

        #region EQ2_onTellIgnored

        /// <summary>
        /// EQ2_onTellIgnored Event Handler
        /// </summary>
	    public event EventHandler<TellIgnoredEventArgs> TellIgnored;

        /// <summary>
        /// EQ2_onTellIgnored Event Raiser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
	    protected internal void OnTellIgnored(object sender, LSEventArgs e)
	    {
	        var temp = TellIgnored;
            if(temp != null)
                temp(sender, new TellIgnoredEventArgs(e.Args));
	    }

        /// <summary>
        /// EQ2_onTellIgnored Event Args
        /// </summary>
	    public class TellIgnoredEventArgs : LSEventArgs
	    {

            internal TellIgnoredEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Message
            /// </summary>
	        public string Message
	        {
                get { return Args[0]; }
	        }

            /// <summary>
            /// Speaker
            /// </summary>
	        public string Speaker
	        {
                get { return Args[1]; }
	        }

	    }

        #endregion

        #region EQ2_onIncomingChatText

        /// <summary>
        /// EQ2_onIncomingChatText Event Handler
        /// </summary>
        public event EventHandler<IncomingChatTextEventArgs> IncomingChatText;

        /// <summary>
        /// EQ2_onIncomingChatText Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnIncomingChatText(object sender, LSEventArgs e)
	    {
	        var temp = IncomingChatText;
            if(temp != null)
                temp(sender, new IncomingChatTextEventArgs(e.Args));
	    }

        /// <summary>
        /// EQ2_onIncomingChatText
        /// </summary>
	    public class IncomingChatTextEventArgs : LSEventArgs
	    {
            internal IncomingChatTextEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Chat Type
            /// </summary>
	        public int ChatType
	        {
                get { return Convert.ToInt32(Args[0]); }
	        }

            /// <summary>
            /// Message
            /// </summary>
	        public string Message
	        {
                get { return Args[1]; }
	        }

            /// <summary>
            /// Speaker
            /// </summary>
	        public string Speaker
	        {
                get { return Args[2]; }
	        }

            /// <summary>
            /// Target
            /// </summary>
	        public string Target
	        {
                get { return Args[3]; }
	        }

            /// <summary>
            /// Returns TRUE if the speaker is an NPC
            /// </summary>
	        public bool SpeakerIsNPC
	        {
                get { return Convert.ToBoolean(Args[4]); }
	        }

            /// <summary>
            /// Channel Name
            /// </summary>
	        public string ChannelName
	        {
                get { return Args[5]; }
	        }

            /// <summary>
            /// Speaker ID
            /// </summary>
            public int SpeakerID
            {
                get { return Convert.ToInt32(Args[6]); }
            }

            /// <summary>
            /// Target ID
            /// </summary>
            public int TargetID
            {
                get { return Convert.ToInt32(Args[7]); }
            }

	    }

        #endregion

        #region EQ2_onSendMailComplete

        /// <summary>
        /// EQ2_onSendMailComplete Event Handler
        /// </summary>
        public event EventHandler<LSEventArgs> SendMailComplete;

        /// <summary>
        /// EQ2_onSendMailComplete Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnSendMailComplete(object sender, LSEventArgs e)
        {
            var temp = SendMailComplete;
            if (temp != null)
                temp(sender, e);
        }

        #endregion

        #region EQ2_onChoiceWindowAppeared

        /// <summary>
        /// EQ2_onChoiceWindowAppeared Event Handler
        /// </summary>
        public event EventHandler<LSEventArgs> ChoiceWindowAppeared;

        /// <summary>
        /// EQ2_onChoiceWindowAppeared Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnChoiceWindowAppeared(object sender, LSEventArgs e)
        {
            var temp = ChoiceWindowAppeared;
            if (temp != null)
                temp(sender, e);
        }

        #endregion

        #region EQ2_onAnnouncement

        /// <summary>
        /// EQ2_onAnnouncement Event Handler
        /// </summary>
        public event EventHandler<AnnouncementEventArgs> Announcement;

        /// <summary>
        /// EQ2_onAnnouncement Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnAnnouncement(object sender, LSEventArgs e)
        {
            var temp = Announcement;
            if (temp != null)
                temp(sender, new AnnouncementEventArgs(e.Args));
        }

        /// <summary>
        /// EQ2_onAnnouncement Event Args
        /// </summary>
	    public class AnnouncementEventArgs : LSEventArgs
	    {
            internal AnnouncementEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Announcement Text
            /// </summary>
            public string Text
            { get { return Args[0]; } }

            /// <summary>
            /// Sound Type
            /// </summary>
            public string SoundType
            {
                get { return Args[1]; }
            }

	    }

        #endregion

        #region EQ2_onIncomingText

        /// <summary>
        /// EQ2_onIncomingText Event Handler
        /// </summary>
        public event EventHandler<IncomingTextEventArgs> IncomingText;

        /// <summary>
        /// EQ2_onIncomingText Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
	    protected virtual void OnIncomingText(object sender, LSEventArgs e)
	    {
	        var temp = IncomingText;
            if(temp != null)
                temp(sender, new IncomingTextEventArgs(e.Args));
	    }

        /// <summary>
        /// EQ2_onIncomingText Event Args
        /// </summary>
	    public class IncomingTextEventArgs : LSEventArgs
	    {
            internal IncomingTextEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Text
            /// </summary>
	        public string Text
	        {
                get { return Args[0]; }
	        }

	    }

        #endregion

        #region EQ2_onRewardWindowAppeared

        /// <summary>
        /// EQ2_onRewardWindowAppeared Event Handler
        /// </summary>
        public event EventHandler<LSEventArgs> RewardWindowAppeared;

        /// <summary>
        /// EQ2_onRewardWindowAppeared Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnRewardWindowAppeared(object sender, LSEventArgs e)
        {
            var temp = RewardWindowAppeared;
            if (temp != null)
                temp(sender, e);
        }

        #endregion

        #region EQ2_onMeAfflicted

        /// <summary>
        /// EQ2_onMeAfflicted Event Handler
        /// </summary>
        public event EventHandler<MeAfflictedEventArgs> MeAfflicted;

        /// <summary>
        /// EQ2_onMeAfflicted Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnMeAfflicted(object sender, LSEventArgs e)
        {
            var temp = MeAfflicted;
            if (temp != null)
                temp(sender, new MeAfflictedEventArgs(e.Args));
        }

        /// <summary>
        /// EQ2_onMeAfflicted Event Args 
        /// </summary>
	    public class MeAfflictedEventArgs : LSEventArgs
	    {
            internal MeAfflictedEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Trauma Counter
            /// </summary>
	        public int TraumaCounter
	        {
                get { return Convert.ToInt32(Args[0]); }
	        }

            /// <summary>
            /// Arcane Counter
            /// </summary>
            public int ArcaneCounter
            {
                get { return Convert.ToInt32(Args[1]); }
            }

            /// <summary>
            /// Noxious Counter
            /// </summary>
            public int NoxiousCounter
            {
                get { return Convert.ToInt32(Args[2]); }
            }

            /// <summary>
            /// Elemental Counter
            /// </summary>
            public int ElementalCounter
            {
                get { return Convert.ToInt32(Args[3]); }
            }

            /// <summary>
            /// Curse Counter
            /// </summary>
            public int CurseCounter
            {
                get { return Convert.ToInt32(Args[4]); }
            }

	    }

        #endregion

        #region EQ2_onGroupMemberAfflicted

        /// <summary>
        /// EQ2_onGroupMemberAfflicted Event Handler
        /// </summary>
        public event EventHandler<MemberAfflictedEventArgs> GroupMemberAfflicted;

        /// <summary>
        /// EQ2_onGroupMemberAfflicted Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnGroupMemberAfflicted(object sender, LSEventArgs e)
        {
            var temp = GroupMemberAfflicted;
            if (temp != null)
                temp(sender, new MemberAfflictedEventArgs(e.Args));
        }

        /// <summary>
        /// EQ2_onGroupMemberAfflicted and EQ2_onRaidMemberAfflicted Event Args 
        /// </summary>
        public class MemberAfflictedEventArgs : LSEventArgs
        {
            internal MemberAfflictedEventArgs(params string[] args) : base(args) { }

            /// <summary>
            /// Afflicted Actor ID
            /// </summary>
            public int ActorID
            {
                get { return Convert.ToInt32(Args[0]); }
            }

            /// <summary>
            /// Trauma Counter
            /// </summary>
            public int TraumaCounter
            {
                get { return Convert.ToInt32(Args[1]); }
            }

            /// <summary>
            /// Arcane Counter
            /// </summary>
            public int ArcaneCounter
            {
                get { return Convert.ToInt32(Args[2]); }
            }

            /// <summary>
            /// Noxious Counter
            /// </summary>
            public int NoxiousCounter
            {
                get { return Convert.ToInt32(Args[3]); }
            }

            /// <summary>
            /// Elemental Counter
            /// </summary>
            public int ElementalCounter
            {
                get { return Convert.ToInt32(Args[4]); }
            }

            /// <summary>
            /// Curse Counter
            /// </summary>
            public int CurseCounter
            {
                get { return Convert.ToInt32(Args[5]); }
            }

        }

        #endregion

        #region EQ2_onRaidMemberAfflicted

        /// <summary>
        /// EQ2_onRaidMemberAfflicted Event Handler
        /// </summary>
        public event EventHandler<MemberAfflictedEventArgs> RaidMemberAfflicted;

        /// <summary>
        /// EQ2_onRaidMemberAfflicted Event Raiser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
        protected virtual void OnRaidMemberAfflicted(object sender, LSEventArgs e)
        {
            var temp = RaidMemberAfflicted;
            if (temp != null)
                temp(sender, new MemberAfflictedEventArgs(e.Args));
        }

        #endregion

        #endregion

        #region Methods

        /// <summary>
        /// Attaches the specified event to the specified handler.
        /// </summary>
        /// <param name="eventToAttach">event to attach</param>
        /// <param name="handler">handler</param>
        private static void Attach(string eventToAttach, EventHandler<LSEventArgs> handler)
        {
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent(eventToAttach), handler);
        }

        /// <summary>
        /// Detaches the specified event from the specified handler.
        /// </summary>
        /// <param name="eventToDetach">event to detach</param>
        /// <param name="handler">handler</param>
        private static void Detach(string eventToDetach, EventHandler<LSEventArgs> handler)
        {
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent(eventToDetach), handler);
        }

        #endregion

    }
}
