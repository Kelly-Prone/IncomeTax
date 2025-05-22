using System;
using System.Collections.Generic;

namespace Course.Entities
{
    class Company : Tax
    {
        public int NumberEmployees { get; set; }

        public Company(string name, double annualTax, int numberEmployees) 
            : base(name, annualTax)
        {
            NumberEmployees = numberEmployees;

        }

        public override double TaxPayer()
        {
            double tax = NumberEmployees > 10 ? 0.14 : 0.16;
            return AnnualTax * tax;

        }
    }
}
