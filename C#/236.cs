/*
Lowest Common Ancestor of a Binary Tree

Medium
*/
/*
Explanation
/*
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution236
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == p || root == q || root == null)
            return root;

        var left = LowestCommonAncestor(root.left, p, q);
        var right = LowestCommonAncestor(root.right, p, q);

        if (left != null && right != null)
            return root;
        else
            return left == null ? right : left;
    }
}
