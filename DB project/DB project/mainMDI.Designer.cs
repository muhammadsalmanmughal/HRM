namespace DB_project
{
    partial class mainMDI
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
            this.btnexit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnhir = new System.Windows.Forms.Button();
            this.btncandi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Silver;
            this.btnexit.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexit.Location = new System.Drawing.Point(12, 287);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(199, 43);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 43);
            this.button4.TabIndex = 18;
            this.button4.Text = "Payroll form";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 43);
            this.button3.TabIndex = 17;
            this.button3.Text = "Attendance Form";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnhir
            // 
            this.btnhir.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhir.Location = new System.Drawing.Point(12, 73);
            this.btnhir.Name = "btnhir";
            this.btnhir.Size = new System.Drawing.Size(199, 43);
            this.btnhir.TabIndex = 16;
            this.btnhir.Text = "Hiring form";
            this.btnhir.UseVisualStyleBackColor = true;
            // 
            // btncandi
            // 
            this.btncandi.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncandi.Location = new System.Drawing.Point(12, 23);
            this.btncandi.Name = "btncandi";
            this.btncandi.Size = new System.Drawing.Size(199, 43);
            this.btncandi.TabIndex = 15;
            this.btncandi.Text = "Candidate Form";
            this.btncandi.UseVisualStyleBackColor = true;
            this.btncandi.Click += new System.EventHandler(this.btncandi_Click);
            // 
            // mainMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(873, 382);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnhir);
            this.Controls.Add(this.btncandi);
            this.Name = "mainMDI";
            this.Text = "mainMDI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnhir;
        private System.Windows.Forms.Button btncandi;
    }
}