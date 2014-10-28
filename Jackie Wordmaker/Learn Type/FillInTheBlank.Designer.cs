namespace Jackie_Wordmaker
{
    partial class FillInTheBlank
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
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblQ = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblNumCor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.buttStart = new System.Windows.Forms.Button();
            this.buttSubmit = new System.Windows.Forms.Button();
            this.buttNext = new System.Windows.Forms.Button();
            this.lblCA = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWord);
            this.groupBox1.Controls.Add(this.txtDefinition);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fill in the blank!";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(62, 166);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(201, 20);
            this.txtWord.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Word: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Definition";
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(17, 35);
            this.txtDefinition.Multiline = true;
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.ReadOnly = true;
            this.txtDefinition.Size = new System.Drawing.Size(246, 125);
            this.txtDefinition.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCorrect);
            this.groupBox2.Controls.Add(this.lblQ);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblPercentage);
            this.groupBox2.Controls.Add(this.lblNumCor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(294, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(86, 129);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Static:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Q: ";
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
            // lblNumCor
            // 
            this.lblNumCor.AutoSize = true;
            this.lblNumCor.Location = new System.Drawing.Point(32, 21);
            this.lblNumCor.Name = "lblNumCor";
            this.lblNumCor.Size = new System.Drawing.Size(42, 13);
            this.lblNumCor.TabIndex = 2;
            this.lblNumCor.Text = "10 / 10";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "C:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(9, 97);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(27, 13);
            this.lblCorrect.TabIndex = 16;
            this.lblCorrect.Text = "N/A";
            // 
            // buttStart
            // 
            this.buttStart.Location = new System.Drawing.Point(294, 202);
            this.buttStart.Name = "buttStart";
            this.buttStart.Size = new System.Drawing.Size(86, 24);
            this.buttStart.TabIndex = 18;
            this.buttStart.Text = "Start";
            this.buttStart.UseVisualStyleBackColor = true;
            this.buttStart.Click += new System.EventHandler(this.buttStart_Click);
            // 
            // buttSubmit
            // 
            this.buttSubmit.Location = new System.Drawing.Point(294, 141);
            this.buttSubmit.Name = "buttSubmit";
            this.buttSubmit.Size = new System.Drawing.Size(84, 24);
            this.buttSubmit.TabIndex = 17;
            this.buttSubmit.Text = "Submit";
            this.buttSubmit.UseVisualStyleBackColor = true;
            this.buttSubmit.Click += new System.EventHandler(this.buttSubmit_Click);
            // 
            // buttNext
            // 
            this.buttNext.Location = new System.Drawing.Point(294, 172);
            this.buttNext.Name = "buttNext";
            this.buttNext.Size = new System.Drawing.Size(86, 24);
            this.buttNext.TabIndex = 16;
            this.buttNext.Text = "Next";
            this.buttNext.UseVisualStyleBackColor = true;
            this.buttNext.Click += new System.EventHandler(this.buttNext_Click);
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(12, 213);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(27, 13);
            this.lblCA.TabIndex = 19;
            this.lblCA.Text = "N/A";
            // 
            // FillInTheBlank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 235);
            this.Controls.Add(this.lblCA);
            this.Controls.Add(this.buttStart);
            this.Controls.Add(this.buttSubmit);
            this.Controls.Add(this.buttNext);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FillInTheBlank";
            this.Text = "Fill in the Blank";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblNumCor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Button buttStart;
        private System.Windows.Forms.Button buttSubmit;
        private System.Windows.Forms.Button buttNext;
        private System.Windows.Forms.Label lblCA;
    }
}