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
        //Accesseurs
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
        
        
        //Over
        public override string ToString()
        {
            return firstName + " " + lastName;
        }



        //construtor         
        
        public Player()
        {
            
        }
    }

}
