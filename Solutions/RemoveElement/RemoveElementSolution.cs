namespace LeetCodeSolutions.Solutions.RemoveElement;

public class RemoveElementSolution
{
    public int RemoveElement(int[] nums, int val) {
        int k = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == val)
            {
                k++;
            }
            else
            {
                nums[i-k] = nums[i];
            }
        }

        return nums.Length - k;
    }
}