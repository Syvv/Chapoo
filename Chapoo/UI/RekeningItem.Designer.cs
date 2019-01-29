namespace UI
{
    partial class RekeningItem
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
            this.lblItem = new System.Windows.Forms.Label();
            this.LblAantal = new System.Windows.Forms.Label();
            this.LblPrijs = new System.Windows.Forms.Label();
            this.LblTotaalprijs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(16, 12);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(34, 17);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "item";
            // 
            // LblAantal
            // 
            this.LblAantal.AutoSize = true;
            this.LblAantal.Location = new System.Drawing.Point(398, 12);
            this.LblAantal.Name = "LblAantal";
            this.LblAantal.Size = new System.Drawing.Size(47, 17);
            this.LblAantal.TabIndex = 1;
            this.LblAantal.Text = "aantal";
            // 
            // LblPrijs
            // 
            this.LblPrijs.AutoSize = true;
            this.LblPrijs.Location = new System.Drawing.Point(451, 12);
            this.LblPrijs.Name = "LblPrijs";
            this.LblPrijs.Size = new System.Drawing.Size(35, 17);
            this.LblPrijs.TabIndex = 2;
            this.LblPrijs.Text = "Prijs";
            // 
            // LblTotaalprijs
            // 
            this.LblTotaalprijs.AutoSize = true;
            this.LblTotaalprijs.Location = new System.Drawing.Point(507, 12);
            this.LblTotaalprijs.Name = "LblTotaalprijs";
            this.LblTotaalprijs.Size = new System.Drawing.Size(75, 17);
            this.LblTotaalprijs.TabIndex = 3;
            this.LblTotaalprijs.Text = "TotaalPrijs";
            // 
            // RekeningItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblTotaalprijs);
            this.Controls.Add(this.LblPrijs);
            this.Controls.Add(this.LblAantal);
            this.Controls.Add(this.lblItem);
            this.Name = "RekeningItem";
            this.Size = new System.Drawing.Size(585, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label LblAantal;
        private System.Windows.Forms.Label LblPrijs;
        private System.Windows.Forms.Label LblTotaalprijs;
    }
}
