namespace Jackie_Wordmaker
{
    partial class WordDatabase
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
            this.DeleteButt = new System.Windows.Forms.Button();
            this.addButt = new System.Windows.Forms.Button();
            this.listDatabase = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.enableCheck = new System.Windows.Forms.CheckBox();
            this.modifyButt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPt = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.wordPic = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stuffzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.putToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortButt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordPic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteButt);
            this.groupBox1.Controls.Add(this.addButt);
            this.groupBox1.Controls.Add(this.listDatabase);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Words";
            // 
            // DeleteButt
            // 
            this.DeleteButt.Location = new System.Drawing.Point(61, 421);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(53, 24);
            this.DeleteButt.TabIndex = 2;
            this.DeleteButt.Text = "Delete";
            this.DeleteButt.UseVisualStyleBackColor = true;
            this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click);
            // 
            // addButt
            // 
            this.addButt.Location = new System.Drawing.Point(6, 421);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(53, 24);
            this.addButt.TabIndex = 2;
            this.addButt.Text = "Add";
            this.addButt.UseVisualStyleBackColor = true;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // listDatabase
            // 
            this.listDatabase.FormattingEnabled = true;
            this.listDatabase.Location = new System.Drawing.Point(6, 21);
            this.listDatabase.Name = "listDatabase";
            this.listDatabase.Size = new System.Drawing.Size(108, 394);
            this.listDatabase.TabIndex = 2;
            this.listDatabase.SelectedIndexChanged += new System.EventHandler(this.listDatabase_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SortButt);
            this.groupBox2.Controls.Add(this.enableCheck);
            this.groupBox2.Controls.Add(this.modifyButt);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtDefinition);
            this.groupBox2.Controls.Add(this.wordPic);
            this.groupBox2.Location = new System.Drawing.Point(138, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 449);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Definition";
            // 
            // enableCheck
            // 
            this.enableCheck.AutoSize = true;
            this.enableCheck.Location = new System.Drawing.Point(198, 424);
            this.enableCheck.Name = "enableCheck";
            this.enableCheck.Size = new System.Drawing.Size(120, 17);
            this.enableCheck.TabIndex = 4;
            this.enableCheck.Text = "Enabled for testing?";
            this.enableCheck.UseVisualStyleBackColor = true;
            // 
            // modifyButt
            // 
            this.modifyButt.Location = new System.Drawing.Point(6, 421);
            this.modifyButt.Name = "modifyButt";
            this.modifyButt.Size = new System.Drawing.Size(121, 24);
            this.modifyButt.TabIndex = 3;
            this.modifyButt.Text = "Edit Word";
            this.modifyButt.UseVisualStyleBackColor = true;
            this.modifyButt.Click += new System.EventHandler(this.modifyButt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPt);
            this.groupBox3.Controls.Add(this.lblDiff);
            this.groupBox3.Location = new System.Drawing.Point(324, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 193);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Property";
            // 
            // lblPt
            // 
            this.lblPt.AutoSize = true;
            this.lblPt.Location = new System.Drawing.Point(6, 49);
            this.lblPt.Name = "lblPt";
            this.lblPt.Size = new System.Drawing.Size(37, 13);
            this.lblPt.TabIndex = 1;
            this.lblPt.Text = "Point: ";
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Location = new System.Drawing.Point(6, 27);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(53, 13);
            this.lblDiff.TabIndex = 0;
            this.lblDiff.Text = "Difficulty: ";
            // 
            // txtDefinition
            // 
            this.txtDefinition.BackColor = System.Drawing.SystemColors.Info;
            this.txtDefinition.Location = new System.Drawing.Point(6, 19);
            this.txtDefinition.Multiline = true;
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.ReadOnly = true;
            this.txtDefinition.Size = new System.Drawing.Size(312, 396);
            this.txtDefinition.TabIndex = 1;
            // 
            // wordPic
            // 
            this.wordPic.Location = new System.Drawing.Point(324, 19);
            this.wordPic.Name = "wordPic";
            this.wordPic.Size = new System.Drawing.Size(225, 225);
            this.wordPic.TabIndex = 0;
            this.wordPic.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.stuffzToolStripMenuItem,
            this.addToolStripMenuItem,
            this.putToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // stuffzToolStripMenuItem
            // 
            this.stuffzToolStripMenuItem.Name = "stuffzToolStripMenuItem";
            this.stuffzToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.stuffzToolStripMenuItem.Text = "Stuffz";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // putToolStripMenuItem
            // 
            this.putToolStripMenuItem.Name = "putToolStripMenuItem";
            this.putToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.putToolStripMenuItem.Text = "Put";
            // 
            // SortButt
            // 
            this.SortButt.Location = new System.Drawing.Point(133, 421);
            this.SortButt.Name = "SortButt";
            this.SortButt.Size = new System.Drawing.Size(59, 24);
            this.SortButt.TabIndex = 5;
            this.SortButt.Text = "Sort";
            this.SortButt.UseVisualStyleBackColor = true;
            // 
            // WordDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WordDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Database";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordPic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listDatabase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox wordPic;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.Button addButt;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.CheckBox enableCheck;
        private System.Windows.Forms.Button modifyButt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPt;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stuffzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem putToolStripMenuItem;
        private System.Windows.Forms.Button SortButt;



    }
}