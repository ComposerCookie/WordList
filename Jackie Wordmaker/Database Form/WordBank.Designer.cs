namespace Jackie_Wordmaker
{
    partial class WordBank
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
            this.listDatabase = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listDatabase
            // 
            this.listDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDatabase.FormattingEnabled = true;
            this.listDatabase.Location = new System.Drawing.Point(0, 0);
            this.listDatabase.Name = "listDatabase";
            this.listDatabase.Size = new System.Drawing.Size(142, 465);
            this.listDatabase.TabIndex = 0;
            this.listDatabase.DoubleClick += new System.EventHandler(this.listDatabase_DoubleClick);
            // 
            // WordBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(142, 465);
            this.Controls.Add(this.listDatabase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(158, 503);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(158, 503);
            this.Name = "WordBank";
            this.ShowInTaskbar = false;
            this.Text = "Work Bank";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listDatabase;

    }
}