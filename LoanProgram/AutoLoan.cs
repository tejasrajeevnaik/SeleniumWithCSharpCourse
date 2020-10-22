using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    class AutoLoan : Loan
    {
        // Private variables

        // Constructor
        public AutoLoan(int yearBuilt_C, string model_C, string make_C, string color_c, int loanNumber_C, string customerFirstName_C, string customerLastName_C, decimal interestRate_C, decimal loanAmount_C, decimal loanTermYears_C) : base(loanNumber_C, customerFirstName_C, customerLastName_C, interestRate_C, loanAmount_C, loanTermYears_C)
        {
            YearBuilt = yearBuilt_C;
            Model = model_C;
            Make = make_C;
            Color = color_c;
        }

        // Properties
        public int YearBuilt
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }

        public string Make
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        // Methods
        public sealed override decimal CalculateInterest()
        {
            return ((InterestRate / 100M) / (LoanTermYears / 12M)) * (LoanAmount + 1000M);
        }

        public override string ToString()
        {
            return base.ToString() + $"\n\nAuto loan details:\nYearBuilt: {YearBuilt}\nModel: {Model}\nMake: {Make}\nColor: {Color}\n\nInterest calculated: {CalculateInterest()}";
        }
    }
}
