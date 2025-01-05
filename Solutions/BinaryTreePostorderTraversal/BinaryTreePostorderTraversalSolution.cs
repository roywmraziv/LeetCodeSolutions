namespace LeetCodeSolutions.Solutions.BinaryTreePostorderTraversal;
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
public class BinaryTreePostorderTraversalSolution
{
    public IList<int> PostorderTraversal(TreeNode root) {
        if(root == null){return [];}
        Stack<TreeNode> stack1 = new Stack<TreeNode>();
        Stack<TreeNode> stack2 = new Stack<TreeNode>();
        List<int> list = new List<int>();

        stack1.Push(root);

        while(stack1.Count() != 0)
        {
            TreeNode current = stack1.Pop();
            stack2.Push(current);

            if(current.left != null)
            {
                stack1.Push(current.left);
            }

            if(current.right != null)
            {
                stack1.Push(current.right);
            }
        }
        while(stack2.Count() != 0)
        {
            TreeNode current = stack2.Pop();
            list.Add(current.val);

        }
        return list;
    }
}