namespace UI
{
    partial class FooiToevoegen
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
            this.lblTotaalbedrag = new System.Windows.Forms.Label();
            this.LblOption = new System.Windows.Forms.Label();
            this.Lblbedrag = new System.Windows.Forms.Label();
            this.TbInvullen = new System.Windows.Forms.TextBox();
            this.OutTotaalbedrag = new System.Windows.Forms.Label();
            this.OutBedrag = new System.Windows.Forms.Label();
            this.lblOptieKeuze = new System.Windows.Forms.Label();
            this.BtnPin = new System.Windows.Forms.Button();
            this.BtnContant = new System.Windows.Forms.Button();
            this.BtnCreditcard = new System.Windows.Forms.Button();
            this.LblFooi = new System.Windows.Forms.Label();
            this.OutFooi = new System.Windows.Forms.Label();
            this.RadioBtnFooiInTotaal = new System.Windows.Forms.RadioButton();
            this.RadioBtnFooiLos = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTotaalbedrag
            // 
            this.lblTotaalbedrag.AutoSize = true;
            this.lblTotaalbedrag.Location = new System.Drawing.Point(253, 167);
            this.lblTotaalbedrag.Name = "lblTotaalbedrag";
            this.lblTotaalbedrag.Size = new System.Drawing.Size(93, 17);
            this.lblTotaalbedrag.TabIndex = 2;
            this.lblTotaalbedrag.Text = "Totaalbedrag";
            // 
            // LblOption
            // 
            this.LblOption.AutoSize = true;
            this.LblOption.Location = new System.Drawing.Point(253, 106);
            this.LblOption.Name = "LblOption";
            this.LblOption.Size = new System.Drawing.Size(14, 17);
            this.LblOption.TabIndex = 3;
            this.LblOption.Text = "x";
            // 
            // Lblbedrag
            // 
            this.Lblbedrag.AutoSize = true;
            this.Lblbedrag.Location = new System.Drawing.Point(253, 59);
            this.Lblbedrag.Name = "Lblbedrag";
            this.Lblbedrag.Size = new System.Drawing.Size(54, 17);
            this.Lblbedrag.TabIndex = 4;
            this.Lblbedrag.Text = "Bedrag";
            // 
            // TbInvullen
            // 
            this.TbInvullen.Location = new System.Drawing.Point(370, 106);
            this.TbInvullen.Name = "TbInvullen";
            this.TbInvullen.Size = new System.Drawing.Size(100, 22);
            this.TbInvullen.TabIndex = 5;
            // 
            // OutTotaalbedrag
            // 
            this.OutTotaalbedrag.AutoSize = true;
            this.OutTotaalbedrag.Location = new System.Drawing.Point(369, 167);
            this.OutTotaalbedrag.Name = "OutTotaalbedrag";
            this.OutTotaalbedrag.Size = new System.Drawing.Size(48, 17);
            this.OutTotaalbedrag.TabIndex = 6;
            this.OutTotaalbedrag.Text = "€ 0.00";
            // 
            // OutBedrag
            // 
            this.OutBedrag.AutoSize = true;
            this.OutBedrag.Location = new System.Drawing.Point(367, 59);
            this.OutBedrag.Name = "OutBedrag";
            this.OutBedrag.Size = new System.Drawing.Size(48, 17);
            this.OutBedrag.TabIndex = 7;
            this.OutBedrag.Text = "€ 0.00";
            // 
            // lblOptieKeuze
            // 
            this.lblOptieKeuze.AutoSize = true;
            this.lblOptieKeuze.Location = new System.Drawing.Point(253, 10);
            this.lblOptieKeuze.Name = "lblOptieKeuze";
            this.lblOptieKeuze.Size = new System.Drawing.Size(14, 17);
            this.lblOptieKeuze.TabIndex = 8;
            this.lblOptieKeuze.Text = "x";
            // 
            // BtnPin
            // 
            this.BtnPin.Location = new System.Drawing.Point(17, 277);
            this.BtnPin.Name = "BtnPin";
            this.BtnPin.Size = new System.Drawing.Size(151, 39);
            this.BtnPin.TabIndex = 9;
            this.BtnPin.Text = "Pin";
            this.BtnPin.UseVisualStyleBackColor = true;
            this.BtnPin.Click += new System.EventHandler(this.BtnPin_Click);
            // 
            // BtnContant
            // 
            this.BtnContant.Location = new System.Drawing.Point(206, 277);
            this.BtnContant.Name = "BtnContant";
            this.BtnContant.Size = new System.Drawing.Size(151, 39);
            this.BtnContant.TabIndex = 10;
            this.BtnContant.Text = "Cash / contant";
            this.BtnContant.UseVisualStyleBackColor = true;
            this.BtnContant.Click += new System.EventHandler(this.BtnContant_Click);
            // 
            // BtnCreditcard
            // 
            this.BtnCreditcard.Location = new System.Drawing.Point(393, 277);
            this.BtnCreditcard.Name = "BtnCreditcard";
            this.BtnCreditcard.Size = new System.Drawing.Size(151, 39);
            this.BtnCreditcard.TabIndex = 11;
            this.BtnCreditcard.Text = "Creditcard";
            this.BtnCreditcard.UseVisualStyleBackColor = true;
            this.BtnCreditcard.Click += new System.EventHandler(this.BtnCreditcard_Click);
            // 
            // LblFooi
            // 
            this.LblFooi.AutoSize = true;
            this.LblFooi.Location = new System.Drawing.Point(253, 139);
            this.LblFooi.Name = "LblFooi";
            this.LblFooi.Size = new System.Drawing.Size(35, 17);
            this.LblFooi.TabIndex = 12;
            this.LblFooi.Text = "Fooi";
            // 
            // OutFooi
            // 
            this.OutFooi.AutoSize = true;
            this.OutFooi.Location = new System.Drawing.Point(367, 139);
            this.OutFooi.Name = "OutFooi";
            this.OutFooi.Size = new System.Drawing.Size(35, 17);
            this.OutFooi.TabIndex = 13;
            this.OutFooi.Text = "Fooi";
            // 
            // RadioBtnFooiInTotaal
            // 
            this.RadioBtnFooiInTotaal.AutoSize = true;
            this.RadioBtnFooiInTotaal.Checked = true;
            this.RadioBtnFooiInTotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnFooiInTotaal.Location = new System.Drawing.Point(41, 48);
            this.RadioBtnFooiInTotaal.Name = "RadioBtnFooiInTotaal";
            this.RadioBtnFooiInTotaal.Size = new System.Drawing.Size(182, 24);
            this.RadioBtnFooiInTotaal.TabIndex = 14;
            this.RadioBtnFooiInTotaal.TabStop = true;
            this.RadioBtnFooiInTotaal.Text = "Fooi in Totaalbedrag";
            this.RadioBtnFooiInTotaal.UseVisualStyleBackColor = true;
            this.RadioBtnFooiInTotaal.CheckedChanged += new System.EventHandler(this.RadioBtnFooiInTotaal_CheckedChanged);
            // 
            // RadioBtnFooiLos
            // 
            this.RadioBtnFooiLos.AutoSize = true;
            this.RadioBtnFooiLos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnFooiLos.Location = new System.Drawing.Point(41, 87);
            this.RadioBtnFooiLos.Name = "RadioBtnFooiLos";
            this.RadioBtnFooiLos.Size = new System.Drawing.Size(170, 24);
            this.RadioBtnFooiLos.TabIndex = 15;
            this.RadioBtnFooiLos.Text = "Fooi los toevoegen";
            this.RadioBtnFooiLos.UseVisualStyleBackColor = true;
            this.RadioBtnFooiLos.CheckedChanged += new System.EventHandler(this.RadioBtnFooiLos_CheckedChanged);
            // 
            // FooiToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RadioBtnFooiLos);
            this.Controls.Add(this.RadioBtnFooiInTotaal);
            this.Controls.Add(this.OutFooi);
            this.Controls.Add(this.LblFooi);
            this.Controls.Add(this.BtnCreditcard);
            this.Controls.Add(this.BtnContant);
            this.Controls.Add(this.BtnPin);
            this.Controls.Add(this.lblOptieKeuze);
            this.Controls.Add(this.OutBedrag);
            this.Controls.Add(this.OutTotaalbedrag);
            this.Controls.Add(this.TbInvullen);
            this.Controls.Add(this.Lblbedrag);
            this.Controls.Add(this.LblOption);
            this.Controls.Add(this.lblTotaalbedrag);
            this.Name = "FooiToevoegen";
            this.Size = new System.Drawing.Size(598, 372);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotaalbedrag;
        private System.Windows.Forms.Label LblOption;
        private System.Windows.Forms.Label Lblbedrag;
        private System.Windows.Forms.TextBox TbInvullen;
        private System.Windows.Forms.Label OutTotaalbedrag;
        private System.Windows.Forms.Label OutBedrag;
        private System.Windows.Forms.Label lblOptieKeuze;
        private System.Windows.Forms.Button BtnPin;
        private System.Windows.Forms.Button BtnContant;
        private System.Windows.Forms.Button BtnCreditcard;
        private System.Windows.Forms.Label LblFooi;
        private System.Windows.Forms.Label OutFooi;
        private System.Windows.Forms.RadioButton RadioBtnFooiInTotaal;
        private System.Windows.Forms.RadioButton RadioBtnFooiLos;
    }
}
