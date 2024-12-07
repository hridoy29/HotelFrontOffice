
namespace FrontOffice.Forms.Transactions
{
    partial class FrontOfficeMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemGroupBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInCheckOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemServiceEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemBillPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemBillTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.miscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationToolStripMenuItem,
            this.checkInCheckOutToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.miscToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1121, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemBooking,
            this.mnuItemGroupBooking});
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.reservationToolStripMenuItem.Text = "Booking Info";
            // 
            // mnuItemBooking
            // 
            this.mnuItemBooking.Name = "mnuItemBooking";
            this.mnuItemBooking.Size = new System.Drawing.Size(224, 26);
            this.mnuItemBooking.Text = "Booking";
            this.mnuItemBooking.Click += new System.EventHandler(this.reservationEntryToolStripMenuItem_Click);
            // 
            // mnuItemGroupBooking
            // 
            this.mnuItemGroupBooking.Name = "mnuItemGroupBooking";
            this.mnuItemGroupBooking.Size = new System.Drawing.Size(224, 26);
            this.mnuItemGroupBooking.Text = "Group Booking";
            this.mnuItemGroupBooking.Click += new System.EventHandler(this.mnuItemGroupBooking_Click);
            // 
            // checkInCheckOutToolStripMenuItem
            // 
            this.checkInCheckOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemCheckIn,
            this.mnuItemCheckOut});
            this.checkInCheckOutToolStripMenuItem.Name = "checkInCheckOutToolStripMenuItem";
            this.checkInCheckOutToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.checkInCheckOutToolStripMenuItem.Text = "Check In / Check Out";
            // 
            // mnuItemCheckIn
            // 
            this.mnuItemCheckIn.Name = "mnuItemCheckIn";
            this.mnuItemCheckIn.Size = new System.Drawing.Size(224, 26);
            this.mnuItemCheckIn.Text = "Check In";
            this.mnuItemCheckIn.Click += new System.EventHandler(this.mnuItemCheckIn_Click);
            // 
            // mnuItemCheckOut
            // 
            this.mnuItemCheckOut.Name = "mnuItemCheckOut";
            this.mnuItemCheckOut.Size = new System.Drawing.Size(224, 26);
            this.mnuItemCheckOut.Text = "Check Out";
            this.mnuItemCheckOut.Click += new System.EventHandler(this.mnuItemCheckOut_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemServiceEntry});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.serviceToolStripMenuItem.Text = "Service Info";
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemBillPayment,
            this.mnuItemBillTransfer});
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.billingToolStripMenuItem.Text = "Billing Info";
            this.billingToolStripMenuItem.Click += new System.EventHandler(this.billingToolStripMenuItem_Click);
            // 
            // mnuItemServiceEntry
            // 
            this.mnuItemServiceEntry.Name = "mnuItemServiceEntry";
            this.mnuItemServiceEntry.Size = new System.Drawing.Size(224, 26);
            this.mnuItemServiceEntry.Text = "Service Entry";
            this.mnuItemServiceEntry.Click += new System.EventHandler(this.mnuItemServiceEntry_Click);
            // 
            // mnuItemBillPayment
            // 
            this.mnuItemBillPayment.Name = "mnuItemBillPayment";
            this.mnuItemBillPayment.Size = new System.Drawing.Size(224, 26);
            this.mnuItemBillPayment.Text = "Bill Payment";
            this.mnuItemBillPayment.Click += new System.EventHandler(this.mnuItemBillPayment_Click);
            // 
            // mnuItemBillTransfer
            // 
            this.mnuItemBillTransfer.Name = "mnuItemBillTransfer";
            this.mnuItemBillTransfer.Size = new System.Drawing.Size(224, 26);
            this.mnuItemBillTransfer.Text = "Bill Transfer";
            this.mnuItemBillTransfer.Click += new System.EventHandler(this.mnuItemBillTransfer_Click);
            // 
            // miscToolStripMenuItem
            // 
            this.miscToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomTransferToolStripMenuItem});
            this.miscToolStripMenuItem.Name = "miscToolStripMenuItem";
            this.miscToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.miscToolStripMenuItem.Text = "Misc.";
            // 
            // roomTransferToolStripMenuItem
            // 
            this.roomTransferToolStripMenuItem.Name = "roomTransferToolStripMenuItem";
            this.roomTransferToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.roomTransferToolStripMenuItem.Text = "RoomTransfer";
            this.roomTransferToolStripMenuItem.Click += new System.EventHandler(this.roomTransferToolStripMenuItem_Click);
            // 
            // FrontOfficeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 544);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrontOfficeMain";
            this.Text = "FrontOfficeMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuItemGroupBooking;
        private System.Windows.Forms.ToolStripMenuItem checkInCheckOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCheckIn;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCheckOut;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemServiceEntry;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBillPayment;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBillTransfer;
        private System.Windows.Forms.ToolStripMenuItem miscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomTransferToolStripMenuItem;
    }
}