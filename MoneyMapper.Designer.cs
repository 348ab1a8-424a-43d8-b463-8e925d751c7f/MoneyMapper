namespace MoneyMapper
{
    partial class MoneyMapper
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
            this.DatabaseGroupBox = new System.Windows.Forms.GroupBox();
            this.ConnectionStateLabel = new System.Windows.Forms.LinkLabel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.AccountGroupBox = new System.Windows.Forms.GroupBox();
            this.EntriesGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatabaseGroupBox
            // 
            this.DatabaseGroupBox.Controls.Add(this.ConnectionStateLabel);
            this.DatabaseGroupBox.Controls.Add(this.StatusLabel);
            this.DatabaseGroupBox.Location = new System.Drawing.Point(12, 55);
            this.DatabaseGroupBox.Name = "DatabaseGroupBox";
            this.DatabaseGroupBox.Size = new System.Drawing.Size(200, 175);
            this.DatabaseGroupBox.TabIndex = 0;
            this.DatabaseGroupBox.TabStop = false;
            this.DatabaseGroupBox.Text = "Database";
            // 
            // ConnectionStateLabel
            // 
            this.ConnectionStateLabel.AutoSize = true;
            this.ConnectionStateLabel.LinkColor = System.Drawing.Color.Red;
            this.ConnectionStateLabel.Location = new System.Drawing.Point(54, 78);
            this.ConnectionStateLabel.Name = "ConnectionStateLabel";
            this.ConnectionStateLabel.Size = new System.Drawing.Size(73, 13);
            this.ConnectionStateLabel.TabIndex = 3;
            this.ConnectionStateLabel.TabStop = true;
            this.ConnectionStateLabel.Text = "Disconnected";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(7, 78);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Status:";
            // 
            // AccountGroupBox
            // 
            this.AccountGroupBox.Location = new System.Drawing.Point(12, 237);
            this.AccountGroupBox.Name = "AccountGroupBox";
            this.AccountGroupBox.Size = new System.Drawing.Size(200, 267);
            this.AccountGroupBox.TabIndex = 1;
            this.AccountGroupBox.TabStop = false;
            this.AccountGroupBox.Text = "Account";
            // 
            // EntriesGroupBox
            // 
            this.EntriesGroupBox.Location = new System.Drawing.Point(12, 511);
            this.EntriesGroupBox.Name = "EntriesGroupBox";
            this.EntriesGroupBox.Size = new System.Drawing.Size(200, 245);
            this.EntriesGroupBox.TabIndex = 2;
            this.EntriesGroupBox.TabStop = false;
            this.EntriesGroupBox.Text = "Entries";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1580, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectToolStripMenuItem,
            this.DisconnectToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // ConnectToolStripMenuItem
            // 
            this.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem";
            this.ConnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ConnectToolStripMenuItem.Text = "Connect";
            this.ConnectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
            // 
            // DisconnectToolStripMenuItem
            // 
            this.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem";
            this.DisconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.DisconnectToolStripMenuItem.Text = "Disconnect";
            this.DisconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);
            // 
            // MoneyMapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 965);
            this.Controls.Add(this.EntriesGroupBox);
            this.Controls.Add(this.AccountGroupBox);
            this.Controls.Add(this.DatabaseGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MoneyMapper";
            this.Text = "Money Mapper";
            this.DatabaseGroupBox.ResumeLayout(false);
            this.DatabaseGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DatabaseGroupBox;
        private System.Windows.Forms.GroupBox AccountGroupBox;
        private System.Windows.Forms.GroupBox EntriesGroupBox;
        private System.Windows.Forms.LinkLabel ConnectionStateLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisconnectToolStripMenuItem;
    }
}

