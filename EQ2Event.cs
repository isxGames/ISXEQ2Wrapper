using System;
using System.Collections.Generic;
using LavishScriptAPI;


namespace EQ2.ISXEQ2
{
	public class EQ2Event
	{

        #region EQ2_ActorSpawned

        /// <summary>
        /// EQ2_ActorSpawned Event Handler 
        /// </summary>
        public event EventHandler<ActorSpawnedEventArgs> ActorSpawned;

        /// <summary>
        /// EQ2_Actor Spawned Event
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
        /// EQ2_ActorDespawned Event
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
        /// EQ2_CastingStarted Event
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
        /// EQ2_CastingEnded Event
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
        /// EQ2_ActorPowerChange Event Handler
        /// </summary>
        public event EventHandler<ActorPowerChangeEventArgs> ActorPowerChange;

        /// <summary>
        /// EQ2_ActorPowerChange Event
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
        /// EQ2_ActorHealthChange Event Handler
        /// </summary>
        public event EventHandler<ActorHealthChangeEventArgs> ActorHealthChange;

        /// <summary>
        /// EQ2_ActorHealthChange Event
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
        /// EQ2_ActorStanceChange Event Handler
        /// </summary>
        public event EventHandler<ActorStanceChangeEventArgs> ActorStanceChange;

        /// <summary>
        /// EQ2_ActorStanceChange Event
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
        /// EQ2_ActorTargetChange Event Handler
        /// </summary>
        public event EventHandler<ActorTargetChangeEventArgs> ActorTargetChange;

        /// <summary>
        /// EQ2_ActorTargetChange Event
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
        /// EQ2_OnHOWindowStateChanged Event
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
        /// EQ2_ExamineAchievement Event
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
        /// EQ2_onQuestOffered Event
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
	        public string QuestName
	        {
                get { return Args[0]; }
	        }

            /// <summary>
            /// Quest Description
            /// </summary>
            public string QuestDescription
            {
                get { return Args[1]; }
            }

	    }

        #endregion

        #region EQ2_ReplyDialogAppeared

        /// <summary>
        /// EQ2_ReplyDialogAppeared Event Handler
        /// </summary>
	    public event EventHandler<ReplyDialogAppearedEventArgs> ReplyDialogAppeared;

        /// <summary>
        /// EQ2_ReplyDialogAppeared Event
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
        /// EQ2_ExamineItemWindowAppeared Event
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
        /// EQ2_onLootWindowAppeared Event
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
        /// EQ2_onInventoryUpdate Event
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
        /// EQ2_onQuestUpdate Event
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
        /// EQ2_FinishedZoning Event
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
        /// EQ2_StartedZoning Event
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
        /// EQ2_onTellIgnored Event
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
        /// EQ2_onIncomingChatText Event
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">arguments</param>
	    public virtual void OnIncomingChatText(object sender, LSEventArgs e)
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

	    }

        #endregion



        
		
		public event EventHandler<LSEventArgs> Announcement;
	
		public event EventHandler<LSEventArgs> RewardWindowAppeared;
				
		public event EventHandler<LSEventArgs> ChoiceWindowAppeared;
		public event EventHandler<LSEventArgs> SendMailComplete;
		public event EventHandler<LSEventArgs> IncomingText;
		public event EventHandler<LSEventArgs> MeAfflicted;
		public event EventHandler<LSEventArgs> GroupMemberAfflicted;
		public event EventHandler<LSEventArgs> RaidMemberAfflicted;
		
		
		
		



		
		#region .Net Event Raisers







		

		protected virtual void OnAnnouncement(object Sender, LSEventArgs e)
		{
			System.EventHandler<LSEventArgs> temp = Announcement;
			if (temp != null)
				temp(Sender, e);
		}

		

		protected virtual void OnRewardWindowAppeared(object Sender, LSEventArgs e)
		{
			System.EventHandler<LSEventArgs> temp = RewardWindowAppeared;
			if (temp != null)
				temp(Sender, e);
		}

		

		

		protected virtual void OnChoiceWindowAppeared(object Sender, LSEventArgs e)
		{
			System.EventHandler<LSEventArgs> temp = ChoiceWindowAppeared;
			if (temp != null)
				temp(Sender, e);
		}

		protected virtual void OnSendMailComplete(object Sender, LSEventArgs e)
		{
			System.EventHandler<LSEventArgs> temp = SendMailComplete;
			if (temp != null)
				temp(Sender, e);
		}


		protected virtual void OnMeAfflicted(object Sender, LSEventArgs e)
		{
			System.EventHandler<LSEventArgs> temp = MeAfflicted;
			if (temp != null)
				temp(Sender, e);
		}

		protected virtual void OnGroupMemberAfflicted(object Sender, LSEventArgs e)
		{
			System.EventHandler<LSEventArgs> temp = GroupMemberAfflicted;
			if (temp != null)
				temp(Sender, e);
		}

		protected virtual void OnRaidMemberAfflicted(object Sender, LSEventArgs e)
		{
			System.EventHandler<LSEventArgs> temp = RaidMemberAfflicted;
			if (temp != null)
				temp(Sender, e);
		}

		

		

		

		

		#endregion

		//
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
            Detach("EQ2_onIncomingText", OnIncomingChatText);




			
			LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onAnnouncement"), OnAnnouncement);
			
			
			
			
			LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onRewardWindowAppeared"), OnRewardWindowAppeared);
			
			
			LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onChoiceWindowAppeared"), OnChoiceWindowAppeared);
			LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onSendMailComplete"), OnSendMailComplete);
			
			LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onMeAfflicted"), OnMeAfflicted);
			LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onGroupMemberAfflicted"), OnGroupMemberAfflicted);
			LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onRaidMemberAfflicted"), OnRaidMemberAfflicted);
			
			
			
			


		}

		
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
            Attach("EQ2_HOWindowStateChange", OnHOWindowStateChanged);
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



			
			
			LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onAnnouncement"), OnAnnouncement);
			
			
			
			
			LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onRewardWindowAppeared"), OnRewardWindowAppeared);
			
			
			LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onChoiceWindowAppeared"), OnChoiceWindowAppeared);
			LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onSendMailComplete"), OnSendMailComplete);
;
			LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onMeAfflicted"), OnMeAfflicted);
			LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onGroupMemberAfflicted"), OnGroupMemberAfflicted);
			LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onRaidMemberAfflicted"), OnRaidMemberAfflicted);
			LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onRaidMemberAfflicted"), OnRaidMemberAfflicted);
			
			
			
			
		}


        /// <summary>
        /// Attaches the specified event to the specified handler.
        /// </summary>
        /// <param name="eventToAttach">event to attach.</param>
        /// <param name="handler">handler</param>
        private static void Attach(string eventToAttach, EventHandler<LSEventArgs> handler)
        {
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent(eventToAttach), handler);
        }

        /// <summary>
        /// Detaches the specified event from the specified handler.
        /// </summary>
        /// <param name="eventToDetach">event to detach.</param>
        /// <param name="handler">handler</param>
        private static void Detach(string eventToDetach, EventHandler<LSEventArgs> handler)
        {
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent(eventToDetach), handler);
        }
	}
}
