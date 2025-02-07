namespace LeetCodeSolutions.Solutions.ThreeSumClosest;

public class ThreeSumClosestSolution
{
    public int ThreeSumClosest(int[] nums, int target) {
        if(nums.Length == 3) return nums[0] + nums[1] + nums[2];

        Array.Sort(nums);
        int dif = int.MaxValue;
        int currentSum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(i > 0 && nums[i] == nums[i-1]) continue;

            int left = i + 1; 
            int right = nums.Length - 1;

            while(left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if(sum == target) return sum;
                else if(Math.Abs(target - sum) < dif)
                {
                    dif = Math.Abs(target - sum);
                    currentSum = sum;
                }
                
                if(sum < target) left += 1;
                else right -= 1;
            }
        }
        return currentSum;
    }
}