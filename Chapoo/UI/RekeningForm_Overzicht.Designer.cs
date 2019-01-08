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
            this.LblTafelnummer = new System.Windows.Forms.Label();
            this.GridVwOverzicht = new System.Windows.Forms.DataGridView();
            this.BtnOpmerking = new System.Windows.Forms.Button();
            this.BtnDoor = new System.Windows.Forms.Button();
            this.LblexclBtw = new System.Windows.Forms.Label();
            this.Lblbtw6 = new System.Windows.Forms.Label();
            this.Lblbtw21 = new System.Windows.Forms.Label();
            this.LblinclBtw = new System.Windows.Forms.Label();
            this.OutInclBtw = new System.Windows.Forms.Label();
            this.OutBtw21 = new System.Windows.Forms.Label();
            this.OutBtw6 = new System.Windows.Forms.Label();
            this.OutExclBtw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridVwOverzicht)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTafelnummer
            // 
            this.LblTafelnummer.AutoSize = true;
            this.LblTafelnummer.Location = new System.Drawing.Point(156, 67);
            this.LblTafelnummer.Name = "LblTafelnummer";
            this.LblTafelnummer.Size = new System.Drawing.Size(150, 17);
            this.LblTafelnummer.TabIndex = 4;
            this.LblTafelnummer.Text = "Hier komt tafelnummer";
            // 
            // GridVwOverzicht
            // 
            this.GridVwOverzicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVwOverzicht.Location = new System.Drawing.Point(36, 106);
            this.GridVwOverzicht.Name = "GridVwOverzicht";
            this.GridVwOverzicht.RowTemplate.Height = 24;
            this.GridVwOverzicht.Size = new System.Drawing.Size(310, 240);
            this.GridVwOverzicht.TabIndex = 5;
            // 
            // BtnOpmerking
            // 
            this.BtnOpmerking.Location = new System.Drawing.Point(239, 370);
            this.BtnOpmerking.Name = "BtnOpmerking";
            this.BtnOpmerking.Size = new System.Drawing.Size(107, 34);
            this.BtnOpmerking.TabIndex = 6;
            this.BtnOpmerking.Text = "Opmerking";
            this.BtnOpmerking.UseVisualStyleBackColor = true;
            this.BtnOpmerking.Click += new System.EventHandler(this.BtnOpmerking_Click);
            // 
            // BtnDoor
            // 
            this.BtnDoor.Location = new System.Drawing.Point(106, 558);
            this.BtnDoor.Name = "BtnDoor";
            this.BtnDoor.Size = new System.Drawing.Size(157, 45);
            this.BtnDoor.TabIndex = 7;
            this.BtnDoor.Text = "doorgaan naar betalen";
            this.BtnDoor.UseVisualStyleBackColor = true;
            this.BtnDoor.Click += new System.EventHandler(this.BtnDoor_Click);
            // 
            // LblexclBtw
            // 
            this.LblexclBtw.AutoSize = true;
            this.LblexclBtw.Location = new System.Drawing.Point(36, 386);
            this.LblexclBtw.Name = "LblexclBtw";
            this.LblexclBtw.Size = new System.Drawing.Size(91, 17);
            this.LblexclBtw.TabIndex = 8;
            this.LblexclBtw.Text = "prijs excl. btw";
            // 
            // Lblbtw6
            // 
            this.Lblbtw6.AutoSize = true;
            this.Lblbtw6.Location = new System.Drawing.Point(66, 407);
            this.Lblbtw6.Name = "Lblbtw6";
            this.Lblbtw6.Size = new System.Drawing.Size(61, 17);
            this.Lblbtw6.TabIndex = 9;
            this.Lblbtw6.Text = "btw   6%";
            // 
            // Lblbtw21
            // 
            this.Lblbtw21.AutoSize = true;
            this.Lblbtw21.Location = new System.Drawing.Point(66, 424);
            this.Lblbtw21.Name = "Lblbtw21";
            this.Lblbtw21.Size = new System.Drawing.Size(61, 17);
            this.Lblbtw21.TabIndex = 10;
            this.Lblbtw21.Text = "btw 21%";
            // 
            // LblinclBtw
            // 
            this.LblinclBtw.AutoSize = true;
            this.LblinclBtw.Location = new System.Drawing.Point(36, 455);
            this.LblinclBtw.Name = "LblinclBtw";
            this.LblinclBtw.Size = new System.Drawing.Size(88, 17);
            this.LblinclBtw.TabIndex = 11;
            this.LblinclBtw.Text = "prijs incl. btw";
            // 
            // OutInclBtw
            // 
            this.OutInclBtw.AutoSize = true;
            this.OutInclBtw.Location = new System.Drawing.Point(156, 455);
            this.OutInclBtw.Name = "OutInclBtw";
            this.OutInclBtw.Size = new System.Drawing.Size(16, 17);
            this.OutInclBtw.TabIndex = 15;
            this.OutInclBtw.Text = "€";
            // 
            // OutBtw21
            // 
            this.OutBtw21.AutoSize = true;
            this.OutBtw21.Location = new System.Drawing.Point(156, 424);
            this.OutBtw21.Name = "OutBtw21";
            this.OutBtw21.Size = new System.Drawing.Size(16, 17);
            this.OutBtw21.TabIndex = 14;
            this.OutBtw21.Text = "€";
            // 
            // OutBtw6
            // 
            this.OutBtw6.AutoSize = true;
            this.OutBtw6.Location = new System.Drawing.Point(156, 407);
            this.OutBtw6.Name = "OutBtw6";
            this.OutBtw6.Size = new System.Drawing.Size(16, 17);
            this.OutBtw6.TabIndex = 13;
            this.OutBtw6.Text = "€";
            // 
            // OutExclBtw
            // 
            this.OutExclBtw.AutoSize = true;
            this.OutExclBtw.Location = new System.Drawing.Point(156, 386);
            this.OutExclBtw.Name = "OutExclBtw";
            this.OutExclBtw.Size = new System.Drawing.Size(16, 17);
            this.OutExclBtw.TabIndex = 12;
            this.OutExclBtw.Text = "€";
            // 
            // RekeningForm_Overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 638);
            this.Controls.Add(this.OutInclBtw);
            this.Controls.Add(this.OutBtw21);
            this.Controls.Add(this.OutBtw6);
            this.Controls.Add(this.OutExclBtw);
            this.Controls.Add(this.LblinclBtw);
            this.Controls.Add(this.Lblbtw21);
            this.Controls.Add(this.Lblbtw6);
            this.Controls.Add(this.LblexclBtw);
            this.Controls.Add(this.BtnDoor);
            this.Controls.Add(this.BtnOpmerking);
            this.Controls.Add(this.GridVwOverzicht);
            this.Controls.Add(this.LblTafelnummer);
            this.Name = "RekeningForm_Overzicht";
            this.Text = "RekeningForm_Overzicht";
            this.Load += new System.EventHandler(this.RekeningForm_Overzicht_Load);
            this.Controls.SetChildIndex(this.LblTafelnummer, 0);
            this.Controls.SetChildIndex(this.GridVwOverzicht, 0);
            this.Controls.SetChildIndex(this.BtnOpmerking, 0);
            this.Controls.SetChildIndex(this.BtnDoor, 0);
            this.Controls.SetChildIndex(this.LblexclBtw, 0);
            this.Controls.SetChildIndex(this.Lblbtw6, 0);
            this.Controls.SetChildIndex(this.Lblbtw21, 0);
            this.Controls.SetChildIndex(this.LblinclBtw, 0);
            this.Controls.SetChildIndex(this.OutExclBtw, 0);
            this.Controls.SetChildIndex(this.OutBtw6, 0);
            this.Controls.SetChildIndex(this.OutBtw21, 0);
            this.Controls.SetChildIndex(this.OutInclBtw, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GridVwOverzicht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTafelnummer;
        private System.Windows.Forms.DataGridView GridVwOverzicht;
        private System.Windows.Forms.Button BtnOpmerking;
        private System.Windows.Forms.Button BtnDoor;
        private System.Windows.Forms.Label LblexclBtw;
        private System.Windows.Forms.Label Lblbtw6;
        private System.Windows.Forms.Label Lblbtw21;
        private System.Windows.Forms.Label LblinclBtw;
        private System.Windows.Forms.Label OutInclBtw;
        private System.Windows.Forms.Label OutBtw21;
        private System.Windows.Forms.Label OutBtw6;
        private System.Windows.Forms.Label OutExclBtw;
    }
}