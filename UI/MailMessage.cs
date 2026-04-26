using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using EQ2.ISXEQ2.InventoryConsignment;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2mailmessage' datatype. Represents the single message
    /// currently shown inside an OpenedMailWindow. Source MailMessageType inherits
    /// nothing (LSTypeDef_Ptr) and registers nine members and two methods.
    /// </summary>
    public class MailMessage : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public MailMessage(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The author (sender) of this message.
        /// </summary>
        public string Author
        {
            get
            {
                Trace.WriteLine(String.Format("MailMessage:Author"));
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
                Trace.WriteLine(String.Format("MailMessage:Attachment"));
                return new ItemInfo(this.GetMember("Attachment"));
            }
        }

        /// <summary>
        /// The body text of this message.
        /// </summary>
        public string Body
        {
            get
            {
                Trace.WriteLine(String.Format("MailMessage:Body"));
                return this.GetStringFromLSO("Body");
            }
        }

        /// <summary>
        /// Amount of copper attached to this message.
        /// </summary>
        public int Copper
        {
            get
            {
                Trace.WriteLine(String.Format("MailMessage:Copper"));
                return this.GetIntFromLSO("Copper");
            }
        }

        /// <summary>
        /// Amount of gold attached to this message.
        /// </summary>
        public int Gold
        {
            get
            {
                Trace.WriteLine(String.Format("MailMessage:Gold"));
                return this.GetIntFromLSO("Gold");
            }
        }

        /// <summary>
        /// Mail message ID.
        /// </summary>
        public uint ID
        {
            get
            {
                Trace.WriteLine(String.Format("MailMessage:ID"));
                return this.GetUIntFromLSO("ID");
            }
        }

        /// <summary>
        /// Amount of platinum attached to this message.
        /// </summary>
        public int Platinum
        {
            get
            {
                Trace.WriteLine(String.Format("MailMessage:Platinum"));
                return this.GetIntFromLSO("Platinum");
            }
        }

        /// <summary>
        /// Amount of silver attached to this message.
        /// </summary>
        public int Silver
        {
            get
            {
                Trace.WriteLine(String.Format("MailMessage:Silver"));
                return this.GetIntFromLSO("Silver");
            }
        }

        /// <summary>
        /// The subject line of this message.
        /// </summary>
        public string Subject
        {
            get
            {
                Trace.WriteLine(String.Format("MailMessage:Subject"));
                return this.GetStringFromLSO("Subject");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Deletes this mail message.
        /// </summary>
        /// <returns>call success</returns>
        public bool Delete()
        {
            Trace.WriteLine(String.Format("MailMessage:Delete()"));
            return this.ExecuteMethod("Delete");
        }

        /// <summary>
        /// Receives (takes) the attachment(s) from this mail message.
        /// </summary>
        /// <returns>call success</returns>
        public bool ReceiveAttachment()
        {
            Trace.WriteLine(String.Format("MailMessage:ReceiveAttachment()"));
            return this.ExecuteMethod("ReceiveAttachment");
        }

        #endregion

    }
}
