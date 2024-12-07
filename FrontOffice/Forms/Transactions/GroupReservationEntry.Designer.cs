
namespace FrontOffice.Forms.Transactions
{
    partial class GroupReservationEntry
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDeptFlightNo = new System.Windows.Forms.TextBox();
            this.ETD = new System.Windows.Forms.Label();
            this.dtpETD = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFlightNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpETA = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPaxNo = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbReservedBy = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.optAirportPickNo = new System.Windows.Forms.RadioButton();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.optAirportPickYes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.stBr = new System.Windows.Forms.StatusBar();
            this.grpGroupReservation = new System.Windows.Forms.GroupBox();
            this.grpAirportDrop = new System.Windows.Forms.GroupBox();
            this.optAirDropNo = new System.Windows.Forms.RadioButton();
            this.optAirDropYes = new System.Windows.Forms.RadioButton();
            this.gtpAirportPik = new System.Windows.Forms.GroupBox();
            this.cmbGuestCompany = new System.Windows.Forms.ComboBox();
            this.txtNumberofGuest = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbGuestReference = new System.Windows.Forms.ComboBox();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpGroupReservation.SuspendLayout();
            this.grpAirportDrop.SuspendLayout();
            this.gtpAirportPik.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtDeptFlightNo);
            this.groupBox3.Controls.Add(this.ETD);
            this.groupBox3.Controls.Add(this.dtpETD);
            this.groupBox3.Location = new System.Drawing.Point(25, 475);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 45);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Departure";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Flight No.";
            // 
            // txtDeptFlightNo
            // 
            this.txtDeptFlightNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDeptFlightNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptFlightNo.Location = new System.Drawing.Point(86, 16);
            this.txtDeptFlightNo.MaxLength = 50;
            this.txtDeptFlightNo.Name = "txtDeptFlightNo";
            this.txtDeptFlightNo.Size = new System.Drawing.Size(132, 24);
            this.txtDeptFlightNo.TabIndex = 1;
            // 
            // ETD
            // 
            this.ETD.AutoSize = true;
            this.ETD.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ETD.Location = new System.Drawing.Point(234, 19);
            this.ETD.Name = "ETD";
            this.ETD.Size = new System.Drawing.Size(36, 17);
            this.ETD.TabIndex = 2;
            this.ETD.Text = "ETD";
            // 
            // dtpETD
            // 
            this.dtpETD.CustomFormat = "HH:mm:ss";
            this.dtpETD.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpETD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpETD.Location = new System.Drawing.Point(276, 15);
            this.dtpETD.Name = "dtpETD";
            this.dtpETD.ShowUpDown = true;
            this.dtpETD.Size = new System.Drawing.Size(100, 24);
            this.dtpETD.TabIndex = 3;
            this.dtpETD.Value = new System.DateTime(2012, 6, 12, 12, 0, 0, 0);
            this.dtpETD.ValueChanged += new System.EventHandler(this.dtpETD_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtFlightNo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtpETA);
            this.groupBox2.Location = new System.Drawing.Point(25, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 53);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arrival";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(2, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Flight No.";
            // 
            // txtFlightNo
            // 
            this.txtFlightNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFlightNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNo.Location = new System.Drawing.Point(86, 18);
            this.txtFlightNo.MaxLength = 50;
            this.txtFlightNo.Name = "txtFlightNo";
            this.txtFlightNo.Size = new System.Drawing.Size(133, 24);
            this.txtFlightNo.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(234, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "ETA";
            // 
            // dtpETA
            // 
            this.dtpETA.CustomFormat = "HH:mm:ss";
            this.dtpETA.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpETA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpETA.Location = new System.Drawing.Point(276, 18);
            this.dtpETA.Name = "dtpETA";
            this.dtpETA.ShowUpDown = true;
            this.dtpETA.Size = new System.Drawing.Size(100, 24);
            this.dtpETA.TabIndex = 3;
            this.dtpETA.Value = new System.DateTime(2012, 6, 12, 14, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(31, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Pax";
            // 
            // txtPaxNo
            // 
            this.txtPaxNo.BackColor = System.Drawing.Color.White;
            this.txtPaxNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaxNo.Location = new System.Drawing.Point(162, 369);
            this.txtPaxNo.MaxLength = 50;
            this.txtPaxNo.Name = "txtPaxNo";
            this.txtPaxNo.Size = new System.Drawing.Size(258, 24);
            this.txtPaxNo.TabIndex = 19;
            this.txtPaxNo.Text = "1";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(113, 594);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(307, 23);
            this.txtRemarks.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(31, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Remarks";
            // 
            // lblRate
            // 
            this.lblRate.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRate.Location = new System.Drawing.Point(31, 259);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(80, 15);
            this.lblRate.TabIndex = 12;
            this.lblRate.Text = "Rate";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(162, 255);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(258, 23);
            this.txtRate.TabIndex = 13;
            this.txtRate.Text = "0";
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(31, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Reserved By ";
            // 
            // cmbReservedBy
            // 
            this.cmbReservedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbReservedBy.BackColor = System.Drawing.Color.Ivory;
            this.cmbReservedBy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReservedBy.FormattingEnabled = true;
            this.cmbReservedBy.Location = new System.Drawing.Point(162, 329);
            this.cmbReservedBy.Name = "cmbReservedBy";
            this.cmbReservedBy.Size = new System.Drawing.Size(258, 25);
            this.cmbReservedBy.TabIndex = 17;
            // 
            // txtNumber
            // 
            this.txtNumber.Enabled = false;
            this.txtNumber.Location = new System.Drawing.Point(162, 21);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(258, 23);
            this.txtNumber.TabIndex = 1;
            // 
            // cmdClose
            // 
            this.cmdClose.Enabled = false;
            this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClose.Location = new System.Drawing.Point(339, 17);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(78, 23);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            // 
            // optAirportPickNo
            // 
            this.optAirportPickNo.AutoSize = true;
            this.optAirportPickNo.Checked = true;
            this.optAirportPickNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.optAirportPickNo.Location = new System.Drawing.Point(69, 20);
            this.optAirportPickNo.Name = "optAirportPickNo";
            this.optAirportPickNo.Size = new System.Drawing.Size(51, 22);
            this.optAirportPickNo.TabIndex = 0;
            this.optAirportPickNo.TabStop = true;
            this.optAirportPickNo.Text = "No";
            this.optAirportPickNo.UseVisualStyleBackColor = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdAdd.Location = new System.Drawing.Point(21, 17);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(78, 23);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // optAirportPickYes
            // 
            this.optAirportPickYes.AutoSize = true;
            this.optAirportPickYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.optAirportPickYes.Location = new System.Drawing.Point(6, 20);
            this.optAirportPickYes.Name = "optAirportPickYes";
            this.optAirportPickYes.Size = new System.Drawing.Size(57, 22);
            this.optAirportPickYes.TabIndex = 1;
            this.optAirportPickYes.Text = "Yes";
            this.optAirportPickYes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdClose);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.cmdAdd);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(27, 645);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 50);
            this.groupBox1.TabIndex = 551;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSave.Location = new System.Drawing.Point(180, 17);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(78, 23);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // stBr
            // 
            this.stBr.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stBr.Location = new System.Drawing.Point(0, 701);
            this.stBr.Name = "stBr";
            this.stBr.Size = new System.Drawing.Size(513, 20);
            this.stBr.TabIndex = 552;
            this.stBr.Text = "Group Booking";
            // 
            // grpGroupReservation
            // 
            this.grpGroupReservation.Controls.Add(this.grpAirportDrop);
            this.grpGroupReservation.Controls.Add(this.gtpAirportPik);
            this.grpGroupReservation.Controls.Add(this.groupBox3);
            this.grpGroupReservation.Controls.Add(this.groupBox2);
            this.grpGroupReservation.Controls.Add(this.label8);
            this.grpGroupReservation.Controls.Add(this.txtPaxNo);
            this.grpGroupReservation.Controls.Add(this.txtRemarks);
            this.grpGroupReservation.Controls.Add(this.label6);
            this.grpGroupReservation.Controls.Add(this.lblRate);
            this.grpGroupReservation.Controls.Add(this.txtRate);
            this.grpGroupReservation.Controls.Add(this.label5);
            this.grpGroupReservation.Controls.Add(this.cmbReservedBy);
            this.grpGroupReservation.Controls.Add(this.txtNumber);
            this.grpGroupReservation.Controls.Add(this.cmbGuestCompany);
            this.grpGroupReservation.Controls.Add(this.txtNumberofGuest);
            this.grpGroupReservation.Controls.Add(this.label7);
            this.grpGroupReservation.Controls.Add(this.label3);
            this.grpGroupReservation.Controls.Add(this.dtpDeparture);
            this.grpGroupReservation.Controls.Add(this.label2);
            this.grpGroupReservation.Controls.Add(this.label13);
            this.grpGroupReservation.Controls.Add(this.cmbGuestReference);
            this.grpGroupReservation.Controls.Add(this.dtpArrivalDate);
            this.grpGroupReservation.Controls.Add(this.label1);
            this.grpGroupReservation.Controls.Add(this.label4);
            this.grpGroupReservation.Controls.Add(this.lblRoomType);
            this.grpGroupReservation.Controls.Add(this.cmbRoomType);
            this.grpGroupReservation.Enabled = false;
            this.grpGroupReservation.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGroupReservation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpGroupReservation.Location = new System.Drawing.Point(27, 12);
            this.grpGroupReservation.Name = "grpGroupReservation";
            this.grpGroupReservation.Size = new System.Drawing.Size(452, 627);
            this.grpGroupReservation.TabIndex = 550;
            this.grpGroupReservation.TabStop = false;
            this.grpGroupReservation.Text = "Group Booking";
            // 
            // grpAirportDrop
            // 
            this.grpAirportDrop.Controls.Add(this.optAirDropNo);
            this.grpAirportDrop.Controls.Add(this.optAirDropYes);
            this.grpAirportDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAirportDrop.Location = new System.Drawing.Point(226, 526);
            this.grpAirportDrop.Name = "grpAirportDrop";
            this.grpAirportDrop.Size = new System.Drawing.Size(192, 51);
            this.grpAirportDrop.TabIndex = 25;
            this.grpAirportDrop.TabStop = false;
            this.grpAirportDrop.Text = "Airport Drop?";
            // 
            // optAirDropNo
            // 
            this.optAirDropNo.AutoSize = true;
            this.optAirDropNo.Checked = true;
            this.optAirDropNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.optAirDropNo.Location = new System.Drawing.Point(68, 19);
            this.optAirDropNo.Name = "optAirDropNo";
            this.optAirDropNo.Size = new System.Drawing.Size(51, 22);
            this.optAirDropNo.TabIndex = 1;
            this.optAirDropNo.TabStop = true;
            this.optAirDropNo.Text = "No";
            this.optAirDropNo.UseVisualStyleBackColor = true;
            // 
            // optAirDropYes
            // 
            this.optAirDropYes.AutoSize = true;
            this.optAirDropYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.optAirDropYes.Location = new System.Drawing.Point(14, 19);
            this.optAirDropYes.Name = "optAirDropYes";
            this.optAirDropYes.Size = new System.Drawing.Size(57, 22);
            this.optAirDropYes.TabIndex = 0;
            this.optAirDropYes.Text = "Yes";
            this.optAirDropYes.UseVisualStyleBackColor = true;
            // 
            // gtpAirportPik
            // 
            this.gtpAirportPik.Controls.Add(this.optAirportPickNo);
            this.gtpAirportPik.Controls.Add(this.optAirportPickYes);
            this.gtpAirportPik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtpAirportPik.Location = new System.Drawing.Point(26, 526);
            this.gtpAirportPik.Name = "gtpAirportPik";
            this.gtpAirportPik.Size = new System.Drawing.Size(194, 51);
            this.gtpAirportPik.TabIndex = 24;
            this.gtpAirportPik.TabStop = false;
            this.gtpAirportPik.Text = "Airport Pickup?";
            // 
            // cmbGuestCompany
            // 
            this.cmbGuestCompany.BackColor = System.Drawing.SystemColors.Info;
            this.cmbGuestCompany.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGuestCompany.FormattingEnabled = true;
            this.cmbGuestCompany.Location = new System.Drawing.Point(162, 98);
            this.cmbGuestCompany.MaxLength = 50;
            this.cmbGuestCompany.Name = "cmbGuestCompany";
            this.cmbGuestCompany.Size = new System.Drawing.Size(258, 25);
            this.cmbGuestCompany.TabIndex = 5;
            // 
            // txtNumberofGuest
            // 
            this.txtNumberofGuest.Location = new System.Drawing.Point(162, 292);
            this.txtNumberofGuest.Name = "txtNumberofGuest";
            this.txtNumberofGuest.Size = new System.Drawing.Size(258, 23);
            this.txtNumberofGuest.TabIndex = 15;
            this.txtNumberofGuest.Text = "1";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(31, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "&Arrival ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(31, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reservation ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.CustomFormat = "dd/MM/yyyy";
            this.dtpDeparture.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeparture.Location = new System.Drawing.Point(162, 177);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(258, 24);
            this.dtpDeparture.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(31, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Copy #";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(31, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "Departure Date";
            // 
            // cmbGuestReference
            // 
            this.cmbGuestReference.BackColor = System.Drawing.SystemColors.Info;
            this.cmbGuestReference.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGuestReference.FormattingEnabled = true;
            this.cmbGuestReference.Location = new System.Drawing.Point(161, 58);
            this.cmbGuestReference.MaxLength = 50;
            this.cmbGuestReference.Name = "cmbGuestReference";
            this.cmbGuestReference.Size = new System.Drawing.Size(258, 25);
            this.cmbGuestReference.TabIndex = 3;
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpArrivalDate.CustomFormat = "dd/MM/yyyy";
            this.dtpArrivalDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalDate.Location = new System.Drawing.Point(161, 138);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(258, 24);
            this.dtpArrivalDate.TabIndex = 7;
            this.dtpArrivalDate.ValueChanged += new System.EventHandler(this.dtpArrivalDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(31, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ref.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(31, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Company";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRoomType.Location = new System.Drawing.Point(31, 221);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(80, 15);
            this.lblRoomType.TabIndex = 10;
            this.lblRoomType.Text = "Room Type";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRoomType.BackColor = System.Drawing.SystemColors.Info;
            this.cmbRoomType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(162, 216);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(258, 24);
            this.cmbRoomType.TabIndex = 11;
            // 
            // GroupReservationEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 721);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stBr);
            this.Controls.Add(this.grpGroupReservation);
            this.Name = "GroupReservationEntry";
            this.Text = "Group Booking";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpGroupReservation.ResumeLayout(false);
            this.grpGroupReservation.PerformLayout();
            this.grpAirportDrop.ResumeLayout(false);
            this.grpAirportDrop.PerformLayout();
            this.gtpAirportPik.ResumeLayout(false);
            this.gtpAirportPik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDeptFlightNo;
        private System.Windows.Forms.Label ETD;
        private System.Windows.Forms.DateTimePicker dtpETD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFlightNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpETA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPaxNo;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbReservedBy;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.RadioButton optAirportPickNo;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.RadioButton optAirportPickYes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.StatusBar stBr;
        private System.Windows.Forms.GroupBox grpGroupReservation;
        private System.Windows.Forms.GroupBox grpAirportDrop;
        private System.Windows.Forms.RadioButton optAirDropNo;
        private System.Windows.Forms.RadioButton optAirDropYes;
        private System.Windows.Forms.GroupBox gtpAirportPik;
        private System.Windows.Forms.ComboBox cmbGuestCompany;
        private System.Windows.Forms.TextBox txtNumberofGuest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbGuestReference;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbRoomType;
    }
}