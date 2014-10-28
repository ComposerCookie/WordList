namespace Jackie_Wordmaker
{
    partial class ListForm
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
            this.lstList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstWord = new System.Windows.Forms.ListBox();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.addButt = new System.Windows.Forms.Button();
            this.buttEdit = new System.Windows.Forms.Button();
            this.buttAddW = new System.Windows.Forms.Button();
            this.buttDelW = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List";
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(6, 19);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(135, 472);
            this.lstList.TabIndex = 1;
            this.lstList.SelectedIndexChanged += new System.EventHandler(this.lstList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstWord);
            this.groupBox2.Location = new System.Drawing.Point(169, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 500);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Word";
            // 
            // lstWord
            // 
            this.lstWord.FormattingEnabled = true;
            this.lstWord.Location = new System.Drawing.Point(6, 19);
            this.lstWord.Name = "lstWord";
            this.lstWord.Size = new System.Drawing.Size(151, 472);
            this.lstWord.TabIndex = 0;
            // 
            // DeleteButt
            // 
            this.DeleteButt.Location = new System.Drawing.Point(87, 518);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(53, 24);
            this.DeleteButt.TabIndex = 3;
            this.DeleteButt.Text = "Delete";
            this.DeleteButt.UseVisualStyleBackColor = true;
            this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click);
            // 
            // addButt
            // 
            this.addButt.Location = new System.Drawing.Point(28, 518);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(53, 24);
            this.addButt.TabIndex = 4;
            this.addButt.Text = "Add";
            this.addButt.UseVisualStyleBackColor = true;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // buttEdit
            // 
            this.buttEdit.Location = new System.Drawing.Point(146, 518);
            this.buttEdit.Name = "buttEdit";
            this.buttEdit.Size = new System.Drawing.Size(53, 24);
            this.buttEdit.TabIndex = 5;
            this.buttEdit.Text = "Edit";
            this.buttEdit.UseVisualStyleBackColor = true;
            this.buttEdit.Click += new System.EventHandler(this.buttEdit_Click);
            // 
            // buttAddW
            // 
            this.buttAddW.Location = new System.Drawing.Point(205, 518);
            this.buttAddW.Name = "buttAddW";
            this.buttAddW.Size = new System.Drawing.Size(53, 24);
            this.buttAddW.TabIndex = 6;
            this.buttAddW.Text = "Add W";
            this.buttAddW.UseVisualStyleBackColor = true;
            this.buttAddW.Click += new System.EventHandler(this.buttAddW_Click);
            // 
            // buttDelW
            // 
            this.buttDelW.Location = new System.Drawing.Point(264, 518);
            this.buttDelW.Name = "buttDelW";
            this.buttDelW.Size = new System.Drawing.Size(53, 24);
            this.buttDelW.TabIndex = 7;
            this.buttDelW.Text = "Del. W";
            this.buttDelW.UseVisualStyleBackColor = true;
            this.buttDelW.Click += new System.EventHandler(this.buttDelW_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 542);
            this.Controls.Add(this.buttDelW);
            this.Controls.Add(this.buttAddW);
            this.Controls.Add(this.buttEdit);
            this.Controls.Add(this.DeleteButt);
            this.Controls.Add(this.addButt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListForm";
            this.Text = "List Database";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstWord;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.Button addButt;
        private System.Windows.Forms.Button buttEdit;
        private System.Windows.Forms.Button buttAddW;
        private System.Windows.Forms.Button buttDelW;
        private System.Windows.Forms.ListBox lstList;
    }
}