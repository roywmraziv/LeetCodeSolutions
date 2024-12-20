namespace LeetCodeSolutions.Solutions.LengthOfLastWord;

public class LengthOfLastWordSolution
{
    public int LengthOfLastWord(string s) {
        s = s.TrimEnd();
        int index = s.Length - 1;

        if(s.Length == 1 || !s.Contains(' '))
        {
            return s.Length;
        }
        

        for(int i = index; i > 0; i--)
        {
            if(char.IsLetter(s[i]))
            {
                index--;
            }
            else
            {
                //index--;
                break;
            }
        }

        return s.Substring(index, s.Length - index -1).Length;
    }
}