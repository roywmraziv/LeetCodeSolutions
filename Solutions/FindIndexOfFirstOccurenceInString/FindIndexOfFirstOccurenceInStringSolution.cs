namespace LeetCodeSolutions.Solutions.FindIndexOfFirstOccurenceInString;

public class FindIndexOfFirstOccurenceInStringSolution
{
    public int StrStr(string haystack, string needle) {
        int k = needle.Length - 1;

        int j = haystack.Length;

        int i = 0;

        while(i + k < j)
        {
            string s = haystack.Substring(i, k+1);
            if(s == needle)
            {
                return i;
                break;
            }
            i++;
        }
        return -1;
    }
}