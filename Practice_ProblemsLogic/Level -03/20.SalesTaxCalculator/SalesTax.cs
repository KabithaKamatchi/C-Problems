
namespace Practice_Problems.Logic;

public static class SalesTax
{
    public static string CalculateTax(int nOrderAmount, string strState, string strCountry)
    {
        double dTaxRate;
        double dTax;
        double dTotal;

        switch(strState)
        {
            case "Wisconsin":
                switch(strCountry)
                {
                    case "EauClaire":
                        dTaxRate = 0.055;
                        break;
                    case "Dunn":
                        dTaxRate = 0.054;
                        break;
                    default:
                        return "Invalid country.";
                }
                dTax = nOrderAmount * dTaxRate;
                dTotal = nOrderAmount + dTax;
                return $"The tax is {dTax:C2}\nThe total is {dTotal:C2}.\n";

            case "Illinois":
                dTaxRate = 0.08;
                dTax = nOrderAmount * dTaxRate;
                dTotal = nOrderAmount + dTax;
                return $"The tax is {dTax:C2}\nThe total is {dTotal:C2}.\n";

            default:
                dTotal = nOrderAmount;
                return $"The total is {dTotal:C2}.";
        }
    }
}
