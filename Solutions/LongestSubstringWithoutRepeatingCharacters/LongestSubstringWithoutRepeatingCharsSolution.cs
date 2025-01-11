namespace LeetCodeSolutions.Solutions.LongestSubstringWithoutRepeatingCharacters;

public class LongestSubstringWithoutRepeatingCharsSolution
{
    public int LengthOfLongestSubstring(string s) {
        int max = 0;
        var currentChars = new HashSet<char>();
        int currentLength = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if(!currentChars.Contains(s[i]))
            {
                currentChars.Add(s[i]);
                currentLength++;
            }
            else
            {
                while(currentChars.Contains(s[i]))
                {
                    currentChars.Remove(s[i - currentLength]);
                    currentLength --;
                }
                currentChars.Add(s[i]);
                currentLength++;
            }

            if(currentLength > max)
            {
                max = currentLength;
            }
        }
        return max;
    }
}