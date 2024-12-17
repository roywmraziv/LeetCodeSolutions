namespace LeetCodeSolutions.Solutions.TwoSum;

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target) {
        foreach(int num in nums)
        {
            // if(num > target)
            // {
            //     continue;
            // }

            if(nums.Contains(target - num)){
                int num1 = Array.IndexOf(nums, num);
                int num2 = Array.LastIndexOf(nums, target-num);
                if(num1 != num2)
                {
                    return [num1, num2];
                }
                
                
            }
    
        }
        return [0,1];

        
    }
}