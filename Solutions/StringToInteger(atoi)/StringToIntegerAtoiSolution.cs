namespace LeetCodeSolutions.Solutions.StringToInteger_atoi_;

public class StringToIntegerAtoiSolution
{
    public int MyAtoi(string s) {
        if(s == "") return 0;
        s = s.TrimStart();
        if(s == "") return 0;

        bool neg = false;

        if(s[0] == '-')
        {
            if(s.Length == 1) return 0;
            s = s.Substring(1);
            neg = true;
        }
        else if(s[0] == '+')
        {
            if(s.Length == 1) return 0;
            s = s.Substring(1);
        }
        s = s.TrimStart('0');
        if(s == "") return 0;
        string strDigit = "";

        for(int i = 0; i < s.Length; i++)
        {
            if(!char.IsDigit(s[i]))
            {
                if(i == 0) return 0;

                break;
            }
            else
            {
                strDigit += s[i];
            }

            if(i == 10) break;
        }

        if(neg == true)
        {
            strDigit = '-' + strDigit;
        }

        if(strDigit.Length < 10)
        {
            return Int32.Parse(strDigit);
        }

        int result;

        bool parsed = Int32.TryParse(strDigit, out result);

        if(parsed) return result; 
        else if(neg == false)
        {
            return 2147483647;
        }
        else return -2147483648;
    }
}