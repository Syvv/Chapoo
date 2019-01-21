﻿namespace UI
{
    partial class Bestelling_overzicht_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bestelling_overzicht_form));
            this.homeButton1 = new Style_guide.HomeButton();
            this.backButton1 = new Style_guide.BackButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnDeleteAll = new Styleguide.BaseButton();
            this.btnChange = new Styleguide.BaseButton();
            this.btnKlaar = new Styleguide.BaseButton();
            this.btnBar = new Styleguide.BaseButton();
            this.btnKeuken = new Styleguide.BaseButton();
            this.SuspendLayout();
            // 
            // homeButton1
            // 
            this.homeButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton1.BackgroundImage")));
            this.homeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.homeButton1.Location = new System.Drawing.Point(12, 6);
            this.homeButton1.Name = "homeButton1";
            this.homeButton1.Size = new System.Drawing.Size(50, 50);
            this.homeButton1.TabIndex = 5;
            this.homeButton1.Text = " ";
            this.homeButton1.UseVisualStyleBackColor = true;
            // 
            // backButton1
            // 
            this.backButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton1.BackgroundImage")));
            this.backButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backButton1.Location = new System.Drawing.Point(12, 57);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(50, 50);
            this.backButton1.TabIndex = 6;
            this.backButton1.Text = " ";
            this.backButton1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 158);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(382, 412);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteAll.Location = new System.Drawing.Point(218, 576);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(132, 50);
            this.btnDeleteAll.TabIndex = 8;
            this.btnDeleteAll.Text = "Delete all";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // btnChange
            // 
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChange.Location = new System.Drawing.Point(25, 576);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(132, 50);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnKlaar
            // 
            this.btnKlaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKlaar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKlaar.Location = new System.Drawing.Point(12, 122);
            this.btnKlaar.Name = "btnKlaar";
            this.btnKlaar.Size = new System.Drawing.Size(100, 30);
            this.btnKlaar.TabIndex = 10;
            this.btnKlaar.Text = "Klaar";
            this.btnKlaar.UseVisualStyleBackColor = true;
            this.btnKlaar.Click += new System.EventHandler(this.btnKlaar_Click);
            // 
            // btnBar
            // 
            this.btnBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBar.Location = new System.Drawing.Point(143, 122);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(100, 30);
            this.btnBar.TabIndex = 11;
            this.btnBar.Text = "Bar";
            this.btnBar.UseVisualStyleBackColor = true;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // btnKeuken
            // 
            this.btnKeuken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeuken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKeuken.Location = new System.Drawing.Point(270, 122);
            this.btnKeuken.Name = "btnKeuken";
            this.btnKeuken.Size = new System.Drawing.Size(100, 30);
            this.btnKeuken.TabIndex = 12;
            this.btnKeuken.Text = "Keuken";
            this.btnKeuken.UseVisualStyleBackColor = true;
            this.btnKeuken.Click += new System.EventHandler(this.btnKeuken_Click);
            // 
            // Bestelling_overzicht_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 638);
            this.Controls.Add(this.btnKeuken);
            this.Controls.Add(this.btnBar);
            this.Controls.Add(this.btnKlaar);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.homeButton1);
            this.Name = "Bestelling_overzicht_form";
            this.Text = "Bestelling_overzicht_form";
            this.Load += new System.EventHandler(this.Bestelling_overzicht_form_Load);
            this.Controls.SetChildIndex(this.homeButton1, 0);
            this.Controls.SetChildIndex(this.backButton1, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.btnDeleteAll, 0);
            this.Controls.SetChildIndex(this.btnChange, 0);
            this.Controls.SetChildIndex(this.btnKlaar, 0);
            this.Controls.SetChildIndex(this.btnBar, 0);
            this.Controls.SetChildIndex(this.btnKeuken, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Style_guide.HomeButton homeButton1;
        private Style_guide.BackButton backButton1;
        private System.Windows.Forms.ListView listView1;
        private Styleguide.BaseButton btnDeleteAll;
        private Styleguide.BaseButton btnChange;
        private Styleguide.BaseButton btnKlaar;
        private Styleguide.BaseButton btnBar;
        private Styleguide.BaseButton btnKeuken;
    }
}