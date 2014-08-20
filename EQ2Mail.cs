using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to an individual email
    /// </summary>
    public class EQ2Mail : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2Mail(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of Body
        /// </summary>
        private string _body;

        /// <summary>
        /// The body of the email
        /// </summary>
        public string Body
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Mail:Body"));
                return _body ?? (_body = this.GetStringFromLSO("Body"));
            }
        }

        /// <summary>
        /// Cache of Copper
        /// </summary>
        private int? _copper;

        /// <summary>
        /// Amount of copper attached to the email. Only works if mail is opened or composing.
        /// </summary>
        public int Copper
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Mail:Copper"));
                if(!_copper.HasValue)
                    _copper = this.GetIntFromLSO("Copper");
                return _copper.Value;
            }
        }

        /// <summary>
        /// Should return the item datatype for the attachment
        /// </summary>
        public Item Gift
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Mail:Gift"));
                return new Item(this.GetMember("Gift"));
            }
        }

        /// <summary>
        /// Cache of Gold
        /// </summary>
        private int? _gold;

        /// <summary>
        /// Amount of gold attached to the email. Only works if mail is opened or composing.
        /// </summary>
        public int Gold
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Mail:Gold"));
                if(!_gold.HasValue)
                    _gold = this.GetIntFromLSO("Gold");
                return _gold.Value;
            }
        }
        
        /// <summary>
        /// Cache of ID
        /// </summary>
        private int? _iD;

        /// <summary>
        /// Mail ID
        /// </summary>
        public int ID
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Mail:ID"));
                if(!_iD.HasValue)
                    _iD = this.GetIntFromLSO("ID");
                return _iD.Value;
            }
        }

        /// <summary>
        /// Cache of Platinum
        /// </summary>
        private int? _platinum;

        /// <summary>
        /// Amount of platinum attached to the email. Only works if mail is opened or composing.
        /// </summary>
        public int Platinum
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Mail:Platinum"));
                if(!_platinum.HasValue)
                    _platinum = this.GetIntFromLSO("Platinum");
                return _platinum.Value;
            }
        }

        /// <summary>
        /// Cache of recipient
        /// </summary>
        private string _recipient;

        /// <summary>
        /// Name of the recipient
        /// </summary>
        public string Recipient
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Mail:Recipient"));
                return _recipient ?? (_recipient = this.GetStringFromLSO("Recipient"));
            }
        }

        /// <summary>
        /// Cache of Sender
        /// </summary>
        private string _sender;

        /// <summary>
        /// Returns the name of the sender
        /// </summary>
        public string Sender
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Mail:Sender"));
                return _sender ?? (_sender = this.GetStringFromLSO("Sender"));
            }
        }

        /// <summary>
        /// Cache of Silver
        /// </summary>
        private int? _silver;

        /// <summary>
        /// Amount of silver attached to the email. Only works if mail is opened or composing.
        /// </summary>
        public int Silver
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Mail:Silver"));
                if(!_silver.HasValue)
                    _silver = this.GetIntFromLSO("Silver");
                return _silver.Value;
            }
        }

        /// <summary>
        /// Cache of Subject
        /// </summary>
        private string _subject;

        /// <summary>
        /// The subject of the email
        /// </summary>
        public string Subject
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Mail:Subject"));
                return _subject ?? (_subject = this.GetStringFromLSO("Subject"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds copper to an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of ccopper to add</param>
        /// <returns>call success</returns>
        public bool AddCopper(int value)
        {
            Trace.WriteLine(String.Format("EQ2Mail:AddCopper({0})", value.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddCopper", value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Add gold to an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of gold to add</param>
        /// <returns>call success</returns>
        public bool AddGold(int value)
        {
            Trace.WriteLine(String.Format("EQ2Mail:AddGold({0})", value.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddGold", value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Adds platinum to an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of platinum to add</param>
        /// <returns>call success</returns>
        public bool AddPlatinum(int value)
        {
            Trace.WriteLine(String.Format("EQ2Mail:AddPlatinum({0})", value.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddPlatinum", value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Adds silver to an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of silver to add</param>
        /// <returns>call success</returns>
        public bool AddSilver(int value)
        {
            Trace.WriteLine(String.Format("EQ2Mail:AddSilver({0})", value.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddSilver", value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Adds additional text to the body of an email. Requires email to be composing.
        /// </summary>
        /// <param name="text">text to append</param>
        /// <returns>call success</returns>
        public bool AppendBody(string text)
        {
            Trace.WriteLine(String.Format("EQ2Mail:AppendBody({0})", text));
            return this.ExecuteMethod("AppendBody", text);
        }

        /// <summary>
        /// Adds an additional recipient to an email. Requires email to be composing.
        /// </summary>
        /// <param name="text">text to append</param>
        /// <returns>call success</returns>
        public bool AppendRecipient(string text)
        {
            Trace.WriteLine(String.Format("EQ2Mail:AppendRecipient({0})", text));
            return this.ExecuteMethod("AppendRecipient", text);
        }

        /// <summary>
        /// Adds additional text to the subject of an email. Requires email to be composing.
        /// </summary>
        /// <param name="text">text to append</param>
        /// <returns>call success</returns>
        public bool AppendSubject(string text)
        {
            Trace.WriteLine(String.Format("EQ2Mail:AppendSubject({0})", text));
            return this.ExecuteMethod("AppendSubject", text);
        }

        /// <summary>
        /// Cancels the email.
        /// </summary>
        /// <returns>call success</returns>
        public bool Cancel()
        {
            Trace.WriteLine(String.Format("EQ2Mail:Cancel()"));
            return this.ExecuteMethod("Cancel");
        }

        /// <summary>
        /// Deletes the email. Does not require the email to be opened or composing.
        /// </summary>
        /// <returns>call success</returns>
        public bool Delete()
        {
            Trace.WriteLine(String.Format("EQ2Mail:Delete()"));
            return this.ExecuteMethod("Delete");
        }

        /// <summary>
        /// Opens the email. Does not require the email to be opened or composing.
        /// </summary>
        /// <returns>call success</returns>
        public bool Open()
        {
            Trace.WriteLine(String.Format("EQ2Mail:Open()"));
            return this.ExecuteMethod("Open");
        }

        /// <summary>
        /// Extracts the attached gift from the email. Does not require the email to be opened or composing.
        /// </summary>
        /// <returns>call success</returns>
        public bool ReceiveGifts()
        {
            Trace.WriteLine(String.Format("EQ2Mail:ReceiveGifts()"));
            return this.ExecuteMethod("ReceiveGifts");
        }

        /// <summary>
        /// Removes copper from an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of copper to remove</param>
        /// <returns>call success</returns>
        public bool RemoveCopper(int value)
        {
            Trace.WriteLine(String.Format("EQ2Mail:RemoveCopper({0})", value.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("RemoveCopper", value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Removes the gift from an email. Requires email to be composing.
        /// </summary>
        /// <returns>call success</returns>
        public bool RemoveGift()
        {
            Trace.WriteLine(String.Format("EQ2Mail:RemoveGift()"));
            return this.ExecuteMethod("RemoveGift");
        }

        /// <summary>
        /// Removes gold from an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of gold to remove</param>
        /// <returns>call success</returns>
        public bool RemoveGold(int value)
        {
            Trace.WriteLine(String.Format("EQ2Mail:RemoveGold({0})", value.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("RemoveGold", value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Removes platinum from an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of platinum to remove</param>
        /// <returns>call success</returns>
        public bool RemovePlatinum(int value)
        {
            Trace.WriteLine(String.Format("EQ2Mail:RemovePlatinum({0})", value.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("RemovePlatinum", value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Removes silver from an email. Requires email to be composing.
        /// </summary>
        /// <param name="value">the amount of silver to remove</param>
        /// <returns>call success</returns>
        public bool RemoveSilver(int value)
        {
            Trace.WriteLine(String.Format("EQ2Mail:RemoveSilver({0})", value.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("RemoveSilver", value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Sends the email. Requires email to be composing.
        /// </summary>
        /// <returns>call success</returns>
        public bool Send()
        {
            Trace.WriteLine(String.Format("EQ2Mail:Send()"));
            return this.ExecuteMethod("Send");
        }

        #endregion

    }
}
