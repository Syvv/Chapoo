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
            this.btnUitloggen = new StyleGuide.UitlogButton();
            this.Togglebtn = new StyleGuide.BaseButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(800, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "(Commentaar:)";
            // 
            // Headertext
            // 
            this.Headertext.AutoSize = true;
            this.Headertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headertext.Location = new System.Drawing.Point(72, 13);
            this.Headertext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Headertext.Name = "Headertext";
            this.Headertext.Size = new System.Drawing.Size(337, 26);
            this.Headertext.TabIndex = 2;
            this.Headertext.Text = "Te bereiden gerechten in Keuken:";
            // 
            // btnUitloggen
            // 
            this.btnUitloggen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUitloggen.BackgroundImage")));
            this.btnUitloggen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUitloggen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUitloggen.Location = new System.Drawing.Point(14, 12);
            this.btnUitloggen.Margin = new System.Windows.Forms.Padding(2);
            this.btnUitloggen.Name = "btnUitloggen";
            this.btnUitloggen.Size = new System.Drawing.Size(25, 26);
            this.btnUitloggen.TabIndex = 0;
            this.btnUitloggen.UseVisualStyleBackColor = true;
            this.btnUitloggen.Click += new System.EventHandler(this.btnUitloggen_Click);
            // 
            // Togglebtn
            // 
            this.Togglebtn.BackColor = System.Drawing.SystemColors.Control;
            this.Togglebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Togglebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Togglebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Togglebtn.Location = new System.Drawing.Point(1402, 1);
            this.Togglebtn.Name = "Togglebtn";
            this.Togglebtn.Size = new System.Drawing.Size(145, 48);
            this.Togglebtn.TabIndex = 3;
            this.Togglebtn.Text = "Bestellingen van vandaag laten zien";
            this.Togglebtn.UseVisualStyleBackColor = false;
            this.Togglebtn.Click += new System.EventHandler(this.Togglebtn_Click);
            // 
            // BarKeukenHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.Togglebtn);
            this.Controls.Add(this.Headertext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUitloggen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1550, 52);
            this.MinimumSize = new System.Drawing.Size(1550, 52);
            this.Name = "BarKeukenHeader";
            this.Size = new System.Drawing.Size(1550, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StyleGuide.UitlogButton btnUitloggen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Headertext;
        private StyleGuide.BaseButton Togglebtn;
    }
}
