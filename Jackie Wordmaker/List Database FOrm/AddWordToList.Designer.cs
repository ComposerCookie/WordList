namespace Jackie_Wordmaker
{
    partial class AddWordToList
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
            this.lstBank = new System.Windows.Forms.ListBox();
            this.lstWord = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttAdd = new System.Windows.Forms.Button();
            this.buttRev = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBank);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Word Bank";
            // 
            // lstBank
            // 
            this.lstBank.FormattingEnabled = true;
            this.lstBank.Location = new System.Drawing.Point(6, 19);
            this.lstBank.Name = "lstBank";
            this.lstBank.Size = new System.Drawing.Size(125, 459);
            this.lstBank.TabIndex = 1;
            // 
            // lstWord
            // 
            this.lstWord.FormattingEnabled = true;
            this.lstWord.Location = new System.Drawing.Point(6, 19);
            this.lstWord.Name = "lstWord";
            this.lstWord.Size = new System.Drawing.Size(125, 459);
            this.lstWord.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstWord);
            this.groupBox2.Location = new System.Drawing.Point(187, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 485);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List\'s Word";
            // 
            // buttAdd
            // 
            this.buttAdd.Location = new System.Drawing.Point(155, 207);
            this.buttAdd.Name = "buttAdd";
            this.buttAdd.Size = new System.Drawing.Size(26, 26);
            this.buttAdd.TabIndex = 2;
            this.buttAdd.Text = ">";
            this.buttAdd.UseVisualStyleBackColor = true;
            this.buttAdd.Click += new System.EventHandler(this.buttAdd_Click);
            // 
            // buttRev
            // 
            this.buttRev.Location = new System.Drawing.Point(155, 239);
            this.buttRev.Name = "buttRev";
            this.buttRev.Size = new System.Drawing.Size(26, 26);
            this.buttRev.TabIndex = 3;
            this.buttRev.Text = "<";
            this.buttRev.UseVisualStyleBackColor = true;
            this.buttRev.Click += new System.EventHandler(this.buttRev_Click);
            // 
            // AddWordToList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 512);
            this.Controls.Add(this.buttRev);
            this.Controls.Add(this.buttAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddWordToList";
            this.Text = "AddWordToList";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBank;
        private System.Windows.Forms.ListBox lstWord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttAdd;
        private System.Windows.Forms.Button buttRev;
    }
}