/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) 
    {
        List<int?> Left = new List<int?>();
        List<int?> Right = new List<int?>();
        TraverseLeft(root);
        TraverseRight(root);
        void TraverseLeft(TreeNode node)
        {
            if (node == null) 
            {
                Left.Add(null);
                return; 
            }

            Left.Add(node.val);

            TraverseLeft(node.left);

            TraverseLeft(node.right);
        }
        void TraverseRight(TreeNode node)
        {
            if (node == null) 
            {
                Right.Add(null);
                return; 
            }

            Right.Add(node.val);

            TraverseRight(node.right);

            TraverseRight(node.left);
        }
        for(int i = 0; i < Left.Count; i++)
        {
            if(Left[i] != Right[i])
                return false;
        }

        return true;
    }
}
//https://leetcode.com/problems/symmetric-tree
//Lavet lige efter den med phone numbers.. Det slog bare lige klik med hvordan det her recursion virker, lol. 
