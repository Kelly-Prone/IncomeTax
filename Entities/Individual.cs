using System;
using System.Collections.Generic;
using Course.Entities;

namespace Course.Entities
{
    class Individual : Tax
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualTax, double healthExpenditures) 
            : base(name, annualTax)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxPayer()
        {
            double tax = AnnualTax < 20000.0 ? 0.15 : 0.25;
            double grossTax = AnnualTax * tax;
            double rebateTax = HealthExpenditures * 0.5;
            return grossTax - rebateTax;
        }
    }
}
