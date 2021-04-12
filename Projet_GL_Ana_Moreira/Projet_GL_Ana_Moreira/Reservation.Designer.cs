
namespace Projet_GL_Ana_Moreira
{
    partial class Reservation
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
            this.lblDescriptionRes = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dgvFest = new System.Windows.Forms.DataGridView();
            this.dgvFestTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLieuTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGenreTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNbParticTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrixTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescriptionRes
            // 
            this.lblDescriptionRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescriptionRes.AutoSize = true;
            this.lblDescriptionRes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescriptionRes.Location = new System.Drawing.Point(14, 17);
            this.lblDescriptionRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescriptionRes.Name = "lblDescriptionRes";
            this.lblDescriptionRes.Size = new System.Drawing.Size(247, 21);
            this.lblDescriptionRes.TabIndex = 0;
            this.lblDescriptionRes.Text = "&Description de votre reservation";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 213);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 15);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "D&ate limite ";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Location = new System.Drawing.Point(111, 210);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(232, 23);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmer.Location = new System.Drawing.Point(818, 206);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(81, 22);
            this.btnConfirmer.TabIndex = 5;
            this.btnConfirmer.Text = "&Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Location = new System.Drawing.Point(909, 206);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(81, 22);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
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
            this.dgvFest.Location = new System.Drawing.Point(14, 50);
            this.dgvFest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvFest.Name = "dgvFest";
            this.dgvFest.RowHeadersWidth = 82;
            this.dgvFest.RowTemplate.Height = 41;
            this.dgvFest.Size = new System.Drawing.Size(976, 143);
            this.dgvFest.TabIndex = 1;
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
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 247);
            this.Controls.Add(this.dgvFest);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDescriptionRes);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1039, 286);
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescriptionRes;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DataGridView dgvFest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFestTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLieuTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGenreTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNbParticTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrixTxtColumn;
    }
}