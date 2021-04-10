
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
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(913, 206);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(81, 22);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(815, 206);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(81, 22);
            this.btnConfirmer.TabIndex = 11;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDescPaye
            // 
            this.lblDescPaye.AutoSize = true;
            this.lblDescPaye.Location = new System.Drawing.Point(18, 20);
            this.lblDescPaye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescPaye.Name = "lblDescPaye";
            this.lblDescPaye.Size = new System.Drawing.Size(169, 15);
            this.lblDescPaye.TabIndex = 7;
            this.lblDescPaye.Text = "Description de votre payement";
            this.lblDescPaye.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMethode
            // 
            this.lblMethode.AutoSize = true;
            this.lblMethode.Location = new System.Drawing.Point(19, 206);
            this.lblMethode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMethode.Name = "lblMethode";
            this.lblMethode.Size = new System.Drawing.Size(127, 15);
            this.lblMethode.TabIndex = 9;
            this.lblMethode.Text = "Methode de payement";
            this.lblMethode.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboMethode
            // 
            this.cboMethode.FormattingEnabled = true;
            this.cboMethode.Items.AddRange(new object[] {
            "Facture",
            "MasterCard"});
            this.cboMethode.Location = new System.Drawing.Point(178, 204);
            this.cboMethode.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboMethode.Name = "cboMethode";
            this.cboMethode.Size = new System.Drawing.Size(171, 23);
            this.cboMethode.TabIndex = 13;
            this.cboMethode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvFest
            // 
            this.dgvFest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.NbParticipant,
            this.dataGridViewTextBoxColumn8});
            this.dgvFest.Location = new System.Drawing.Point(18, 47);
            this.dgvFest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvFest.Name = "dgvFest";
            this.dgvFest.RowHeadersWidth = 82;
            this.dgvFest.RowTemplate.Height = 41;
            this.dgvFest.Size = new System.Drawing.Size(976, 143);
            this.dgvFest.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Festival";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Lieu";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Genre musical";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // NbParticipant
            // 
            this.NbParticipant.HeaderText = "Nombre de participant";
            this.NbParticipant.MinimumWidth = 8;
            this.NbParticipant.Name = "NbParticipant";
            this.NbParticipant.Width = 90;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
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
            this.Name = "Payement";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}