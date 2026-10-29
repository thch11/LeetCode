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
    public bool HasPathSum(TreeNode root, int targetSum) 
    {
        bool sumReached = false;

        Traverse(root, 0);
        void Traverse(TreeNode current, int sum)
        {
            if(current == null)
                return;
            if(current.left == null && current.right == null && sum + current.val == targetSum)
            {
                sumReached = true;
                return;
            }

            Traverse(current.left, current.val + sum);
            Traverse(current.right, current.val + sum);         
        }
        return sumReached;
    }
}
//https://leetcode.com/problems/path-sum
