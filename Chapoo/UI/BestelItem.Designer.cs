namespace UI
{
    partial class BestelItem
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
            this.addButton1 = new StyleGuide.AddButton();
            this.SuspendLayout();
            // 
            // addButton1
            // 
            this.addButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addButton1.Location = new System.Drawing.Point(41, 49);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(50, 50);
            this.addButton1.TabIndex = 0;
            this.addButton1.Text = "+";
            this.addButton1.UseVisualStyleBackColor = true;
            // 
            // tekst1
            // 
            this.tekst1.AutoSize = true;
            this.tekst1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tekst1.Location = new System.Drawing.Point(116, 62);
            this.tekst1.Name = "tekst1";
            this.tekst1.Size = new System.Drawing.Size(64, 25);
            this.tekst1.TabIndex = 1;
            this.tekst1.Text = "tekst1";
            // 
            // BestelItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tekst1);
            this.Controls.Add(this.addButton1);
            this.Name = "BestelItem";
            this.Size = new System.Drawing.Size(550, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StyleGuide.AddButton addButton1;
        private StyleGuide.Tekst tekst1;
    }
}
