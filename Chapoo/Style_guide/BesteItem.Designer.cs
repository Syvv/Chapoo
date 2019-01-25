namespace StyleGuide
{
    partial class BesteItem
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
            this.baseButton1 = new StyleGuide.BaseButton();
            this.SuspendLayout();
            // 
            // baseButton1
            // 
            this.baseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baseButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.baseButton1.Location = new System.Drawing.Point(45, 58);
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.Size = new System.Drawing.Size(42, 38);
            this.baseButton1.TabIndex = 0;
            this.baseButton1.Text = "+";
            this.baseButton1.UseVisualStyleBackColor = true;
            // 
            // txtItem
            // 
            this.txtItem.AutoSize = true;
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtItem.Location = new System.Drawing.Point(120, 68);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(124, 25);
            this.txtItem.TabIndex = 1;
            this.txtItem.Text = "Lorem ipsum";
            // 
            // BesteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.baseButton1);
            this.Name = "BesteItem";
            this.Size = new System.Drawing.Size(550, 150);
            this.Load += new System.EventHandler(this.BesteItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseButton baseButton1;
        private Tekst txtItem;
    }
}
