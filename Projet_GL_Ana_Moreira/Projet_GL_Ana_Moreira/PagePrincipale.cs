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

        private void Form1_Load(object sender, EventArgs e)
        {
            JournalDeBord j = new JournalDeBord();
            j.MdiParent = this;
            j.Show();

        }

        private void PagePrincipale_Shown(object sender, EventArgs e)
        {
            ShowLogin();
        }


      

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
