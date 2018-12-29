namespace Style_guide
{
    partial class BaseFormMobile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseFormMobile));
            this.homeButton1 = new Style_guide.HomeButton();
            this.titel2 = new Styleguide.Titel();
            this.backButton1 = new Style_guide.BackButton();
            this.SuspendLayout();
            // 
            // homeButton1
            // 
            this.homeButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton1.BackgroundImage")));
            this.homeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.homeButton1.Location = new System.Drawing.Point(10, 5);
            this.homeButton1.Name = "homeButton1";
            this.homeButton1.Size = new System.Drawing.Size(50, 50);
            this.homeButton1.TabIndex = 2;
            this.homeButton1.Text = " ";
            this.homeButton1.UseVisualStyleBackColor = true;
            // 
            // titel2
            // 
            this.titel2.AutoSize = true;
            this.titel2.Font = new System.Drawing.Font("Arial", 25F);
            this.titel2.Location = new System.Drawing.Point(98, 9);
            this.titel2.Name = "titel2";
            this.titel2.Size = new System.Drawing.Size(165, 47);
            this.titel2.TabIndex = 1;
            this.titel2.Text = "Chapoo";
            this.titel2.Click += new System.EventHandler(this.titel2_Click);
            // 
            // backButton1
            // 
            this.backButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton1.BackgroundImage")));
            this.backButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backButton1.Location = new System.Drawing.Point(10, 50);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(50, 50);
            this.backButton1.TabIndex = 3;
            this.backButton1.UseVisualStyleBackColor = true;
            // 
            // BaseFormMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(382, 636);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.homeButton1);
            this.Controls.Add(this.titel2);
            this.Name = "BaseFormMobile";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Styleguide.Titel titel2;
        private HomeButton homeButton1;
        private BackButton backButton1;
    }
}

