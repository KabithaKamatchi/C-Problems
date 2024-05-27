

namespace Practice_ProblemsLogic;

    public static class NumbersToNames
    {
        public static string CalculateNames(int nMonth)
        {
            string strMonthName;

            switch(nMonth)
            {
                case 0:
                    strMonthName = "January";
                    return $"The Name of the month is {strMonthName}";
                case 1:
                    strMonthName = "February";
                    return $"The Name of the month is {strMonthName}";
                case 2:
                    strMonthName = "March";
                    return $"The Name of the month is {strMonthName}";
                case 3:
                    strMonthName = "April";
                    return $"The Name of the month is {strMonthName}";
                case 4:
                    strMonthName = "May";
                    return $"The Name of the month is {strMonthName}";
                case 5:
                    strMonthName = "June";
                    return $"The Name of the month is {strMonthName}";
                case 6:
                    strMonthName = "July";
                    return $"The Name of the month is {strMonthName}";
                case 7:
                    strMonthName = "August";
                    return $"The Name of the month is {strMonthName}";
                case 8:
                    strMonthName = "September";
                    return $"The Name of the month is {strMonthName}";
                case 9:
                    strMonthName = "October";
                    return $"The Name of the month is {strMonthName}";
                case 10:
                    strMonthName = "November";
                    return $"The Name of the month is {strMonthName}";
                case 11:
                    strMonthName = "December";
                    return $"The Name of the month is {strMonthName}";
                default:
                        return $"Invalid Month";

            }
        } 
    
   }

