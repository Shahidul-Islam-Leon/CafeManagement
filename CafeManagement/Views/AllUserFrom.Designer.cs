﻿namespace CafeManagement.Views
{
    partial class AllUserFrom
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
            this.AllUsersGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllUsersGridView
            // 
            this.AllUsersGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.AllUsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllUsersGridView.Location = new System.Drawing.Point(0, 57);
            this.AllUsersGridView.Name = "AllUsersGridView";
            this.AllUsersGridView.RowHeadersWidth = 51;
            this.AllUsersGridView.RowTemplate.Height = 24;
            this.AllUsersGridView.Size = new System.Drawing.Size(797, 390);
            this.AllUsersGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "All User List";
            // 
            // AllUserFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllUsersGridView);
            this.Name = "AllUserFrom";
            this.Text = "AllUserFrom";
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllUsersGridView;
        private System.Windows.Forms.Label label1;
    }
}