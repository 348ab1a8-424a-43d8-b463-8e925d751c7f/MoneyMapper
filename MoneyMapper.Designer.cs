﻿namespace MoneyMapper
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
            this.AccountGroupBox = new System.Windows.Forms.GroupBox();
            this.EntriesGroupBox = new System.Windows.Forms.GroupBox();
            this.ConnectToDBButton = new System.Windows.Forms.Button();
            this.DatabaseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatabaseGroupBox
            // 
            this.DatabaseGroupBox.Controls.Add(this.ConnectToDBButton);
            this.DatabaseGroupBox.Location = new System.Drawing.Point(13, 13);
            this.DatabaseGroupBox.Name = "DatabaseGroupBox";
            this.DatabaseGroupBox.Size = new System.Drawing.Size(200, 175);
            this.DatabaseGroupBox.TabIndex = 0;
            this.DatabaseGroupBox.TabStop = false;
            this.DatabaseGroupBox.Text = "Database";
            // 
            // AccountGroupBox
            // 
            this.AccountGroupBox.Location = new System.Drawing.Point(13, 195);
            this.AccountGroupBox.Name = "AccountGroupBox";
            this.AccountGroupBox.Size = new System.Drawing.Size(200, 267);
            this.AccountGroupBox.TabIndex = 1;
            this.AccountGroupBox.TabStop = false;
            this.AccountGroupBox.Text = "Account";
            // 
            // EntriesGroupBox
            // 
            this.EntriesGroupBox.Location = new System.Drawing.Point(13, 469);
            this.EntriesGroupBox.Name = "EntriesGroupBox";
            this.EntriesGroupBox.Size = new System.Drawing.Size(200, 245);
            this.EntriesGroupBox.TabIndex = 2;
            this.EntriesGroupBox.TabStop = false;
            this.EntriesGroupBox.Text = "Entries";
            // 
            // ConnectToDBButton
            // 
            this.ConnectToDBButton.Location = new System.Drawing.Point(6, 19);
            this.ConnectToDBButton.Name = "ConnectToDBButton";
            this.ConnectToDBButton.Size = new System.Drawing.Size(188, 23);
            this.ConnectToDBButton.TabIndex = 0;
            this.ConnectToDBButton.Text = "Connect to DB";
            this.ConnectToDBButton.UseVisualStyleBackColor = true;
            this.ConnectToDBButton.Click += new System.EventHandler(this.ConnectToDBButton_Click);
            // 
            // MoneyMapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 965);
            this.Controls.Add(this.EntriesGroupBox);
            this.Controls.Add(this.AccountGroupBox);
            this.Controls.Add(this.DatabaseGroupBox);
            this.Name = "MoneyMapper";
            this.Text = "Money Mapper";
            this.DatabaseGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DatabaseGroupBox;
        private System.Windows.Forms.GroupBox AccountGroupBox;
        private System.Windows.Forms.GroupBox EntriesGroupBox;
        private System.Windows.Forms.Button ConnectToDBButton;
    }
}

