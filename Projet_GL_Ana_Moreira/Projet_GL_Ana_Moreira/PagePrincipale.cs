using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projet_GL_Ana_Moreira
{
    public partial class PagePrincipale : Form
    {
        public PagePrincipale()
        {
            InitializeComponent();
        }
        public void ShowLogin()
        {
            PageLogin p = new PageLogin();
            p.ShowDialog();
        }
        public void ShowJournal() {
            JournalDeBord j = JournalDeBord.GetInstance();
            j.MdiParent = this;
            j.Show();
        }
        private void PagePrincipale_Load(object sender, EventArgs e)
        {
            ShowJournal();
        }
        private void PagePrincipale_Shown(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
         
        }
     
       

        private void horizontalStripMenuItem1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascardeStripMenuItem1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void verticaleStripMenuItem1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void journalStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowJournal();
        }

        private void deconnecterStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void userStripMenuItem1_Click(object sender, EventArgs e)
        {
            Compte c = Compte.GetInstance();
            c.MdiParent = this;
            c.Show();
        }
    }
}
