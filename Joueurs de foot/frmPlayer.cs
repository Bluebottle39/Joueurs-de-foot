using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using player;

namespace Joueurs_de_foot
{
    public partial class frmPlayer : Form
    {
        private Player playerToAdd;

        public Player PlayerToAdd   // property
        {
            get { return playerToAdd; }   // get method
            //set { playertoadd = value; }  // set method
        }


        public frmPlayer()
        {
            InitializeComponent();
        }

        

        private void cmdAddModify_Click(object sender, EventArgs e)
        {

            
            string _name = txtNom.Text;
            string _surname = txtPrénom.Text;
            string _phoneNumber = txtNumTéléphone.Text;
            
            playerToAdd = new Player(_name, _surname, _phoneNumber);
            
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
