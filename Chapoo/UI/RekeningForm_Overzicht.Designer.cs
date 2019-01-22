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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RekeningForm_Overzicht));
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
            this.listView = new System.Windows.Forms.ListView();
            this.LblOpmerking = new System.Windows.Forms.Label();
            this.OutOpmerking = new System.Windows.Forms.Label();
            this.homeButton1 = new Style_guide.HomeButton();
            this.backButton1 = new Style_guide.BackButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridVwOverzicht)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTafelnummer
            // 
            this.LblTafelnummer.AutoSize = true;
            this.LblTafelnummer.Location = new System.Drawing.Point(158, 59);
            this.LblTafelnummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTafelnummer.Name = "LblTafelnummer";
            this.LblTafelnummer.Size = new System.Drawing.Size(12, 13);
            this.LblTafelnummer.TabIndex = 4;
            this.LblTafelnummer.Text = "x";
            // 
            // GridVwOverzicht
            // 
            this.GridVwOverzicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVwOverzicht.Location = new System.Drawing.Point(11, 76);
            this.GridVwOverzicht.Margin = new System.Windows.Forms.Padding(2);
            this.GridVwOverzicht.Name = "GridVwOverzicht";
            this.GridVwOverzicht.RowTemplate.Height = 24;
            this.GridVwOverzicht.Size = new System.Drawing.Size(264, 221);
            this.GridVwOverzicht.TabIndex = 5;
            // 
            // BtnOpmerking
            // 
            this.BtnOpmerking.Location = new System.Drawing.Point(182, 314);
            this.BtnOpmerking.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOpmerking.Name = "BtnOpmerking";
            this.BtnOpmerking.Size = new System.Drawing.Size(80, 28);
            this.BtnOpmerking.TabIndex = 6;
            this.BtnOpmerking.Text = "Opmerking";
            this.BtnOpmerking.UseVisualStyleBackColor = true;
            this.BtnOpmerking.Click += new System.EventHandler(this.BtnOpmerking_Click);
            // 
            // BtnDoor
            // 
            this.BtnDoor.Location = new System.Drawing.Point(80, 453);
            this.BtnDoor.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDoor.Name = "BtnDoor";
            this.BtnDoor.Size = new System.Drawing.Size(118, 37);
            this.BtnDoor.TabIndex = 7;
            this.BtnDoor.Text = "doorgaan naar betalen";
            this.BtnDoor.UseVisualStyleBackColor = true;
            this.BtnDoor.Click += new System.EventHandler(this.BtnDoor_Click);
            // 
            // LblexclBtw
            // 
            this.LblexclBtw.AutoSize = true;
            this.LblexclBtw.Location = new System.Drawing.Point(27, 314);
            this.LblexclBtw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblexclBtw.Name = "LblexclBtw";
            this.LblexclBtw.Size = new System.Drawing.Size(70, 13);
            this.LblexclBtw.TabIndex = 8;
            this.LblexclBtw.Text = "prijs excl. btw";
            // 
            // Lblbtw6
            // 
            this.Lblbtw6.AutoSize = true;
            this.Lblbtw6.Location = new System.Drawing.Point(50, 331);
            this.Lblbtw6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lblbtw6.Name = "Lblbtw6";
            this.Lblbtw6.Size = new System.Drawing.Size(47, 13);
            this.Lblbtw6.TabIndex = 9;
            this.Lblbtw6.Text = "btw   9%";
            // 
            // Lblbtw21
            // 
            this.Lblbtw21.AutoSize = true;
            this.Lblbtw21.Location = new System.Drawing.Point(50, 344);
            this.Lblbtw21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lblbtw21.Name = "Lblbtw21";
            this.Lblbtw21.Size = new System.Drawing.Size(47, 13);
            this.Lblbtw21.TabIndex = 10;
            this.Lblbtw21.Text = "btw 21%";
            // 
            // LblinclBtw
            // 
            this.LblinclBtw.AutoSize = true;
            this.LblinclBtw.Location = new System.Drawing.Point(27, 370);
            this.LblinclBtw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblinclBtw.Name = "LblinclBtw";
            this.LblinclBtw.Size = new System.Drawing.Size(67, 13);
            this.LblinclBtw.TabIndex = 11;
            this.LblinclBtw.Text = "prijs incl. btw";
            // 
            // OutInclBtw
            // 
            this.OutInclBtw.AutoSize = true;
            this.OutInclBtw.Location = new System.Drawing.Point(117, 370);
            this.OutInclBtw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutInclBtw.Name = "OutInclBtw";
            this.OutInclBtw.Size = new System.Drawing.Size(13, 13);
            this.OutInclBtw.TabIndex = 15;
            this.OutInclBtw.Text = "€";
            // 
            // OutBtw21
            // 
            this.OutBtw21.AutoSize = true;
            this.OutBtw21.Location = new System.Drawing.Point(117, 344);
            this.OutBtw21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutBtw21.Name = "OutBtw21";
            this.OutBtw21.Size = new System.Drawing.Size(13, 13);
            this.OutBtw21.TabIndex = 14;
            this.OutBtw21.Text = "€";
            // 
            // OutBtw6
            // 
            this.OutBtw6.AutoSize = true;
            this.OutBtw6.Location = new System.Drawing.Point(117, 331);
            this.OutBtw6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutBtw6.Name = "OutBtw6";
            this.OutBtw6.Size = new System.Drawing.Size(13, 13);
            this.OutBtw6.TabIndex = 13;
            this.OutBtw6.Text = "€";
            // 
            // OutExclBtw
            // 
            this.OutExclBtw.AutoSize = true;
            this.OutExclBtw.Location = new System.Drawing.Point(117, 314);
            this.OutExclBtw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutExclBtw.Name = "OutExclBtw";
            this.OutExclBtw.Size = new System.Drawing.Size(13, 13);
            this.OutExclBtw.TabIndex = 12;
            this.OutExclBtw.Text = "€";
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(202, 453);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(231, 219);
            this.listView.TabIndex = 16;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // LblOpmerking
            // 
            this.LblOpmerking.AutoSize = true;
            this.LblOpmerking.Location = new System.Drawing.Point(29, 396);
            this.LblOpmerking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOpmerking.Name = "LblOpmerking";
            this.LblOpmerking.Size = new System.Drawing.Size(58, 13);
            this.LblOpmerking.TabIndex = 17;
            this.LblOpmerking.Text = "Opmerking";
            // 
            // OutOpmerking
            // 
            this.OutOpmerking.AutoSize = true;
            this.OutOpmerking.Location = new System.Drawing.Point(114, 396);
            this.OutOpmerking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutOpmerking.Name = "OutOpmerking";
            this.OutOpmerking.Size = new System.Drawing.Size(10, 13);
            this.OutOpmerking.TabIndex = 18;
            this.OutOpmerking.Text = "-";
            // 
            // homeButton1
            // 
            this.homeButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton1.BackgroundImage")));
            this.homeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.homeButton1.Location = new System.Drawing.Point(12, -4);
            this.homeButton1.Name = "homeButton1";
            this.homeButton1.Size = new System.Drawing.Size(38, 39);
            this.homeButton1.TabIndex = 19;
            this.homeButton1.Text = "homeButton1";
            this.homeButton1.UseVisualStyleBackColor = true;
            // 
            // backButton1
            // 
            this.backButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton1.BackgroundImage")));
            this.backButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backButton1.Location = new System.Drawing.Point(11, 32);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(48, 42);
            this.backButton1.TabIndex = 20;
            this.backButton1.Text = "backButton1";
            this.backButton1.UseVisualStyleBackColor = true;
            // 
            // RekeningForm_Overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 518);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.homeButton1);
            this.Controls.Add(this.OutOpmerking);
            this.Controls.Add(this.LblOpmerking);
            this.Controls.Add(this.listView);
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
            this.Controls.SetChildIndex(this.listView, 0);
            this.Controls.SetChildIndex(this.LblOpmerking, 0);
            this.Controls.SetChildIndex(this.OutOpmerking, 0);
            this.Controls.SetChildIndex(this.homeButton1, 0);
            this.Controls.SetChildIndex(this.backButton1, 0);
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
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label LblOpmerking;
        private System.Windows.Forms.Label OutOpmerking;
        private Style_guide.HomeButton homeButton1;
        private Style_guide.BackButton backButton1;
    }
}