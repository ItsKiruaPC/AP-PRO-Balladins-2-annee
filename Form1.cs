using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_PRO_Balladins
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconnexion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmdp.Text) || string.IsNullOrEmpty(txtnomuser.Text))
            {
                lblinfo.Text="Veuillez saisir votre mot de passe et votre utilisateur";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
