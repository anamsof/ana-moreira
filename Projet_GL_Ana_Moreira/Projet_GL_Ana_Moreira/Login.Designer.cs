
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
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(38, 65);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(73, 32);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.Location = new System.Drawing.Point(38, 124);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(158, 32);
            this.lblMP.TabIndex = 1;
            this.lblMP.Text = "Mot de passe";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(217, 62);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(246, 39);
            this.txtLogin.TabIndex = 2;
            // 
            // txtMP
            // 
            this.txtMP.Location = new System.Drawing.Point(217, 121);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(246, 39);
            this.txtMP.TabIndex = 3;
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(313, 189);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(150, 46);
            this.btnConnecter.TabIndex = 4;
            this.btnConnecter.Text = "Connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(313, 250);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(150, 46);
            this.btnCreer.TabIndex = 5;
            this.btnCreer.Text = "Creer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // PageLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 322);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.txtMP);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.lblLogin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(518, 393);
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
    }
}

