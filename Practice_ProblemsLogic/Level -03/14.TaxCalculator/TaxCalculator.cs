
namespace Practice_Problems.Logic;

    public static  class TaxCalculator
    {
        public static string CalculateTax(int nOrderAmount, string strState)
        {

            switch (strState)
            {
            case "WI":
                double dTaxRate = 5.5/10;
                double dTotal = nOrderAmount + dTaxRate;
                return $"The subtotal is {nOrderAmount}\nThe tax is {dTaxRate}\nThe total is {dTotal}.\n";

            case "MN":
                return $"The total is {nOrderAmount}"; 

            default: 
                return "Invalid state ";
            }
        }
    }
