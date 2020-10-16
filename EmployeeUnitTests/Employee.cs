using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeUnitTests
{
    class Employee
    {
        #region Private variables for the class
        private readonly string employeeNumber;
        private readonly string firstName;
        private readonly string lastName;
        private DateTime dateOfHire = DateTime.Today;
        private string jobDescription = String.Empty;
        private string department = "Not assigned";
        private int monthlySalary = 11000;
        #endregion

        // Constructor
        public Employee(string employeeNumber, string firstName, string lastName)
        {
            this.employeeNumber = employeeNumber;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Properties
        public string EmployeeNumber
        {
            get { return employeeNumber; }
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public DateTime DateOfHire
        {
            get { return dateOfHire; }
            set { dateOfHire = value; }
        }

        public string JobDescription
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public int MonthlySalary
        {
            get { return monthlySalary; }
            set { monthlySalary = value; }
        }

        // Methods
        public string GetNameInStandardFormat()
        {
            return $"{firstName} {lastName}";
        }

        public string GetNameInSortableFormat()
        {
            return $"{lastName}, {firstName}";
        }
    }
}
