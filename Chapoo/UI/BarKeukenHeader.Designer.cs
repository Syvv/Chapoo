namespace UI
{
    partial class BarKeukenHeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarKeukenHeader));
            this.label1 = new System.Windows.Forms.Label();
            this.Headertext = new System.Windows.Forms.Label();
            this.uitlogButton = new StyleGuide.UitlogButton();
            this.Togglebtn = new StyleGuide.BaseButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1067, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "(Commentaar:)";
            // 
            // Headertext
            // 
            this.Headertext.AutoSize = true;
            this.Headertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headertext.Location = new System.Drawing.Point(96, 16);
            this.Headertext.Name = "Headertext";
            this.Headertext.Size = new System.Drawing.Size(421, 31);
            this.Headertext.TabIndex = 2;
            this.Headertext.Text = "Te bereiden gerechten in Keuken:";
            // 
            // uitlogButton
            // 
            this.uitlogButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uitlogButton.BackgroundImage")));
            this.uitlogButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uitlogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uitlogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uitlogButton.Location = new System.Drawing.Point(14, 8);
            this.uitlogButton.Name = "uitlogButton";
            this.uitlogButton.Size = new System.Drawing.Size(76, 50);
            this.uitlogButton.TabIndex = 4;
            this.uitlogButton.UseVisualStyleBackColor = true;
            this.uitlogButton.Click += new System.EventHandler(this.uitlogButton_Click);
            // 
            // Togglebtn
            // 
            this.Togglebtn.BackColor = System.Drawing.SystemColors.Control;
            this.Togglebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Togglebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Togglebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Togglebtn.Location = new System.Drawing.Point(1817, 3);
            this.Togglebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Togglebtn.Name = "Togglebtn";
            this.Togglebtn.Size = new System.Drawing.Size(193, 59);
            this.Togglebtn.TabIndex = 3;
            this.Togglebtn.Text = "Bestellingen van vandaag laten zien";
            this.Togglebtn.UseVisualStyleBackColor = false;
            this.Togglebtn.Click += new System.EventHandler(this.Togglebtn_Click);
            // 
            // BarKeukenHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.uitlogButton);
            this.Controls.Add(this.Togglebtn);
            this.Controls.Add(this.Headertext);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(2033, 64);
            this.MinimumSize = new System.Drawing.Size(2033, 64);
            this.Name = "BarKeukenHeader";
            this.Size = new System.Drawing.Size(2033, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Headertext;
        private StyleGuide.BaseButton Togglebtn;
        private StyleGuide.UitlogButton uitlogButton;
    }
}
