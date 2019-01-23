namespace UI
{
    partial class RekeningForm_Betaal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RekeningForm_Betaal));
            this.lbltotzonFooi = new System.Windows.Forms.Label();
            this.OutBedragZondFooi = new System.Windows.Forms.Label();
            this.lblIngevuldBedrag = new System.Windows.Forms.Label();
            this.TbBedragBetaald = new System.Windows.Forms.TextBox();
            this.lblFooi = new System.Windows.Forms.Label();
            this.OutFooi = new System.Windows.Forms.Label();
            this.lblTotaalEind = new System.Windows.Forms.Label();
            this.OutTotaalEind = new System.Windows.Forms.Label();
            this.btnBerekenFooi = new System.Windows.Forms.Button();
            this.BtnBetalingAfronden = new System.Windows.Forms.Button();
            this.BtnCreditcard = new System.Windows.Forms.Button();
            this.btn_Cash = new System.Windows.Forms.Button();
            this.LblTafelnummer = new System.Windows.Forms.Label();
            this.backButton1 = new Style_guide.BackButton();
            this.homeButton2 = new Style_guide.HomeButton();
            this.SuspendLayout();
            // 
            // lbltotzonFooi
            // 
            this.lbltotzonFooi.AutoSize = true;
            this.lbltotzonFooi.Location = new System.Drawing.Point(29, 146);
            this.lbltotzonFooi.Name = "lbltotzonFooi";
            this.lbltotzonFooi.Size = new System.Drawing.Size(152, 17);
            this.lbltotzonFooi.TabIndex = 5;
            this.lbltotzonFooi.Text = "Totaal bedrag incl. Btw";
            // 
            // OutBedragZondFooi
            // 
            this.OutBedragZondFooi.AutoSize = true;
            this.OutBedragZondFooi.Location = new System.Drawing.Point(225, 146);
            this.OutBedragZondFooi.Name = "OutBedragZondFooi";
            this.OutBedragZondFooi.Size = new System.Drawing.Size(42, 17);
            this.OutBedragZondFooi.TabIndex = 6;
            this.OutBedragZondFooi.Text = "€ x,xx";
            // 
            // lblIngevuldBedrag
            // 
            this.lblIngevuldBedrag.AutoSize = true;
            this.lblIngevuldBedrag.Location = new System.Drawing.Point(33, 191);
            this.lblIngevuldBedrag.Name = "lblIngevuldBedrag";
            this.lblIngevuldBedrag.Size = new System.Drawing.Size(105, 17);
            this.lblIngevuldBedrag.TabIndex = 7;
            this.lblIngevuldBedrag.Text = "Bedrag betaald";
            // 
            // TbBedragBetaald
            // 
            this.TbBedragBetaald.Location = new System.Drawing.Point(228, 185);
            this.TbBedragBetaald.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbBedragBetaald.Name = "TbBedragBetaald";
            this.TbBedragBetaald.Size = new System.Drawing.Size(100, 22);
            this.TbBedragBetaald.TabIndex = 8;
            // 
            // lblFooi
            // 
            this.lblFooi.AutoSize = true;
            this.lblFooi.Location = new System.Drawing.Point(33, 249);
            this.lblFooi.Name = "lblFooi";
            this.lblFooi.Size = new System.Drawing.Size(35, 17);
            this.lblFooi.TabIndex = 9;
            this.lblFooi.Text = "Fooi";
            // 
            // OutFooi
            // 
            this.OutFooi.AutoSize = true;
            this.OutFooi.Location = new System.Drawing.Point(228, 249);
            this.OutFooi.Name = "OutFooi";
            this.OutFooi.Size = new System.Drawing.Size(42, 17);
            this.OutFooi.TabIndex = 10;
            this.OutFooi.Text = "€ x,xx";
            // 
            // lblTotaalEind
            // 
            this.lblTotaalEind.AutoSize = true;
            this.lblTotaalEind.Location = new System.Drawing.Point(33, 300);
            this.lblTotaalEind.Name = "lblTotaalEind";
            this.lblTotaalEind.Size = new System.Drawing.Size(125, 17);
            this.lblTotaalEind.TabIndex = 11;
            this.lblTotaalEind.Text = "Totaal Eindbedrag";
            // 
            // OutTotaalEind
            // 
            this.OutTotaalEind.AutoSize = true;
            this.OutTotaalEind.Location = new System.Drawing.Point(231, 299);
            this.OutTotaalEind.Name = "OutTotaalEind";
            this.OutTotaalEind.Size = new System.Drawing.Size(42, 17);
            this.OutTotaalEind.TabIndex = 12;
            this.OutTotaalEind.Text = "€ x,xx";
            // 
            // btnBerekenFooi
            // 
            this.btnBerekenFooi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBerekenFooi.Location = new System.Drawing.Point(37, 345);
            this.btnBerekenFooi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBerekenFooi.Name = "btnBerekenFooi";
            this.btnBerekenFooi.Size = new System.Drawing.Size(123, 31);
            this.btnBerekenFooi.TabIndex = 13;
            this.btnBerekenFooi.Text = "FooiBerekenen";
            this.btnBerekenFooi.UseVisualStyleBackColor = false;
            this.btnBerekenFooi.Click += new System.EventHandler(this.btnBerekenFooi_Click);
            // 
            // BtnBetalingAfronden
            // 
            this.BtnBetalingAfronden.Location = new System.Drawing.Point(212, 541);
            this.BtnBetalingAfronden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBetalingAfronden.Name = "BtnBetalingAfronden";
            this.BtnBetalingAfronden.Size = new System.Drawing.Size(133, 41);
            this.BtnBetalingAfronden.TabIndex = 14;
            this.BtnBetalingAfronden.Text = "Pin";
            this.BtnBetalingAfronden.UseVisualStyleBackColor = true;
            this.BtnBetalingAfronden.Click += new System.EventHandler(this.BtnBetalingAfronden_Click);
            // 
            // BtnCreditcard
            // 
            this.BtnCreditcard.Location = new System.Drawing.Point(12, 541);
            this.BtnCreditcard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreditcard.Name = "BtnCreditcard";
            this.BtnCreditcard.Size = new System.Drawing.Size(133, 41);
            this.BtnCreditcard.TabIndex = 15;
            this.BtnCreditcard.Text = "Creditcard";
            this.BtnCreditcard.UseVisualStyleBackColor = true;
            this.BtnCreditcard.Click += new System.EventHandler(this.BtnCreditcard_Click);
            // 
            // btn_Cash
            // 
            this.btn_Cash.Location = new System.Drawing.Point(12, 477);
            this.btn_Cash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cash.Name = "btn_Cash";
            this.btn_Cash.Size = new System.Drawing.Size(133, 41);
            this.btn_Cash.TabIndex = 16;
            this.btn_Cash.Text = "Cash";
            this.btn_Cash.UseVisualStyleBackColor = true;
            this.btn_Cash.Click += new System.EventHandler(this.btn_Cash_Click);
            // 
            // LblTafelnummer
            // 
            this.LblTafelnummer.AutoSize = true;
            this.LblTafelnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTafelnummer.Location = new System.Drawing.Point(207, 67);
            this.LblTafelnummer.Name = "LblTafelnummer";
            this.LblTafelnummer.Size = new System.Drawing.Size(22, 25);
            this.LblTafelnummer.TabIndex = 31;
            this.LblTafelnummer.Text = "x";
            // 
            // backButton1
            // 
            this.backButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton1.BackgroundImage")));
            this.backButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backButton1.Location = new System.Drawing.Point(18, 57);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(50, 50);
            this.backButton1.TabIndex = 33;
            this.backButton1.Text = " ";
            this.backButton1.UseVisualStyleBackColor = true;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // homeButton2
            // 
            this.homeButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton2.BackgroundImage")));
            this.homeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.homeButton2.Location = new System.Drawing.Point(18, 11);
            this.homeButton2.Name = "homeButton2";
            this.homeButton2.Size = new System.Drawing.Size(50, 50);
            this.homeButton2.TabIndex = 32;
            this.homeButton2.Text = " ";
            this.homeButton2.UseVisualStyleBackColor = true;
            this.homeButton2.Click += new System.EventHandler(this.homeButton2_Click);
            // 
            // RekeningForm_Betaal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 638);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.homeButton2);
            this.Controls.Add(this.LblTafelnummer);
            this.Controls.Add(this.btn_Cash);
            this.Controls.Add(this.BtnCreditcard);
            this.Controls.Add(this.BtnBetalingAfronden);
            this.Controls.Add(this.btnBerekenFooi);
            this.Controls.Add(this.OutTotaalEind);
            this.Controls.Add(this.lblTotaalEind);
            this.Controls.Add(this.OutFooi);
            this.Controls.Add(this.lblFooi);
            this.Controls.Add(this.TbBedragBetaald);
            this.Controls.Add(this.lblIngevuldBedrag);
            this.Controls.Add(this.OutBedragZondFooi);
            this.Controls.Add(this.lbltotzonFooi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RekeningForm_Betaal";
            this.Text = "RekeningForm_Betaal";
            this.Controls.SetChildIndex(this.lbltotzonFooi, 0);
            this.Controls.SetChildIndex(this.OutBedragZondFooi, 0);
            this.Controls.SetChildIndex(this.lblIngevuldBedrag, 0);
            this.Controls.SetChildIndex(this.TbBedragBetaald, 0);
            this.Controls.SetChildIndex(this.lblFooi, 0);
            this.Controls.SetChildIndex(this.OutFooi, 0);
            this.Controls.SetChildIndex(this.lblTotaalEind, 0);
            this.Controls.SetChildIndex(this.OutTotaalEind, 0);
            this.Controls.SetChildIndex(this.btnBerekenFooi, 0);
            this.Controls.SetChildIndex(this.BtnBetalingAfronden, 0);
            this.Controls.SetChildIndex(this.BtnCreditcard, 0);
            this.Controls.SetChildIndex(this.btn_Cash, 0);
            this.Controls.SetChildIndex(this.LblTafelnummer, 0);
            this.Controls.SetChildIndex(this.homeButton2, 0);
            this.Controls.SetChildIndex(this.backButton1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltotzonFooi;
        private System.Windows.Forms.Label OutBedragZondFooi;
        private System.Windows.Forms.Label lblIngevuldBedrag;
        private System.Windows.Forms.TextBox TbBedragBetaald;
        private System.Windows.Forms.Label lblFooi;
        private System.Windows.Forms.Label OutFooi;
        private System.Windows.Forms.Label lblTotaalEind;
        private System.Windows.Forms.Label OutTotaalEind;
        private System.Windows.Forms.Button btnBerekenFooi;
        private System.Windows.Forms.Button BtnBetalingAfronden;
        private System.Windows.Forms.Button BtnCreditcard;
        private System.Windows.Forms.Button btn_Cash;
        private System.Windows.Forms.Label LblTafelnummer;
        private Style_guide.BackButton backButton1;
        private Style_guide.HomeButton homeButton2;
    }
}