using System;
using System.Collections.Generic;
using System.Text;

namespace TechMWinAssignment
{
    class EmployeeInput
    {
        public EmployeeInput(string firstName,string lastName,int annualSalary,int superRate,DateTime paymentStartDate)
        {
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = annualSalary;
            SuperRate = superRate;
            PaymentStartDate = paymentStartDate;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double AnnualSalary { get; set; }
        public double SuperRate { get; set; }
        public DateTime PaymentStartDate { get; set; }
        
    }
}
