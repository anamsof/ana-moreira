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
        private static JournalDeBord instanceUnique;
        public static JournalDeBord GetInstance() {
            if (instanceUnique == null || instanceUnique.IsDisposed) {
                instanceUnique = new JournalDeBord(); 
            }
            return instanceUnique;
        }

        public JournalDeBord()
        {
            InitializeComponent();
            

        }
        public void ShowLogin() {
            PageLogin p = new PageLogin();
            p.ShowDialog();
        }
        private void btnRecherche_Click(object sender, EventArgs e)
        {
            RechercheAvance p = RechercheAvance.GetInstance();
            p.MdiParent = this.MdiParent;
            p.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Programme p = Programme.GetInstance(); ;
            p.MdiParent = this.MdiParent;
            p.Show();
           
        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void JournalDeBord_Load(object sender, EventArgs e)
        {


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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRecomm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
