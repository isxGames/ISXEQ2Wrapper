using System;
using System.Text;

using LavishVMAPI;
using InnerSpaceAPI;
using LavishScriptAPI;


namespace EQ2.ISXEQ2
{
    public class Event
    {
        #region .Net Events
        //public event System.EventHandler<LSEventArgs> EVEEvent;
        #endregion

        #region .Net Event Raisers
        /*
        protected virtual void EVE_EVEEvent(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ReceivedNotice;
            if (temp != null)
                temp(Sender, e);
        }
        */
        #endregion

        ~Event()
        {
            //LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EVE_EVEEvent"), EVE_Event);

        }

        public Event()
        {
            //LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EVE_EVEEvent"), IRC_ReceivedNotice);
        }


    }
}
