namespace LeetCodeSolutions.Solutions.FourSum;

public class FourSumSolution
{
    public IList<IList<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        List<List<int>> results = new List<List<int>>();

        if(nums.Length < 4) return results.Cast<IList<int>>().ToList();

        for(int i = 0; i < nums.Length - 3; i++)
        {
            if(i > 0 && nums[i] == nums[i -1]) continue;

            for(int j = i + 1; j < nums.Length - 2; j++)
            {
                if(j > i + 1 && nums[j] == nums[j - 1]) continue;
                
                int left = j + 1;
                int right = nums.Length - 1;

                while(left < right)
                {
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];

                    if(sum == target)
                    {
                        var l = new List<int> {nums[i], nums[left], nums[right], nums[j]};
                        results.Add(l);

                        while(left < right && nums[left] == nums[left + 1]) left += 1;
                        while(left < right && nums[right] == nums[right - 1]) right -= 1;

                        left += 1;
                        right -= 1;
                    }
                    else if(sum < target) left += 1;
                    else right -= 1;
                }
                
            }
        }
        return results.Cast<IList<int>>().ToList();
    }
}