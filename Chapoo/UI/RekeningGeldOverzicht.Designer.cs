namespace UI
{
    partial class RekeningGeldOverzicht
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBtw6 = new System.Windows.Forms.Label();
            this.LblBtw21 = new System.Windows.Forms.Label();
            this.LblTotaalBedrag = new System.Windows.Forms.Label();
            this.OutBtw6 = new System.Windows.Forms.Label();
            this.OutBtw21 = new System.Windows.Forms.Label();
            this.OutTotaalBedrag = new System.Windows.Forms.Label();
            this.LblFooi = new System.Windows.Forms.Label();
            this.OutFooi = new System.Windows.Forms.Label();
            this.BtnOpmerking = new System.Windows.Forms.Button();
            this.BtnFooi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBtw6
            // 
            this.lblBtw6.AutoSize = true;
            this.lblBtw6.Location = new System.Drawing.Point(22, 25);
            this.lblBtw6.Name = "lblBtw6";
            this.lblBtw6.Size = new System.Drawing.Size(58, 17);
            this.lblBtw6.TabIndex = 0;
            this.lblBtw6.Text = "Btw  6%";
            // 
            // LblBtw21
            // 
            this.LblBtw21.AutoSize = true;
            this.LblBtw21.Location = new System.Drawing.Point(22, 52);
            this.LblBtw21.Name = "LblBtw21";
            this.LblBtw21.Size = new System.Drawing.Size(62, 17);
            this.LblBtw21.TabIndex = 1;
            this.LblBtw21.Text = "Btw 21%";
            // 
            // LblTotaalBedrag
            // 
            this.LblTotaalBedrag.AutoSize = true;
            this.LblTotaalBedrag.Location = new System.Drawing.Point(22, 104);
            this.LblTotaalBedrag.Name = "LblTotaalBedrag";
            this.LblTotaalBedrag.Size = new System.Drawing.Size(93, 17);
            this.LblTotaalBedrag.TabIndex = 2;
            this.LblTotaalBedrag.Text = "Totaalbedrag";
            // 
            // OutBtw6
            // 
            this.OutBtw6.AutoSize = true;
            this.OutBtw6.Location = new System.Drawing.Point(160, 25);
            this.OutBtw6.Name = "OutBtw6";
            this.OutBtw6.Size = new System.Drawing.Size(48, 17);
            this.OutBtw6.TabIndex = 3;
            this.OutBtw6.Text = "€ 0.00";
            // 
            // OutBtw21
            // 
            this.OutBtw21.AutoSize = true;
            this.OutBtw21.Location = new System.Drawing.Point(160, 52);
            this.OutBtw21.Name = "OutBtw21";
            this.OutBtw21.Size = new System.Drawing.Size(48, 17);
            this.OutBtw21.TabIndex = 4;
            this.OutBtw21.Text = "€ 0.00";
            // 
            // OutTotaalBedrag
            // 
            this.OutTotaalBedrag.AutoSize = true;
            this.OutTotaalBedrag.Location = new System.Drawing.Point(160, 103);
            this.OutTotaalBedrag.Name = "OutTotaalBedrag";
            this.OutTotaalBedrag.Size = new System.Drawing.Size(48, 17);
            this.OutTotaalBedrag.TabIndex = 5;
            this.OutTotaalBedrag.Text = "€ 0.00";
            // 
            // LblFooi
            // 
            this.LblFooi.AutoSize = true;
            this.LblFooi.Location = new System.Drawing.Point(22, 78);
            this.LblFooi.Name = "LblFooi";
            this.LblFooi.Size = new System.Drawing.Size(35, 17);
            this.LblFooi.TabIndex = 6;
            this.LblFooi.Text = "Fooi";
            // 
            // OutFooi
            // 
            this.OutFooi.AutoSize = true;
            this.OutFooi.Location = new System.Drawing.Point(160, 78);
            this.OutFooi.Name = "OutFooi";
            this.OutFooi.Size = new System.Drawing.Size(48, 17);
            this.OutFooi.TabIndex = 7;
            this.OutFooi.Text = "€ 0.00";
            // 
            // BtnOpmerking
            // 
            this.BtnOpmerking.Location = new System.Drawing.Point(376, 25);
            this.BtnOpmerking.Name = "BtnOpmerking";
            this.BtnOpmerking.Size = new System.Drawing.Size(132, 44);
            this.BtnOpmerking.TabIndex = 8;
            this.BtnOpmerking.Text = "Opmerking";
            this.BtnOpmerking.UseVisualStyleBackColor = true;
            // 
            // BtnFooi
            // 
            this.BtnFooi.Location = new System.Drawing.Point(376, 89);
            this.BtnFooi.Name = "BtnFooi";
            this.BtnFooi.Size = new System.Drawing.Size(132, 44);
            this.BtnFooi.TabIndex = 9;
            this.BtnFooi.Text = "Fooi";
            this.BtnFooi.UseVisualStyleBackColor = true;
            // 
            // RekeningGeldOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnFooi);
            this.Controls.Add(this.BtnOpmerking);
            this.Controls.Add(this.OutFooi);
            this.Controls.Add(this.LblFooi);
            this.Controls.Add(this.OutTotaalBedrag);
            this.Controls.Add(this.OutBtw21);
            this.Controls.Add(this.OutBtw6);
            this.Controls.Add(this.LblTotaalBedrag);
            this.Controls.Add(this.LblBtw21);
            this.Controls.Add(this.lblBtw6);
            this.Name = "RekeningGeldOverzicht";
            this.Size = new System.Drawing.Size(544, 165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBtw6;
        private System.Windows.Forms.Label LblBtw21;
        private System.Windows.Forms.Label LblTotaalBedrag;
        private System.Windows.Forms.Label OutBtw6;
        private System.Windows.Forms.Label OutBtw21;
        private System.Windows.Forms.Label OutTotaalBedrag;
        private System.Windows.Forms.Label LblFooi;
        private System.Windows.Forms.Label OutFooi;
        private System.Windows.Forms.Button BtnOpmerking;
        private System.Windows.Forms.Button BtnFooi;
    }
}
