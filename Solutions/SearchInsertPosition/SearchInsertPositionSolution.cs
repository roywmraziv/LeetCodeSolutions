namespace LeetCodeSolutions.Solutions.SearchInsertPosition;

public class SearchInsertPositionSolution
{
    public int SearchInsert(int[] nums, int target) {
        int end = nums.Length - 1;
        int bgn = 0;
        int mid = bgn + (end - bgn) /2;
        
        if(nums[0] > target){
            return 0;
        }

        
        while(bgn < end)
        {
            if(nums[mid] == target)
            {
                return mid;
            }
            else if(nums[mid] < target)
            {
                bgn = mid + 1;
            }
            else if(nums[mid] > target)
            {
                end = mid;
            }

            mid = bgn + (end - bgn) /2;

        }
        return target <= nums[mid] ? mid: mid + 1;
        

        // if(nums[0] > target)
        // {
        //     return 0;
        // }
        // if(nums[end] < target){
        //     return end + 1;
        // }

        // for(int i = 0; i < nums.Length; i++)
        // {
        //     if(nums[i] == target)
        //     {
        //         return i;
        //     }

        //     if(i > 0 && nums[i] > target && nums[i-1] < target)
        //     {
        //         return i;
        //     }

        //     if(i + 1 < nums.Length && nums[i] < target && nums[i+1] > target )
        //     {
        //         return i + 1;
        //     }
        // }
        // return 800;
    }
}