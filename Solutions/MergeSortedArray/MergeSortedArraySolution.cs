namespace LeetCodeSolutions.Solutions.MergeSortedArray;

public class MergeSortedArraySolution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) {

        // foreach(int x in nums2){
        //         nums1[m] = x;
        //         m++;
        //     }

        // Array.Sort(nums1);

        int i = 0;
        int j = m;
        int k = m;

        
        if(m == 0){
            //nums1 = nums2;
            foreach(int x in nums2){
                nums1[j] = x;
                j++;
            }
        }
        else if (n >= 1){
            foreach(int x in nums2){
                nums1[j] = x;
                j++;
            }
            Array.Sort(nums1);

            int temp;

            while(i < m && k < m + n){
                if(nums1[i] > nums1[k]){
                    temp = nums1[i];
                    nums1[i] = nums1[k];
                    nums1[k] = temp;
                    k++;
                    i++;
                }
                else{
                    i++;
                    k++;
                }
            }
        }
        

    }
}