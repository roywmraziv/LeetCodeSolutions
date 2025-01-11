namespace LeetCodeSolutions.Solutions.MedianOfTwoSortedArrays;

public class MedianOfTwoSortedArraysSolution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int l = nums1.Length + nums2.Length;
        int[] nums3 = new int[l];

        int i = 0;
        int j = 0;
        int k = 0;

        while(i < nums1.Length || j < nums2.Length)
        {
            if(i < nums1.Length && j < nums2.Length)
            {
                if(nums1[i] < nums2[j])
                {
                    nums3[k]= nums1[i];
                    k++;
                    i++;
                }
                else
                {
                    nums3[k] = nums2[j];
                    k++;
                    j++;
                }
            }
            else if(i < nums1.Length)
            {
                nums3[k] = nums1[i];
                k++;
                i++;
            }
            else
            {
                nums3[k] = nums2[j];
                k++;
                j++;
            }
        }

        if(l % 2 == 1)
        {
            return nums3[(l/2)];
        }
        else
        {
            double median = nums3[l/2] + nums3[l/2 - 1];
            median /= 2;

            return median;

        }
    }
}