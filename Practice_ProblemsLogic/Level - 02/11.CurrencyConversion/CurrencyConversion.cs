using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practice_Problems.Logic;

    public static class CurrencyConversion
    { 
        public static string AmountUSD(double dEuros, double dExchangeRate, double dTotalUSD)
        {
            dTotalUSD = dEuros*dExchangeRate;
            return $"{dEuros} euros at an exchange rate of {dExchangeRate} is {dTotalUSD} U.S. dollars";

         }
    }
 