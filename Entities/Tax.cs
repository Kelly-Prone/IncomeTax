using System;
using System.Collections.Generic;


namespace Course.Entities
{
    abstract class Tax
    {
        public string Name { get; set; }
        public double AnnualTax { get; set; }

        public Tax(string name, double annualTax)
        {
            Name = name;
            AnnualTax = annualTax;
        }

        public abstract double TaxPayer();
    }
}
