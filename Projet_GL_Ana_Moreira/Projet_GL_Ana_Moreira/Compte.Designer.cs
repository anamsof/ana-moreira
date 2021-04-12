
namespace Projet_GL_Ana_Moreira
{
    partial class Compte
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
            this.txtPays = new System.Windows.Forms.TextBox();
            this.lblPays = new System.Windows.Forms.Label();
            this.lblCivilie = new System.Windows.Forms.Label();
            this.cboCivil = new System.Windows.Forms.ComboBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.btnAnuuler = new System.Windows.Forms.Button();
            this.txtMPConf = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblMPConfi = new System.Windows.Forms.Label();
            this.lblMP = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPays
            // 
            this.txtPays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPays.Location = new System.Drawing.Point(104, 209);
            this.txtPays.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(110, 23);
            this.txtPays.TabIndex = 43;
            this.txtPays.TextChanged += new System.EventHandler(this.txtPays_TextChanged);
            // 
            // lblPays
            // 
            this.lblPays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(21, 212);
            this.lblPays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(31, 15);
            this.lblPays.TabIndex = 42;
            this.lblPays.Text = "Pa&ys";
            this.lblPays.Click += new System.EventHandler(this.lblPays_Click);
            // 
            // lblCivilie
            // 
            this.lblCivilie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCivilie.AutoSize = true;
            this.lblCivilie.Location = new System.Drawing.Point(21, 22);
            this.lblCivilie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCivilie.Name = "lblCivilie";
            this.lblCivilie.Size = new System.Drawing.Size(39, 15);
            this.lblCivilie.TabIndex = 41;
            this.lblCivilie.Text = "C&ivilié";
            this.lblCivilie.Click += new System.EventHandler(this.lblCivilie_Click);
            // 
            // cboCivil
            // 
            this.cboCivil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCivil.FormattingEnabled = true;
            this.cboCivil.Items.AddRange(new object[] {
            "Choisissez :",
            "Monsieur",
            "Madame",
            "Mademoiselle"});
            this.cboCivil.Location = new System.Drawing.Point(104, 19);
            this.cboCivil.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboCivil.Name = "cboCivil";
            this.cboCivil.Size = new System.Drawing.Size(110, 23);
            this.cboCivil.TabIndex = 40;
            this.cboCivil.SelectedIndexChanged += new System.EventHandler(this.cboCivil_SelectedIndexChanged);
            // 
            // txtCP
            // 
            this.txtCP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCP.Location = new System.Drawing.Point(104, 179);
            this.txtCP.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(110, 23);
            this.txtCP.TabIndex = 39;
            this.txtCP.TextChanged += new System.EventHandler(this.txtCP_TextChanged);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdresse.Location = new System.Drawing.Point(104, 149);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(110, 23);
            this.txtAdresse.TabIndex = 37;
            this.txtAdresse.TextChanged += new System.EventHandler(this.txtAdresse_TextChanged);
            // 
            // lblAdresse
            // 
            this.lblAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(22, 155);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(48, 15);
            this.lblAdresse.TabIndex = 36;
            this.lblAdresse.Text = "Adre&sse";
            this.lblAdresse.Click += new System.EventHandler(this.lblAdresse_Click);
            // 
            // lblCP
            // 
            this.lblCP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(22, 184);
            this.lblCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(70, 15);
            this.lblCP.TabIndex = 38;
            this.lblCP.Text = "Co&de Postal";
            this.lblCP.Click += new System.EventHandler(this.lblCP_Click);
            // 
            // btnAnuuler
            // 
            this.btnAnuuler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuuler.Location = new System.Drawing.Point(357, 180);
            this.btnAnuuler.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAnuuler.Name = "btnAnuuler";
            this.btnAnuuler.Size = new System.Drawing.Size(110, 26);
            this.btnAnuuler.TabIndex = 35;
            this.btnAnuuler.Text = "&Annuler";
            this.btnAnuuler.UseVisualStyleBackColor = true;
            this.btnAnuuler.Click += new System.EventHandler(this.btnAnuuler_Click);
            // 
            // txtMPConf
            // 
            this.txtMPConf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMPConf.Location = new System.Drawing.Point(357, 79);
            this.txtMPConf.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMPConf.Name = "txtMPConf";
            this.txtMPConf.Size = new System.Drawing.Size(110, 23);
            this.txtMPConf.TabIndex = 33;
            this.txtMPConf.TextChanged += new System.EventHandler(this.txtMPConf_TextChanged);
            // 
            // txtMP
            // 
            this.txtMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMP.Location = new System.Drawing.Point(357, 49);
            this.txtMP.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(110, 23);
            this.txtMP.TabIndex = 31;
            this.txtMP.TextChanged += new System.EventHandler(this.txtMP_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Location = new System.Drawing.Point(357, 19);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(110, 23);
            this.txtLogin.TabIndex = 29;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(104, 109);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(110, 23);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrenom.Location = new System.Drawing.Point(104, 79);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(110, 23);
            this.txtPrenom.TabIndex = 25;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            // 
            // txtNom
            // 
            this.txtNom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNom.Location = new System.Drawing.Point(104, 49);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(110, 23);
            this.txtNom.TabIndex = 23;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Location = new System.Drawing.Point(357, 148);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(110, 26);
            this.btnModifier.TabIndex = 34;
            this.btnModifier.Text = "Modi&fier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblMPConfi
            // 
            this.lblMPConfi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMPConfi.AutoSize = true;
            this.lblMPConfi.Location = new System.Drawing.Point(253, 82);
            this.lblMPConfi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMPConfi.Name = "lblMPConfi";
            this.lblMPConfi.Size = new System.Drawing.Size(61, 15);
            this.lblMPConfi.TabIndex = 32;
            this.lblMPConfi.Text = "&Confirmer";
            this.lblMPConfi.Click += new System.EventHandler(this.lblMPConfi_Click);
            // 
            // lblMP
            // 
            this.lblMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMP.AutoSize = true;
            this.lblMP.Location = new System.Drawing.Point(253, 52);
            this.lblMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(77, 15);
            this.lblMP.TabIndex = 30;
            this.lblMP.Text = "&Mot de passe";
            this.lblMP.Click += new System.EventHandler(this.lblMP_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(253, 22);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(37, 15);
            this.lblLogin.TabIndex = 28;
            this.lblLogin.Text = "&Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(21, 82);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 15);
            this.lblPrenom.TabIndex = 24;
            this.lblPrenom.Text = "&Prenom";
            this.lblPrenom.Click += new System.EventHandler(this.lblPrenom_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 112);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "&Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblNom
            // 
            this.lblNom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(21, 52);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(34, 15);
            this.lblNom.TabIndex = 22;
            this.lblNom.Text = "&Nom";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 266);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.lblCivilie);
            this.Controls.Add(this.cboCivil);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.btnAnuuler);
            this.Controls.Add(this.txtMPConf);
            this.Controls.Add(this.txtMP);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblMPConfi);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNom);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(523, 305);
            this.Name = "Compte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compte";
            this.Load += new System.EventHandler(this.Compte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Label lblCivilie;
        private System.Windows.Forms.ComboBox cboCivil;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Button btnAnuuler;
        private System.Windows.Forms.TextBox txtMPConf;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblMPConfi;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNom;
    }
}