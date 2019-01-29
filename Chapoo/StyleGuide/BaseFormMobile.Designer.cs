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
            this.txtTafel = new StyleGuide.Titel();
            this.uitlogButton1 = new StyleGuide.UitlogButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton1 = new StyleGuide.BackButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opnemenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afrekenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.pnlTop.Controls.Add(this.txtTafel);
            this.pnlTop.Controls.Add(this.uitlogButton1);
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Controls.Add(this.backButton1);
            this.pnlTop.Controls.Add(this.menuStrip1);
            this.pnlTop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTop.Location = new System.Drawing.Point(-2, -1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(585, 121);
            this.pnlTop.TabIndex = 4;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
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
            this.txtTafel.Click += new System.EventHandler(this.txtTafel_Click);
            // 
            // uitlogButton1
            // 
            this.uitlogButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uitlogButton1.BackgroundImage")));
            this.uitlogButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uitlogButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uitlogButton1.Location = new System.Drawing.Point(530, 54);
            this.uitlogButton1.Name = "uitlogButton1";
            this.uitlogButton1.Size = new System.Drawing.Size(42, 39);
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
            this.backButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backButton1.Location = new System.Drawing.Point(14, 48);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(50, 50);
            this.backButton1.TabIndex = 1;
            this.backButton1.Text = " ";
            this.backButton1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opnemenToolStripMenuItem,
            this.overzichtToolStripMenuItem,
            this.afrekenenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 40);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // opnemenToolStripMenuItem
            // 
            this.opnemenToolStripMenuItem.Name = "opnemenToolStripMenuItem";
            this.opnemenToolStripMenuItem.Size = new System.Drawing.Size(155, 36);
            this.opnemenToolStripMenuItem.Text = "1. opnemen";
            // 
            // overzichtToolStripMenuItem
            // 
            this.overzichtToolStripMenuItem.Name = "overzichtToolStripMenuItem";
            this.overzichtToolStripMenuItem.Size = new System.Drawing.Size(149, 36);
            this.overzichtToolStripMenuItem.Text = "2. overzicht";
            // 
            // afrekenenToolStripMenuItem
            // 
            this.afrekenenToolStripMenuItem.Name = "afrekenenToolStripMenuItem";
            this.afrekenenToolStripMenuItem.Size = new System.Drawing.Size(159, 36);
            this.afrekenenToolStripMenuItem.Text = "3. afrekenen";
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public BackButton backButton1;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        public System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem opnemenToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem overzichtToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem afrekenenToolStripMenuItem;
        public UitlogButton uitlogButton1;
        public Titel txtTafel;
        public System.Windows.Forms.FlowLayoutPanel pnlMain;
        public System.Windows.Forms.FlowLayoutPanel pnlBottom;
    }
}

