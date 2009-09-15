// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Text;

using LavishVMAPI;
using InnerSpaceAPI;
using LavishScriptAPI;


namespace EQ2.ISXEQ2
{
    public class EQ2Event
    {
        //
        #region .Net Events
        public event System.EventHandler<LSEventArgs> IncomingChatText;
        public event System.EventHandler<LSEventArgs> InventoryUpdate;
        public event System.EventHandler<LSEventArgs> Announcement;
        public event System.EventHandler<LSEventArgs> CastingStarted;
        public event System.EventHandler<LSEventArgs> CastingEnded;
        public event System.EventHandler<LSEventArgs> ActorSpawned;
        public event System.EventHandler<LSEventArgs> ActorDespawned;
        public event System.EventHandler<LSEventArgs> RewardWindowAppeared;
        public event System.EventHandler<LSEventArgs> QuestOffered;
        public event System.EventHandler<LSEventArgs> ChoiceWindowAppeared;
        public event System.EventHandler<LSEventArgs> SendMailComplete;
        public event System.EventHandler<LSEventArgs> IncomingText;
        public event System.EventHandler<LSEventArgs> MeAfflicted;
        public event System.EventHandler<LSEventArgs> GroupMemberAfflicted;
        public event System.EventHandler<LSEventArgs> RaidMemberAfflicted;
        public event System.EventHandler<LSEventArgs> ActorTargetChange;
        public event System.EventHandler<LSEventArgs> ActorStanceChange;
        public event System.EventHandler<LSEventArgs> ActorHealthChange;
        public event System.EventHandler<LSEventArgs> ActorPowerChange;

        #endregion

        //
        #region .Net Event Raisers
        protected virtual void OnIncomingChatText(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = IncomingChatText;
            if (temp != null)
                temp(Sender, e);
        }

        protected virtual void OnInventoryUpdate(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = InventoryUpdate;
            if (temp != null)
                temp(Sender, e);
        }

        protected virtual void OnAnnouncement(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = Announcement;
            if (temp != null)
                temp(Sender, e);
        }

        protected virtual void OnCastingStarted(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = CastingStarted;
            if (temp != null)
                temp(Sender, e);
        }

        protected virtual void OnCastingEnded(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = CastingEnded;
            if (temp != null)
                temp(Sender, e);
        }

        protected virtual void OnActorSpawned(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ActorSpawned;
            if (temp != null)
                temp(Sender, e);
        }

        protected virtual void OnActorDespawned(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ActorDespawned;
            if (temp != null)
                temp(Sender, e);
        }

        protected virtual void OnRewardWindowAppeared(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = RewardWindowAppeared;
            if (temp != null)
                temp(Sender, e);
        }

        protected virtual void OnQuestOffered(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = QuestOffered;
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

        protected virtual void OnIncomingText(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = IncomingText;
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

        protected virtual void OnActorTargetChange(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ActorTargetChange;
            if (temp != null)
                temp(Sender, e);
        }

        protected virtual void OnActorStanceChange(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ActorStanceChange;
            if (temp != null)
                temp(Sender, e);
        }

        protected virtual void OnActorHealthChange(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ActorHealthChange;
            if (temp != null)
                temp(Sender, e);
        }

        protected virtual void OnActorPowerChange(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ActorPowerChange;
            if (temp != null)
                temp(Sender, e);
        }

        #endregion

        //
        ~EQ2Event()
        {
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onIncomingChatText"), OnIncomingChatText);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onInventoryUpdate"), OnInventoryUpdate);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onAnnouncement"), OnAnnouncement);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onCastingStarted"), OnCastingStarted);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onCastingEnded"), OnCastingEnded);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onActorSpawned"), OnActorSpawned);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onActorDespawned"), OnActorDespawned);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onRewardWindowAppeared"), OnRewardWindowAppeared);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onQuestOffered"), OnQuestOffered);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onChoiceWindowAppeared"), OnChoiceWindowAppeared);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onSendMailComplete"), OnSendMailComplete);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onIncomingText"), OnIncomingText);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onMeAfflicted"), OnMeAfflicted);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onGroupMemberAfflicted"), OnGroupMemberAfflicted);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onRaidMemberAfflicted"), OnRaidMemberAfflicted);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_ActorTargetChange"), OnActorTargetChange);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_ActorStanceChange"), OnActorStanceChange);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_ActorHealthChange"), OnActorHealthChange);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_ActorPowerChange"), OnActorPowerChange);

        }

        //
        public EQ2Event()
        {
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onIncomingChatText"), OnIncomingChatText);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onInventoryUpdate"), OnInventoryUpdate);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onAnnouncement"), OnAnnouncement);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onCastingStarted"), OnCastingStarted);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onCastingEnded"), OnCastingEnded);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onActorSpawned"), OnActorSpawned);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onActorDespawned"), OnActorDespawned);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onRewardWindowAppeared"), OnRewardWindowAppeared);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onQuestOffered"), OnQuestOffered);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onChoiceWindowAppeared"), OnChoiceWindowAppeared);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onSendMailComplete"), OnSendMailComplete);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onIncomingText"), OnIncomingText);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onMeAfflicted"), OnMeAfflicted);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onGroupMemberAfflicted"), OnGroupMemberAfflicted);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onRaidMemberAfflicted"), OnRaidMemberAfflicted);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_ActorTargetChange"), OnActorTargetChange);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_ActorStanceChange"), OnActorStanceChange);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_ActorHealthChange"), OnActorHealthChange);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_ActorPowerChange"), OnActorPowerChange);
        }
    }
}
