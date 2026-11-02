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
    public int FindBottomLeftValue(TreeNode root) 
    {
        int returnValue = root.val;
        int deepestLevel = 0;
        
        Traverse(root, 0);
        
        void Traverse(TreeNode current, int level)
        {
            if (current == null)
                return;
            
            if (level > deepestLevel)
            {
                deepestLevel = level;
                returnValue = current.val;
            }
            
            Traverse(current.left, level + 1);
            Traverse(current.right, level + 1);
        }
        
        return returnValue;
    }
}
//https://leetcode.com/problems/find-bottom-left-tree-value
