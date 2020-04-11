namespace DBproject
{
    partial class CandidateForm
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
            this.masktxtphone = new System.Windows.Forms.MaskedTextBox();
            this.txtcancity = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comboexper = new System.Windows.Forms.ComboBox();
            this.comboapply = new System.Windows.Forms.ComboBox();
            this.combogender = new System.Windows.Forms.ComboBox();
            this.txtlastcompany = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtquali = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtcanid = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnret = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnaddcan = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtextraskill = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.combomartial = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // masktxtphone
            // 
            this.masktxtphone.Location = new System.Drawing.Point(124, 184);
            this.masktxtphone.Mask = "(9999) 000-0000";
            this.masktxtphone.Name = "masktxtphone";
            this.masktxtphone.Size = new System.Drawing.Size(161, 20);
            this.masktxtphone.TabIndex = 40;
            this.masktxtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.masktxtphone_KeyPress);
            // 
            // txtcancity
            // 
            this.txtcancity.Location = new System.Drawing.Point(124, 124);
            this.txtcancity.Name = "txtcancity";
            this.txtcancity.Size = new System.Drawing.Size(159, 20);
            this.txtcancity.TabIndex = 36;
            this.txtcancity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcancity_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 122);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 18);
            this.label19.TabIndex = 55;
            this.label19.Text = "City:";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(124, 98);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(159, 20);
            this.txtage.TabIndex = 35;
            this.txtage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtage_KeyPress);
            this.txtage.Validating += new System.ComponentModel.CancelEventHandler(this.txtage_Validating);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(9, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 18);
            this.label18.TabIndex = 54;
            this.label18.Text = "Age:";
            // 
            // comboexper
            // 
            this.comboexper.FormattingEnabled = true;
            this.comboexper.Items.AddRange(new object[] {
            "Newly Graduated",
            "1 year",
            "2 years",
            "3 years",
            "4 years",
            "5 years",
            "6 years",
            "7 years",
            "More then seven years"});
            this.comboexper.Location = new System.Drawing.Point(124, 330);
            this.comboexper.Name = "comboexper";
            this.comboexper.Size = new System.Drawing.Size(161, 21);
            this.comboexper.TabIndex = 52;
            // 
            // comboapply
            // 
            this.comboapply.FormattingEnabled = true;
            this.comboapply.Items.AddRange(new object[] {
            "ASP.Net developer",
            "Mobile Application developer",
            "Web Application developer",
            "Data Entry Operator"});
            this.comboapply.Location = new System.Drawing.Point(124, 300);
            this.comboapply.Name = "comboapply";
            this.comboapply.Size = new System.Drawing.Size(162, 21);
            this.comboapply.TabIndex = 51;
            this.comboapply.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboapply_KeyPress);
            // 
            // combogender
            // 
            this.combogender.FormattingEnabled = true;
            this.combogender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other",
            "Undefined"});
            this.combogender.Location = new System.Drawing.Point(124, 270);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(159, 21);
            this.combogender.TabIndex = 46;
            this.combogender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combogender_KeyPress);
            // 
            // txtlastcompany
            // 
            this.txtlastcompany.Location = new System.Drawing.Point(124, 361);
            this.txtlastcompany.Name = "txtlastcompany";
            this.txtlastcompany.Size = new System.Drawing.Size(159, 20);
            this.txtlastcompany.TabIndex = 53;
            this.txtlastcompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlastcompany_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(124, 210);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(162, 20);
            this.txtemail.TabIndex = 42;
            this.txtemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemail_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(324, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1009, 489);
            this.groupBox3.TabIndex = 98;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(996, 471);
            this.dataGridView1.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(674, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 97;
            this.label5.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 96;
            this.label3.Text = "Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1059, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(226, 32);
            this.label13.TabIndex = 95;
            this.label13.Text = "Minware Company";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 32);
            this.label14.TabIndex = 94;
            this.label14.Text = "Candidate form";
            // 
            // txtquali
            // 
            this.txtquali.Location = new System.Drawing.Point(124, 239);
            this.txtquali.Name = "txtquali";
            this.txtquali.Size = new System.Drawing.Size(161, 20);
            this.txtquali.TabIndex = 44;
            this.txtquali.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquali_KeyPress);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(124, 150);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(159, 20);
            this.txtaddress.TabIndex = 38;
            this.txtaddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaddress_KeyPress);
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(124, 72);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(159, 20);
            this.txtlastname.TabIndex = 33;
            this.txtlastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlastname_KeyPress);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(124, 44);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(159, 20);
            this.txtfirstname.TabIndex = 30;
            this.txtfirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfirstname_KeyPress);
            // 
            // txtcanid
            // 
            this.txtcanid.Location = new System.Drawing.Point(124, 16);
            this.txtcanid.Name = "txtcanid";
            this.txtcanid.Size = new System.Drawing.Size(159, 20);
            this.txtcanid.TabIndex = 29;
           
            this.txtcanid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcanid_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 360);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 18);
            this.label16.TabIndex = 50;
            this.label16.Text = "Last Compnay:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 330);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 18);
            this.label15.TabIndex = 49;
            this.label15.Text = "Job Experience:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "Applied for:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 18);
            this.label12.TabIndex = 43;
            this.label12.Text = "Gender:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 18);
            this.label11.TabIndex = 41;
            this.label11.Text = "Qualification:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnret);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnaddcan);
            this.groupBox1.Location = new System.Drawing.Point(14, 536);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 70);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            // 
            // btnret
            // 
            this.btnret.BackColor = System.Drawing.SystemColors.Control;
            this.btnret.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.btnret.Location = new System.Drawing.Point(298, 19);
            this.btnret.Name = "btnret";
            this.btnret.Size = new System.Drawing.Size(119, 39);
            this.btnret.TabIndex = 82;
            this.btnret.Text = "Retrieve";
            this.btnret.UseVisualStyleBackColor = false;
            this.btnret.Click += new System.EventHandler(this.btnret_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.Control;
            this.btndel.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(146, 19);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(119, 39);
            this.btndel.TabIndex = 79;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(596, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 39);
            this.button1.TabIndex = 78;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnaddcan
            // 
            this.btnaddcan.BackColor = System.Drawing.SystemColors.Control;
            this.btnaddcan.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcan.Location = new System.Drawing.Point(6, 19);
            this.btnaddcan.Name = "btnaddcan";
            this.btnaddcan.Size = new System.Drawing.Size(119, 39);
            this.btnaddcan.TabIndex = 77;
            this.btnaddcan.Text = "Add";
            this.btnaddcan.UseVisualStyleBackColor = false;
            this.btnaddcan.Click += new System.EventHandler(this.btnaddcan_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 37;
            this.label9.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Candidate ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtextraskill);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.combomartial);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.masktxtphone);
            this.groupBox2.Controls.Add(this.txtcancity);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtage);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.comboexper);
            this.groupBox2.Controls.Add(this.comboapply);
            this.groupBox2.Controls.Add(this.combogender);
            this.groupBox2.Controls.Add(this.txtlastcompany);
            this.groupBox2.Controls.Add(this.txtquali);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.txtlastname);
            this.groupBox2.Controls.Add(this.txtfirstname);
            this.groupBox2.Controls.Add(this.txtcanid);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(14, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 483);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            // 
            // txtextraskill
            // 
            this.txtextraskill.Location = new System.Drawing.Point(124, 425);
            this.txtextraskill.Name = "txtextraskill";
            this.txtextraskill.Size = new System.Drawing.Size(159, 20);
            this.txtextraskill.TabIndex = 64;
            this.txtextraskill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtextraskill_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 424);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 18);
            this.label17.TabIndex = 63;
            this.label17.Text = "Extra Skills:";
            // 
            // combomartial
            // 
            this.combomartial.FormattingEnabled = true;
            this.combomartial.Items.AddRange(new object[] {
            "Married",
            "Unmarried"});
            this.combomartial.Location = new System.Drawing.Point(125, 393);
            this.combomartial.Name = "combomartial";
            this.combomartial.Size = new System.Drawing.Size(162, 21);
            this.combomartial.TabIndex = 62;
            this.combomartial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combomartial_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(9, 393);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 18);
            this.label20.TabIndex = 61;
            this.label20.Text = "Martial Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "Last Name:";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.lblday.Location = new System.Drawing.Point(737, 21);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(42, 22);
            this.lblday.TabIndex = 100;
            this.lblday.Text = "Day";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.lbldate.Location = new System.Drawing.Point(388, 21);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(43, 22);
            this.lbldate.TabIndex = 99;
            this.lbldate.Text = "date";
            // 
            // CandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 635);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "CandidateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandidateForm";
            this.Load += new System.EventHandler(this.CandidateForm_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox masktxtphone;
        private System.Windows.Forms.TextBox txtcancity;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboexper;
        private System.Windows.Forms.ComboBox comboapply;
        private System.Windows.Forms.ComboBox combogender;
        private System.Windows.Forms.TextBox txtlastcompany;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtquali;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtcanid;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnret;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnaddcan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtextraskill;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox combomartial;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lbldate;
    }
}