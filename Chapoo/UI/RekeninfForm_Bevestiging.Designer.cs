namespace UI
{
    partial class RekeninfForm_Bevestiging
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblVrijgeven = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "De rekening is betaald";
            // 
            // lblVrijgeven
            // 
            this.lblVrijgeven.AutoSize = true;
            this.lblVrijgeven.Location = new System.Drawing.Point(90, 205);
            this.lblVrijgeven.Name = "lblVrijgeven";
            this.lblVrijgeven.Size = new System.Drawing.Size(95, 13);
            this.lblVrijgeven.TabIndex = 6;
            this.lblVrijgeven.Text = "tafel is vrijgegeven";
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(81, 241);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(120, 31);
            this.BtnReturn.TabIndex = 7;
            this.BtnReturn.Text = "Naar Overzicht";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // RekeninfForm_Bevestiging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 518);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.lblVrijgeven);
            this.Controls.Add(this.label1);
            this.Name = "RekeninfForm_Bevestiging";
            this.Text = "RekeninfForm_Bevestiging";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblVrijgeven, 0);
            this.Controls.SetChildIndex(this.BtnReturn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVrijgeven;
        private System.Windows.Forms.Button BtnReturn;
    }
}