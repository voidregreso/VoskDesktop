using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Size = System.Drawing.Size;

namespace RecogUI
{
    partial class FrmSubtitle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.SuspendLayout();
            // 
            // FrmSubtitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1449, 326);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSubtitle";
            this.ShowInTaskbar = false;
            this.Text = "FrmSubtitle";
            this.Load += new System.EventHandler(this.FrmSubtitle_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmSubtitle_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmSubtitle_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}