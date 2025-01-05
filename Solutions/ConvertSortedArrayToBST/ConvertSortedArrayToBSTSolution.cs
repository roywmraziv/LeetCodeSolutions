namespace LeetCodeSolutions.Solutions.ConvertSortedArrayToBST;
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
public class ConvertSortedArrayToBSTSolution
{
    public TreeNode SortedArrayToBST(int[] nums) 
    {
        return BuildBST(nums, 0, nums.Length - 1);
    }
    public TreeNode BuildBST(int[] nums, int start, int end)
    {
        if(start > end){return null;}

        int mid = (start + end) / 2;

        var current = new TreeNode();
        current.val = nums[mid];

        current.left = BuildBST(nums, start, mid-1);
        current.right = BuildBST(nums, mid + 1, end);

        return current;
    }
}