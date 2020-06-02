using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using joueur;

namespace Joueurs_de_foot
{
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();
        }

        

        private void cmdAddModify_Click(object sender, EventArgs e)
        {
            string _nom = txtNom.Text;
            string _prénom = txtPrénom.Text;
            string _numTelephone = txtNumTéléphone.Text;
            
            Joueur toadd = new Joueur(_nom, _prénom, _numTelephone);
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
