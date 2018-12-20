namespace UI
{
    partial class Login
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
            this.Loginbtn = new System.Windows.Forms.Button();
            this.BedieningRAD = new System.Windows.Forms.RadioButton();
            this.BarRAD = new System.Windows.Forms.RadioButton();
            this.KeukenRAD = new System.Windows.Forms.RadioButton();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(15, 158);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(188, 23);
            this.Loginbtn.TabIndex = 0;
            this.Loginbtn.Text = "Log in";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // BedieningRAD
            // 
            this.BedieningRAD.AutoSize = true;
            this.BedieningRAD.Checked = true;
            this.BedieningRAD.Location = new System.Drawing.Point(15, 80);
            this.BedieningRAD.Name = "BedieningRAD";
            this.BedieningRAD.Size = new System.Drawing.Size(72, 17);
            this.BedieningRAD.TabIndex = 1;
            this.BedieningRAD.TabStop = true;
            this.BedieningRAD.Text = "Bediening";
            this.BedieningRAD.UseVisualStyleBackColor = true;
            // 
            // BarRAD
            // 
            this.BarRAD.AutoSize = true;
            this.BarRAD.Location = new System.Drawing.Point(15, 101);
            this.BarRAD.Name = "BarRAD";
            this.BarRAD.Size = new System.Drawing.Size(87, 17);
            this.BarRAD.TabIndex = 2;
            this.BarRAD.Text = "Barpersoneel";
            this.BarRAD.UseVisualStyleBackColor = true;
            // 
            // KeukenRAD
            // 
            this.KeukenRAD.AutoSize = true;
            this.KeukenRAD.Location = new System.Drawing.Point(15, 124);
            this.KeukenRAD.Name = "KeukenRAD";
            this.KeukenRAD.Size = new System.Drawing.Size(108, 17);
            this.KeukenRAD.TabIndex = 3;
            this.KeukenRAD.Text = "Keukenpersoneel";
            this.KeukenRAD.UseVisualStyleBackColor = true;
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(76, 12);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(124, 20);
            this.UsernameInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(76, 48);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(124, 20);
            this.PasswordInput.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.KeukenRAD);
            this.Controls.Add(this.BarRAD);
            this.Controls.Add(this.BedieningRAD);
            this.Controls.Add(this.Loginbtn);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.RadioButton BedieningRAD;
        private System.Windows.Forms.RadioButton BarRAD;
        private System.Windows.Forms.RadioButton KeukenRAD;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordInput;
    }
}