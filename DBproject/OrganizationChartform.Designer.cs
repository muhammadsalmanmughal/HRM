namespace DBproject
{
    partial class OrganizationChartform
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
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvorganization = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorganization)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(268, 38);
            this.label13.TabIndex = 102;
            this.label13.Text = "Organization Chart";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvorganization);
            this.groupBox1.Location = new System.Drawing.Point(19, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 541);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            // 
            // dgvorganization
            // 
            this.dgvorganization.AllowUserToAddRows = false;
            this.dgvorganization.AllowUserToDeleteRows = false;
            this.dgvorganization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorganization.Location = new System.Drawing.Point(6, 16);
            this.dgvorganization.Name = "dgvorganization";
            this.dgvorganization.ReadOnly = true;
            this.dgvorganization.Size = new System.Drawing.Size(478, 519);
            this.dgvorganization.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnexit.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(19, 593);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(192, 39);
            this.btnexit.TabIndex = 130;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // OrganizationChartform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 639);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Name = "OrganizationChartform";
            this.Text = "OrganizationChartform";
            this.Load += new System.EventHandler(this.OrganizationChartform_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvorganization)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvorganization;
        private System.Windows.Forms.Button btnexit;
    }
}