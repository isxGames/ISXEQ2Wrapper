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
        #endregion

        //
        ~EQ2Event()
        {
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onIncomingChatText"), OnIncomingChatText);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onInventoryUpdate"), OnInventoryUpdate);
            LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_OnAnnouncement"), OnAnnouncement);

        }

        //
        public EQ2Event()
        {
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onIncomingChatText"), OnIncomingChatText);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_onInventoryUpdate"), OnInventoryUpdate);
            LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_OnAnnouncement"), OnAnnouncement);
        }
    }
}
