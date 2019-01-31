namespace StyleGuide
{
    partial class BaseFormMobile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseFormMobile));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMenuAfrekenen = new StyleGuide.BaseButton();
            this.btnMenuOpnemen = new StyleGuide.BaseButton();
            this.txtTafel = new StyleGuide.Titel();
            this.uitlogButton1 = new StyleGuide.UitlogButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton1 = new StyleGuide.BackButton();
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnMenuAfrekenen);
            this.pnlTop.Controls.Add(this.btnMenuOpnemen);
            this.pnlTop.Controls.Add(this.txtTafel);
            this.pnlTop.Controls.Add(this.uitlogButton1);
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Controls.Add(this.backButton1);
            this.pnlTop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTop.Location = new System.Drawing.Point(-2, -1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(585, 121);
            this.pnlTop.TabIndex = 4;
            // 
            // btnMenuAfrekenen
            // 
            this.btnMenuAfrekenen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAfrekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMenuAfrekenen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenuAfrekenen.Location = new System.Drawing.Point(287, -1);
            this.btnMenuAfrekenen.Name = "btnMenuAfrekenen";
            this.btnMenuAfrekenen.Size = new System.Drawing.Size(297, 38);
            this.btnMenuAfrekenen.TabIndex = 12;
            this.btnMenuAfrekenen.Text = "Afrekenen";
            this.btnMenuAfrekenen.UseVisualStyleBackColor = true;
            // 
            // btnMenuOpnemen
            // 
            this.btnMenuOpnemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuOpnemen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMenuOpnemen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenuOpnemen.Location = new System.Drawing.Point(-1, -1);
            this.btnMenuOpnemen.Name = "btnMenuOpnemen";
            this.btnMenuOpnemen.Size = new System.Drawing.Size(291, 38);
            this.btnMenuOpnemen.TabIndex = 10;
            this.btnMenuOpnemen.Text = "Opnemen";
            this.btnMenuOpnemen.UseVisualStyleBackColor = true;
            this.btnMenuOpnemen.Click += new System.EventHandler(this.btnMenuOpnemen_Click);
            // 
            // txtTafel
            // 
            this.txtTafel.AutoSize = true;
            this.txtTafel.Font = new System.Drawing.Font("Arial", 20F);
            this.txtTafel.Location = new System.Drawing.Point(230, 54);
            this.txtTafel.Name = "txtTafel";
            this.txtTafel.Size = new System.Drawing.Size(87, 39);
            this.txtTafel.TabIndex = 9;
            this.txtTafel.Text = "Tafel";
            // 
            // uitlogButton1
            // 
            this.uitlogButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uitlogButton1.BackgroundImage")));
            this.uitlogButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uitlogButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uitlogButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uitlogButton1.Location = new System.Drawing.Point(504, 54);
            this.uitlogButton1.Name = "uitlogButton1";
            this.uitlogButton1.Size = new System.Drawing.Size(67, 60);
            this.uitlogButton1.TabIndex = 8;
            this.uitlogButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 411);
            this.panel1.TabIndex = 6;
            // 
            // backButton1
            // 
            this.backButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton1.BackgroundImage")));
            this.backButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backButton1.Location = new System.Drawing.Point(-1, 54);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(97, 51);
            this.backButton1.TabIndex = 1;
            this.backButton1.Text = " ";
            this.backButton1.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Location = new System.Drawing.Point(-2, 120);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(585, 458);
            this.pnlMain.TabIndex = 6;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Location = new System.Drawing.Point(-2, 577);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(584, 276);
            this.pnlBottom.TabIndex = 7;
            // 
            // BaseFormMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(582, 853);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "BaseFormMobile";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public BackButton backButton1;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        public System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.Panel panel1;
        public UitlogButton uitlogButton1;
        public Titel txtTafel;
        public System.Windows.Forms.FlowLayoutPanel pnlMain;
        public System.Windows.Forms.FlowLayoutPanel pnlBottom;
        public BaseButton btnMenuAfrekenen;
        public BaseButton btnMenuOpnemen;
    }
}

