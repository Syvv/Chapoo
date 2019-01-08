namespace UI
{
    partial class Bestelling_opnemen_opmerking_form
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
            this.btnSendComment = new Styleguide.BaseButton();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSendComment
            // 
            this.btnSendComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSendComment.Location = new System.Drawing.Point(72, 287);
            this.btnSendComment.Name = "btnSendComment";
            this.btnSendComment.Size = new System.Drawing.Size(100, 30);
            this.btnSendComment.TabIndex = 0;
            this.btnSendComment.Text = "Verstuur";
            this.btnSendComment.UseVisualStyleBackColor = true;
            this.btnSendComment.Click += new System.EventHandler(this.btnSendComment_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(72, 53);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(341, 140);
            this.txtComment.TabIndex = 1;
            this.txtComment.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Commentaar (optioneel)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aantal";
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(72, 230);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(100, 22);
            this.txtAantal.TabIndex = 4;
            this.txtAantal.Text = "1";
            // 
            // Bestelling_opnemen_opmerking_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(489, 329);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnSendComment);
            this.Name = "Bestelling_opnemen_opmerking_form";
            this.Text = "Bestelling_opnemen_opmerking_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Styleguide.BaseButton btnSendComment;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAantal;
    }
}