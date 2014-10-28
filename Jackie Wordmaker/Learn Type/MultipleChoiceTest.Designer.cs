namespace Jackie_Wordmaker
{
    partial class MultipleChoiceTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.chkRan = new System.Windows.Forms.CheckBox();
            this.lstList = new System.Windows.Forms.ListBox();
            this.chkSpec = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.buttStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtWords);
            this.groupBox1.Controls.Add(this.chkRan);
            this.groupBox1.Controls.Add(this.lstList);
            this.groupBox1.Controls.Add(this.chkSpec);
            this.groupBox1.Controls.Add(this.chkAll);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiple Choice Method:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "words";
            // 
            // txtWords
            // 
            this.txtWords.Enabled = false;
            this.txtWords.Location = new System.Drawing.Point(109, 245);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(46, 20);
            this.txtWords.TabIndex = 31;
            // 
            // chkRan
            // 
            this.chkRan.AutoSize = true;
            this.chkRan.Location = new System.Drawing.Point(10, 247);
            this.chkRan.Name = "chkRan";
            this.chkRan.Size = new System.Drawing.Size(102, 17);
            this.chkRan.TabIndex = 30;
            this.chkRan.Text = "Randomize me: ";
            this.chkRan.UseVisualStyleBackColor = true;
            this.chkRan.Click += new System.EventHandler(this.chkRan_Click);
            // 
            // lstList
            // 
            this.lstList.Enabled = false;
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(96, 73);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(113, 160);
            this.lstList.TabIndex = 29;
            // 
            // chkSpec
            // 
            this.chkSpec.AutoSize = true;
            this.chkSpec.Location = new System.Drawing.Point(10, 73);
            this.chkSpec.Name = "chkSpec";
            this.chkSpec.Size = new System.Drawing.Size(80, 17);
            this.chkSpec.TabIndex = 28;
            this.chkSpec.Text = "specific list:";
            this.chkSpec.UseVisualStyleBackColor = true;
            this.chkSpec.Click += new System.EventHandler(this.chkSpec_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Checked = true;
            this.chkAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAll.Location = new System.Drawing.Point(10, 50);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(85, 17);
            this.chkAll.TabIndex = 27;
            this.chkAll.Text = "the entire list";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.Click += new System.EventHandler(this.chkAll_Click);
            // 
            // buttStart
            // 
            this.buttStart.Location = new System.Drawing.Point(182, 290);
            this.buttStart.Name = "buttStart";
            this.buttStart.Size = new System.Drawing.Size(52, 21);
            this.buttStart.TabIndex = 33;
            this.buttStart.Text = "Start";
            this.buttStart.UseVisualStyleBackColor = true;
            this.buttStart.Click += new System.EventHandler(this.buttStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "I\'m learning: ";
            // 
            // MultipleChoiceTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 313);
            this.Controls.Add(this.buttStart);
            this.Controls.Add(this.groupBox1);
            this.Name = "MultipleChoiceTest";
            this.Text = "Multiple Choice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.CheckBox chkRan;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.CheckBox chkSpec;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttStart;
    }
}