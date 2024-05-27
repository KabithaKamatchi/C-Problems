namespace Practice_ProblemsLogic;

    public static class MathOperation
    {
        public static string ArithmeticOperations(int nNum1, int nNum2)
        {
            int nAddition = nNum1 + nNum2;
            int nSubtraction = nNum1 - nNum2;
            int nMultiplication = nNum1 * nNum2;
            int nDivision = nNum1 / nNum2;

            string strResult = $"Addition: {nAddition}\n" +
                               $"Subtraction: {nSubtraction}\n" +
                               $"Multiplication: {nMultiplication}\n" +
                               $"Division: {nDivision}\n";

            return strResult;
        }
    }

