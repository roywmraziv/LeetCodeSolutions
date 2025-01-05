namespace LeetCodeSolutions.Solutions.BinaryTreeInorderTraversal;

// Definition for a binary tree node.
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
public class BinaryTreeInorderTraversalSolution
{
    public IList<int> InorderTraversal(TreeNode root) {

        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        List<int> result = new List<int>();

        while(current != null || stack.Count != 0)
        {
            while(current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            result.Add(current.val);
            current = current.right;
        }

        return result;



    }
}