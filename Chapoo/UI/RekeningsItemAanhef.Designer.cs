namespace UI
{
    partial class RekeningsItemAanhef
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
            this.LblTotaalprijs = new System.Windows.Forms.Label();
            this.LblPrijs = new System.Windows.Forms.Label();
            this.LblAantal = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTotaalprijs
            // 
            this.LblTotaalprijs.AutoSize = true;
            this.LblTotaalprijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotaalprijs.Location = new System.Drawing.Point(496, 12);
            this.LblTotaalprijs.Name = "LblTotaalprijs";
            this.LblTotaalprijs.Size = new System.Drawing.Size(89, 18);
            this.LblTotaalprijs.TabIndex = 7;
            this.LblTotaalprijs.Text = "TotaalPrijs";
            // 
            // LblPrijs
            // 
            this.LblPrijs.AutoSize = true;
            this.LblPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrijs.Location = new System.Drawing.Point(445, 12);
            this.LblPrijs.Name = "LblPrijs";
            this.LblPrijs.Size = new System.Drawing.Size(42, 18);
            this.LblPrijs.TabIndex = 6;
            this.LblPrijs.Text = "Prijs";
            // 
            // LblAantal
            // 
            this.LblAantal.AutoSize = true;
            this.LblAantal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAantal.Location = new System.Drawing.Point(2, 12);
            this.LblAantal.Name = "LblAantal";
            this.LblAantal.Size = new System.Drawing.Size(53, 18);
            this.LblAantal.TabIndex = 5;
            this.LblAantal.Text = "aantal";
            this.LblAantal.Click += new System.EventHandler(this.LblAantal_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(75, 12);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(86, 18);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Menu item";
            // 
            // RekeningsItemAanhef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblTotaalprijs);
            this.Controls.Add(this.LblPrijs);
            this.Controls.Add(this.LblAantal);
            this.Controls.Add(this.lblItem);
            this.Name = "RekeningsItemAanhef";
            this.Size = new System.Drawing.Size(585, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTotaalprijs;
        private System.Windows.Forms.Label LblPrijs;
        private System.Windows.Forms.Label LblAantal;
        private System.Windows.Forms.Label lblItem;
    }
}
