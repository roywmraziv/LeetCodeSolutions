namespace LeetCodeSolutions.Solutions.MinimumDepthOfBinaryTree;
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
// can be improved using a queue and returning first instance of hittting leaf node
public class MinimumDepthOfBinaryTreeSolution
{
    public int MinDepth(TreeNode root) {
        if(root == null){return 0;}

        Stack<(TreeNode, int)> stack = new Stack<(TreeNode, int)>();

        stack.Push((root,1));

        int minDepth = 1000000;

        while(stack.Count != 0)
        {
            (TreeNode current, int currentDepth) = stack.Pop();

            if(current.left == null && current.right == null)
            {
                if(currentDepth < minDepth)
                {
                    minDepth = currentDepth;
                }
            }

            if(current.left != null)
            {
                stack.Push((current.left, currentDepth + 1));
            }
            if(current.right != null)
            {
                stack.Push((current.right, currentDepth+ 1));
            }
        }
        return minDepth;
    }
}