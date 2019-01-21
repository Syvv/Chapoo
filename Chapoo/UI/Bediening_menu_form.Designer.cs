namespace UI
{
    partial class Bediening_menu_form
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
            this.baseButton1 = new Styleguide.BaseButton();
            this.baseButton2 = new Styleguide.BaseButton();
            this.baseButton3 = new Styleguide.BaseButton();
            this.SuspendLayout();
            // 
            // baseButton1
            // 
            this.baseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baseButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.baseButton1.Location = new System.Drawing.Point(27, 147);
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.Size = new System.Drawing.Size(328, 67);
            this.baseButton1.TabIndex = 5;
            this.baseButton1.Text = "Bestelling opnemen";
            this.baseButton1.UseVisualStyleBackColor = true;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // baseButton2
            // 
            this.baseButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baseButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.baseButton2.Location = new System.Drawing.Point(27, 246);
            this.baseButton2.Name = "baseButton2";
            this.baseButton2.Size = new System.Drawing.Size(328, 67);
            this.baseButton2.TabIndex = 6;
            this.baseButton2.Text = "Bestellingen";
            this.baseButton2.UseVisualStyleBackColor = true;
            this.baseButton2.Click += new System.EventHandler(this.baseButton2_Click);
            // 
            // baseButton3
            // 
            this.baseButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baseButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.baseButton3.Location = new System.Drawing.Point(27, 347);
            this.baseButton3.Name = "baseButton3";
            this.baseButton3.Size = new System.Drawing.Size(328, 67);
            this.baseButton3.TabIndex = 7;
            this.baseButton3.Text = "Afrekenen";
            this.baseButton3.UseVisualStyleBackColor = true;
            this.baseButton3.Click += new System.EventHandler(this.baseButton3_Click);
            // 
            // Bediening_menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 638);
            this.Controls.Add(this.baseButton3);
            this.Controls.Add(this.baseButton2);
            this.Controls.Add(this.baseButton1);
            this.Name = "Bediening_menu_form";
            this.Text = "Bediening_menu_form";
            this.Load += new System.EventHandler(this.Bediening_menu_form_Load);
            this.Controls.SetChildIndex(this.baseButton1, 0);
            this.Controls.SetChildIndex(this.baseButton2, 0);
            this.Controls.SetChildIndex(this.baseButton3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Styleguide.BaseButton baseButton1;
        private Styleguide.BaseButton baseButton2;
        private Styleguide.BaseButton baseButton3;
    }
}