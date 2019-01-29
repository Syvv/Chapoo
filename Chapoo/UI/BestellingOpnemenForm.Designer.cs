namespace UI
{
    partial class BestellingOpnemenForm : StyleGuide.BaseFormMobile
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton1
            // 
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(585, 163);
            // 
            // btnMenuAfrekenen
            // 
            this.btnMenuAfrekenen.Click += new System.EventHandler(this.btnMenuAfrekenen_Click);
            // 
            // BestellingOpnemenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(582, 853);
            this.Name = "BestellingOpnemenForm";
            this.Text = "Bestelling_opnemen";
            this.Load += new System.EventHandler(this.Bestelling_opnemen_form_Load);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}