using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    class HomeLoan : Loan
    {
        // Private variables

        // Constructor
        public HomeLoan(string homeaddress_C, int yearBuilt_C, int squareFootage_C, int loanNumber_C, string customerFirstName_C, string customerLastName_C, decimal interestRate_C, decimal loanAmount_C, decimal loanTermYears_C) : base(loanNumber_C, customerFirstName_C, customerLastName_C, interestRate_C, loanAmount_C, loanTermYears_C)
        {
            HomeAddress = homeaddress_C;
            YearBuilt = yearBuilt_C;
            SquareFootage = squareFootage_C;
        }

        // Properties
        public string HomeAddress
        {
            get;
            set;
        }

        public int YearBuilt
        {
            get;
            set;
        }

        public int SquareFootage
        {
            get;
            set;
        }

        // Methods
        public sealed override decimal CalculateInterest()
        {
            return ((InterestRate / 100M) / (LoanTermYears / 12M)) * (LoanAmount + 5000M);
        }

        public override string ToString()
        {
            return base.ToString() + $"\n\nHome loan details:\nHomeAddress: {HomeAddress}\nYearBuilt: {YearBuilt}\nSquareFootage: {SquareFootage}\n\nInterest calculated: {CalculateInterest()}";
        }
    }
}
