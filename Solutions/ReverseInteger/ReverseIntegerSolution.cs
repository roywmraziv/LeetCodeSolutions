namespace LeetCodeSolutions.Solutions.ReverseInteger;

public class ReverseIntegerSolution
{
    public int Reverse(int x) {
        int y = 0;
        bool neg = false;

        if( x == 0)
        {
            return 0;
        } 
        else if( x < 0)
        {
            x *= -1;
            neg = true;
        }



        while(x > 0)
        {
            if (y > 214748364 || (y == 214748364 && x % 10 > 7))
            {
                return 0;
            }
            
            y = (y * 10) + (x % 10);
            x = x / 10; 
        }

        if(neg == true)
        {
            y *= -1;
        }

        return y;
       
    }
}