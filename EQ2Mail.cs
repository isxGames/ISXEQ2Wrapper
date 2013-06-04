// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System.Globalization;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// All of the available data for an individual in-game email
    /// </summary>
    public class EQ2Mail : LavishScriptObject
    {

        #region Constructor

        public EQ2Mail(LavishScriptObject obj)
            : base(obj)
        {
        }

        public int ID
        {
            get { return GetMember<int>("ID"); }
        }

        #endregion

        /// <summary>
        /// Returns the name of the sender
        /// </summary>
        public string Sender
        {
            get
            {
                return this.GetStringFromLSO("Sender");
            }
        }

        /// <summary>
        /// The subject of the email
        /// </summary>
        public string Subject
        {
            get
            {
                return this.GetStringFromLSO("Subject");
            }
        }

        /// <summary>
        /// The body of the email
        /// </summary>
        public string Body
        {
            get
            {
                return this.GetStringFromLSO("Body");
            }
        }

        /// <summary>
        /// Amount of copper attached to the email. Only works if mail is opened or composing.
        /// </summary>
        public int Copper
        {
            get
            {
                return this.GetIntFromLSO("Copper");
            }
        }

        /// <summary>
        /// Amount of silver attached to the email. Only works if mail is opened or composing.
        /// </summary>
        public int Silver
        {
            get
            {
                return this.GetIntFromLSO("Silver");
            }
        }

        /// <summary>
        /// Amount of gold attached to the email. Only works if mail is opened or composing.
        /// </summary>
        public int Gold
        {
            get
            {
                return this.GetIntFromLSO("Gold");
            }
        }

        /// TODO: Identify Gift member datatype as Int or Item
        /// <summary>
        /// Amount of platinum attached to the email. Only works if mail is opened or omposing.
        /// </summary>
        public int Platinum
        {
            get
            {
                return this.GetIntFromLSO("Platinum");
            }
        }

        /// <summary>
        /// Should return the item datatype for the attachment, returns an int instead
        /// </summary>
        public int Gift
        {
            get
            {
                return this.GetIntFromLSO("Gift");
            }
        }

        /// <summary>
        /// Returns the name of the recipient
        /// </summary>
        public string Recipient
        {
            get
            {
                return this.GetStringFromLSO("Recipient");
            }
        }

        /// <summary>
        /// Opens the email. Does not require the email to be opened or composing.
        /// </summary>
        public void Open()
        {
            ExecuteMethod("Open");
        }

        /// <summary>
        /// Deletes the email. Does not require the email to be opened or composing.
        /// </summary>
        public void Delete()
        {
            ExecuteMethod("Delete");
        }

        /// <summary>
        /// Extracts the attached gift from the email. Does not require the email to be opened or composing.
        /// </summary>
        public void ReceiveGifts()
        {
            ExecuteMethod("ReceiveGifts");
        }
        
        /// <summary>
        /// Adds an additional recipient to an email. Requires email to be composing.
        /// </summary>
        /// <param name="text">text to append</param>
        public void AppendRecipient(string text)
        {
            ExecuteMethod("AppendRecipient",text);
        }

        /// <summary>
        /// Adds additional text to the subject of an email. Requires email to be composing.
        /// </summary>
        /// <param name="text">text to append</param>
        public void AppendSubject(string text)
        {
            ExecuteMethod("AppendSubject",text);
        }

        /// <summary>
        /// Adds additional text to the body of an email. Requires email to be composing.
        /// </summary>
        /// <param name="text">text to append</param>
        public void AppendBody(string text)
        {
            ExecuteMethod("AppendBody",text);
        }

        /// <summary>
        /// Removes the gift from an email. Requires email to be composing.
        /// </summary>
        public void RemoveGift()
        {
            ExecuteMethod("RemoveGift");
        }

        /// <summary>
        /// Adds copper to an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of ccopper to add</param>
        public void AddCopper(int value)
        {
            ExecuteMethod("AddCopper",value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Adds silver to an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of silver to add</param>
        public void AddSilver(int value)
        {
            ExecuteMethod("AddSilver",value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Add gold to an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of gold to add</param>
        public void AddGold(int value)
        {
            ExecuteMethod("AddGold",value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Adds platinum to an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of platinum to add</param>
        public void AddPlatinum(int value)
        {
            ExecuteMethod("AddPlatinum",value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Removes copper from an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of copper to remove</param>
        public void RemoveCopper(int value)
        {
            ExecuteMethod("RemoveCopper",value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Removes silver from an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of silver to remove</param>
        public void RemoveSilver(int value)
        {
            ExecuteMethod("RemoveSilver",value.ToString());
        }

        /// <summary>
        /// Removes gold from an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of gold to remove</param>
        public void RemoveGold(int value)
        {
            ExecuteMethod("RemoveGold",value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Removes platinum from an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of platinum to remove</param>
        public void RemovePlatinum(int value)
        {
            ExecuteMethod("RemovePlatinum",value.ToString(CultureInfo.InvariantCulture));
        }
        
        /// <summary>
        /// Cancels the email.
        /// </summary>
        public void Cancel()
        {
            ExecuteMethod("Cancel");
        }

        /// <summary>
        /// Sends the email. Requires email to be composing.
        /// </summary>
        public void Send()
        {
            ExecuteMethod("Send");
        }

    }
}
