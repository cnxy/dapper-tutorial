﻿namespace Z.Dapper.Examples.API.Dapper.Result
{
    partial class Multi_Result
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
            this.uiRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiRead
            // 
            this.uiRead.Location = new System.Drawing.Point(20, 20);
            this.uiRead.Name = "uiRead";
            this.uiRead.Size = new System.Drawing.Size(245, 23);
            this.uiRead.TabIndex = 0;
            this.uiRead.Text = "Read";
            this.uiRead.UseVisualStyleBackColor = true;
            this.uiRead.Click += new System.EventHandler(this.Read);
            // 
            // Multi_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiRead);
            this.Name = "Multi_Result";
            this.Text = "Result - Multi-Result";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiRead;
    }
}