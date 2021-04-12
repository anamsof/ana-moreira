
namespace Projet_GL_Ana_Moreira
{
    partial class Facture
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
            this.lblFacture = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.Festival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modalité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblTexteInfo = new System.Windows.Forms.Label();
            this.lblTexteDelai = new System.Windows.Forms.Label();
            this.dgvFest = new System.Windows.Forms.DataGridView();
            this.cboCivil = new System.Windows.Forms.ComboBox();
            this.chkNewLetters = new System.Windows.Forms.CheckBox();
            this.dgvFestTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLieuTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGenreTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNbParticTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrixTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFacture
            // 
            this.lblFacture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFacture.AutoSize = true;
            this.lblFacture.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFacture.Location = new System.Drawing.Point(24, 9);
            this.lblFacture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacture.Name = "lblFacture";
            this.lblFacture.Size = new System.Drawing.Size(84, 30);
            this.lblFacture.TabIndex = 0;
            this.lblFacture.Text = "&Facture";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Location = new System.Drawing.Point(24, 166);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(188, 23);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtNom
            // 
            this.txtNom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNom.Location = new System.Drawing.Point(24, 94);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(188, 23);
            this.txtNom.TabIndex = 2;
            this.txtNom.Text = "Nom ";
            this.txtNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrenom.Location = new System.Drawing.Point(216, 94);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(188, 23);
            this.txtPrenom.TabIndex = 3;
            this.txtPrenom.Text = "Prenom";
            this.txtPrenom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Festival
            // 
            this.Festival.HeaderText = "Festival";
            this.Festival.MinimumWidth = 10;
            this.Festival.Name = "Festival";
            this.Festival.Width = 200;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 10;
            this.Date.Name = "Date";
            this.Date.Width = 200;
            // 
            // Lieu
            // 
            this.Lieu.HeaderText = "Lieu";
            this.Lieu.MinimumWidth = 10;
            this.Lieu.Name = "Lieu";
            this.Lieu.Width = 200;
            // 
            // Modalité
            // 
            this.Modalité.HeaderText = "Modalité";
            this.Modalité.MinimumWidth = 10;
            this.Modalité.Name = "Modalité";
            this.Modalité.Width = 200;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(24, 129);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "email";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdresse.Location = new System.Drawing.Point(461, 94);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(254, 23);
            this.txtAdresse.TabIndex = 6;
            this.txtAdresse.Text = "Adresse";
            // 
            // txtCP
            // 
            this.txtCP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCP.Location = new System.Drawing.Point(461, 129);
            this.txtCP.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(254, 23);
            this.txtCP.TabIndex = 7;
            this.txtCP.Text = "Code Postale";
            // 
            // txtPays
            // 
            this.txtPays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPays.Location = new System.Drawing.Point(461, 166);
            this.txtPays.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(254, 23);
            this.txtPays.TabIndex = 8;
            this.txtPays.Text = "Pays";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmer.Location = new System.Drawing.Point(900, 99);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(100, 22);
            this.btnConfirmer.TabIndex = 11;
            this.btnConfirmer.Text = "&Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Location = new System.Drawing.Point(900, 130);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 22);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Location = new System.Drawing.Point(900, 160);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 22);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblTexteInfo
            // 
            this.lblTexteInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTexteInfo.AutoSize = true;
            this.lblTexteInfo.Location = new System.Drawing.Point(24, 376);
            this.lblTexteInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTexteInfo.Name = "lblTexteInfo";
            this.lblTexteInfo.Size = new System.Drawing.Size(317, 15);
            this.lblTexteInfo.TabIndex = 34;
            this.lblTexteInfo.Text = "&La facture en pdf sera envoyé au email instrit plus ci dessus";
            this.lblTexteInfo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTexteDelai
            // 
            this.lblTexteDelai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTexteDelai.AutoSize = true;
            this.lblTexteDelai.Location = new System.Drawing.Point(24, 398);
            this.lblTexteDelai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTexteDelai.Name = "lblTexteDelai";
            this.lblTexteDelai.Size = new System.Drawing.Size(273, 15);
            this.lblTexteDelai.TabIndex = 35;
            this.lblTexteDelai.Text = "&Payement du 30 jours apres reception de la facture";
            // 
            // dgvFest
            // 
            this.dgvFest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFestTxtColumn,
            this.dgvDateTxtColumn,
            this.dgvLieuTxtColumn,
            this.dgvGenreTxtColumn,
            this.dgvNbParticTxtColumn,
            this.dgvPrixTxtColumn});
            this.dgvFest.Location = new System.Drawing.Point(24, 213);
            this.dgvFest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvFest.Name = "dgvFest";
            this.dgvFest.RowHeadersWidth = 82;
            this.dgvFest.RowTemplate.Height = 41;
            this.dgvFest.Size = new System.Drawing.Size(976, 143);
            this.dgvFest.TabIndex = 9;
            // 
            // cboCivil
            // 
            this.cboCivil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCivil.FormattingEnabled = true;
            this.cboCivil.Items.AddRange(new object[] {
            "Monsieur",
            "Madame",
            "Mademoiselle"});
            this.cboCivil.Location = new System.Drawing.Point(24, 56);
            this.cboCivil.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboCivil.Name = "cboCivil";
            this.cboCivil.Size = new System.Drawing.Size(188, 23);
            this.cboCivil.TabIndex = 1;
            // 
            // chkNewLetters
            // 
            this.chkNewLetters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNewLetters.AutoSize = true;
            this.chkNewLetters.Location = new System.Drawing.Point(780, 376);
            this.chkNewLetters.Name = "chkNewLetters";
            this.chkNewLetters.Size = new System.Drawing.Size(220, 19);
            this.chkNewLetters.TabIndex = 10;
            this.chkNewLetters.Text = "&Je souhaite recevoir vos NewsLetters ";
            this.chkNewLetters.UseVisualStyleBackColor = true;
            // 
            // dgvFestTxtColumn
            // 
            this.dgvFestTxtColumn.HeaderText = "Festival";
            this.dgvFestTxtColumn.MinimumWidth = 8;
            this.dgvFestTxtColumn.Name = "dgvFestTxtColumn";
            this.dgvFestTxtColumn.Width = 200;
            // 
            // dgvDateTxtColumn
            // 
            this.dgvDateTxtColumn.HeaderText = "Date";
            this.dgvDateTxtColumn.MinimumWidth = 8;
            this.dgvDateTxtColumn.Name = "dgvDateTxtColumn";
            this.dgvDateTxtColumn.Width = 150;
            // 
            // dgvLieuTxtColumn
            // 
            this.dgvLieuTxtColumn.HeaderText = "Lieu";
            this.dgvLieuTxtColumn.MinimumWidth = 8;
            this.dgvLieuTxtColumn.Name = "dgvLieuTxtColumn";
            this.dgvLieuTxtColumn.Width = 150;
            // 
            // dgvGenreTxtColumn
            // 
            this.dgvGenreTxtColumn.HeaderText = "Genre musical";
            this.dgvGenreTxtColumn.MinimumWidth = 8;
            this.dgvGenreTxtColumn.Name = "dgvGenreTxtColumn";
            this.dgvGenreTxtColumn.Width = 150;
            // 
            // dgvNbParticTxtColumn
            // 
            this.dgvNbParticTxtColumn.HeaderText = "Nombre de participant";
            this.dgvNbParticTxtColumn.MinimumWidth = 8;
            this.dgvNbParticTxtColumn.Name = "dgvNbParticTxtColumn";
            this.dgvNbParticTxtColumn.Width = 90;
            // 
            // dgvPrixTxtColumn
            // 
            this.dgvPrixTxtColumn.HeaderText = "Prix";
            this.dgvPrixTxtColumn.MinimumWidth = 8;
            this.dgvPrixTxtColumn.Name = "dgvPrixTxtColumn";
            this.dgvPrixTxtColumn.Width = 150;
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 434);
            this.Controls.Add(this.chkNewLetters);
            this.Controls.Add(this.cboCivil);
            this.Controls.Add(this.dgvFest);
            this.Controls.Add(this.lblTexteDelai);
            this.Controls.Add(this.lblTexteInfo);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblFacture);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1059, 473);
            this.Name = "Facture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facture";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFacture;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Festival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modalité;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblTexteInfo;
        private System.Windows.Forms.Label lblTexteDelai;
        private System.Windows.Forms.DataGridView dgvFest;
        private System.Windows.Forms.ComboBox cboCivil;
        private System.Windows.Forms.CheckBox chkNewLetters;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFestTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLieuTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGenreTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNbParticTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrixTxtColumn;
    }
}