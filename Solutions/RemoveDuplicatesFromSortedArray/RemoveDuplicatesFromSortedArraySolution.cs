namespace LeetCodeSolutions.Solutions.RemoveDuplicatesFromSortedArray;

public class RemoveDuplicatesFromSortedArraySolution
{
    public int RemoveDuplicates(int[] nums) {
        int k = 0;
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] != nums[k])
            {
                k++;
                nums[k] = nums[i];
            }
        }

        return k + 1;
    }
}

// original attempt below
/*int count = 1;

        int[] newList = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++)
        {
            if(i == 0)
            {
                newList[0] = nums[0];
            }
            else if(newList[i-count] == nums[i])
            {
                count++;
                continue;
            }
            else
            {
                newList[i - count + 1] = nums[i];
            }
        }

        for(int i = 0; i < nums.Length; i++){
            nums[i] = newList[i];
        }
        return nums.Length - count + 1;*/