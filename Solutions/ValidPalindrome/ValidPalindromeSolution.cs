namespace LeetCodeSolutions.Solutions.ValidPalindrome;
using System.Text.RegularExpressions;
public class ValidPalindromeSolution
{
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        s = s.Replace(" ", "");
        s = Regex.Replace(s, @"[^a-zA-Z0-9]", "");

        if(s.Length == 0)
        {
            return true;
        }
        
        if((s.Length == 2 && s[0] != s[1]))
        {
            return false;
        }

        for(int i = 0; i < (s.Length / 2) ; i++)
        {
            if((s[i] != s[s.Length - 1 - i]))
            {
                return false;
            }
        }
        return true;

    }
}