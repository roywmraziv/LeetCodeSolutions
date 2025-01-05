namespace LeetCodeSolutions.Solutions.MaximumDepthOfBinaryTree;
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
public class MaximumDepthOfBinaryTreeSolution
{
    public int MaxDepth(TreeNode root) {
        if(root == null){return 0;}
        Stack<(TreeNode, int)> stack = new Stack<(TreeNode,int)>();

        stack.Push((root, 1));

        int maxDepth = 0;
        //int currentDepth = 1;


        //var visited = new HashSet<TreeNode>();

        while(stack.Count != 0)
        {
            (TreeNode current, int currentDepth) = stack.Pop();
            if((current.left == null && current.right == null))
            {
                if(currentDepth > maxDepth)
                {
                    maxDepth = currentDepth;
                }
            }
                
            //visited.Add(current);

            if(current.left != null)
            {
                stack.Push((current.left, currentDepth + 1));
            }
            if(current.right != null)
            {
                stack.Push((current.right, currentDepth + 1));
            }

        }
        return maxDepth;
    }
}