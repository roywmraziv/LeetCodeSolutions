namespace LeetCodeSolutions.Solutions.PathSum;
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
public class PathSumSolution
{
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null){return false;}

        Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();

        queue.Enqueue((root, root.val));

        while(queue.Count != 0)
        {
            (TreeNode current, int currentVal) = queue.Dequeue();

            if(current.left == null && current.right == null)
            {
                if(currentVal == targetSum)
                {
                    return true;
                }
            }

            if(current.left != null)
            {
                queue.Enqueue((current.left, currentVal + current.left.val));
            }

            if(current.right != null)
            {
                queue.Enqueue((current.right, currentVal + current.right.val));
            }
        }

        return false;
    }
}