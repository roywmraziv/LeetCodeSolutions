namespace LeetCodeSolutions.Solutions.LongestCommonPrefix;

public class LongestCommonPrefixSolution
{
    public string LongestCommonPrefix(string[] strs) {
        int shortest = strs[0].Length;
        int shortestIndex = 0;

        foreach(string word in strs)
        {
            if(word.Length < shortest)
            {
                shortest = word.Length;
                shortestIndex = Array.IndexOf(strs, word);
            }
        }

        string pf = "";
        bool go = true;

        for(int i = 0; i < shortest; i++)
        {
            foreach(string word in strs)
            {
                if(strs[shortestIndex][i] == word[i])
                {
                    continue;
                }
                else{
                    go = false;
                }
            }
            if(go == true)
            {
                pf += strs[shortestIndex][i];
            }
        }
        return pf;

    }
}