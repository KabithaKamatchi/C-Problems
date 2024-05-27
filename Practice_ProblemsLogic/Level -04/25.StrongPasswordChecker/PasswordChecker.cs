

namespace Practice_Problems.Logic;

public static class PasswordChecker
{
    public static string CheckStrongPassword(string strPassword)
    {
        bool hasLetters = false;
        bool hasNumbers = false;
        bool hasSpecialCharacters = false;

        
        foreach(char ch in strPassword)
        {
            if(char.IsLetter(ch))
            {
                hasLetters = true;
            }
            else if(char.IsDigit(ch))
            {
                hasNumbers = true;
            }
            else
            {
                hasSpecialCharacters = true;
            }
        }

        if(strPassword.Length < 8)
        {
            if(!hasLetters && hasNumbers)
            {
                return $"The password {strPassword} is a very weak password.";
            }
            else if(hasLetters && !hasNumbers)
            {
                return $"The password {strPassword} is a weak password.";
            }
        }
        else
        {
            if(hasLetters && hasNumbers && !hasSpecialCharacters)
            {
                return $"The password {strPassword} is a strong password.";
            }
            else if(hasLetters && hasNumbers && hasSpecialCharacters)
            {
                return $"The password {strPassword} is a very strong password.";
            }
        }

        return $"The password {strPassword} is an invalid password.";
    }
}

