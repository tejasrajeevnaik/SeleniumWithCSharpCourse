using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTaxCalculator
{
    class Property
    {
        // Private variables
        private decimal millageRate = 10.3M;
        private decimal exemption = 25000M;
        private decimal assessedValueIncreasePercentage = 2.7M;

        // Constructor
        public Property(string address_C, int lastYearAssessedValue_C)
        {
            Address = address_C;
            LastYearAssessedValue = lastYearAssessedValue_C;
        }

        // Properties
        public string Address
        {
            get;
            set;
        }

        public decimal LastYearAssessedValue
        {
            get;
            set;
        }

        public decimal MillageRate
        {
            get { return millageRate; }
        }

        public decimal Exemption
        {
            get { return exemption; }
        }

        public decimal AssessedValueIncreasePercentage
        {
            get { return assessedValueIncreasePercentage; }
        }

        // Methods
        public decimal GetNewAssessedValue()
        {
            return LastYearAssessedValue + (AssessedValueIncreasePercentage / 100M) * LastYearAssessedValue;
        }

        public decimal GetProposedPropertyTax()
        {
            if(GetNewAssessedValue() <= Exemption)
            {
                return 0M;
            }
            else
            {
                return ((GetNewAssessedValue() - Exemption) / 1000M) * MillageRate;
            }
        }

        public override string ToString()
        {
            return $"Property address: {Address}\nLast year assessed value: {LastYearAssessedValue}\nCurrent assessed value: {GetNewAssessedValue()}\nExemption: {Exemption}\nTaxableValue: {(GetNewAssessedValue() <= Exemption ? 0 : GetNewAssessedValue() - Exemption)}\nMillage rate (per $1000): {MillageRate}\n\nTaxes due: {GetProposedPropertyTax()}";
        }
    }
}
