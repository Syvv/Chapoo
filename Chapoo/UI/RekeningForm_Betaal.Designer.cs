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
            this.lblTafelnummer = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // lblTafelnummer
            // 
            this.lblTafelnummer.AutoSize = true;
            this.lblTafelnummer.Location = new System.Drawing.Point(209, 74);
            this.lblTafelnummer.Name = "lblTafelnummer";
            this.lblTafelnummer.Size = new System.Drawing.Size(91, 17);
            this.lblTafelnummer.TabIndex = 4;
            this.lblTafelnummer.Text = "Tafelnummer";
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
            // RekeningForm_Betaal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 638);
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
            this.Controls.Add(this.lblTafelnummer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RekeningForm_Betaal";
            this.Text = "RekeningForm_Betaal";
            this.Controls.SetChildIndex(this.lblTafelnummer, 0);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTafelnummer;
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
    }
}