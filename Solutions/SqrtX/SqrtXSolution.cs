namespace LeetCodeSolutions.Solutions.SqrtX;

public class SqrtXSolution
{
    public int MySqrt(int x) {
        if(x == 1){return 1;}
        if(x == 0){return 0;}

        double low = 0;
        double high = x;

        double mid = (low + high) / 2;

        while(Math.Abs(mid * mid - x) > 1e-6)
        {
            if(mid * mid < x){
                low = mid;
            }

            if(mid * mid > x){
                high = mid;
            }

            mid = (low + high) / 2;

        }

        return (int)mid;

        
    }
}