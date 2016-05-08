using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLogin
{
   public class Employee:BaseViewModel
    {
        private int id;
        public int Id { get { return id; } set { id = value; RaisePropertyChange("Id"); } }

        private string firstName;
        public string FirstName { get { return firstName; } set { firstName = value; RaisePropertyChange("FirstName"); } }

        private string lastName;
        public string LastName { get { return lastName; } set { lastName = value; RaisePropertyChange("LastName"); } }

        private string email;
        public string Email { get { return email; } set { email = value; RaisePropertyChange("Email"); } }

        private string address;
        public string Address { get { return address; } set { address = value; RaisePropertyChange("Address"); } }

    }
}
