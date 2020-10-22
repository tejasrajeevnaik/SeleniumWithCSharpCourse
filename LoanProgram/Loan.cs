using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    abstract class Loan
    {
        // Private variables
        private decimal interestRate;
        private decimal loanAmount;
        private decimal loanTermYears;

        // Constructor
        protected Loan(int loanNumber_C, string customerFirstName_C, string customerLastName_C, decimal interestRate_C, decimal loanAmount_C, decimal loanTermYears_C)
        {
            LoanNumber = loanNumber_C;
            CustomerFirstName = customerFirstName_C;
            CustomerLastName = customerLastName_C;
            InterestRate = interestRate_C;
            LoanAmount = loanAmount_C;
            LoanTermYears = loanTermYears_C;
        }

        // Properties
        public int LoanNumber
        {
            get;
            set;
        }

        public string CustomerFirstName
        {
            get;
            set;
        }

        public string CustomerLastName
        {
            get;
            set;
        }

        public decimal InterestRate
        {
            get { return interestRate; }
            set
            {
                if(value < 0M)
                {
                    interestRate = 1M;
                }
                else
                {
                    interestRate = value;
                }
            }
        }

        public decimal LoanAmount
        {
            get { return loanAmount; }
            set
            {
                if (value < 10000M)
                {
                    loanAmount = 10000M;
                }
                else
                {
                    loanAmount = value;
                }
            }
        }

        public decimal LoanTermYears
        {
            get { return loanTermYears; }
            set
            {
                if (value < 1M)
                {
                    loanTermYears = 1M;
                }
                else
                {
                    loanTermYears = value;
                }
            }
        }

        // Methods
        public abstract decimal CalculateInterest();

        public override string ToString()
        {
            return $"Loan details:\nLoanNumber: {LoanNumber}\nCustomer Name: {CustomerFirstName} {CustomerLastName}\nInterestRate: {InterestRate}\nLoanAmount: {LoanAmount}\nLoanTermYears: {LoanTermYears}";
        }
    }
}
