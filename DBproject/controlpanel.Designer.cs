namespace DBproject
{
    partial class ControlPanel
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightCyan;
            this.btnexit.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(12, 287);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(199, 43);
            this.btnexit.TabIndex = 24;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 43);
            this.button4.TabIndex = 23;
            this.button4.Text = "Organization Chart";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 43);
            this.button3.TabIndex = 22;
            this.button3.Text = "Attendance Form";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnhir
            // 
            this.btnhir.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhir.Location = new System.Drawing.Point(12, 73);
            this.btnhir.Name = "btnhir";
            this.btnhir.Size = new System.Drawing.Size(199, 43);
            this.btnhir.TabIndex = 21;
            this.btnhir.Text = "Hiring form";
            this.btnhir.UseVisualStyleBackColor = true;
            this.btnhir.Click += new System.EventHandler(this.btnhir_Click);
            // 
            // btncandi
            // 
            this.btncandi.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncandi.Location = new System.Drawing.Point(12, 23);
            this.btncandi.Name = "btncandi";
            this.btncandi.Size = new System.Drawing.Size(199, 43);
            this.btncandi.TabIndex = 20;
            this.btncandi.Text = "Candidate Form";
            this.btncandi.UseVisualStyleBackColor = true;
            this.btncandi.Click += new System.EventHandler(this.btncandi_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 43);
            this.button1.TabIndex = 25;
            this.button1.Text = "Payroll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(879, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnhir);
            this.Controls.Add(this.btncandi);
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnhir;
        private System.Windows.Forms.Button btncandi;
        private System.Windows.Forms.Button button1;
    }
}

