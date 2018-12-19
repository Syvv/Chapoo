namespace UI
{
    partial class TestRekeningForm
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
            this.lblTotaalbedrag = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TBInvul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTotaalbedrag
            // 
            this.lblTotaalbedrag.AutoSize = true;
            this.lblTotaalbedrag.Location = new System.Drawing.Point(98, 136);
            this.lblTotaalbedrag.Name = "lblTotaalbedrag";
            this.lblTotaalbedrag.Size = new System.Drawing.Size(86, 17);
            this.lblTotaalbedrag.TabIndex = 0;
            this.lblTotaalbedrag.Text = "TotaalBedra";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBInvul
            // 
            this.TBInvul.Location = new System.Drawing.Point(222, 136);
            this.TBInvul.Name = "TBInvul";
            this.TBInvul.Size = new System.Drawing.Size(100, 22);
            this.TBInvul.TabIndex = 2;
            // 
            // TestRekeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBInvul);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTotaalbedrag);
            this.Name = "TestRekeningForm";
            this.Text = "TestRekeningForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotaalbedrag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBInvul;
    }
}