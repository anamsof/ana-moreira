
namespace Projet_GL_Ana_Moreira
{
    partial class Programme
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
            this.lblProgram = new System.Windows.Forms.Label();
            this.dgvFest = new System.Windows.Forms.DataGridView();
            this.dgvGroupe = new System.Windows.Forms.DataGridView();
            this.dgvModalité = new System.Windows.Forms.DataGridView();
            this.btnAjoutFav = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnPayer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dgvFestTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLieuTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGenreTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNbParticTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrixTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGroupeTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHeureTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSceneTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvModaliteTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrixModaTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalité)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProgram
            // 
            this.lblProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgram.Location = new System.Drawing.Point(23, 19);
            this.lblProgram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(177, 21);
            this.lblProgram.TabIndex = 0;
            this.lblProgram.Text = "&Programme du Festival";
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
            this.dgvFest.Location = new System.Drawing.Point(23, 50);
            this.dgvFest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvFest.Name = "dgvFest";
            this.dgvFest.RowHeadersWidth = 82;
            this.dgvFest.RowTemplate.Height = 41;
            this.dgvFest.Size = new System.Drawing.Size(978, 148);
            this.dgvFest.TabIndex = 1;
            this.dgvFest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dgvGroupe
            // 
            this.dgvGroupe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvGroupeTxtColumn,
            this.dgvHeureTxtColumn,
            this.dgvSceneTxtColumn});
            this.dgvGroupe.Location = new System.Drawing.Point(23, 266);
            this.dgvGroupe.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvGroupe.Name = "dgvGroupe";
            this.dgvGroupe.RowHeadersWidth = 82;
            this.dgvGroupe.RowTemplate.Height = 41;
            this.dgvGroupe.Size = new System.Drawing.Size(685, 141);
            this.dgvGroupe.TabIndex = 2;
            // 
            // dgvModalité
            // 
            this.dgvModalité.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModalité.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModalité.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvModaliteTxtColumn,
            this.dgvPrixModaTxtColumn});
            this.dgvModalité.Location = new System.Drawing.Point(747, 266);
            this.dgvModalité.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvModalité.Name = "dgvModalité";
            this.dgvModalité.RowHeadersWidth = 82;
            this.dgvModalité.RowTemplate.Height = 41;
            this.dgvModalité.Size = new System.Drawing.Size(386, 141);
            this.dgvModalité.TabIndex = 3;
            // 
            // btnAjoutFav
            // 
            this.btnAjoutFav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjoutFav.Location = new System.Drawing.Point(1027, 49);
            this.btnAjoutFav.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAjoutFav.Name = "btnAjoutFav";
            this.btnAjoutFav.Size = new System.Drawing.Size(106, 26);
            this.btnAjoutFav.TabIndex = 4;
            this.btnAjoutFav.Text = "&Ajouter favoris";
            this.btnAjoutFav.UseVisualStyleBackColor = true;
            this.btnAjoutFav.Click += new System.EventHandler(this.btnAjoutFav_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservation.Location = new System.Drawing.Point(1027, 90);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(106, 26);
            this.btnReservation.TabIndex = 5;
            this.btnReservation.Text = "&Reserver";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnPayer
            // 
            this.btnPayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayer.Location = new System.Drawing.Point(1027, 132);
            this.btnPayer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPayer.Name = "btnPayer";
            this.btnPayer.Size = new System.Drawing.Size(106, 26);
            this.btnPayer.TabIndex = 6;
            this.btnPayer.Text = "Pa&yer";
            this.btnPayer.UseVisualStyleBackColor = true;
            this.btnPayer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Location = new System.Drawing.Point(1027, 172);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(106, 26);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "An&nuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
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
            // dgvGroupeTxtColumn
            // 
            this.dgvGroupeTxtColumn.HeaderText = "Groupe";
            this.dgvGroupeTxtColumn.MinimumWidth = 8;
            this.dgvGroupeTxtColumn.Name = "dgvGroupeTxtColumn";
            this.dgvGroupeTxtColumn.Width = 200;
            // 
            // dgvHeureTxtColumn
            // 
            this.dgvHeureTxtColumn.HeaderText = "Heure de passage";
            this.dgvHeureTxtColumn.MinimumWidth = 8;
            this.dgvHeureTxtColumn.Name = "dgvHeureTxtColumn";
            this.dgvHeureTxtColumn.Width = 200;
            // 
            // dgvSceneTxtColumn
            // 
            this.dgvSceneTxtColumn.HeaderText = "Scene";
            this.dgvSceneTxtColumn.MinimumWidth = 8;
            this.dgvSceneTxtColumn.Name = "dgvSceneTxtColumn";
            this.dgvSceneTxtColumn.Width = 200;
            // 
            // dgvModaliteTxtColumn
            // 
            this.dgvModaliteTxtColumn.HeaderText = "Modalité";
            this.dgvModaliteTxtColumn.MinimumWidth = 8;
            this.dgvModaliteTxtColumn.Name = "dgvModaliteTxtColumn";
            this.dgvModaliteTxtColumn.Width = 200;
            // 
            // dgvPrixModaTxtColumn
            // 
            this.dgvPrixModaTxtColumn.HeaderText = "Prix";
            this.dgvPrixModaTxtColumn.MinimumWidth = 8;
            this.dgvPrixModaTxtColumn.Name = "dgvPrixModaTxtColumn";
            // 
            // Programme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 455);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnPayer);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnAjoutFav);
            this.Controls.Add(this.dgvModalité);
            this.Controls.Add(this.dgvGroupe);
            this.Controls.Add(this.dgvFest);
            this.Controls.Add(this.lblProgram);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1184, 494);
            this.Name = "Programme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalité)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.DataGridView dgvFest;
        private System.Windows.Forms.DataGridView dgvGroupe;
        private System.Windows.Forms.DataGridView dgvModalité;
        private System.Windows.Forms.Button btnAjoutFav;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnPayer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFestTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLieuTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGenreTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNbParticTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrixTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGroupeTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHeureTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSceneTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvModaliteTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrixModaTxtColumn;
    }
}