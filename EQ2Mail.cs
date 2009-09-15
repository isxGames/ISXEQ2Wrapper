// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class EQ2Mail : LavishScriptObject
    {
        public EQ2Mail(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public int ID
        {
            get
            {
                return GetMember<int>("ID");
            }
        }

        public string Sender
        {
            get
            {
                return GetMember<string>("Sender");
            }
        }

        public string Subject
        {
            get
            {
                return GetMember<string>("Subject");
            }
        }

        public string Body
        {
            get
            {
                return GetMember<string>("Body");
            }
        }

        public int Copper
        {
            get
            {
                return GetMember<int>("Copper");
            }
        }

        public int Silver
        {
            get
            {
                return GetMember<int>("Silver");
            }
        }

        public int Gold
        {
            get
            {
                return GetMember<int>("Gold");
            }
        }

        public int Platinum
        {
            get
            {
                return GetMember<int>("Platinum");
            }
        }

        public int Gift
        {
            get
            {
                return GetMember<int>("Gift");
            }
        }

        public string Recipient
        {
            get
            {
                return GetMember<string>("Recipient");
            }
        }

        public void Open()
        {
            ExecuteMethod("Open");
        }

        public void Delete()
        {
            ExecuteMethod("Delete");
        }

        public void ReceiveGifts()
        {
            ExecuteMethod("ReceiveGifts");
        }
        
        public void AppendRecipient(string Text)
        {
            ExecuteMethod("AppendRecipient",Text);
        }

        public void AppendSubject(string Text)
        {
            ExecuteMethod("AppendSubject",Text);
        }

        public void AppendBody(string Text)
        {
            ExecuteMethod("AppendBody",Text);
        }

        public void RemoveGift()
        {
            ExecuteMethod("RemoveGift");
        }

        public void AddCopper(int Value)
        {
            ExecuteMethod("AddCopper",Value.ToString());
        }

        public void AddSilver(int Value)
        {
            ExecuteMethod("AddSilver",Value.ToString());
        }

        public void AddGold(int Value)
        {
            ExecuteMethod("AddGold",Value.ToString());
        }

        public void AddPlatinum(int Value)
        {
            ExecuteMethod("AddPlatinum",Value.ToString());
        }

        public void RemoveCopper(int Value)
        {
            ExecuteMethod("RemoveCopper",Value.ToString());
        }

        public void RemoveSilver(int Value)
        {
            ExecuteMethod("RemoveSilver",Value.ToString());
        }

        public void RemoveGold(int Value)
        {
            ExecuteMethod("RemoveGold",Value.ToString());
        }

        public void RemovePlatinum(int Value)
        {
            ExecuteMethod("RemovePlatinum",Value.ToString());
        }
        
        public void Cancel()
        {
            ExecuteMethod("Cancel");
        }

        public void Send()
        {
            ExecuteMethod("Send");
        }

    }
}
