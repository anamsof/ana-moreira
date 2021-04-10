using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projet_GL_Ana_Moreira
{
    public partial class Payement : Form
    {
        public Payement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboMethode.SelectedIndex == 0) { Facture f = new Facture(); f.ShowDialog(); }
            else if (cboMethode.SelectedIndex == 1) {MasterCard m = new MasterCard(); m.ShowDialog(); }
            else { MessageBox.Show("Selectionner une methode de payement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }
    }
}
