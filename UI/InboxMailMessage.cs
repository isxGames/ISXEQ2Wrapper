using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using EQ2.ISXEQ2.InventoryConsignment;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2inboxmailmessage' datatype. Represents a single message
    /// entry in the MailWindow inbox listing. Exposes nine members and three methods
    /// (the extra method versus MailMessage is Open).
    /// </summary>
    public class InboxMailMessage : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public InboxMailMessage(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The author (sender) of this inbox message.
        /// </summary>
        public string Author
        {
            get
            {
                Trace.WriteLine(String.Format("InboxMailMessage:Author"));
                return this.GetStringFromLSO("Author");
            }
        }

        /// <summary>
        /// The attachment item (if any). Returns ItemInfo so attachment data is
        /// available without re-initialization.
        /// </summary>
        public ItemInfo Attachment
        {
            get
            {
                Trace.WriteLine(String.Format("InboxMailMessage:Attachment"));
                return new ItemInfo(this.GetMember("Attachment"));
            }
        }

        /// <summary>
        /// The body text of this inbox message.
        /// </summary>
        public string Body
        {
            get
            {
                Trace.WriteLine(String.Format("InboxMailMessage:Body"));
                return this.GetStringFromLSO("Body");
            }
        }

        /// <summary>
        /// Amount of copper attached to this inbox message.
        /// </summary>
        public int Copper
        {
            get
            {
                Trace.WriteLine(String.Format("InboxMailMessage:Copper"));
                return this.GetIntFromLSO("Copper");
            }
        }

        /// <summary>
        /// Amount of gold attached to this inbox message.
        /// </summary>
        public int Gold
        {
            get
            {
                Trace.WriteLine(String.Format("InboxMailMessage:Gold"));
                return this.GetIntFromLSO("Gold");
            }
        }

        /// <summary>
        /// Inbox message ID.
        /// </summary>
        public uint ID
        {
            get
            {
                Trace.WriteLine(String.Format("InboxMailMessage:ID"));
                return this.GetUIntFromLSO("ID");
            }
        }

        /// <summary>
        /// Amount of platinum attached to this inbox message.
        /// </summary>
        public int Platinum
        {
            get
            {
                Trace.WriteLine(String.Format("InboxMailMessage:Platinum"));
                return this.GetIntFromLSO("Platinum");
            }
        }

        /// <summary>
        /// Amount of silver attached to this inbox message.
        /// </summary>
        public int Silver
        {
            get
            {
                Trace.WriteLine(String.Format("InboxMailMessage:Silver"));
                return this.GetIntFromLSO("Silver");
            }
        }

        /// <summary>
        /// The subject line of this inbox message.
        /// </summary>
        public string Subject
        {
            get
            {
                Trace.WriteLine(String.Format("InboxMailMessage:Subject"));
                return this.GetStringFromLSO("Subject");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Deletes this inbox mail message.
        /// </summary>
        /// <returns>call success</returns>
        public bool Delete()
        {
            Trace.WriteLine(String.Format("InboxMailMessage:Delete()"));
            return this.ExecuteMethod("Delete");
        }

        /// <summary>
        /// Opens this inbox mail message (issues the getmailmessage command).
        /// </summary>
        /// <returns>call success</returns>
        public bool Open()
        {
            Trace.WriteLine(String.Format("InboxMailMessage:Open()"));
            return this.ExecuteMethod("Open");
        }

        /// <summary>
        /// Receives (takes) the attachment(s) from this inbox mail message.
        /// </summary>
        /// <returns>call success</returns>
        public bool ReceiveAttachment()
        {
            Trace.WriteLine(String.Format("InboxMailMessage:ReceiveAttachment()"));
            return this.ExecuteMethod("ReceiveAttachment");
        }

        #endregion

    }
}
