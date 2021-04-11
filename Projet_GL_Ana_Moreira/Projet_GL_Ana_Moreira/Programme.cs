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
            r.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payement p = new Payement();
            p.ShowDialog();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            JournalDeBord j = new JournalDeBord();
            j.Show();
        }
    }
}
