namespace LeetCodeSolutions.Solutions.SingleNumber;
// can be completed more efficiently using bitwise XOR
public class SingleNumberSolution
{
    public int SingleNumber(int[] nums) {
        if(nums.Length == 1){return nums[0];}

        foreach(int num in nums)
        {
            if(Array.IndexOf(nums, num) == Array.LastIndexOf(nums, num))
            {
                return num;
            }
        }
        return 0;
    }
}