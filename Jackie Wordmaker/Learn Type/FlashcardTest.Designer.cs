namespace Jackie_Wordmaker
{
    partial class FlashcardTest
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.chkRan = new System.Windows.Forms.CheckBox();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.chkSpec = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startButt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtWords);
            this.groupBox1.Controls.Add(this.chkRan);
            this.groupBox1.Controls.Add(this.lstWords);
            this.groupBox1.Controls.Add(this.chkSpec);
            this.groupBox1.Controls.Add(this.chkAll);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Study Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "****more method to come later ****";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "words";
            // 
            // txtWords
            // 
            this.txtWords.Enabled = false;
            this.txtWords.Location = new System.Drawing.Point(133, 240);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(46, 20);
            this.txtWords.TabIndex = 11;
            // 
            // chkRan
            // 
            this.chkRan.AutoSize = true;
            this.chkRan.Location = new System.Drawing.Point(34, 242);
            this.chkRan.Name = "chkRan";
            this.chkRan.Size = new System.Drawing.Size(102, 17);
            this.chkRan.TabIndex = 10;
            this.chkRan.Text = "Randomize me: ";
            this.chkRan.UseVisualStyleBackColor = true;
            this.chkRan.Click += new System.EventHandler(this.chkRan_Click);
            // 
            // lstWords
            // 
            this.lstWords.Enabled = false;
            this.lstWords.FormattingEnabled = true;
            this.lstWords.Location = new System.Drawing.Point(120, 68);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(113, 160);
            this.lstWords.TabIndex = 9;
            this.lstWords.SelectedIndexChanged += new System.EventHandler(this.lstWords_SelectedIndexChanged);
            // 
            // chkSpec
            // 
            this.chkSpec.AutoSize = true;
            this.chkSpec.Location = new System.Drawing.Point(34, 68);
            this.chkSpec.Name = "chkSpec";
            this.chkSpec.Size = new System.Drawing.Size(80, 17);
            this.chkSpec.TabIndex = 8;
            this.chkSpec.Text = "specific list:";
            this.chkSpec.UseVisualStyleBackColor = true;
            this.chkSpec.Click += new System.EventHandler(this.chkSpec_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Checked = true;
            this.chkAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAll.Location = new System.Drawing.Point(34, 45);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(85, 17);
            this.chkAll.TabIndex = 7;
            this.chkAll.Text = "the entire list";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.Click += new System.EventHandler(this.chkAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "I want to study: ";
            // 
            // startButt
            // 
            this.startButt.Location = new System.Drawing.Point(200, 361);
            this.startButt.Name = "startButt";
            this.startButt.Size = new System.Drawing.Size(52, 23);
            this.startButt.TabIndex = 24;
            this.startButt.Text = "Start";
            this.startButt.UseVisualStyleBackColor = true;
            this.startButt.Click += new System.EventHandler(this.startButt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "opening flashcard will be closed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "*Once you press start, all";
            // 
            // FlashcardTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 390);
            this.Controls.Add(this.startButt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FlashcardTest";
            this.Text = "Flashcard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.CheckBox chkSpec;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.CheckBox chkRan;
        private System.Windows.Forms.Button startButt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

    }
}