namespace UI
{
    partial class BarKeukenUIElement
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
            this.Tafelnummer = new System.Windows.Forms.Label();
            this.Hoeveelheid = new System.Windows.Forms.Label();
            this.MenuItem = new System.Windows.Forms.Label();
            this.Commentaar = new System.Windows.Forms.Label();
            this.GereedstellenBtn = new System.Windows.Forms.Button();
            this.Timestamp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tafelnummer
            // 
            this.Tafelnummer.AutoSize = true;
            this.Tafelnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tafelnummer.Location = new System.Drawing.Point(6, 19);
            this.Tafelnummer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Tafelnummer.MinimumSize = new System.Drawing.Size(160, 48);
            this.Tafelnummer.Name = "Tafelnummer";
            this.Tafelnummer.Size = new System.Drawing.Size(160, 48);
            this.Tafelnummer.TabIndex = 0;
            // 
            // Hoeveelheid
            // 
            this.Hoeveelheid.AutoSize = true;
            this.Hoeveelheid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Hoeveelheid.Location = new System.Drawing.Point(180, 19);
            this.Hoeveelheid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Hoeveelheid.MinimumSize = new System.Drawing.Size(80, 48);
            this.Hoeveelheid.Name = "Hoeveelheid";
            this.Hoeveelheid.Size = new System.Drawing.Size(80, 48);
            this.Hoeveelheid.TabIndex = 1;
            // 
            // MenuItem
            // 
            this.MenuItem.AutoSize = true;
            this.MenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MenuItem.Location = new System.Drawing.Point(270, 19);
            this.MenuItem.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MenuItem.MinimumSize = new System.Drawing.Size(1300, 48);
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(1300, 48);
            this.MenuItem.TabIndex = 2;
            // 
            // Commentaar
            // 
            this.Commentaar.AutoSize = true;
            this.Commentaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Commentaar.Location = new System.Drawing.Point(1600, 19);
            this.Commentaar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Commentaar.MaximumSize = new System.Drawing.Size(700, 192);
            this.Commentaar.MinimumSize = new System.Drawing.Size(700, 48);
            this.Commentaar.Name = "Commentaar";
            this.Commentaar.Size = new System.Drawing.Size(700, 48);
            this.Commentaar.TabIndex = 3;
            // 
            // GereedstellenBtn
            // 
            this.GereedstellenBtn.BackColor = System.Drawing.SystemColors.Info;
            this.GereedstellenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GereedstellenBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.GereedstellenBtn.Location = new System.Drawing.Point(2400, 10);
            this.GereedstellenBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GereedstellenBtn.MinimumSize = new System.Drawing.Size(500, 58);
            this.GereedstellenBtn.Name = "GereedstellenBtn";
            this.GereedstellenBtn.Size = new System.Drawing.Size(500, 63);
            this.GereedstellenBtn.TabIndex = 4;
            this.GereedstellenBtn.Text = "Deze rij gereedstellen";
            this.GereedstellenBtn.UseVisualStyleBackColor = false;
            // 
            // Timestamp
            // 
            this.Timestamp.AutoSize = true;
            this.Timestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Timestamp.Location = new System.Drawing.Point(2900, 19);
            this.Timestamp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Timestamp.MinimumSize = new System.Drawing.Size(200, 48);
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.Size = new System.Drawing.Size(200, 48);
            this.Timestamp.TabIndex = 5;
            this.Timestamp.Text = "00:00";
            // 
            // BarKeukenUIElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.Timestamp);
            this.Controls.Add(this.GereedstellenBtn);
            this.Controls.Add(this.Commentaar);
            this.Controls.Add(this.MenuItem);
            this.Controls.Add(this.Hoeveelheid);
            this.Controls.Add(this.Tafelnummer);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(3100, 231);
            this.MinimumSize = new System.Drawing.Size(3100, 77);
            this.Name = "BarKeukenUIElement";
            this.Size = new System.Drawing.Size(3100, 77);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tafelnummer;
        private System.Windows.Forms.Label Hoeveelheid;
        private System.Windows.Forms.Label MenuItem;
        private System.Windows.Forms.Label Commentaar;
        private System.Windows.Forms.Button GereedstellenBtn;
        private System.Windows.Forms.Label Timestamp;
    }
}
