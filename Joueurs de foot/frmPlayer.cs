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
        private Player activePlayer;
        


        public Player ActivePlayer
        {
            get { return activePlayer; }
            set { activePlayer = value; }
        }
 

        

        private void cmdAddModify_Click(object sender, EventArgs e)
        {

            //string _lastName = txtLastName.Text;
            //string _firstName = txtFirstName.Text;
            //string _phoneNumber = txtPhoneNumber.Text;

            //activePlayer = new Player(_firstName, _lastName, _phoneNumber);

            ActivePlayer.FirstName = txtFirstName.Text;
            ActivePlayer.LastName = txtLastName.Text;
            ActivePlayer.PhoneNumber = txtPhoneNumber.Text;

            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            
            Close();
        }



        //Constructors
        //public frmPlayer()
        //{
        //    InitializeComponent();
        //}

        public frmPlayer(Player playerToModify)
        {
            ActivePlayer = playerToModify;

            InitializeComponent();
            txtFirstName.Text = ActivePlayer.FirstName;
            txtLastName.Text = ActivePlayer.LastName;
            txtPhoneNumber.Text = ActivePlayer.PhoneNumber;
        }



    }
}
