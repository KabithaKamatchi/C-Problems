using System;

namespace PracticeProblemsLogic
{
    public static class AgeCalculator
    {
        public static int CalculateRetirementYear(int nCurrentAge, int nRetirementAge, int nCurrentYear)
        {
            if(nCurrentAge < 0 || nRetirementAge < 0)
            {
                return 0;
            }

            if(nRetirementAge <= nCurrentAge)
            {
                return 0;
            }

            int yearsLeftUntilRetirement = nRetirementAge - nCurrentAge;

            return nCurrentYear + yearsLeftUntilRetirement;
        }
    }
}
