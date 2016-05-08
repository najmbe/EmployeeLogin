using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EmployeeLogin
{
   public class EmployeeViewModel:BaseViewModel
    {
        private ObservableCollection<Employee> _employee= new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees
        {
            get { return _employee; }
            set { _employee = value; }
        }
        public EmployeeViewModel()
        {
            Employees= new ObservableCollection<Employee>()
            {
                new Employee(){Id=1,Address="Blk 244/A",Email="email1@gmail.com",FirstName="FirstNameA",LastName="LastNameA"},
                new Employee(){Id=2,Address="Blk 244/B",Email="email2@gmail.com",FirstName="FirstNameB",LastName="LastNameB"},
                new Employee(){Id=3,Address="Blk 244/C",Email="email3@gmail.com",FirstName="FirstNameC",LastName="LastNameC"},
                new Employee(){Id=4,Address="Blk 244/D",Email="email4@gmail.com",FirstName="FirstNameD",LastName="LastNameD"},
                new Employee(){Id=5,Address="Blk 244/E",Email="email5@gmail.com",FirstName="FirstNameE",LastName="LastNameE"},
                new Employee(){Id=6,Address="Blk 244/F",Email="email6@gmail.com",FirstName="FirstNameF",LastName="LastNameF"},
                new Employee(){Id=7,Address="Blk 244/G",Email="email7@gmail.com",FirstName="FirstNameG",LastName="LastNameG"},
                new Employee(){Id=8,Address="Blk 244/H",Email="email8@gmail.com",FirstName="FirstNameH",LastName="LastNameH"},
            };
        }
        private ICommand _save;
        public ICommand Save
        {
            get { return new RelayCommand(SaveEmployee,true); }
            set { _save = value; RaisePropertyChange("Save"); }
        }
        private ICommand _myCommand; 
        public ICommand MyCommand
        {
            get { return new RelayCommand(FillDetails, true); }
            set { _myCommand = value; RaisePropertyChange("MyCommand"); }
        }

        private void FillDetails(object obj)
        {
            var x = (Employee)obj;
            NewAddress = x.Address;
            NewEmail = x.Email;
            NewId = x.Id;
            NewFirstName = x.FirstName;
            NewLastName = x.LastName;
        }

        private void SaveEmployee(object obj)
        {
            CheckName();
            var emp = new Employee();
            emp.Address = NewAddress;
            emp.Email = NewEmail;
            emp.FirstName = NewFirstName;emp.LastName = NewLastName;emp.Id = NewId;
            Employees.Add(emp);
        }

        public void CheckName()
        {
           // throw new NotImplementedException();
        }

        private int id;
        public int NewId { get { return id; } set { id = value; RaisePropertyChange("NewId"); } }

        private string firstName;
        public string NewFirstName { get { return firstName; } set { firstName = value; RaisePropertyChange("NewFirstName"); } }

        private string lastName;
        public string NewLastName { get { return lastName; } set { lastName = value; RaisePropertyChange("NewLastName"); } }

        private string email;
        public string NewEmail { get { return email; } set { email = value; RaisePropertyChange("NewEmail"); } }

        private string address;
        public string NewAddress { get { return address; } set { address = value; RaisePropertyChange("NewAddress"); } }

    }
}
