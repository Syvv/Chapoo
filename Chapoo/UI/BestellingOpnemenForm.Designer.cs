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
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenuOverzicht
            // 
            this.btnMenuOverzicht.Click += new System.EventHandler(this.btnMenuOverzicht_Click);
            // 
            // btnMenuOpnemen
            // 
            this.btnMenuOpnemen.Click += new System.EventHandler(this.btnMenuOpnemen_Click);
            // 
            // BestellingOpnemenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(582, 853);
            this.Name = "BestellingOpnemenForm";
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}