﻿
namespace Projet_GL_Ana_Moreira
{
    partial class PageLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMP = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(20, 30);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(37, 15);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "&Login";
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.Location = new System.Drawing.Point(20, 58);
            this.lblMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(77, 15);
            this.lblMP.TabIndex = 1;
            this.lblMP.Text = "&Mot de passe";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(117, 29);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(134, 23);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtMP
            // 
            this.txtMP.Location = new System.Drawing.Point(117, 57);
            this.txtMP.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(134, 23);
            this.txtMP.TabIndex = 3;
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(169, 89);
            this.btnConnecter.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(81, 22);
            this.btnConnecter.TabIndex = 4;
            this.btnConnecter.Text = "&Connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(169, 117);
            this.btnCreer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(81, 22);
            this.btnCreer.TabIndex = 5;
            this.btnCreer.Text = "C&reer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(270, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PageLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 166);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.txtMP);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(286, 205);
            this.MinimumSize = new System.Drawing.Size(286, 205);
            this.Name = "PageLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

