namespace LeetCodeSolutions.Solutions.SymmetricTree;
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
public class SymmetricTreeSolution
{
    public bool IsSymmetric(TreeNode root) {
        {
            TreeNode p = root.left;
            TreeNode q = root.right;
            if( p == null && q == null){return true;}
            if ( p == null || q == null){return false;}

            TreeNode node1 = root.left;
            TreeNode node2 = root.right;

            Stack<(TreeNode node1, TreeNode node2)> stack = new Stack<(TreeNode, TreeNode)>();
            stack.Push((node1, node2));

            while(stack.Count != 0)
            {
                (node1, node2) = stack.Pop();

                if(node1 == null && node2 == null)
                {
                    continue;
                }
                if(node1 == null || node2 == null)
                {
                    return false;
                }

                if(node1.val != node2.val)
                {
                    return false;
                }

                stack.Push((node1.left, node2.right));
                stack.Push((node1.right, node2.left));
            }
            return true;
        }
    }
}