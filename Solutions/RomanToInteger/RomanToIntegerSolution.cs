namespace LeetCodeSolutions.Solutions.RomanToInteger;

public class RomanToIntegerSolution
{
    public int RomanToInt(string s) {
        Dictionary<string, int> map = new Dictionary<string, int>();
        Dictionary<string, int> map2 = new Dictionary<string, int>();

        map.Add("IV", 4);
        map.Add("IX", 9);
        map.Add("XL", 40);
        map.Add("XC", 90);
        map.Add("CD", 400);
        map.Add("CM", 900);
        map.Add("I", 1);
        map.Add("V", 5);
        map.Add("X", 10);
        map.Add("L", 50);
        map.Add("C", 100);
        map.Add("D", 500);
        map.Add("M", 1000);

        List<string> list = new List<string> {"IV", "IX", "XL", "XC", "CD", "CM" };
        int total = 0;

        while(s.Length > 0)
        {
            int lengthToTake;
            if(s.Length >= 2){
                lengthToTake = 2;
            }
            else{
                lengthToTake = 1;
            }
            

            string lastPart = s.Substring(s.Length - lengthToTake , lengthToTake);

            if(list.Contains(lastPart))
            {
                total += map[lastPart];
                s = s.Substring(0, s.Length - lengthToTake);
            }
            else
            {
                lengthToTake = 1;
                lastPart = s.Substring(s.Length - lengthToTake , lengthToTake);
                total += map[lastPart];
                s = s.Substring(0, s.Length - lengthToTake);

            }
        }
        return total;
        

        
        

    }
}