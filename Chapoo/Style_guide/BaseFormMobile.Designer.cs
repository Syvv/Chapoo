﻿namespace Style_guide
{
    partial class BaseFormMobile
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
            this.titel2 = new Styleguide.Titel();
            this.SuspendLayout();
            // 
            // titel2
            // 
            this.titel2.AutoSize = true;
            this.titel2.Font = new System.Drawing.Font("Arial", 25F);
            this.titel2.Location = new System.Drawing.Point(98, 9);
            this.titel2.Name = "titel2";
            this.titel2.Size = new System.Drawing.Size(165, 47);
            this.titel2.TabIndex = 1;
            this.titel2.Text = "Chapoo";
            this.titel2.Click += new System.EventHandler(this.titel2_Click);
            // 
            // BaseFormMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 636);
            this.Controls.Add(this.titel2);
            this.Name = "BaseFormMobile";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Styleguide.Titel titel2;
    }
}
