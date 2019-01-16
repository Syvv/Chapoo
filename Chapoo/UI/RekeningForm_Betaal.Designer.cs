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
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tafelnummer";
            // 
            // lbltotzonFooi
            // 
            this.lbltotzonFooi.AutoSize = true;
            this.lbltotzonFooi.Location = new System.Drawing.Point(30, 146);
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
            this.OutFooi.Location = new System.Drawing.Point(228, 248);
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
            this.btnBerekenFooi.Location = new System.Drawing.Point(36, 372);
            this.btnBerekenFooi.Name = "btnBerekenFooi";
            this.btnBerekenFooi.Size = new System.Drawing.Size(122, 31);
            this.btnBerekenFooi.TabIndex = 13;
            this.btnBerekenFooi.Text = "FooiBerekenen";
            this.btnBerekenFooi.UseVisualStyleBackColor = true;
            this.btnBerekenFooi.Click += new System.EventHandler(this.btnBerekenFooi_Click);
            // 
            // BtnBetalingAfronden
            // 
            this.BtnBetalingAfronden.Location = new System.Drawing.Point(129, 480);
            this.BtnBetalingAfronden.Name = "BtnBetalingAfronden";
            this.BtnBetalingAfronden.Size = new System.Drawing.Size(134, 41);
            this.BtnBetalingAfronden.TabIndex = 14;
            this.BtnBetalingAfronden.Text = "Pin";
            this.BtnBetalingAfronden.UseVisualStyleBackColor = true;
            this.BtnBetalingAfronden.Click += new System.EventHandler(this.BtnBetalingAfronden_Click);
            // 
            // RekeningForm_Betaal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 638);
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
            this.Controls.Add(this.label1);
            this.Name = "RekeningForm_Betaal";
            this.Text = "RekeningForm_Betaal";
            this.Controls.SetChildIndex(this.label1, 0);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}