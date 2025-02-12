namespace LeetCodeSolutions.Solutions.BinaryTreePreorderTraversal;
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
public class BinaryTreePreorderTraversalSolution
{
    public IList<int> PreorderTraversal(TreeNode root) {
        if(root == null){return [];}

        Stack<TreeNode> stack = new Stack <TreeNode>();
        List<int> list = new List<int>();

        stack.Push(root);

        while(stack.Count() != 0)
        {
            TreeNode current = stack.Pop();

            list.Add(current.val);

            if(current.right != null)
            {
                stack.Push(current.right);
            }

            if(current.left != null)
            {
                stack.Push(current.left);
            }
        }

        return list;
    }
}