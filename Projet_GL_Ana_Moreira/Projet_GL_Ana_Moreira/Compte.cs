using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projet_GL_Ana_Moreira
{
    public partial class Compte : Form
    {
        private static Compte instanceUnique;
        public static Compte GetInstance()
        {
            if (instanceUnique == null || instanceUnique.IsDisposed)
            {
                instanceUnique = new Compte();
            }
            return instanceUnique;
        }
        public Compte()
        {
            InitializeComponent();
        }

        private void Compte_Load(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //Modifie la BDD
            this.Close();
        }

        private void btnAnuuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPays_Click(object sender, EventArgs e)
        {

        }

        private void lblCivilie_Click(object sender, EventArgs e)
        {

        }

        private void cboCivil_SelectedIndexChanged(object sender, EventArgs e)
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

        private void lblCP_Click(object sender, EventArgs e)
        {

        }

        private void txtMPConf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMP_TextChanged(object sender, EventArgs e)
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

        private void lblMPConfi_Click(object sender, EventArgs e)
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

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }
    }
}
