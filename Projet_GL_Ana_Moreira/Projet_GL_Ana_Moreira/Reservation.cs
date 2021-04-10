using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projet_GL_Ana_Moreira
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            // modifier le statue & La BDD
            if () {
                Payement p = new Payement();
                p.ShowDialog();
            }
            else if () {
                Reservation r = new Reservation();
                r.ShowDialog();
            }
            else { 
            
            }
            this.Close();
        }
    }
}
