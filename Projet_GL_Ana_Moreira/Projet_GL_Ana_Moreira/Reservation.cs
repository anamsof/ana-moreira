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
        public static DateTime Today { get; }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            dtpDate.Value = thisDay.AddDays(30); // ajout temps 30 Jours
                    
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            // ajouter au BBD 
            this.Close();
        }
    }
}
