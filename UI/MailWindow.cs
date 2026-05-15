using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using EQ2.ISXEQ2.InventoryConsignment;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2mailwindow' datatype. Represents the main mail window
    /// (compose pane plus inbox listing). Inherits from EQ2Window. Recipient,
    /// Subject and Body return EQ2TextBox widgets (use SetProperty("Text", value)
    /// on those widgets to populate compose fields); Send returns the EQ2Button.
    /// </summary>
    public class MailWindow : EQ2Window
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public MailWindow(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The attachment item currently attached to the compose pane.
        /// </summary>
        public ItemInfo Attachment
        {
            get
            {
                Trace.WriteLine(String.Format("MailWindow:Attachment"));
                return new ItemInfo(this.GetMember("Attachment"));
            }
        }

        /// <summary>
        /// The compose-pane body textbox widget.
        /// </summary>
        public EQ2TextBox Body
        {
            get
            {
                Trace.WriteLine(String.Format("MailWindow:Body"));
                return new EQ2TextBox(this.GetMember("Body"));
            }
        }

        /// <summary>
        /// Amount of copper currently attached to the compose pane.
        /// </summary>
        public uint Copper
        {
            get
            {
                Trace.WriteLine(String.Format("MailWindow:Copper"));
                return this.GetUIntFromLSO("Copper");
            }
        }

        /// <summary>
        /// Amount of gold currently attached to the compose pane.
        /// </summary>
        public uint Gold
        {
            get
            {
                Trace.WriteLine(String.Format("MailWindow:Gold"));
                return this.GetUIntFromLSO("Gold");
            }
        }

        /// <summary>
        /// Returns the inbox message at the specified index. (1 to NumInbox)
        /// </summary>
        /// <param name="index">index (1-based)</param>
        /// <returns>InboxMailMessage</returns>
        public InboxMailMessage Inbox(int index)
        {
            Trace.WriteLine(String.Format("MailWindow:Inbox({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new InboxMailMessage(this.GetMember("Inbox", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// The number of messages currently in the inbox.
        /// </summary>
        public int NumInbox
        {
            get
            {
                Trace.WriteLine(String.Format("MailWindow:NumInbox"));
                return this.GetIntFromLSO("NumInbox");
            }
        }

        /// <summary>
        /// Amount of platinum currently attached to the compose pane.
        /// </summary>
        public uint Platinum
        {
            get
            {
                Trace.WriteLine(String.Format("MailWindow:Platinum"));
                return this.GetUIntFromLSO("Platinum");
            }
        }

        /// <summary>
        /// The compose-pane recipient textbox widget.
        /// </summary>
        public EQ2TextBox Recipient
        {
            get
            {
                Trace.WriteLine(String.Format("MailWindow:Recipient"));
                return new EQ2TextBox(this.GetMember("Recipient"));
            }
        }

        /// <summary>
        /// The compose-pane Send button widget. To send mail, click this button
        /// (e.g. via LeftClick on the EQ2Button).
        /// </summary>
        public EQ2Button Send
        {
            get
            {
                Trace.WriteLine(String.Format("MailWindow:Send"));
                return new EQ2Button(this.GetMember("Send"));
            }
        }

        /// <summary>
        /// Amount of silver currently attached to the compose pane.
        /// </summary>
        public uint Silver
        {
            get
            {
                Trace.WriteLine(String.Format("MailWindow:Silver"));
                return this.GetUIntFromLSO("Silver");
            }
        }

        /// <summary>
        /// The compose-pane subject textbox widget.
        /// </summary>
        public EQ2TextBox Subject
        {
            get
            {
                Trace.WriteLine(String.Format("MailWindow:Subject"));
                return new EQ2TextBox(this.GetMember("Subject"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds the specified amount of copper to the compose pane. Amount must be at least 1.
        /// </summary>
        /// <param name="amount">amount of copper to add (>= 1)</param>
        /// <returns>call success</returns>
        public bool AddCopper(int amount)
        {
            Trace.WriteLine(String.Format("MailWindow:AddCopper({0})", amount.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddCopper", amount.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Adds the specified amount of gold to the compose pane. Amount must be at least 1.
        /// </summary>
        /// <param name="amount">amount of gold to add (>= 1)</param>
        /// <returns>call success</returns>
        public bool AddGold(int amount)
        {
            Trace.WriteLine(String.Format("MailWindow:AddGold({0})", amount.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddGold", amount.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Adds the specified amount of platinum to the compose pane. Amount must be at least 1.
        /// </summary>
        /// <param name="amount">amount of platinum to add (>= 1)</param>
        /// <returns>call success</returns>
        public bool AddPlatinum(int amount)
        {
            Trace.WriteLine(String.Format("MailWindow:AddPlatinum({0})", amount.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddPlatinum", amount.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Adds the specified amount of silver to the compose pane. Amount must be at least 1.
        /// </summary>
        /// <param name="amount">amount of silver to add (>= 1)</param>
        /// <returns>call success</returns>
        public bool AddSilver(int amount)
        {
            Trace.WriteLine(String.Format("MailWindow:AddSilver({0})", amount.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("AddSilver", amount.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Cancels the mail compose (issues the cancel_mail command).
        /// </summary>
        /// <returns>call success</returns>
        public bool Cancel()
        {
            Trace.WriteLine(String.Format("MailWindow:Cancel()"));
            return this.ExecuteMethod("Cancel");
        }

        /// <summary>
        /// Removes the attached item from the compose pane (issues set_mail_item).
        /// </summary>
        /// <returns>call success</returns>
        public bool RemoveAttachment()
        {
            Trace.WriteLine(String.Format("MailWindow:RemoveAttachment()"));
            return this.ExecuteMethod("RemoveAttachment");
        }

        /// <summary>
        /// Removes the specified amount of copper from the compose pane. Amount must be at least 1.
        /// </summary>
        /// <param name="amount">amount of copper to remove (>= 1)</param>
        /// <returns>call success</returns>
        public bool RemoveCopper(int amount)
        {
            Trace.WriteLine(String.Format("MailWindow:RemoveCopper({0})", amount.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("RemoveCopper", amount.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Removes the specified amount of gold from the compose pane. Amount must be at least 1.
        /// </summary>
        /// <param name="amount">amount of gold to remove (>= 1)</param>
        /// <returns>call success</returns>
        public bool RemoveGold(int amount)
        {
            Trace.WriteLine(String.Format("MailWindow:RemoveGold({0})", amount.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("RemoveGold", amount.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Removes the specified amount of platinum from the compose pane. Amount must be at least 1.
        /// </summary>
        /// <param name="amount">amount of platinum to remove (>= 1)</param>
        /// <returns>call success</returns>
        public bool RemovePlatinum(int amount)
        {
            Trace.WriteLine(String.Format("MailWindow:RemovePlatinum({0})", amount.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("RemovePlatinum", amount.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Removes the specified amount of silver from the compose pane. Amount must be at least 1.
        /// </summary>
        /// <param name="amount">amount of silver to remove (>= 1)</param>
        /// <returns>call success</returns>
        public bool RemoveSilver(int amount)
        {
            Trace.WriteLine(String.Format("MailWindow:RemoveSilver({0})", amount.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("RemoveSilver", amount.ToString(CultureInfo.InvariantCulture));
        }

        #endregion

    }
}
