using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joueur
{
    public class Joueur
    {
        //Attribute
        private string nom;
        private string prénom;
        private string numTelephone;

        //methods
        public string Nom   // property
        {
            get { return nom; }   // get method
            set { nom = value; }  // set method
        }

        public string Prénom   // property
        {
            get { return prénom; }   // get method
            set { prénom = value; }  // set method
        }

        public string NumTelephone   // property
        {
            get { return numTelephone; }   // get method
            set { numTelephone = value; }  // set method
        }


        //construtor         
        public Joueur(string _nom, string _prénom, string _numTelephone)
        {
            this.nom = _nom;
            this.prénom = _prénom;
            this.numTelephone = _numTelephone;
        }
    }

}
