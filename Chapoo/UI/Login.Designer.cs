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
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(16, 105);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(251, 28);
            this.Loginbtn.TabIndex = 0;
            this.Loginbtn.Text = "Log in";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(101, 15);
            this.UsernameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(164, 22);
            this.UsernameInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(101, 59);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '#';
            this.PasswordInput.Size = new System.Drawing.Size(164, 22);
            this.PasswordInput.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.Loginbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordInput;
    }
}