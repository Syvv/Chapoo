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
            this.btnTotaalBedrag = new System.Windows.Forms.Button();
            this.BtnFooiLosToevoegen = new System.Windows.Forms.Button();
            this.lblTotaalbedrag = new System.Windows.Forms.Label();
            this.lblFooi = new System.Windows.Forms.Label();
            this.Lblbedrag = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OutTotaalbedrag = new System.Windows.Forms.Label();
            this.OutBedrag = new System.Windows.Forms.Label();
            this.lblOptieKeuze = new System.Windows.Forms.Label();
            this.BtnPin = new System.Windows.Forms.Button();
            this.BtnContant = new System.Windows.Forms.Button();
            this.BtnCreditcard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTotaalBedrag
            // 
            this.btnTotaalBedrag.Location = new System.Drawing.Point(17, 48);
            this.btnTotaalBedrag.Name = "btnTotaalBedrag";
            this.btnTotaalBedrag.Size = new System.Drawing.Size(151, 39);
            this.btnTotaalBedrag.TabIndex = 0;
            this.btnTotaalBedrag.Text = "Totaalbedrag";
            this.btnTotaalBedrag.UseVisualStyleBackColor = true;
            this.btnTotaalBedrag.Click += new System.EventHandler(this.btnTotaalBedrag_Click);
            // 
            // BtnFooiLosToevoegen
            // 
            this.BtnFooiLosToevoegen.Location = new System.Drawing.Point(17, 106);
            this.BtnFooiLosToevoegen.Name = "BtnFooiLosToevoegen";
            this.BtnFooiLosToevoegen.Size = new System.Drawing.Size(151, 39);
            this.BtnFooiLosToevoegen.TabIndex = 1;
            this.BtnFooiLosToevoegen.Text = "Fooi los toevoegen";
            this.BtnFooiLosToevoegen.UseVisualStyleBackColor = true;
            this.BtnFooiLosToevoegen.Click += new System.EventHandler(this.button2_Click);
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
            // lblFooi
            // 
            this.lblFooi.AutoSize = true;
            this.lblFooi.Location = new System.Drawing.Point(253, 106);
            this.lblFooi.Name = "lblFooi";
            this.lblFooi.Size = new System.Drawing.Size(35, 17);
            this.lblFooi.TabIndex = 3;
            this.lblFooi.Text = "Fooi";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
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
            // 
            // BtnContant
            // 
            this.BtnContant.Location = new System.Drawing.Point(206, 277);
            this.BtnContant.Name = "BtnContant";
            this.BtnContant.Size = new System.Drawing.Size(151, 39);
            this.BtnContant.TabIndex = 10;
            this.BtnContant.Text = "Cash / contant";
            this.BtnContant.UseVisualStyleBackColor = true;
            // 
            // BtnCreditcard
            // 
            this.BtnCreditcard.Location = new System.Drawing.Point(393, 277);
            this.BtnCreditcard.Name = "BtnCreditcard";
            this.BtnCreditcard.Size = new System.Drawing.Size(151, 39);
            this.BtnCreditcard.TabIndex = 11;
            this.BtnCreditcard.Text = "Creditcard";
            this.BtnCreditcard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fooi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fooi";
            // 
            // FooiToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCreditcard);
            this.Controls.Add(this.BtnContant);
            this.Controls.Add(this.BtnPin);
            this.Controls.Add(this.lblOptieKeuze);
            this.Controls.Add(this.OutBedrag);
            this.Controls.Add(this.OutTotaalbedrag);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lblbedrag);
            this.Controls.Add(this.lblFooi);
            this.Controls.Add(this.lblTotaalbedrag);
            this.Controls.Add(this.BtnFooiLosToevoegen);
            this.Controls.Add(this.btnTotaalBedrag);
            this.Name = "FooiToevoegen";
            this.Size = new System.Drawing.Size(598, 372);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTotaalBedrag;
        private System.Windows.Forms.Button BtnFooiLosToevoegen;
        private System.Windows.Forms.Label lblTotaalbedrag;
        private System.Windows.Forms.Label lblFooi;
        private System.Windows.Forms.Label Lblbedrag;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label OutTotaalbedrag;
        private System.Windows.Forms.Label OutBedrag;
        private System.Windows.Forms.Label lblOptieKeuze;
        private System.Windows.Forms.Button BtnPin;
        private System.Windows.Forms.Button BtnContant;
        private System.Windows.Forms.Button BtnCreditcard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
