using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projet_GL_Ana_Moreira
{
    public partial class RechercheAvance : Form
    {
        private static RechercheAvance instanceUnique;
        public static RechercheAvance GetInstance()
        {
            if (instanceUnique == null || instanceUnique.IsDisposed)
            {
                instanceUnique = new RechercheAvance();
            }
            return instanceUnique;
        }
        public RechercheAvance()
        {
            InitializeComponent();
        }

     

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RechercheAvancé_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFest_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            Programme p = new Programme();
            p.MdiParent = this.MdiParent;
            p.Show();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            // recherche dans la bdd
        }
    }
}
