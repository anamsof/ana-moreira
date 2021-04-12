
namespace Projet_GL_Ana_Moreira
{
    partial class Payement
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lblDescPaye = new System.Windows.Forms.Label();
            this.lblMethode = new System.Windows.Forms.Label();
            this.cboMethode = new System.Windows.Forms.ComboBox();
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
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Location = new System.Drawing.Point(913, 206);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(81, 22);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmer.Location = new System.Drawing.Point(815, 206);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(81, 22);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "&Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDescPaye
            // 
            this.lblDescPaye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescPaye.AutoSize = true;
            this.lblDescPaye.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescPaye.Location = new System.Drawing.Point(19, 20);
            this.lblDescPaye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescPaye.Name = "lblDescPaye";
            this.lblDescPaye.Size = new System.Drawing.Size(237, 21);
            this.lblDescPaye.TabIndex = 0;
            this.lblDescPaye.Text = "&Description de votre payement";
            this.lblDescPaye.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMethode
            // 
            this.lblMethode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMethode.AutoSize = true;
            this.lblMethode.Location = new System.Drawing.Point(19, 206);
            this.lblMethode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMethode.Name = "lblMethode";
            this.lblMethode.Size = new System.Drawing.Size(127, 15);
            this.lblMethode.TabIndex = 2;
            this.lblMethode.Text = "&Methode de payement";
            this.lblMethode.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboMethode
            // 
            this.cboMethode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMethode.FormattingEnabled = true;
            this.cboMethode.Items.AddRange(new object[] {
            "Facture",
            "MasterCard"});
            this.cboMethode.Location = new System.Drawing.Point(178, 204);
            this.cboMethode.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboMethode.Name = "cboMethode";
            this.cboMethode.Size = new System.Drawing.Size(171, 23);
            this.cboMethode.TabIndex = 3;
            this.cboMethode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.dgvFest.Location = new System.Drawing.Point(19, 47);
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
            // Payement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 247);
            this.Controls.Add(this.dgvFest);
            this.Controls.Add(this.cboMethode);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lblMethode);
            this.Controls.Add(this.lblDescPaye);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1026, 286);
            this.Name = "Payement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lblDescPaye;
        private System.Windows.Forms.Label lblMethode;
        private System.Windows.Forms.ComboBox cboMethode;
        private System.Windows.Forms.DataGridView dgvFest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFestTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLieuTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGenreTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNbParticTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrixTxtColumn;
    }
}