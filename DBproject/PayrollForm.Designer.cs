namespace DBproject
{
    partial class PayrollForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvPayroll = new System.Windows.Forms.DataGridView();
            this.lblDISPLAY = new System.Windows.Forms.Label();
            this.lblEMPPAYSLIP = new System.Windows.Forms.Label();
            this.btnGENER = new System.Windows.Forms.Button();
            this.btnCALC = new System.Windows.Forms.Button();
            this.lblAMOUNT = new System.Windows.Forms.Label();
            this.txtNETPAY = new System.Windows.Forms.TextBox();
            this.lblTNETPAY = new System.Windows.Forms.Label();
            this.txtTAXES = new System.Windows.Forms.TextBox();
            this.txtmedallow = new System.Windows.Forms.TextBox();
            this.txtGROSSPAY = new System.Windows.Forms.TextBox();
            this.txthours = new System.Windows.Forms.TextBox();
            this.txtrates = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTAXES = new System.Windows.Forms.Label();
            this.lblMEDALL = new System.Windows.Forms.Label();
            this.lblgrosspay = new System.Windows.Forms.Label();
            this.lblHRSWORK = new System.Windows.Forms.Label();
            this.lblHRSRATE = new System.Windows.Forms.Label();
            this.lblEAR = new System.Windows.Forms.Label();
            this.lblNAME = new System.Windows.Forms.Label();
            this.lblEMPID = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnret = new System.Windows.Forms.Button();
            this.lbldatetime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblday2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPayroll
            // 
            this.dgvPayroll.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayroll.Location = new System.Drawing.Point(428, 132);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.Size = new System.Drawing.Size(354, 393);
            this.dgvPayroll.TabIndex = 103;
            // 
            // lblDISPLAY
            // 
            this.lblDISPLAY.AutoSize = true;
            this.lblDISPLAY.Location = new System.Drawing.Point(425, 116);
            this.lblDISPLAY.Name = "lblDISPLAY";
            this.lblDISPLAY.Size = new System.Drawing.Size(52, 13);
            this.lblDISPLAY.TabIndex = 102;
            this.lblDISPLAY.Text = "DISPLAY";
            // 
            // lblEMPPAYSLIP
            // 
            this.lblEMPPAYSLIP.AutoSize = true;
            this.lblEMPPAYSLIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMPPAYSLIP.Location = new System.Drawing.Point(162, 107);
            this.lblEMPPAYSLIP.Name = "lblEMPPAYSLIP";
            this.lblEMPPAYSLIP.Size = new System.Drawing.Size(239, 25);
            this.lblEMPPAYSLIP.TabIndex = 100;
            this.lblEMPPAYSLIP.Text = "EMPLOYEE PAYSLIP\r\n";
            // 
            // btnGENER
            // 
            this.btnGENER.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGENER.Location = new System.Drawing.Point(185, 442);
            this.btnGENER.Name = "btnGENER";
            this.btnGENER.Size = new System.Drawing.Size(119, 23);
            this.btnGENER.TabIndex = 99;
            this.btnGENER.Text = "GENERATE";
            this.btnGENER.UseVisualStyleBackColor = false;
            this.btnGENER.Click += new System.EventHandler(this.btnGENER_Click);
            // 
            // btnCALC
            // 
            this.btnCALC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCALC.Location = new System.Drawing.Point(12, 442);
            this.btnCALC.Name = "btnCALC";
            this.btnCALC.Size = new System.Drawing.Size(114, 23);
            this.btnCALC.TabIndex = 98;
            this.btnCALC.Text = "CALCULATE";
            this.btnCALC.UseVisualStyleBackColor = false;
            this.btnCALC.Click += new System.EventHandler(this.btnCALC_Click);
            // 
            // lblAMOUNT
            // 
            this.lblAMOUNT.AutoSize = true;
            this.lblAMOUNT.Location = new System.Drawing.Point(201, 212);
            this.lblAMOUNT.Name = "lblAMOUNT";
            this.lblAMOUNT.Size = new System.Drawing.Size(61, 13);
            this.lblAMOUNT.TabIndex = 97;
            this.lblAMOUNT.Text = "AMOUNTS";
            // 
            // txtNETPAY
            // 
            this.txtNETPAY.Location = new System.Drawing.Point(185, 395);
            this.txtNETPAY.Name = "txtNETPAY";
            this.txtNETPAY.Size = new System.Drawing.Size(100, 20);
            this.txtNETPAY.TabIndex = 96;
            // 
            // lblTNETPAY
            // 
            this.lblTNETPAY.AutoSize = true;
            this.lblTNETPAY.Location = new System.Drawing.Point(9, 402);
            this.lblTNETPAY.Name = "lblTNETPAY";
            this.lblTNETPAY.Size = new System.Drawing.Size(104, 13);
            this.lblTNETPAY.TabIndex = 95;
            this.lblTNETPAY.Text = "TOTAL EARNINGS:";
            // 
            // txtTAXES
            // 
            this.txtTAXES.Location = new System.Drawing.Point(185, 362);
            this.txtTAXES.Name = "txtTAXES";
            this.txtTAXES.Size = new System.Drawing.Size(100, 20);
            this.txtTAXES.TabIndex = 94;
            // 
            // txtmedallow
            // 
            this.txtmedallow.Location = new System.Drawing.Point(185, 330);
            this.txtmedallow.Name = "txtmedallow";
            this.txtmedallow.Size = new System.Drawing.Size(100, 20);
            this.txtmedallow.TabIndex = 93;
            // 
            // txtGROSSPAY
            // 
            this.txtGROSSPAY.Location = new System.Drawing.Point(185, 304);
            this.txtGROSSPAY.Name = "txtGROSSPAY";
            this.txtGROSSPAY.Size = new System.Drawing.Size(100, 20);
            this.txtGROSSPAY.TabIndex = 92;
            // 
            // txthours
            // 
            this.txthours.Location = new System.Drawing.Point(185, 272);
            this.txthours.Name = "txthours";
            this.txthours.Size = new System.Drawing.Size(100, 20);
            this.txthours.TabIndex = 91;
            this.txthours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthours_KeyPress);
            // 
            // txtrates
            // 
            this.txtrates.Location = new System.Drawing.Point(185, 241);
            this.txtrates.Name = "txtrates";
            this.txtrates.Size = new System.Drawing.Size(100, 20);
            this.txtrates.TabIndex = 90;
            this.txtrates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrates_KeyPress);
            this.txtrates.Validating += new System.ComponentModel.CancelEventHandler(this.txtrates_Validating);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(185, 147);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 89;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(185, 174);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 88;
            // 
            // lblTAXES
            // 
            this.lblTAXES.AutoSize = true;
            this.lblTAXES.Location = new System.Drawing.Point(11, 369);
            this.lblTAXES.Name = "lblTAXES";
            this.lblTAXES.Size = new System.Drawing.Size(45, 13);
            this.lblTAXES.TabIndex = 87;
            this.lblTAXES.Text = "TAXES:";
            // 
            // lblMEDALL
            // 
            this.lblMEDALL.AutoSize = true;
            this.lblMEDALL.Location = new System.Drawing.Point(9, 337);
            this.lblMEDALL.Name = "lblMEDALL";
            this.lblMEDALL.Size = new System.Drawing.Size(120, 13);
            this.lblMEDALL.TabIndex = 86;
            this.lblMEDALL.Text = "MEDICAL ALLOWNCE:";
            // 
            // lblgrosspay
            // 
            this.lblgrosspay.AutoSize = true;
            this.lblgrosspay.Location = new System.Drawing.Point(9, 311);
            this.lblgrosspay.Name = "lblgrosspay";
            this.lblgrosspay.Size = new System.Drawing.Size(72, 13);
            this.lblgrosspay.TabIndex = 85;
            this.lblgrosspay.Text = "GROSS PAY:";
            // 
            // lblHRSWORK
            // 
            this.lblHRSWORK.AutoSize = true;
            this.lblHRSWORK.Location = new System.Drawing.Point(9, 279);
            this.lblHRSWORK.Name = "lblHRSWORK";
            this.lblHRSWORK.Size = new System.Drawing.Size(101, 13);
            this.lblHRSWORK.TabIndex = 84;
            this.lblHRSWORK.Text = "HOURS WORKED:";
            // 
            // lblHRSRATE
            // 
            this.lblHRSRATE.AutoSize = true;
            this.lblHRSRATE.Location = new System.Drawing.Point(9, 248);
            this.lblHRSRATE.Name = "lblHRSRATE";
            this.lblHRSRATE.Size = new System.Drawing.Size(81, 13);
            this.lblHRSRATE.TabIndex = 83;
            this.lblHRSRATE.Text = "HOURS RATE:";
            // 
            // lblEAR
            // 
            this.lblEAR.AutoSize = true;
            this.lblEAR.Location = new System.Drawing.Point(9, 212);
            this.lblEAR.Name = "lblEAR";
            this.lblEAR.Size = new System.Drawing.Size(63, 13);
            this.lblEAR.TabIndex = 82;
            this.lblEAR.Text = "EARNINGS";
            // 
            // lblNAME
            // 
            this.lblNAME.AutoSize = true;
            this.lblNAME.Location = new System.Drawing.Point(9, 181);
            this.lblNAME.Name = "lblNAME";
            this.lblNAME.Size = new System.Drawing.Size(70, 13);
            this.lblNAME.TabIndex = 80;
            this.lblNAME.Text = "FULL NAME:";
            // 
            // lblEMPID
            // 
            this.lblEMPID.AutoSize = true;
            this.lblEMPID.Location = new System.Drawing.Point(9, 154);
            this.lblEMPID.Name = "lblEMPID";
            this.lblEMPID.Size = new System.Drawing.Size(70, 13);
            this.lblEMPID.TabIndex = 79;
            this.lblEMPID.Text = "Employee ID:";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnexit.Location = new System.Drawing.Point(12, 502);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(114, 23);
            this.btnexit.TabIndex = 104;
            this.btnexit.Text = "Go Back";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnret
            // 
            this.btnret.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnret.Location = new System.Drawing.Point(185, 502);
            this.btnret.Name = "btnret";
            this.btnret.Size = new System.Drawing.Size(119, 23);
            this.btnret.TabIndex = 105;
            this.btnret.Text = "Retrieve";
            this.btnret.UseVisualStyleBackColor = false;
            this.btnret.Click += new System.EventHandler(this.btnret_Click);
            // 
            // lbldatetime
            // 
            this.lbldatetime.AutoSize = true;
            this.lbldatetime.Location = new System.Drawing.Point(109, 63);
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.Size(47, 13);
            this.lbldatetime.TabIndex = 107;
            this.lbldatetime.Text = "datetime";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Old English Text MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(250, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 19);
            this.label11.TabIndex = 110;
            this.label11.Text = "Day:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Old English Text MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 19);
            this.label16.TabIndex = 109;
            this.label16.Text = "Date Time:";
            // 
            // lblday2
            // 
            this.lblday2.AutoSize = true;
            this.lblday2.Location = new System.Drawing.Point(318, 62);
            this.lblday2.Name = "lblday2";
            this.lblday2.Size = new System.Drawing.Size(24, 13);
            this.lblday2.TabIndex = 108;
            this.lblday2.Text = "day";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 633);
            this.Controls.Add(this.lbldatetime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblday2);
            this.Controls.Add(this.btnret);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.dgvPayroll);
            this.Controls.Add(this.lblDISPLAY);
            this.Controls.Add(this.lblEMPPAYSLIP);
            this.Controls.Add(this.btnGENER);
            this.Controls.Add(this.btnCALC);
            this.Controls.Add(this.lblAMOUNT);
            this.Controls.Add(this.txtNETPAY);
            this.Controls.Add(this.lblTNETPAY);
            this.Controls.Add(this.txtTAXES);
            this.Controls.Add(this.txtmedallow);
            this.Controls.Add(this.txtGROSSPAY);
            this.Controls.Add(this.txthours);
            this.Controls.Add(this.txtrates);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTAXES);
            this.Controls.Add(this.lblMEDALL);
            this.Controls.Add(this.lblgrosspay);
            this.Controls.Add(this.lblHRSWORK);
            this.Controls.Add(this.lblHRSRATE);
            this.Controls.Add(this.lblEAR);
            this.Controls.Add(this.lblNAME);
            this.Controls.Add(this.lblEMPID);
            this.Name = "PayrollForm";
            this.Text = "PayrollForm";
            this.Load += new System.EventHandler(this.PayrollForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPayroll;
        private System.Windows.Forms.Label lblDISPLAY;
        private System.Windows.Forms.Label lblEMPPAYSLIP;
        private System.Windows.Forms.Button btnGENER;
        private System.Windows.Forms.Button btnCALC;
        private System.Windows.Forms.Label lblAMOUNT;
        private System.Windows.Forms.TextBox txtNETPAY;
        private System.Windows.Forms.Label lblTNETPAY;
        private System.Windows.Forms.TextBox txtTAXES;
        private System.Windows.Forms.TextBox txtmedallow;
        private System.Windows.Forms.TextBox txtGROSSPAY;
        private System.Windows.Forms.TextBox txthours;
        private System.Windows.Forms.TextBox txtrates;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTAXES;
        private System.Windows.Forms.Label lblMEDALL;
        private System.Windows.Forms.Label lblgrosspay;
        private System.Windows.Forms.Label lblHRSWORK;
        private System.Windows.Forms.Label lblHRSRATE;
        private System.Windows.Forms.Label lblEAR;
        private System.Windows.Forms.Label lblNAME;
        private System.Windows.Forms.Label lblEMPID;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnret;
        private System.Windows.Forms.Label lbldatetime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblday2;
        private System.Windows.Forms.Timer timer1;

    }
}