using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projet_GL_Ana_Moreira
{
    public partial class Programme : Form
    {
        private static Programme instanceUnique;
        public static Programme GetInstance()
        {
            if (instanceUnique == null || instanceUnique.IsDisposed)
            {
                instanceUnique = new Programme();
            }
            return instanceUnique;
        }
        public Programme()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            r.MdiParent = this.MdiParent;
            r.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payement p = new Payement();
            p.MdiParent = this.MdiParent;
            p.Show();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjoutFav_Click(object sender, EventArgs e)
        {
            //ajoute bdd Favoris
        }
    }
}
