using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostMessagesLibrary
{
    class User : Person
    {
        private string UserPassword;
        private int UserId;

        public User (string firstName, string lastName, string email, DateTime birthDate, string userPassword, int userId) :
            base (firstName, lastName, email, birthDate)
        {
            this.UserPassword = userPassword;
            this.UserId = userId;
        }

        public void LogIn()
        {

        }

        public void PostMessage()
        {

        }
    }
}
