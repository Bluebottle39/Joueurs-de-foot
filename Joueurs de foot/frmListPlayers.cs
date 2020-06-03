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
    public partial class frmListPlayers : Form
    {
        public frmListPlayers()
        {
            InitializeComponent();
        }
        
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            Player newPlayer = new Player();
            frmPlayer addPlayer = new frmPlayer(newPlayer);
            
            addPlayer.ShowDialog();
            
            if (addPlayer.DialogResult == DialogResult.OK)
            {
                lstPlayers.Items.Add(addPlayer.ActivePlayer);
                lstPlayers.SelectedIndex = lstPlayers.Items.Count -1;
            }
            
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdModify_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex != -1)
            {
                Player player = new Player();
                int index = lstPlayers.SelectedIndex;

                // player initialisé avec les valeurs de l'élément sélectionné
                player = lstPlayers.SelectedItem as Player;

                frmPlayer modifyPlayer = new frmPlayer(player);

                modifyPlayer.ShowDialog();

                // Modification dans la liste et sélection du joueur
                if (modifyPlayer.DialogResult == DialogResult.OK)
                {
                    lstPlayers.Items.Insert(index, modifyPlayer.ActivePlayer);
                    lstPlayers.Items.RemoveAt(index + 1);
                    lstPlayers.SelectedIndex = index;

                }
            }
        }
    }
}
