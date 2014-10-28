namespace Jackie_Wordmaker
{
    partial class MultipleChoice
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.chkD = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumCor = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.buttNext = new System.Windows.Forms.Button();
            this.buttSubmit = new System.Windows.Forms.Button();
            this.buttStart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblCorrect);
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkD);
            this.groupBox1.Controls.Add(this.chkB);
            this.groupBox1.Controls.Add(this.chkC);
            this.groupBox1.Controls.Add(this.chkA);
            this.groupBox1.Controls.Add(this.txtQuestion);
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test: ";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(63, 19);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(317, 92);
            this.txtQuestion.TabIndex = 0;
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.Enabled = false;
            this.chkA.Location = new System.Drawing.Point(35, 158);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(15, 14);
            this.chkA.TabIndex = 1;
            this.chkA.UseVisualStyleBackColor = true;
            this.chkA.Click += new System.EventHandler(this.chkA_Click);
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Enabled = false;
            this.chkC.Location = new System.Drawing.Point(35, 277);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(15, 14);
            this.chkC.TabIndex = 2;
            this.chkC.UseVisualStyleBackColor = true;
            this.chkC.Click += new System.EventHandler(this.chkC_Click);
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Enabled = false;
            this.chkB.Location = new System.Drawing.Point(266, 158);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(15, 14);
            this.chkB.TabIndex = 3;
            this.chkB.UseVisualStyleBackColor = true;
            this.chkB.Click += new System.EventHandler(this.chkB_Click);
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.Enabled = false;
            this.chkD.Location = new System.Drawing.Point(266, 277);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(15, 14);
            this.chkD.TabIndex = 4;
            this.chkD.UseVisualStyleBackColor = true;
            this.chkD.Click += new System.EventHandler(this.chkD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "D";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(287, 155);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.Size = new System.Drawing.Size(181, 88);
            this.txtB.TabIndex = 9;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(56, 155);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(181, 88);
            this.txtA.TabIndex = 10;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(56, 274);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(181, 88);
            this.txtC.TabIndex = 11;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(287, 274);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(181, 88);
            this.txtD.TabIndex = 12;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(316, 124);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(27, 13);
            this.lblCorrect.TabIndex = 13;
            this.lblCorrect.Text = "N/A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblQ);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblPercentage);
            this.groupBox2.Controls.Add(this.lblNumCor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(386, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(86, 129);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Static:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "P:";
            // 
            // lblNumCor
            // 
            this.lblNumCor.AutoSize = true;
            this.lblNumCor.Location = new System.Drawing.Point(32, 21);
            this.lblNumCor.Name = "lblNumCor";
            this.lblNumCor.Size = new System.Drawing.Size(42, 13);
            this.lblNumCor.TabIndex = 2;
            this.lblNumCor.Text = "10 / 10";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(32, 43);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(33, 13);
            this.lblPercentage.TabIndex = 3;
            this.lblPercentage.Text = "100%";
            // 
            // buttNext
            // 
            this.buttNext.Location = new System.Drawing.Point(441, 387);
            this.buttNext.Name = "buttNext";
            this.buttNext.Size = new System.Drawing.Size(52, 24);
            this.buttNext.TabIndex = 1;
            this.buttNext.Text = "Next";
            this.buttNext.UseVisualStyleBackColor = true;
            this.buttNext.Click += new System.EventHandler(this.buttNext_Click);
            // 
            // buttSubmit
            // 
            this.buttSubmit.Location = new System.Drawing.Point(383, 387);
            this.buttSubmit.Name = "buttSubmit";
            this.buttSubmit.Size = new System.Drawing.Size(52, 24);
            this.buttSubmit.TabIndex = 2;
            this.buttSubmit.Text = "Submit";
            this.buttSubmit.UseVisualStyleBackColor = true;
            this.buttSubmit.Click += new System.EventHandler(this.buttSubmit_Click);
            // 
            // buttStart
            // 
            this.buttStart.Location = new System.Drawing.Point(238, 387);
            this.buttStart.Name = "buttStart";
            this.buttStart.Size = new System.Drawing.Size(52, 24);
            this.buttStart.TabIndex = 3;
            this.buttStart.Text = "Start";
            this.buttStart.UseVisualStyleBackColor = true;
            this.buttStart.Click += new System.EventHandler(this.buttStart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Q: ";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(32, 67);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(25, 13);
            this.lblQ.TabIndex = 5;
            this.lblQ.Text = "222";
            // 
            // MultipleChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 417);
            this.Controls.Add(this.buttStart);
            this.Controls.Add(this.buttSubmit);
            this.Controls.Add(this.buttNext);
            this.Controls.Add(this.groupBox1);
            this.Name = "MultipleChoice";
            this.Text = "Multiple Choice TEST!!!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblNumCor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkD;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button buttNext;
        private System.Windows.Forms.Button buttSubmit;
        private System.Windows.Forms.Button buttStart;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label label7;
    }
}