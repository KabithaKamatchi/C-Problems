using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems.Logic;

    public static class PasswordValidation
    {
        public static string Verification(string password)
        {
            if(password == "12345")
            {
                return $"I don't know you";
            }

            else if(password == "abc$123")
            {
                 return $"Welcome";
            }

            else
            {
                return "Incorrect Password";
            }
        }
    }
