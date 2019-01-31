namespace UI
{
    partial class VoorraadMelding
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
            this.lblTitel = new StyleGuide.Titel();
            this.lblVoorraad = new System.Windows.Forms.Label();
            this.baseButton1 = new StyleGuide.BaseButton();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Arial", 20F);
            this.lblTitel.Location = new System.Drawing.Point(49, 16);
            this.lblTitel.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(473, 78);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Het opgegeven aantal is hoger dan de voorraad";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVoorraad
            // 
            this.lblVoorraad.AutoSize = true;
            this.lblVoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoorraad.Location = new System.Drawing.Point(96, 130);
            this.lblVoorraad.Name = "lblVoorraad";
            this.lblVoorraad.Size = new System.Drawing.Size(79, 29);
            this.lblVoorraad.TabIndex = 1;
            this.lblVoorraad.Text = "label1";
            // 
            // baseButton1
            // 
            this.baseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baseButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.baseButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.baseButton1.Location = new System.Drawing.Point(231, 206);
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.Size = new System.Drawing.Size(122, 49);
            this.baseButton1.TabIndex = 2;
            this.baseButton1.Text = "OK";
            this.baseButton1.UseVisualStyleBackColor = true;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // VoorraadMelding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.baseButton1);
            this.Controls.Add(this.lblVoorraad);
            this.Controls.Add(this.lblTitel);
            this.Name = "VoorraadMelding";
            this.Size = new System.Drawing.Size(584, 276);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StyleGuide.Titel lblTitel;
        private StyleGuide.BaseButton baseButton1;
        private System.Windows.Forms.Label lblVoorraad;
    }
}
