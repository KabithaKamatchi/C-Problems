using System;

namespace PracticeProblemsLogic
{
    public static class PaintCalculator
    {
        public static int nCalculateGallonsNeeded(int nSquareFeet)
        {
            
            int gallonsNeeded = nSquareFeet / 360;

          
            if(nSquareFeet % 360 != 0)
            {
                gallonsNeeded++;
            }

            return gallonsNeeded;
        }
    }
}
