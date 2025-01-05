namespace LeetCodeSolutions.Solutions.PlusOne;

public class PlusOneSolution
{
    public int[] PlusOne(int[] digits) {
        int x = digits.Length - 1;

        for(int i = x; i >= 0; i--)
        {
            if(digits[i] + 1 < 10)
            {
                digits[i] = digits[i] + 1;
                break;
            }
            else
            {
                digits[i] = 0;
            }
        } 
        if(digits[0] == 0)
        {
            int[] newList = new int[x+2];

            newList[0] = 1;

            for(int i = 0; i < digits.Length; i ++)
            {
                newList[i+1] = digits[i];
            }
            return newList;
        }
        else
        {
            return digits;
        }
    }
}