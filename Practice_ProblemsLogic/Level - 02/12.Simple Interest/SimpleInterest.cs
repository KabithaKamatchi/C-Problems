
namespace Practice_Problems.Logic;

    public static class SimpleInterest
    {
        public static string PrincipalAmount(int nPricipal, int  nRate, int nYears, int nSimpleAmount)
        {
            nSimpleAmount = nPricipal *(1 + nRate*nYears);
            return $"After {nYears} years at {nRate}%, the investment will be worth {nSimpleAmount}";
        }
       
    }
