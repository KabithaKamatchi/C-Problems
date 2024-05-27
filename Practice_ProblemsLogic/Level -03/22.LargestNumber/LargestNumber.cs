

namespace Practice_ProblemsLogic;

    public static class LargestNumber
    {
        public static string CalculateLargestNumber(int nFirstNumber, int nSecondNumber)
        {

            if (nFirstNumber == nSecondNumber)
            {
             return $"The numbers are not different.";
            }
            else
            {
                int nLargest = nFirstNumber;

                if(nSecondNumber > nLargest)
                {
                    nLargest = nSecondNumber;
                }

                return $"The largest number is {nLargest}";
            }
       
        }
    }

