using System;
using System.Collections.Generic;
using System.Text;

namespace TechMWinAssignment
{
    class SalaryCalculation
    {
        public static double CalculateTax(double taxableIncome)
        {
            
            if (taxableIncome <= 18200)
                return 0;
            else if (taxableIncome >= 18201 && taxableIncome <= 37000)
                return Math.Round(((taxableIncome - 18200) * 0.19)/12);
            else if (taxableIncome >= 37001 && taxableIncome <= 87000)
                return Math.Round((3572 + (taxableIncome - 37000) * 0.325) / 12);
            else if (taxableIncome >= 87001 && taxableIncome <= 180000)
                return Math.Round((19822 + (taxableIncome - 87000) * 0.37) / 12);
            else if (taxableIncome >= 37001 && taxableIncome <= 87000)
                return Math.Round((54232 + (taxableIncome - 180000) * 0.45) / 12);
            else return 0;
        }
        public static string RequiredDateFormat(DateTime dt)
        {
            return dt.Day + "/" + dt.Month.ToString("MMM") + "/" + dt.Year;
        
           
        }

    }
}
