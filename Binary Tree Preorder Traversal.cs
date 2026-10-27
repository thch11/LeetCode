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
    public IList<int> PreorderTraversal(TreeNode root) 
    {
        IList<int> PreOrder = new List<int>();

        Traverse(root);
        void Traverse(TreeNode current)
        {
            if(current == null)
                return;
            PreOrder.Add(current.val);

            Traverse(current.left);
            Traverse(current.right);
        }
        return PreOrder;
    }
}
//https://leetcode.com/problems/binary-tree-preorder-traversal
//Løst på like 2 minutter.. Ret cool, skrevet helt fra bunden, ikke engang lånt kode fra alle de andre opgaver.. Ret stolt. :)
