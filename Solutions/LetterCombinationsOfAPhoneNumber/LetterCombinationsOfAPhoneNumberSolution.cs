namespace LeetCodeSolutions.Solutions.LetterCombinationsOfAPhoneNumber;

public class LetterCombinationsOfAPhoneNumberSolution
{
    public IList<string> LetterCombinations(string digits) {
        if (string.IsNullOrEmpty(digits)) return new List<string>();

        Dictionary<char, string[]> map = new Dictionary<char,string[]>
        {
            {'2', new string[] { "a", "b", "c" }},
            {'3', new string[] { "d", "e", "f" }},
            {'4', new string[] { "g", "h", "i" }},
            {'5', new string[] { "j", "k", "l" }},
            {'6', new string[] { "m", "n", "o" }},
            {'7', new string[] { "p", "q", "r", "s" }},
            {'8', new string[] { "t", "u", "v" }},
            {'9', new string[] { "w", "x", "y", "z" }},
        };

        if(digits.Length == 1) return map[digits[0]];
        int l = 1;

        for(int x = 0; x < digits.Length; x++)
        {
            l *= map[digits[x]].Length;
        }

        List<string> result = Enumerable.Repeat("", l).ToList();
        int blockSize = l;
        for(int i = 0; i < digits.Length; i++)
        {
            string[] charList = map[digits[i]];
            blockSize /= charList.Length;

            for(int j = 0; j < l; j++)
            { 
                int letterIndex = (j / blockSize) % charList.Length;
                result[j] += charList[letterIndex]; 
            }
        }

        return result;


    }
}