namespace LeetCodeSolutions.Solutions.MajorityElement;

public class MajorityElementSolution
{
    public int MajorityElement(int[] nums) {
        
        Dictionary<int,int> count = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(!count.ContainsKey(num))
            {
                count.Add(num, 0);
            }
            else
            {
                count[num] = count[num] + 1;
            }
        }

        return count.OrderByDescending(kvp => kvp.Value).First().Key;
        
    }
}