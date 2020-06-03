using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
    public class Player
    {
        //Attributes
        private string firstName;
        private string lastName;
        private string phoneNumber;

        //methods
        public string FirstName   // property
        {
            get { return firstName; }   // get method
            set { firstName = value; }  // set method
        }

        public string LastName   // property
        {
            get { return lastName; }   // get method
            set { lastName = value; }  // set method
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
            return firstName + " " + lastName;
        }



        //construtor         
        //public Player(string _firstName, string _lastName, string _phoneNumber)
        //{
        //    this.firstName = _firstName;
        //    this.lastName = _lastName;
        //    this.phoneNumber = _phoneNumber;
        //}
        public Player()
        {
            
        }
    }

}
