using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace EmployeeLogin.Tests
{
    /// <summary>
        /// Summary description for EmployeeViewModelTest
        /// </summary>
        [TestClass]
        public class EmployeeViewModelTest
        {
            EmployeeViewModel employeeViewModel;

            public EmployeeViewModelTest()
            {
                //arrange
                employeeViewModel = new EmployeeViewModel();
            }

            [TestMethod]
            public void CheckEmployeesNotNull()
            {
                //assert
                CollectionAssert.AllItemsAreNotNull(employeeViewModel.Employees);
           
            }

        [TestMethod]
        public void SaveTest()
        {
            //act
            bool result = employeeViewModel.Save.CanExecute(null);

            //assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void EmployeesCountNotTrueTest()
        {
            //arrange
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() { Id = 1, Address = "Blk 244/A", Email = "email1@gmail.com", FirstName = "FirstNameA", LastName = "LastNameA" });
            employees.Add(new Employee() { Id = 2, Address = "Blk 244/B", Email = "email2@gmail.com", FirstName = "FirstNameB", LastName = "LastNameB" });

            //assert
            CollectionAssert.AreNotEqual(employees, employeeViewModel.Employees);

        }
    }
    
}