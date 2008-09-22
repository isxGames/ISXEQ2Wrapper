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
        }
    }
}
