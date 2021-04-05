
namespace Projet_GL_Ana_Moreira
{
    partial class CreerCompte
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMP = new System.Windows.Forms.Label();
            this.lblMPConfi = new System.Windows.Forms.Label();
            this.btnCreer = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.txtMPConf = new System.Windows.Forms.TextBox();
            this.btnAnuuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(23, 20);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(34, 15);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "&Nom";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 80);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "&Email";
            this.lblEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(23, 52);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 15);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "&Prenom";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(260, 22);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(37, 15);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "&Login";
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.Location = new System.Drawing.Point(260, 52);
            this.lblMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(77, 15);
            this.lblMP.TabIndex = 4;
            this.lblMP.Text = "&Mot de passe";
            // 
            // lblMPConfi
            // 
            this.lblMPConfi.AutoSize = true;
            this.lblMPConfi.Location = new System.Drawing.Point(260, 80);
            this.lblMPConfi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMPConfi.Name = "lblMPConfi";
            this.lblMPConfi.Size = new System.Drawing.Size(61, 15);
            this.lblMPConfi.TabIndex = 5;
            this.lblMPConfi.Text = "&Confirmer";
            this.lblMPConfi.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(391, 115);
            this.btnCreer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(81, 22);
            this.btnCreer.TabIndex = 6;
            this.btnCreer.Text = "C&reer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.Creer_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(99, 20);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(110, 23);
            this.txtNom.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(99, 51);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(110, 23);
            this.txtPrenom.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 80);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(110, 23);
            this.txtEmail.TabIndex = 9;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(364, 20);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(110, 23);
            this.txtLogin.TabIndex = 10;
            // 
            // txtMP
            // 
            this.txtMP.Location = new System.Drawing.Point(364, 51);
            this.txtMP.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(110, 23);
            this.txtMP.TabIndex = 11;
            // 
            // txtMPConf
            // 
            this.txtMPConf.Location = new System.Drawing.Point(364, 80);
            this.txtMPConf.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMPConf.Name = "txtMPConf";
            this.txtMPConf.Size = new System.Drawing.Size(110, 23);
            this.txtMPConf.TabIndex = 12;
            // 
            // btnAnuuler
            // 
            this.btnAnuuler.Location = new System.Drawing.Point(391, 147);
            this.btnAnuuler.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAnuuler.Name = "btnAnuuler";
            this.btnAnuuler.Size = new System.Drawing.Size(81, 22);
            this.btnAnuuler.TabIndex = 13;
            this.btnAnuuler.Text = "&Annuler";
            this.btnAnuuler.UseVisualStyleBackColor = true;
            this.btnAnuuler.Click += new System.EventHandler(this.btnAnuuler_Click);
            // 
            // CreerCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 187);
            this.Controls.Add(this.btnAnuuler);
            this.Controls.Add(this.txtMPConf);
            this.Controls.Add(this.txtMP);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.lblMPConfi);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNom);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "CreerCompte";
            this.Text = "CreerCompte";
            this.Load += new System.EventHandler(this.CreerCompte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.Label lblMPConfi;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.TextBox txtMPConf;
        private System.Windows.Forms.Button btnAnuuler;
    }
}