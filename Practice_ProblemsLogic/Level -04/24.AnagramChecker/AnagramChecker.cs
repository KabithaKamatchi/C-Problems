

using Practice_ProblemsLogic;

namespace Practice_Problems.Logic;

    public static  class AnagramChecker
    {
        public static string CalculateAnagram(string strFirstWord, string strSecondWord)
        {
             if(strFirstWord.Length != strSecondWord.Length)
            {
                return "Not Anagrams";
            }

             int[] charFirstCount = new int[26];
             int[] charSecondCount = new int[26];

              for(int i = 0; i < 26; i++)
                {
                    if(charFirstCount[i] != charSecondCount[i])
                    {
                      return "Not Anagrams";
                    }
                }

          return "Anagrams";
        }
    }
