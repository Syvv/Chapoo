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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnOpslaan = new System.Windows.Forms.Button();
            this.BtnAnuleren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 106);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 212);
            this.textBox1.TabIndex = 4;
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
            // 
            // BtnAnuleren
            // 
            this.BtnAnuleren.BackColor = System.Drawing.Color.Red;
            this.BtnAnuleren.Cursor = System.Windows.Forms.Cursors.No;
            this.BtnAnuleren.ForeColor = System.Drawing.Color.Black;
            this.BtnAnuleren.Location = new System.Drawing.Point(209, 344);
            this.BtnAnuleren.Name = "BtnAnuleren";
            this.BtnAnuleren.Size = new System.Drawing.Size(143, 34);
            this.BtnAnuleren.TabIndex = 6;
            this.BtnAnuleren.Text = "Anuleren";
            this.BtnAnuleren.UseVisualStyleBackColor = false;
            // 
            // Rekening_OpmerkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 638);
            this.Controls.Add(this.BtnAnuleren);
            this.Controls.Add(this.BtnOpslaan);
            this.Controls.Add(this.textBox1);
            this.Name = "Rekening_OpmerkingForm";
            this.Text = "Rekening_OpmerkingForm";
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.BtnOpslaan, 0);
            this.Controls.SetChildIndex(this.BtnAnuleren, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnOpslaan;
        private System.Windows.Forms.Button BtnAnuleren;
    }
}