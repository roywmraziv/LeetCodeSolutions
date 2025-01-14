namespace LeetCodeSolutions.Solutions.LongestPalindromicSubstring;

public class LongestPalindromicSubstringSolution
{
    public string LongestPalindrome(string s)
    {
        int max = 0;
        string ls = "";

        for(int i = 0; i < s.Length; i++)
        {
            Expand(s, i, i, ref max, ref ls);

            Expand(s, i, i + 1, ref max, ref ls);
        }

        return ls;
 
    }
    public void Expand(string s, int left, int right, ref int max, ref string ls)
    {
        while(left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        left++;
        right--;

        int length = right - left + 1;

        if(length > max)
        {
            max = length;
            ls = s.Substring(left, length);
        }
    }
}