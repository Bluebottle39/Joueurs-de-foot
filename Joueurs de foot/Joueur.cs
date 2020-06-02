﻿using System;
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
        public Joueur playertoadd;


        public frmPlayer()
        {
            InitializeComponent();
        }

        

        private void cmdAddModify_Click(object sender, EventArgs e)
        {

            
            string _name = txtNom.Text;
            string _surname = txtPrénom.Text;
            string _phoneNumber = txtNumTéléphone.Text;
            
            playertoadd = new Joueur(_name, _surname, _phoneNumber);
            
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
