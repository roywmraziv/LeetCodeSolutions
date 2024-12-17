namespace LeetCodeSolutions.Solutions.PalindromeNumber;

public class PalindromeNumberSolution
{
    public bool IsPalindrome(int x) {
        if (x < 0) return false; // negative numbers are not palindromes
        if (x <= 9) return true; // single-digit numbers are palindromes
        string s = x.ToString();

        int end = x.ToString().Length - 1;

        for(int i = 0; i < x.ToString().Length; i++)
        {
            if(s[i] == s[end])
            {
                end--;
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;


        
        
    }
}