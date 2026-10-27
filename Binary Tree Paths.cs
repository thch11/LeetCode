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
    public IList<string> BinaryTreePaths(TreeNode root) 
    {
        IList<string> returnList = new List<string>();
        if(root == null)
            return returnList;
        if(root.left == null && root.right == null)
        {
            returnList.Add(root.val.ToString());
            return returnList;
        }
        
        Traverse(root.val.ToString(), root);

        void Traverse(string a, TreeNode current)
        {
            if(current == null)
                return;

            if(current.left == null && current.right == null)
            {
                returnList.Add(a);
                return; 
            }

            if (current.left != null)
                Traverse(a + "->" + current.left.val, current.left);

            if (current.right != null)
                Traverse(a + "->" + current.right.val, current.right);
        }   
        
        return returnList; 
    }
}
//https://leetcode.com/problems/binary-tree-paths
