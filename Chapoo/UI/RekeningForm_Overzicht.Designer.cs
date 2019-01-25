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
            this.homeButton2 = new StyleGuide.HomeButton();
            this.backButton1 = new StyleGuide.BackButton();
            this.LblTafelnummer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridVwOverzicht)).BeginInit();
            this.SuspendLayout();
            // 
            // GridVwOverzicht
            // 
            this.GridVwOverzicht.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVwOverzicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVwOverzicht.Location = new System.Drawing.Point(0, 94);
            this.GridVwOverzicht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridVwOverzicht.Name = "GridVwOverzicht";
            this.GridVwOverzicht.RowTemplate.Height = 24;
            this.GridVwOverzicht.Size = new System.Drawing.Size(380, 272);
            this.GridVwOverzicht.TabIndex = 5;
            // 
            // BtnOpmerking
            // 
            this.BtnOpmerking.Location = new System.Drawing.Point(243, 386);
            this.BtnOpmerking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOpmerking.Name = "BtnOpmerking";
            this.BtnOpmerking.Size = new System.Drawing.Size(107, 34);
            this.BtnOpmerking.TabIndex = 6;
            this.BtnOpmerking.Text = "Opmerking";
            this.BtnOpmerking.UseVisualStyleBackColor = true;
            this.BtnOpmerking.Click += new System.EventHandler(this.BtnOpmerking_Click);
            // 
            // BtnDoor
            // 
            this.BtnDoor.Location = new System.Drawing.Point(107, 558);
            this.BtnDoor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDoor.Name = "BtnDoor";
            this.BtnDoor.Size = new System.Drawing.Size(157, 46);
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
            this.Lblbtw6.Location = new System.Drawing.Point(67, 407);
            this.Lblbtw6.Name = "Lblbtw6";
            this.Lblbtw6.Size = new System.Drawing.Size(61, 17);
            this.Lblbtw6.TabIndex = 9;
            this.Lblbtw6.Text = "btw   9%";
            // 
            // Lblbtw21
            // 
            this.Lblbtw21.AutoSize = true;
            this.Lblbtw21.Location = new System.Drawing.Point(67, 423);
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
            this.OutBtw21.Location = new System.Drawing.Point(156, 423);
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
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(269, 558);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(307, 269);
            this.listView.TabIndex = 16;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // LblOpmerking
            // 
            this.LblOpmerking.AutoSize = true;
            this.LblOpmerking.Location = new System.Drawing.Point(39, 487);
            this.LblOpmerking.Name = "LblOpmerking";
            this.LblOpmerking.Size = new System.Drawing.Size(77, 17);
            this.LblOpmerking.TabIndex = 17;
            this.LblOpmerking.Text = "Opmerking";
            // 
            // OutOpmerking
            // 
            this.OutOpmerking.AutoSize = true;
            this.OutOpmerking.Location = new System.Drawing.Point(152, 487);
            this.OutOpmerking.Name = "OutOpmerking";
            this.OutOpmerking.Size = new System.Drawing.Size(13, 17);
            this.OutOpmerking.TabIndex = 18;
            this.OutOpmerking.Text = "-";
            // 
            // homeButton2
            // 
            this.homeButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton2.BackgroundImage")));
            this.homeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.homeButton2.Location = new System.Drawing.Point(15, -4);
            this.homeButton2.Name = "homeButton2";
            this.homeButton2.Size = new System.Drawing.Size(50, 50);
            this.homeButton2.TabIndex = 24;
            this.homeButton2.Text = " ";
            this.homeButton2.UseVisualStyleBackColor = true;
            this.homeButton2.Click += new System.EventHandler(this.homeButton2_Click);
            // 
            // backButton1
            // 
            this.backButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton1.BackgroundImage")));
            this.backButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backButton1.Location = new System.Drawing.Point(15, 42);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(50, 50);
            this.backButton1.TabIndex = 25;
            this.backButton1.Text = " ";
            this.backButton1.UseVisualStyleBackColor = true;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click_1);
            // 
            // LblTafelnummer
            // 
            this.LblTafelnummer.AutoSize = true;
            this.LblTafelnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTafelnummer.Location = new System.Drawing.Point(209, 67);
            this.LblTafelnummer.Name = "LblTafelnummer";
            this.LblTafelnummer.Size = new System.Drawing.Size(22, 25);
            this.LblTafelnummer.TabIndex = 31;
            this.LblTafelnummer.Text = "x";
            // 
            // RekeningForm_Overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 638);
            this.Controls.Add(this.LblTafelnummer);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.homeButton2);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RekeningForm_Overzicht";
            this.Text = "RekeningForm_Overzicht";
            this.Load += new System.EventHandler(this.RekeningForm_Overzicht_Load);
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
            this.Controls.SetChildIndex(this.homeButton2, 0);
            this.Controls.SetChildIndex(this.backButton1, 0);
            this.Controls.SetChildIndex(this.LblTafelnummer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GridVwOverzicht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private StyleGuide.HomeButton homeButton2;
        private StyleGuide.BackButton backButton1;
        private System.Windows.Forms.Label LblTafelnummer;
    }
}