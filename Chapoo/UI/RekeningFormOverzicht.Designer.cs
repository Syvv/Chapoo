namespace UI
{
    partial class RekeningFormOverzicht
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
            // backButton1
            // 
            this.backButton1.FlatAppearance.BorderSize = 0;
            // 
            // uitlogButton1
            // 
            this.uitlogButton1.Click += new System.EventHandler(this.uitlogButton1_Click);
            // 
            // txtTafel
            // 
            this.txtTafel.Click += new System.EventHandler(this.txtTafel_Click);
            // 
            // RekeningFormOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 853);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RekeningFormOverzicht";
            this.Text = "RekeningFormOverzicht";
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}