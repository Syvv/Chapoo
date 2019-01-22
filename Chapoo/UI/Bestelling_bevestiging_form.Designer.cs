namespace UI
{
    partial class Bestelling_bevestiging_form
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
            this.titel1 = new Styleguide.Titel();
            this.baseButton1 = new Styleguide.BaseButton();
            this.baseButton2 = new Styleguide.BaseButton();
            this.SuspendLayout();
            // 
            // titel1
            // 
            this.titel1.AutoSize = true;
            this.titel1.Font = new System.Drawing.Font("Arial", 20F);
            this.titel1.Location = new System.Drawing.Point(65, 46);
            this.titel1.MaximumSize = new System.Drawing.Size(450, 0);
            this.titel1.Name = "titel1";
            this.titel1.Size = new System.Drawing.Size(361, 78);
            this.titel1.TabIndex = 1;
            this.titel1.Text = "Weet je zeker dat je wilt verwijderen?";
            this.titel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titel1.Click += new System.EventHandler(this.titel1_Click);
            // 
            // baseButton1
            // 
            this.baseButton1.BackColor = System.Drawing.Color.White;
            this.baseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baseButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.baseButton1.Location = new System.Drawing.Point(58, 191);
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.Size = new System.Drawing.Size(165, 53);
            this.baseButton1.TabIndex = 2;
            this.baseButton1.Text = "Delete";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // baseButton2
            // 
            this.baseButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baseButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.baseButton2.Location = new System.Drawing.Point(245, 191);
            this.baseButton2.Name = "baseButton2";
            this.baseButton2.Size = new System.Drawing.Size(165, 53);
            this.baseButton2.TabIndex = 3;
            this.baseButton2.Text = "Cancel";
            this.baseButton2.UseVisualStyleBackColor = true;
            // 
            // Bevestiging_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(489, 329);
            this.Controls.Add(this.baseButton2);
            this.Controls.Add(this.baseButton1);
            this.Controls.Add(this.titel1);
            this.Name = "Bevestiging_form";
            this.Text = "Confirmation_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Styleguide.Titel titel1;
        private Styleguide.BaseButton baseButton1;
        private Styleguide.BaseButton baseButton2;
    }
}