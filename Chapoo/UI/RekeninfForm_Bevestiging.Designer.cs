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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RekeninfForm_Bevestiging));
            this.label1 = new System.Windows.Forms.Label();
            this.lblVrijgeven = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.backButton1 = new Style_guide.BackButton();
            this.homeButton2 = new Style_guide.HomeButton();
            this.LblTafelnummer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "De rekening is betaald";
            // 
            // lblVrijgeven
            // 
            this.lblVrijgeven.AutoSize = true;
            this.lblVrijgeven.Location = new System.Drawing.Point(120, 252);
            this.lblVrijgeven.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVrijgeven.Name = "lblVrijgeven";
            this.lblVrijgeven.Size = new System.Drawing.Size(126, 17);
            this.lblVrijgeven.TabIndex = 6;
            this.lblVrijgeven.Text = "tafel is vrijgegeven";
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(108, 297);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(160, 38);
            this.BtnReturn.TabIndex = 7;
            this.BtnReturn.Text = "Naar Overzicht";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // backButton1
            // 
            this.backButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton1.BackgroundImage")));
            this.backButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backButton1.Location = new System.Drawing.Point(12, 57);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(50, 50);
            this.backButton1.TabIndex = 27;
            this.backButton1.Text = " ";
            this.backButton1.UseVisualStyleBackColor = true;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // homeButton2
            // 
            this.homeButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton2.BackgroundImage")));
            this.homeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.homeButton2.Location = new System.Drawing.Point(12, 11);
            this.homeButton2.Name = "homeButton2";
            this.homeButton2.Size = new System.Drawing.Size(50, 50);
            this.homeButton2.TabIndex = 26;
            this.homeButton2.Text = " ";
            this.homeButton2.UseVisualStyleBackColor = true;
            this.homeButton2.Click += new System.EventHandler(this.homeButton2_Click);
            // 
            // LblTafelnummer
            // 
            this.LblTafelnummer.AutoSize = true;
            this.LblTafelnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTafelnummer.Location = new System.Drawing.Point(209, 67);
            this.LblTafelnummer.Name = "LblTafelnummer";
            this.LblTafelnummer.Size = new System.Drawing.Size(22, 25);
            this.LblTafelnummer.TabIndex = 31;
            this.LblTafelnummer.Text = "x";
            // 
            // RekeninfForm_Bevestiging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 638);
            this.Controls.Add(this.LblTafelnummer);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.homeButton2);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.lblVrijgeven);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RekeninfForm_Bevestiging";
            this.Text = "RekeninfForm_Bevestiging";
            this.Load += new System.EventHandler(this.RekeninfForm_Bevestiging_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblVrijgeven, 0);
            this.Controls.SetChildIndex(this.BtnReturn, 0);
            this.Controls.SetChildIndex(this.homeButton2, 0);
            this.Controls.SetChildIndex(this.backButton1, 0);
            this.Controls.SetChildIndex(this.LblTafelnummer, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVrijgeven;
        private System.Windows.Forms.Button BtnReturn;
        private Style_guide.BackButton backButton1;
        private Style_guide.HomeButton homeButton2;
        private System.Windows.Forms.Label LblTafelnummer;
    }
}