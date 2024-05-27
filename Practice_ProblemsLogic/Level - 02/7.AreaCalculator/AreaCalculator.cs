namespace Practice_ProblemsLogic
{
    public static class AreaCalculator
    {
        public static double CalculateAreaInSquareFeet(double length, double width)
        {
            return length * width;
        }

        public static double ConvertSquareFeetToSquareMeters(double areaInSquareFeet)
        {
           
            return areaInSquareFeet * 0.09290304;
        }
    }
}
