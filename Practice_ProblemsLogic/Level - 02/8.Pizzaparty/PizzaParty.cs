namespace PracticeProblemsLogic
{
    public static class PizzaParty
    {
        public static string CalculatePizzaSlices(int nPeople, int nPizza)
        {
            int nTotalSlices = nPizza * 8; 

            int nSlicesPerPerson = nTotalSlices / nPeople;
            int nLeftOverSlices = nTotalSlices % nPeople;

            string strResult = $"{nPeople} people with {nPizza} pizzas\n";
            strResult += $"Each person gets {nSlicesPerPerson} pieces of pizza.\n";
            strResult += $"There are {nLeftOverSlices} leftover pieces.";

            return strResult;
        }
    }
}
