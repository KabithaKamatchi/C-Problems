namespace PracticeProblemsLogic;

public static class SelfCheckout
{
    public static double CalculatedSubtotal(double[] lstPrices, double[] lstQuantities)
    {
        double dSubtotal = 0;

        for(int i = 0; i < lstPrices.Length; i++)
        {
            dSubtotal += lstPrices[i] * lstQuantities[i];
        }

        return dSubtotal;
    }

    public static double CalculateTax(double dSubtotal, double dTaxRate)
    {
        return dSubtotal * dTaxRate;
    }

    public static double CalculateTotal(double dSubtotal, double dTax)
    {
        return dSubtotal + dTax;
    }
}



