namespace LeetCodeSolutions.Solutions.AddBinary;

public class AddBinarySolution
{
    public string AddBinary(string a, string b) {
        string result = "";
        int carry = 0;

        int i = a.Length - 1;
        int j = b.Length -1;

        int bit1;
        int bit2;
        int sum;

        while(i >= 0 || j >= 0 || carry != 0)
        {
            if(i >= 0)
            {
                bit1 = int.Parse(Convert.ToString(a[i]));
                i--;
            }
            else
            {
                bit1 = 0;
            }

            if( j >= 0)
            {
                bit2 = int.Parse(Convert.ToString(b[j]));
                j--;
            }
            else
            {
                bit2 = 0;
            }

            sum = bit1 + bit2 + carry;

            carry = sum / 2;

            result = Convert.ToString(sum % 2) + result;
        }
        return result;
        
    }
}