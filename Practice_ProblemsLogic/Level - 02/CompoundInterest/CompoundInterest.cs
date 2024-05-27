
namespace Practice_Problems.Logic;

    public static class CompoundInterest
    {
         public static string CalculateCompound(int nPrincipalAmount, int nAnnualRate , int nYears, int nInterestPerYear, int nCompoundAmount)
        {
            nCompoundAmount = nPrincipalAmount*(1 + (nAnnualRate / nInterestPerYear)) ^ nInterestPerYear * nYears;

            return $"{nPrincipalAmount} invested at {nAnnualRate}% for {nYears} years compounded {nInterestPerYear} times per year is {nCompoundAmount}";
        }
    }
