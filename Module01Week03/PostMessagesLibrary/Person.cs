using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostMessagesLibrary
{
    public class Person
    {
        private string FirstName;
        private string LastName;
        private string Email;
        private DateTime BirthDate;

        public Person(string firstName, string lastName, string email, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        public void CreateAccount()
        {
            
        }
    }
}
