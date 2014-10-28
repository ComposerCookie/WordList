namespace Jackie_Wordmaker
{
    partial class Export
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.chkRan = new System.Windows.Forms.CheckBox();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.chkSpec = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtWords);
            this.groupBox1.Controls.Add(this.chkRan);
            this.groupBox1.Controls.Add(this.lstWords);
            this.groupBox1.Controls.Add(this.chkSpec);
            this.groupBox1.Controls.Add(this.chkAll);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "I\'m exporting: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "words";
            // 
            // txtWords
            // 
            this.txtWords.Enabled = false;
            this.txtWords.Location = new System.Drawing.Point(210, 277);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(46, 20);
            this.txtWords.TabIndex = 25;
            // 
            // chkRan
            // 
            this.chkRan.AutoSize = true;
            this.chkRan.Location = new System.Drawing.Point(111, 279);
            this.chkRan.Name = "chkRan";
            this.chkRan.Size = new System.Drawing.Size(102, 17);
            this.chkRan.TabIndex = 24;
            this.chkRan.Text = "Randomize me: ";
            this.chkRan.UseVisualStyleBackColor = true;
            this.chkRan.Click += new System.EventHandler(this.chkRan_Click);
            // 
            // lstWords
            // 
            this.lstWords.Enabled = false;
            this.lstWords.FormattingEnabled = true;
            this.lstWords.Location = new System.Drawing.Point(197, 105);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(113, 160);
            this.lstWords.TabIndex = 23;
            // 
            // chkSpec
            // 
            this.chkSpec.AutoSize = true;
            this.chkSpec.Location = new System.Drawing.Point(111, 105);
            this.chkSpec.Name = "chkSpec";
            this.chkSpec.Size = new System.Drawing.Size(80, 17);
            this.chkSpec.TabIndex = 22;
            this.chkSpec.Text = "specific list:";
            this.chkSpec.UseVisualStyleBackColor = true;
            this.chkSpec.Click += new System.EventHandler(this.chkSpec_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Checked = true;
            this.chkAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAll.Location = new System.Drawing.Point(111, 82);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(85, 17);
            this.chkAll.TabIndex = 21;
            this.chkAll.Text = "the entire list";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.Click += new System.EventHandler(this.chkAll_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(235, 42);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 27);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtLocation
            // 
            this.txtLocation.ForeColor = System.Drawing.Color.Black;
            this.txtLocation.Location = new System.Drawing.Point(60, 49);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(169, 20);
            this.txtLocation.TabIndex = 18;
            this.txtLocation.Text = "C:\\Program Files\\WordMaker\\Project\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Path:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 20);
            this.txtName.TabIndex = 17;
            this.txtName.Text = "List1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name:";
            // 
            // buttExport
            // 
            this.buttExport.Location = new System.Drawing.Point(284, 334);
            this.buttExport.Name = "buttExport";
            this.buttExport.Size = new System.Drawing.Size(52, 21);
            this.buttExport.TabIndex = 2;
            this.buttExport.Text = "Export";
            this.buttExport.UseVisualStyleBackColor = true;
            this.buttExport.Click += new System.EventHandler(this.buttExport_Click);
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 364);
            this.Controls.Add(this.buttExport);
            this.Controls.Add(this.groupBox1);
            this.Name = "Export";
            this.Text = "Export";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.CheckBox chkRan;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.CheckBox chkSpec;
        private System.Windows.Forms.CheckBox chkAll;
    }
}