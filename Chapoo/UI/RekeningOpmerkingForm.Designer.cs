namespace UI
{
    partial class RekeningOpmerkingForm
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
            this.TbOpmerking = new System.Windows.Forms.TextBox();
            this.BtnOpslaan = new System.Windows.Forms.Button();
            this.BtnAnuleren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbOpmerking
            // 
            this.TbOpmerking.Location = new System.Drawing.Point(21, 12);
            this.TbOpmerking.Multiline = true;
            this.TbOpmerking.Name = "TbOpmerking";
            this.TbOpmerking.Size = new System.Drawing.Size(449, 128);
            this.TbOpmerking.TabIndex = 0;
            // 
            // BtnOpslaan
            // 
            this.BtnOpslaan.Location = new System.Drawing.Point(21, 166);
            this.BtnOpslaan.Name = "BtnOpslaan";
            this.BtnOpslaan.Size = new System.Drawing.Size(206, 44);
            this.BtnOpslaan.TabIndex = 1;
            this.BtnOpslaan.Text = "Opslaan";
            this.BtnOpslaan.UseVisualStyleBackColor = true;
            this.BtnOpslaan.Click += new System.EventHandler(this.BtnOpslaan_Click);
            // 
            // BtnAnuleren
            // 
            this.BtnAnuleren.Location = new System.Drawing.Point(264, 166);
            this.BtnAnuleren.Name = "BtnAnuleren";
            this.BtnAnuleren.Size = new System.Drawing.Size(206, 44);
            this.BtnAnuleren.TabIndex = 2;
            this.BtnAnuleren.Text = "Anuleren";
            this.BtnAnuleren.UseVisualStyleBackColor = true;
            this.BtnAnuleren.Click += new System.EventHandler(this.BtnAnuleren_Click);
            // 
            // RekeningOpmerkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 306);
            this.Controls.Add(this.BtnAnuleren);
            this.Controls.Add(this.BtnOpslaan);
            this.Controls.Add(this.TbOpmerking);
            this.Name = "RekeningOpmerkingForm";
            this.Text = "RekeningOpmerkingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbOpmerking;
        private System.Windows.Forms.Button BtnOpslaan;
        private System.Windows.Forms.Button BtnAnuleren;
    }
}