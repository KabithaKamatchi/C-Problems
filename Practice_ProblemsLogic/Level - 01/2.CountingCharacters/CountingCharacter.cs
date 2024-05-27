namespace Practice_ProblemsLogic;

public static class CountingCharacter
{
    public static string Character(string STR_WORD)
    {
        int nCount = 0;

        for(int i = 0; i < STR_WORD.Length; i++)
        {
            nCount++;
        }

        return $"{STR_WORD} has {nCount} characters.";
    }
}
