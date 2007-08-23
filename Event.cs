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
        //public event System.EventHandler<LSEventArgs> EQ2Event;
        #endregion

        #region .Net Event Raisers
        /*
        protected virtual void EQ2_EQ2Event(object Sender, LSEventArgs e)
        {
            System.EventHandler<LSEventArgs> temp = ReceivedNotice;
            if (temp != null)
                temp(Sender, e);
        }
        */
        #endregion

        ~Event()
        {
            //LavishScript.Events.DetachEventTarget(LavishScript.Events.RegisterEvent("EQ2_EQ2Event"), EQ2_Event);

        }

        public Event()
        {
            //LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("EQ2_EQ2Event"), EQ2_Event);
        }


    }
}
