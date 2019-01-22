namespace UI
{
    partial class Bestelling_overzicht_aanpassen_form
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
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.btnVerander = new Styleguide.BaseButton();
            this.btnCancel = new Styleguide.BaseButton();
            this.SuspendLayout();
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(12, 225);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(100, 22);
            this.txtAantal.TabIndex = 9;
            this.txtAantal.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aantal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Commentaar (optioneel)";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(12, 48);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(341, 140);
            this.txtComment.TabIndex = 6;
            this.txtComment.Text = "";
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // btnVerander
            // 
            this.btnVerander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerander.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVerander.Location = new System.Drawing.Point(12, 275);
            this.btnVerander.Name = "btnVerander";
            this.btnVerander.Size = new System.Drawing.Size(100, 30);
            this.btnVerander.TabIndex = 5;
            this.btnVerander.Text = "Verander";
            this.btnVerander.UseVisualStyleBackColor = true;
            this.btnVerander.Click += new System.EventHandler(this.btnVerander_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(253, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Bestelling_overzicht_aanpassen_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(382, 329);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnVerander);
            this.Name = "Bestelling_overzicht_aanpassen_form";
            this.Text = "Bestelling_overzicht_aanpassen_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtComment;
        private Styleguide.BaseButton btnVerander;
        private Styleguide.BaseButton btnCancel;
    }
}