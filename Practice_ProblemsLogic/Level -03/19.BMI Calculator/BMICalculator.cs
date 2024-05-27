namespace Practice_Problems.Logic;

    public static class BMICalculator
    {
        public static string CalculateBMI(double dWeight,double dHeight)
        {
            double dBMI = (dWeight / (dHeight * dHeight)) * (703);
            

            if(dBMI < 18.5)
            {
                string  message = $"Your BMI is {dBMI:F1}.\nYou are underweight.You should see your doctor.";
                return message;
            }
            else if(dBMI >= 18.5 && dBMI < 24)
            {
                string message = $"Your BMI is {dBMI:F1}.\nYou are within the ideal weight range.";
                return message;
            }
            else
            {
                string  message = $"Your BMI is {dBMI:F1}.\nYou are overweight.You should see your doctor.";
                return message;
            }
           
        }
    }
