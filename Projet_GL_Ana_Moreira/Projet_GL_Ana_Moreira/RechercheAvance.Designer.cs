﻿
namespace Projet_GL_Ana_Moreira
{
    partial class RechercheAvance
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
            this.lblRechercheA = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblFest = new System.Windows.Forms.Label();
            this.lblGroupe = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblNbPers = new System.Windows.Forms.Label();
            this.lblLieu = new System.Windows.Forms.Label();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.txtFest = new System.Windows.Forms.TextBox();
            this.txtGroupe = new System.Windows.Forms.TextBox();
            this.cboMin = new System.Windows.Forms.ComboBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.dgvFestRecherche = new System.Windows.Forms.DataGridView();
            this.Festival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.cboNbPers = new System.Windows.Forms.ComboBox();
            this.cboMax = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.dgvFestTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLieuTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGenreTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrixTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFestRecherche)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRechercheA
            // 
            this.lblRechercheA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRechercheA.AutoSize = true;
            this.lblRechercheA.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRechercheA.Location = new System.Drawing.Point(25, 25);
            this.lblRechercheA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRechercheA.Name = "lblRechercheA";
            this.lblRechercheA.Size = new System.Drawing.Size(144, 21);
            this.lblRechercheA.TabIndex = 0;
            this.lblRechercheA.Text = "&Recherche Avancé";
            this.lblRechercheA.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(25, 117);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(38, 15);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "&Genre";
            // 
            // lblFest
            // 
            this.lblFest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFest.AutoSize = true;
            this.lblFest.Location = new System.Drawing.Point(25, 76);
            this.lblFest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFest.Name = "lblFest";
            this.lblFest.Size = new System.Drawing.Size(46, 15);
            this.lblFest.TabIndex = 1;
            this.lblFest.Text = "&Festival";
            // 
            // lblGroupe
            // 
            this.lblGroupe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroupe.AutoSize = true;
            this.lblGroupe.Location = new System.Drawing.Point(25, 156);
            this.lblGroupe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGroupe.Name = "lblGroupe";
            this.lblGroupe.Size = new System.Drawing.Size(46, 15);
            this.lblGroupe.TabIndex = 5;
            this.lblGroupe.Text = "Gr&oupe";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Location = new System.Drawing.Point(25, 209);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(230, 23);
            this.dtpDate.TabIndex = 14;
            // 
            // lblPrix
            // 
            this.lblPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(292, 80);
            this.lblPrix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(27, 15);
            this.lblPrix.TabIndex = 7;
            this.lblPrix.Text = "&Prix";
            // 
            // lblNbPers
            // 
            this.lblNbPers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNbPers.AutoSize = true;
            this.lblNbPers.Location = new System.Drawing.Point(292, 156);
            this.lblNbPers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbPers.Name = "lblNbPers";
            this.lblNbPers.Size = new System.Drawing.Size(75, 15);
            this.lblNbPers.TabIndex = 12;
            this.lblNbPers.Text = "&Nb Personne";
            // 
            // lblLieu
            // 
            this.lblLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLieu.AutoSize = true;
            this.lblLieu.Location = new System.Drawing.Point(292, 115);
            this.lblLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(29, 15);
            this.lblLieu.TabIndex = 10;
            this.lblLieu.Text = "&Lieu";
            // 
            // cboGenre
            // 
            this.cboGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.ItemHeight = 15;
            this.cboGenre.Location = new System.Drawing.Point(110, 115);
            this.cboGenre.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(145, 23);
            this.cboGenre.TabIndex = 4;
            // 
            // txtFest
            // 
            this.txtFest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFest.Location = new System.Drawing.Point(110, 73);
            this.txtFest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtFest.Name = "txtFest";
            this.txtFest.Size = new System.Drawing.Size(145, 23);
            this.txtFest.TabIndex = 2;
            this.txtFest.TextChanged += new System.EventHandler(this.txtFest_TextChanged);
            // 
            // txtGroupe
            // 
            this.txtGroupe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupe.Location = new System.Drawing.Point(110, 154);
            this.txtGroupe.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtGroupe.Name = "txtGroupe";
            this.txtGroupe.Size = new System.Drawing.Size(145, 23);
            this.txtGroupe.TabIndex = 6;
            // 
            // cboMin
            // 
            this.cboMin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMin.FormattingEnabled = true;
            this.cboMin.ItemHeight = 15;
            this.cboMin.Location = new System.Drawing.Point(402, 77);
            this.cboMin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboMin.Name = "cboMin";
            this.cboMin.Size = new System.Drawing.Size(63, 23);
            this.cboMin.TabIndex = 8;
            this.cboMin.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecherche.Location = new System.Drawing.Point(593, 77);
            this.btnRecherche.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(116, 26);
            this.btnRecherche.TabIndex = 16;
            this.btnRecherche.Text = "R&echercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // dgvFestRecherche
            // 
            this.dgvFestRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFestRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFestRecherche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFestTxtColumn,
            this.dgvDateTxtColumn,
            this.dgvLieuTxtColumn,
            this.dgvGenreTxtColumn,
            this.dgvPrixTxtColumn});
            this.dgvFestRecherche.Location = new System.Drawing.Point(25, 255);
            this.dgvFestRecherche.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvFestRecherche.Name = "dgvFestRecherche";
            this.dgvFestRecherche.RowHeadersWidth = 82;
            this.dgvFestRecherche.RowTemplate.Height = 41;
            this.dgvFestRecherche.Size = new System.Drawing.Size(684, 247);
            this.dgvFestRecherche.TabIndex = 15;
            this.dgvFestRecherche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // txtLieu
            // 
            this.txtLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLieu.Location = new System.Drawing.Point(402, 112);
            this.txtLieu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(145, 23);
            this.txtLieu.TabIndex = 11;
            this.txtLieu.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cboNbPers
            // 
            this.cboNbPers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNbPers.FormattingEnabled = true;
            this.cboNbPers.ItemHeight = 15;
            this.cboNbPers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboNbPers.Location = new System.Drawing.Point(402, 154);
            this.cboNbPers.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboNbPers.Name = "cboNbPers";
            this.cboNbPers.Size = new System.Drawing.Size(145, 23);
            this.cboNbPers.TabIndex = 13;
            // 
            // cboMax
            // 
            this.cboMax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMax.FormattingEnabled = true;
            this.cboMax.ItemHeight = 15;
            this.cboMax.Location = new System.Drawing.Point(484, 77);
            this.cboMax.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboMax.Name = "cboMax";
            this.cboMax.Size = new System.Drawing.Size(63, 23);
            this.cboMax.TabIndex = 9;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Location = new System.Drawing.Point(593, 156);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(116, 26);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelection.Location = new System.Drawing.Point(593, 115);
            this.btnSelection.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(116, 26);
            this.btnSelection.TabIndex = 18;
            this.btnSelection.Text = "Selectionner";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
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
            // 
            // dgvLieuTxtColumn
            // 
            this.dgvLieuTxtColumn.HeaderText = "Lieu";
            this.dgvLieuTxtColumn.MinimumWidth = 8;
            this.dgvLieuTxtColumn.Name = "dgvLieuTxtColumn";
            // 
            // dgvGenreTxtColumn
            // 
            this.dgvGenreTxtColumn.HeaderText = "Genre musical";
            this.dgvGenreTxtColumn.MinimumWidth = 8;
            this.dgvGenreTxtColumn.Name = "dgvGenreTxtColumn";
            // 
            // dgvPrixTxtColumn
            // 
            this.dgvPrixTxtColumn.HeaderText = "Prix";
            this.dgvPrixTxtColumn.MinimumWidth = 8;
            this.dgvPrixTxtColumn.Name = "dgvPrixTxtColumn";
            // 
            // RechercheAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 553);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.cboMax);
            this.Controls.Add(this.cboNbPers);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.dgvFestRecherche);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.cboMin);
            this.Controls.Add(this.txtGroupe);
            this.Controls.Add(this.txtFest);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.lblLieu);
            this.Controls.Add(this.lblNbPers);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblGroupe);
            this.Controls.Add(this.lblFest);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblRechercheA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(759, 592);
            this.Name = "RechercheAvance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recherche Avancé";
            this.Load += new System.EventHandler(this.RechercheAvancé_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFestRecherche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRechercheA;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblFest;
        private System.Windows.Forms.Label lblGroupe;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblNbPers;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.TextBox txtFest;
        private System.Windows.Forms.TextBox txtGroupe;
        private System.Windows.Forms.ComboBox cboMin;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.DataGridView dgvFestRecherche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Festival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lieu;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.ComboBox cboNbPers;
        private System.Windows.Forms.ComboBox cboMax;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DataGridView dgvFest;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFestTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLieuTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGenreTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrixTxtColumn;
    }
}