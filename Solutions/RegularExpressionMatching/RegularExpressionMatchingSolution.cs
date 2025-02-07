namespace LeetCodeSolutions.Solutions.RegularExpressionMatching;
using System.Text.RegularExpressions;
public class RegularExpressionMatchingSolution
{
    public bool IsMatch(string s, string p) {
        p = "^" + p + "$";
        Regex reg = new Regex(p);

        return reg.IsMatch(s);
    }
}