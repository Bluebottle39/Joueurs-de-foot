using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joueurs_de_foot
{
    public partial class frmListPlayers : Form
    {
        public frmListPlayers()
        {
            InitializeComponent();
        }
        
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            Form frmPlayer = new frmPlayer();
            frmPlayer.ShowDialog();
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
