using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projet_GL_Ana_Moreira
{
    public partial class JournalDeBord : Form
    {
        public JournalDeBord()
        {
            InitializeComponent();
            

        }
        public void ShowLogin() {
            PageLogin p = new PageLogin();
            p.ShowDialog();
        }

        private void JournalDeBord_Load(object sender, EventArgs e)
        {


        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void lblFav_Click(object sender, EventArgs e)
        {

        }

        private void lblFest_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            RechercheAvancé p = new RechercheAvancé();
            p.Show();

        }
    }
}
