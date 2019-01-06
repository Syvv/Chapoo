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
            this.SuspendLayout();
            // 
            // btnSendComment
            // 
            this.btnSendComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSendComment.Location = new System.Drawing.Point(156, 209);
            this.btnSendComment.Name = "btnSendComment";
            this.btnSendComment.Size = new System.Drawing.Size(100, 30);
            this.btnSendComment.TabIndex = 0;
            this.btnSendComment.Text = "Verstuur";
            this.btnSendComment.UseVisualStyleBackColor = true;
            this.btnSendComment.Click += new System.EventHandler(this.btnSendComment_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(45, 40);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(341, 140);
            this.txtComment.TabIndex = 1;
            this.txtComment.Text = "";
            // 
            // Bestelling_opnemen_opmerking_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(425, 273);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnSendComment);
            this.Name = "Bestelling_opnemen_opmerking_form";
            this.Text = "Bestelling_opnemen_opmerking_form";
            this.ResumeLayout(false);

        }

        #endregion

        private Styleguide.BaseButton btnSendComment;
        private System.Windows.Forms.RichTextBox txtComment;
    }
}