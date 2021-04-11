
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
            this.Groupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modalité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjoutFav = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalité)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(14, 19);
            this.lblProgram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(129, 15);
            this.lblProgram.TabIndex = 0;
            this.lblProgram.Text = "&Programme du Festival";
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
            this.dgvFest.Location = new System.Drawing.Point(14, 50);
            this.dgvFest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvFest.Name = "dgvFest";
            this.dgvFest.RowHeadersWidth = 82;
            this.dgvFest.RowTemplate.Height = 41;
            this.dgvFest.Size = new System.Drawing.Size(978, 148);
            this.dgvFest.TabIndex = 25;
            this.dgvFest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dgvGroupe
            // 
            this.dgvGroupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Groupe,
            this.Heure,
            this.Scene});
            this.dgvGroupe.Location = new System.Drawing.Point(14, 266);
            this.dgvGroupe.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvGroupe.Name = "dgvGroupe";
            this.dgvGroupe.RowHeadersWidth = 82;
            this.dgvGroupe.RowTemplate.Height = 41;
            this.dgvGroupe.Size = new System.Drawing.Size(685, 141);
            this.dgvGroupe.TabIndex = 26;
            // 
            // dgvModalité
            // 
            this.dgvModalité.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModalité.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modalité,
            this.PrixMode});
            this.dgvModalité.Location = new System.Drawing.Point(738, 266);
            this.dgvModalité.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvModalité.Name = "dgvModalité";
            this.dgvModalité.RowHeadersWidth = 82;
            this.dgvModalité.RowTemplate.Height = 41;
            this.dgvModalité.Size = new System.Drawing.Size(386, 141);
            this.dgvModalité.TabIndex = 27;
            // 
            // Groupe
            // 
            this.Groupe.HeaderText = "Groupe";
            this.Groupe.MinimumWidth = 8;
            this.Groupe.Name = "Groupe";
            this.Groupe.Width = 200;
            // 
            // Heure
            // 
            this.Heure.HeaderText = "Heure de passage";
            this.Heure.MinimumWidth = 8;
            this.Heure.Name = "Heure";
            this.Heure.Width = 200;
            // 
            // Scene
            // 
            this.Scene.HeaderText = "Scene";
            this.Scene.MinimumWidth = 8;
            this.Scene.Name = "Scene";
            this.Scene.Width = 200;
            // 
            // Modalité
            // 
            this.Modalité.HeaderText = "Modalité";
            this.Modalité.MinimumWidth = 8;
            this.Modalité.Name = "Modalité";
            this.Modalité.Width = 200;
            // 
            // PrixMode
            // 
            this.PrixMode.HeaderText = "Prix";
            this.PrixMode.MinimumWidth = 8;
            this.PrixMode.Name = "PrixMode";
            // 
            // btnAjoutFav
            // 
            this.btnAjoutFav.Location = new System.Drawing.Point(1018, 49);
            this.btnAjoutFav.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAjoutFav.Name = "btnAjoutFav";
            this.btnAjoutFav.Size = new System.Drawing.Size(106, 26);
            this.btnAjoutFav.TabIndex = 32;
            this.btnAjoutFav.Text = "&Ajouter favoris";
            this.btnAjoutFav.UseVisualStyleBackColor = true;
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(1018, 90);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(106, 26);
            this.btnReservation.TabIndex = 33;
            this.btnReservation.Text = "&Reserver";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1018, 132);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 26);
            this.button1.TabIndex = 34;
            this.button1.Text = "Pa&yer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(1018, 172);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(106, 26);
            this.btnAnnuler.TabIndex = 35;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
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
            // Programme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 455);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnAjoutFav);
            this.Controls.Add(this.dgvModalité);
            this.Controls.Add(this.dgvGroupe);
            this.Controls.Add(this.dgvFest);
            this.Controls.Add(this.lblProgram);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Programme";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Groupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scene;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modalité;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixMode;
        private System.Windows.Forms.Button btnAjoutFav;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
    }
}