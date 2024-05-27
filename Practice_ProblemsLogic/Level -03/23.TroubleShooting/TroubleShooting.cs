
namespace Practice_Problems.Logic;

     public static  class TroubleShooting
    {
        public static string CalculateIssues(bool bIsSilent, bool bIsCorroded)
        {
            if (bIsSilent)
            {
                    if (bIsCorroded)
                    {
                         return $"Clean terminals and try again";
                    }

                    else
                    {
                         return $"Replace cables and try again";  
                    }
           
            }
            else
            {
            return $"This is not the cause of the problem";
            }
        }
    }
