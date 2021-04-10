using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GL_Ana_Moreira
{
    public partial class PageLogin : Form
    {
        public PageLogin(){
            InitializeComponent();
           
        }

        private void btnCreer_Click(object sender, EventArgs e) {
            Form cc = new CreerCompte();
            cc.Show();
        }

        private void verification() {
            if (txtLogin.Text == "" || txtMP.Text == ""){
                MessageBox.Show("Element manquant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                this.Close();
            
            }
        }
        private void btnConnecter_Click(object sender, EventArgs e) {
            verification();
          
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            Focus();
           
        }

        private void txtMP_TextChanged(object sender, EventArgs e)
        {
            txtMP.PasswordChar = '*';
        }

        private void PageLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
