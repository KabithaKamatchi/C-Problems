

namespace Practice_ProblemsLogic;

    public static  class DrivingAge
    {
            public static string CalculateAge(int nAge)
        {
            if(nAge >= 18)
            {
                return $"You are old enough to legally drive.";
            }
            else
            {
                return $"You are not old enough to legally drive.";
            }
        }
    }
