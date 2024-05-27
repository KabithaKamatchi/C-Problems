
namespace Practice_Problems.Logic;

    public static  class BloodAlcohol
    {
        public static string CalculateBAC(double dAlcohol,double dBodyWeight,double dAlcoholRatio,double dLastDrink)
        {
            double dBAC = ((dAlcohol * 5.14) / (dBodyWeight * dAlcoholRatio)) - (.015 * dLastDrink);

            string strLegalStatus;

            if(dBAC >=0.08)
            {
                  strLegalStatus = "not Legal";
            }
            else
            {
                 strLegalStatus = "Legal";
            }

             return $"Your BAC is {dBAC:F2}\nIt is {strLegalStatus} for you to drive.";
        }
    }
