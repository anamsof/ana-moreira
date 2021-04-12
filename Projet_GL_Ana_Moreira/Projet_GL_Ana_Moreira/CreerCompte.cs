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
            cboCivil.SelectedIndex = 0;
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

            if (cboCivil.SelectedIndex == 0 || txtNom.Text == "" || txtPrenom.Text == "" || txtEmail.Text == "" || txtLogin.Text == "" || txtMP.Text == "" || txtMPConf.Text == "" || txtAdresse.Text == "" || txtCP.Text == "" || txtPays.Text == "")
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
            this.Close();
        }

        private void btnAnuuler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous vraiment annuler votre reation de compte", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            this.Close();
            Form cc = new PageLogin();
            cc.Show();
        }

        private void txtMP_TextChanged(object sender, EventArgs e)
        {
            txtMP.PasswordChar = '*';
        }

        private void txtMPConf_TextChanged(object sender, EventArgs e)
        {
            txtMPConf.PasswordChar = '*';
        }

        private void cboCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblCP_Click(object sender, EventArgs e)
        {

        }

        private void lblPays_Click(object sender, EventArgs e)
        {

        }

        private void lblCivilie_Click(object sender, EventArgs e)
        {

        }

        private void txtCP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAdresse_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPays_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMP_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblPrenom_Click(object sender, EventArgs e)
        {

        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }
    }
}
