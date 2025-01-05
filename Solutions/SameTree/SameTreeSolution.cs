namespace LeetCodeSolutions.Solutions.SameTree;

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
public class SameTreeSolution
{
    public bool IsSameTree(TreeNode p, TreeNode q) 
    {
        if( p == null && q == null){return true;}
        if ( p == null || q == null){return false;}

        TreeNode node1 = p;
        TreeNode node2 = q;

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

            stack.Push((node1.left, node2.left));
            stack.Push((node1.right, node2.right));
        }
        return true;
    }
}