using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projet_GL_Ana_Moreira
{
    public partial class CreerCompte : Form
    {
        public CreerCompte()
        {
            InitializeComponent();
        }

        private void CreerCompte_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
                   }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void verification(){

            if (txtNom.Text == "" || txtPrenom.Text == "" || txtEmail.Text == "" || txtLogin.Text == "" || txtMP.Text == "" || txtMPConf.Text == "")
            {
                MessageBox.Show("Element manquant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMP.Text != txtMPConf.Text) {
                MessageBox.Show("La confirmation du mot de passe n'est pas la même", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form cc = new PageLogin();
                cc.Show();
            }
            
           
        }

        private void Creer_Click(object sender, EventArgs e)
        {
            verification();
        }

        private void btnAnuuler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous vraiment annuler votre reation de compte", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            Form cc = new PageLogin();
            cc.Show();
        }
    }
}
