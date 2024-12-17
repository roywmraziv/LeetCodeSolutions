namespace LeetCodeSolutions.Solutions.ValidParentheses;
// only beats 12% 
public class ValidParenthesesSolution
{
    public bool IsValid(string s) {

        if(s.Length == 1)
        {
            return false;
        }
        else if (s[0] == ')' || s[0] == ']' || s[0] == '}')
        {
            return false;
        }

        var dict = new Dictionary <char, char>();
        dict.Add('(', ')');
        dict.Add('[', ']');
        dict.Add('{', '}');

        var stack = new Stack <char>();

        foreach(char c in s)
        {
            if(c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if((c == ')' || c == ']' || c == '}'))
            {
                try{
                    if(c == dict[stack.Peek()])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                        break;
                    }
                }
                catch(Exception e)
                {
                    return false;
                    break;
                }
                
            }
            else
            {
                return false;
                break;
            }
        }
        
        return stack.Count == 0 ? true : false;
    }
}