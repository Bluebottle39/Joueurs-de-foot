using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
    public class Player
    {
        //Attribute
        private string name;
        private string surname;
        private string phoneNumber;

        //methods
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        public string Surname   // property
        {
            get { return surname; }   // get method
            set { surname = value; }  // set method
        }

        public string PhoneNumber   // property
        {
            get { return phoneNumber; }   // get method
            set { phoneNumber = value; }  // set method
        }
        
        //public string Names
        //{
        //    get { return name + " " + surname;}
        //}

        public override string ToString()
        {
            return name + " " + surname;
        }



        //construtor         
        public Player(string _nom, string _prénom, string _numTelephone)
        {
            this.name = _nom;
            this.surname = _prénom;
            this.phoneNumber = _numTelephone;
        }
    }

}
