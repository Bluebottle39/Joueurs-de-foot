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
        private string name;
        private string surname;
        private string phoneNumber;

        //methods
        public string Nom   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        public string Prénom   // property
        {
            get { return surname; }   // get method
            set { surname = value; }  // set method
        }

        public string NumTelephone   // property
        {
            get { return phoneNumber; }   // get method
            set { phoneNumber = value; }  // set method
        }


        //construtor         
        public Joueur(string _nom, string _prénom, string _numTelephone)
        {
            this.name = _nom;
            this.surname = _prénom;
            this.phoneNumber = _numTelephone;
        }
    }

}
