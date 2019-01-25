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
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeButton1 = new StyleGuide.HomeButton();
            this.backButton1 = new StyleGuide.BackButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opnemenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afrekenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.uitlogButton1 = new StyleGuide.UitlogButton();
            this.topPanel.SuspendLayout();
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
            // topPanel
            // 
            this.topPanel.Controls.Add(this.uitlogButton1);
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Controls.Add(this.homeButton1);
            this.topPanel.Controls.Add(this.backButton1);
            this.topPanel.Controls.Add(this.menuStrip1);
            this.topPanel.Location = new System.Drawing.Point(-2, -1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(585, 164);
            this.topPanel.TabIndex = 4;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 411);
            this.panel1.TabIndex = 6;
            // 
            // homeButton1
            // 
            this.homeButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton1.BackgroundImage")));
            this.homeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.homeButton1.Location = new System.Drawing.Point(14, 48);
            this.homeButton1.Name = "homeButton1";
            this.homeButton1.Size = new System.Drawing.Size(50, 50);
            this.homeButton1.TabIndex = 0;
            this.homeButton1.Text = " ";
            this.homeButton1.UseVisualStyleBackColor = true;
            // 
            // backButton1
            // 
            this.backButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton1.BackgroundImage")));
            this.backButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backButton1.Location = new System.Drawing.Point(14, 104);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(50, 50);
            this.backButton1.TabIndex = 1;
            this.backButton1.Text = " ";
            this.backButton1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opnemenToolStripMenuItem,
            this.overzichtToolStripMenuItem,
            this.afrekenenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 40);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
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
            // bottomPanel
            // 
            this.bottomPanel.Location = new System.Drawing.Point(-2, 660);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(585, 194);
            this.bottomPanel.TabIndex = 5;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(-2, 159);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(585, 503);
            this.mainPanel.TabIndex = 6;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
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
            // BaseFormMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(582, 853);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "BaseFormMobile";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected HomeButton homeButton1;
        protected BackButton backButton1;
        protected System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        protected System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        protected System.Windows.Forms.Panel topPanel;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem opnemenToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem overzichtToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem afrekenenToolStripMenuItem;
        protected System.Windows.Forms.Panel bottomPanel;
        protected System.Windows.Forms.Panel mainPanel;
        protected UitlogButton uitlogButton1;
    }
}

