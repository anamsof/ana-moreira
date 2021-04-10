
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.Modifier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblTexteInfo = new System.Windows.Forms.Label();
            this.lblTexteDelai = new System.Windows.Forms.Label();
            this.dgvFest = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCivil = new System.Windows.Forms.ComboBox();
            this.chkNewLetters = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Facture";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(24, 166);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(275, 23);
            this.dtpDate.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(24, 94);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(174, 23);
            this.txtNom.TabIndex = 2;
            this.txtNom.Text = "Nom ";
            this.txtNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(212, 94);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(174, 23);
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
            this.txtEmail.Location = new System.Drawing.Point(24, 129);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "email";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(461, 94);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(254, 23);
            this.txtAdresse.TabIndex = 6;
            this.txtAdresse.Text = "Adresse";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(461, 129);
            this.txtCP.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(254, 23);
            this.txtCP.TabIndex = 7;
            this.txtCP.Text = "Code Postale";
            // 
            // txtPays
            // 
            this.txtPays.Location = new System.Drawing.Point(461, 166);
            this.txtPays.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(254, 23);
            this.txtPays.TabIndex = 8;
            this.txtPays.Text = "Pays";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(900, 99);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(100, 22);
            this.btnConfirmer.TabIndex = 11;
            this.btnConfirmer.Text = "&Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(900, 130);
            this.Modifier.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(100, 22);
            this.Modifier.TabIndex = 12;
            this.Modifier.Text = "&Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
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
            this.dgvFest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Genre,
            this.NbParticipant,
            this.Prix});
            this.dgvFest.Location = new System.Drawing.Point(24, 213);
            this.dgvFest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvFest.Name = "dgvFest";
            this.dgvFest.RowHeadersWidth = 82;
            this.dgvFest.RowTemplate.Height = 41;
            this.dgvFest.Size = new System.Drawing.Size(976, 143);
            this.dgvFest.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Festival";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Lieu";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre musical";
            this.Genre.MinimumWidth = 8;
            this.Genre.Name = "Genre";
            this.Genre.Width = 150;
            // 
            // NbParticipant
            // 
            this.NbParticipant.HeaderText = "Nombre de participant";
            this.NbParticipant.MinimumWidth = 8;
            this.NbParticipant.Name = "NbParticipant";
            this.NbParticipant.Width = 90;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 8;
            this.Prix.Name = "Prix";
            this.Prix.Width = 150;
            // 
            // cboCivil
            // 
            this.cboCivil.FormattingEnabled = true;
            this.cboCivil.Items.AddRange(new object[] {
            "Monsieur",
            "Madame",
            "Mademoiselle"});
            this.cboCivil.Location = new System.Drawing.Point(24, 56);
            this.cboCivil.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboCivil.Name = "cboCivil";
            this.cboCivil.Size = new System.Drawing.Size(174, 23);
            this.cboCivil.TabIndex = 1;
            // 
            // chkNewLetters
            // 
            this.chkNewLetters.AutoSize = true;
            this.chkNewLetters.Location = new System.Drawing.Point(780, 376);
            this.chkNewLetters.Name = "chkNewLetters";
            this.chkNewLetters.Size = new System.Drawing.Size(220, 19);
            this.chkNewLetters.TabIndex = 10;
            this.chkNewLetters.Text = "&Je souhaite recevoir vos NewsLetters ";
            this.chkNewLetters.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Facture";
            this.Text = "Facture";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblTexteInfo;
        private System.Windows.Forms.Label lblTexteDelai;
        private System.Windows.Forms.DataGridView dgvFest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.ComboBox cboCivil;
        private System.Windows.Forms.CheckBox chkNewLetters;
    }
}