
namespace Projet_GL_Ana_Moreira
{
    partial class PagePrincipale
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ouvrirStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.journalStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fenetreStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verticaleStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cascardeStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnecterStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirStripMenuItem1,
            this.fenetreStripMenuItem1,
            this.deconnecterStripMenuItem1,
            this.userStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.fenetreStripMenuItem1;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1415, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ouvrirStripMenuItem1
            // 
            this.ouvrirStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.journalStripMenuItem1});
            this.ouvrirStripMenuItem1.Name = "ouvrirStripMenuItem1";
            this.ouvrirStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.ouvrirStripMenuItem1.Text = "Ouvrir";
            // 
            // journalStripMenuItem1
            // 
            this.journalStripMenuItem1.Name = "journalStripMenuItem1";
            this.journalStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.journalStripMenuItem1.Text = "Journal de Bord";
            this.journalStripMenuItem1.Click += new System.EventHandler(this.journalStripMenuItem1_Click);
            // 
            // fenetreStripMenuItem1
            // 
            this.fenetreStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalStripMenuItem1,
            this.verticaleStripMenuItem1,
            this.cascardeStripMenuItem1});
            this.fenetreStripMenuItem1.Name = "fenetreStripMenuItem1";
            this.fenetreStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.fenetreStripMenuItem1.Text = "Fenêtre";
            // 
            // horizontalStripMenuItem1
            // 
            this.horizontalStripMenuItem1.Name = "horizontalStripMenuItem1";
            this.horizontalStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.horizontalStripMenuItem1.Text = "Horizontale";
            this.horizontalStripMenuItem1.Click += new System.EventHandler(this.horizontalStripMenuItem1_Click);
            // 
            // verticaleStripMenuItem1
            // 
            this.verticaleStripMenuItem1.Name = "verticaleStripMenuItem1";
            this.verticaleStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.verticaleStripMenuItem1.Text = "Verticale";
            this.verticaleStripMenuItem1.Click += new System.EventHandler(this.verticaleStripMenuItem1_Click);
            // 
            // cascardeStripMenuItem1
            // 
            this.cascardeStripMenuItem1.Name = "cascardeStripMenuItem1";
            this.cascardeStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.cascardeStripMenuItem1.Text = "Cascarde";
            this.cascardeStripMenuItem1.Click += new System.EventHandler(this.cascardeStripMenuItem1_Click);
            // 
            // deconnecterStripMenuItem1
            // 
            this.deconnecterStripMenuItem1.Name = "deconnecterStripMenuItem1";
            this.deconnecterStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.deconnecterStripMenuItem1.Text = "Deconnecter";
            this.deconnecterStripMenuItem1.Click += new System.EventHandler(this.deconnecterStripMenuItem1_Click);
            // 
            // userStripMenuItem1
            // 
            this.userStripMenuItem1.Name = "userStripMenuItem1";
            this.userStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.userStripMenuItem1.Text = "Compte";
            this.userStripMenuItem1.Click += new System.EventHandler(this.userStripMenuItem1_Click);
            // 
            // PagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 667);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1431, 706);
            this.Name = "PagePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagePrincipale";
            this.Load += new System.EventHandler(this.PagePrincipale_Load);
            this.Shown += new System.EventHandler(this.PagePrincipale_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fenetreStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem horizontalStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verticaleStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cascardeStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem journalStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deconnecterStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userStripMenuItem1;
    }
}