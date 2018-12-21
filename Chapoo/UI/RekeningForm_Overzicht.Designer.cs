namespace UI
{
    partial class RekeningForm_Overzicht
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
            this.DataGritVieuwOverzicht = new System.Windows.Forms.DataGridView();
            this.buttonGritVieuw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGritVieuwOverzicht)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGritVieuwOverzicht
            // 
            this.DataGritVieuwOverzicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGritVieuwOverzicht.Location = new System.Drawing.Point(44, 71);
            this.DataGritVieuwOverzicht.Name = "DataGritVieuwOverzicht";
            this.DataGritVieuwOverzicht.RowTemplate.Height = 24;
            this.DataGritVieuwOverzicht.Size = new System.Drawing.Size(320, 306);
            this.DataGritVieuwOverzicht.TabIndex = 0;
            this.DataGritVieuwOverzicht.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonGritVieuw
            // 
            this.buttonGritVieuw.Location = new System.Drawing.Point(126, 383);
            this.buttonGritVieuw.Name = "buttonGritVieuw";
            this.buttonGritVieuw.Size = new System.Drawing.Size(149, 41);
            this.buttonGritVieuw.TabIndex = 1;
            this.buttonGritVieuw.Text = "GritShow";
            this.buttonGritVieuw.UseVisualStyleBackColor = true;
            this.buttonGritVieuw.Click += new System.EventHandler(this.buttonGritVieuw_Click);
            // 
            // RekeningForm_Overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 753);
            this.Controls.Add(this.buttonGritVieuw);
            this.Controls.Add(this.DataGritVieuwOverzicht);
            this.Name = "RekeningForm_Overzicht";
            this.Text = "RekeningForm_Overzicht";
            this.Load += new System.EventHandler(this.RekeningForm_Overzicht_Load);
            this.Controls.SetChildIndex(this.DataGritVieuwOverzicht, 0);
            this.Controls.SetChildIndex(this.buttonGritVieuw, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataGritVieuwOverzicht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGritVieuwOverzicht;
        private System.Windows.Forms.Button buttonGritVieuw;
    }
}