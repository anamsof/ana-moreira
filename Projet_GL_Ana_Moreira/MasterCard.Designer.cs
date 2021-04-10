
namespace Projet_GL_Ana_Moreira
{
    partial class MasterCard
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
            this.lblIban = new System.Windows.Forms.Label();
            this.lblBIC = new System.Windows.Forms.Label();
            this.lblEcheance = new System.Windows.Forms.Label();
            this.lblTexte = new System.Windows.Forms.Label();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.txtBIC = new System.Windows.Forms.TextBox();
            this.txtEcheance = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.Location = new System.Drawing.Point(25, 17);
            this.lblIban.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(34, 15);
            this.lblIban.TabIndex = 0;
            this.lblIban.Text = "IBAN";
            // 
            // lblBIC
            // 
            this.lblBIC.AutoSize = true;
            this.lblBIC.Location = new System.Drawing.Point(25, 55);
            this.lblBIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBIC.Name = "lblBIC";
            this.lblBIC.Size = new System.Drawing.Size(25, 15);
            this.lblBIC.TabIndex = 2;
            this.lblBIC.Text = "BIC";
            // 
            // lblEcheance
            // 
            this.lblEcheance.AutoSize = true;
            this.lblEcheance.Location = new System.Drawing.Point(211, 58);
            this.lblEcheance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEcheance.Name = "lblEcheance";
            this.lblEcheance.Size = new System.Drawing.Size(57, 15);
            this.lblEcheance.TabIndex = 3;
            this.lblEcheance.Text = "Echeance";
            // 
            // lblTexte
            // 
            this.lblTexte.AutoSize = true;
            this.lblTexte.Location = new System.Drawing.Point(25, 132);
            this.lblTexte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTexte.Name = "lblTexte";
            this.lblTexte.Size = new System.Drawing.Size(214, 15);
            this.lblTexte.TabIndex = 4;
            this.lblTexte.Text = "La confirmation sera envoyée par email";
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(86, 17);
            this.txtIban.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(299, 23);
            this.txtIban.TabIndex = 5;
            this.txtIban.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBIC
            // 
            this.txtBIC.Location = new System.Drawing.Point(86, 55);
            this.txtBIC.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBIC.Name = "txtBIC";
            this.txtBIC.Size = new System.Drawing.Size(110, 23);
            this.txtBIC.TabIndex = 6;
            // 
            // txtEcheance
            // 
            this.txtEcheance.Location = new System.Drawing.Point(302, 55);
            this.txtEcheance.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtEcheance.Name = "txtEcheance";
            this.txtEcheance.Size = new System.Drawing.Size(83, 23);
            this.txtEcheance.TabIndex = 7;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(302, 93);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(81, 22);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(211, 93);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(81, 22);
            this.btnConfirmer.TabIndex = 9;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.button2_Click);
            // 
            // MasterCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 161);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtEcheance);
            this.Controls.Add(this.txtBIC);
            this.Controls.Add(this.txtIban);
            this.Controls.Add(this.lblTexte);
            this.Controls.Add(this.lblEcheance);
            this.Controls.Add(this.lblBIC);
            this.Controls.Add(this.lblIban);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MasterCard";
            this.Text = "MasterCard";
            this.Load += new System.EventHandler(this.MasterCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.Label lblBIC;
        private System.Windows.Forms.Label lblEcheance;
        private System.Windows.Forms.Label lblTexte;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.TextBox txtBIC;
        private System.Windows.Forms.TextBox txtEcheance;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
    }
}