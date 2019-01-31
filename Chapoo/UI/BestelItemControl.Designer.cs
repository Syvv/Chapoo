namespace UI
{
    partial class BestelItemControl
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
            this.addButton1 = new StyleGuide.AddButton();
            this.lblItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton1
            // 
            this.addButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addButton1.Location = new System.Drawing.Point(3, 13);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(84, 50);
            this.addButton1.TabIndex = 0;
            this.addButton1.Text = "+";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(93, 26);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(64, 25);
            this.lblItem.TabIndex = 1;
            this.lblItem.Text = "label1";
            // 
            // BestelItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.addButton1);
            this.Name = "BestelItemControl";
            this.Size = new System.Drawing.Size(582, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public StyleGuide.AddButton addButton1;
        public System.Windows.Forms.Label lblItem;
    }
}
