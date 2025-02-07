namespace LeetCodeSolutions.Solutions._3Sum;

public class ThreeSumSolution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        List<List<int>> results = new List<List<int>>();

        if (nums.Length == 3) // catch the edge case 
        {
            if (nums[0] + nums[1] + nums[2] == 0)
            {
                results.Add(nums.ToList()); // Convert int[] to List<int>
                return results.Cast<IList<int>>().ToList(); // Convert to IList<IList<int>>
            }
            else
            {
                return results.Cast<IList<int>>().ToList(); // Convert to IList<IList<int>>
            }
        }

        for(int i = 0; i < nums.Length - 3; i++)
        {
            if(i > 0 && nums[i] == nums[i-1]) continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while(left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                
                if(sum == 0)
                {
                    var l = new List<int> {nums[i], nums[left], nums[right]};
                    results.Add(l);

                    while(left < right && nums[left] == nums[left + 1]) left += 1;
                    while(left < right && nums[right] == nums[right - 1]) right -= 1;
                    left += 1;
                    right -= 1;
                }
                else if(sum < 0) left += 1;
                else right -= 1;
            }
        }

        return results.Cast<IList<int>>().ToList();
    }
}