namespace LeetCodeSolutions.Solutions.GenerateParentheses;

public class GenerateParenthesesSolution
{
    public IList<string> GenerateParenthesis(int n) {
        List<string> results = new List<string>();

        backtrack("", n, n, results);

        return results;
    }
    public void backtrack(string s, int left, int right, List<string> results)
    {
        if(left == 0 && right ==0)
        {
            results.Add(s);
        }

        if(left > 0)
        {
            backtrack(s + "(", left - 1, right, results);
        }

        if(right > left)
        {
            backtrack(s + ")", left, right - 1, results);
        }
    }
}