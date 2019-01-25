namespace UI
{
    partial class Rekening_OpmerkingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rekening_OpmerkingForm));
            this.Tbopmerking = new System.Windows.Forms.TextBox();
            this.BtnOpslaan = new System.Windows.Forms.Button();
            this.BtnAnuleren = new System.Windows.Forms.Button();
            this.backButton1 = new StyleGuide.BackButton();
            this.homeButton2 = new StyleGuide.HomeButton();
            this.LblTafelnummer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tbopmerking
            // 
            this.Tbopmerking.Location = new System.Drawing.Point(30, 106);
            this.Tbopmerking.Multiline = true;
            this.Tbopmerking.Name = "Tbopmerking";
            this.Tbopmerking.Size = new System.Drawing.Size(322, 212);
            this.Tbopmerking.TabIndex = 4;
            // 
            // BtnOpslaan
            // 
            this.BtnOpslaan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnOpslaan.Location = new System.Drawing.Point(30, 344);
            this.BtnOpslaan.Name = "BtnOpslaan";
            this.BtnOpslaan.Size = new System.Drawing.Size(143, 34);
            this.BtnOpslaan.TabIndex = 5;
            this.BtnOpslaan.Text = "Opslaan";
            this.BtnOpslaan.UseVisualStyleBackColor = false;
            this.BtnOpslaan.Click += new System.EventHandler(this.BtnOpslaan_Click);
            // 
            // BtnAnuleren
            // 
            this.BtnAnuleren.BackColor = System.Drawing.Color.Red;
            this.BtnAnuleren.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAnuleren.ForeColor = System.Drawing.Color.Black;
            this.BtnAnuleren.Location = new System.Drawing.Point(209, 344);
            this.BtnAnuleren.Name = "BtnAnuleren";
            this.BtnAnuleren.Size = new System.Drawing.Size(143, 34);
            this.BtnAnuleren.TabIndex = 6;
            this.BtnAnuleren.Text = "Anuleren";
            this.BtnAnuleren.UseVisualStyleBackColor = false;
            this.BtnAnuleren.Click += new System.EventHandler(this.BtnAnuleren_Click);
            // 
            // backButton1
            // 
            this.backButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton1.BackgroundImage")));
            this.backButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backButton1.Location = new System.Drawing.Point(12, 55);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(50, 50);
            this.backButton1.TabIndex = 29;
            this.backButton1.Text = " ";
            this.backButton1.UseVisualStyleBackColor = true;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // homeButton2
            // 
            this.homeButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton2.BackgroundImage")));
            this.homeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.homeButton2.Location = new System.Drawing.Point(12, 9);
            this.homeButton2.Name = "homeButton2";
            this.homeButton2.Size = new System.Drawing.Size(50, 50);
            this.homeButton2.TabIndex = 28;
            this.homeButton2.Text = " ";
            this.homeButton2.UseVisualStyleBackColor = true;
            this.homeButton2.Click += new System.EventHandler(this.homeButton2_Click);
            // 
            // LblTafelnummer
            // 
            this.LblTafelnummer.AutoSize = true;
            this.LblTafelnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTafelnummer.Location = new System.Drawing.Point(204, 67);
            this.LblTafelnummer.Name = "LblTafelnummer";
            this.LblTafelnummer.Size = new System.Drawing.Size(22, 25);
            this.LblTafelnummer.TabIndex = 30;
            this.LblTafelnummer.Text = "x";
            // 
            // Rekening_OpmerkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 638);
            this.Controls.Add(this.LblTafelnummer);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.homeButton2);
            this.Controls.Add(this.BtnAnuleren);
            this.Controls.Add(this.BtnOpslaan);
            this.Controls.Add(this.Tbopmerking);
            this.Name = "Rekening_OpmerkingForm";
            this.Text = "Rekening_OpmerkingForm";
            this.Controls.SetChildIndex(this.Tbopmerking, 0);
            this.Controls.SetChildIndex(this.BtnOpslaan, 0);
            this.Controls.SetChildIndex(this.BtnAnuleren, 0);
            this.Controls.SetChildIndex(this.homeButton2, 0);
            this.Controls.SetChildIndex(this.backButton1, 0);
            this.Controls.SetChildIndex(this.LblTafelnummer, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbopmerking;
        private System.Windows.Forms.Button BtnOpslaan;
        private System.Windows.Forms.Button BtnAnuleren;
        private StyleGuide.BackButton backButton1;
        private StyleGuide.HomeButton homeButton2;
        private System.Windows.Forms.Label LblTafelnummer;
    }
}