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
    public int MaxDepth(TreeNode root) 
    {
        List<int> IndexList = new List<int>();
        void Traverse(TreeNode current, int index)
        {

            if(current == null)
            {
                return;
            }
            Traverse(current.left, index + 1);

            Traverse(current.right, index + 1);
            IndexList.Add(index);
        }
        Traverse(root, 1);
        int highest = 0;
        for(int i = 0; i < IndexList.Count; i++)
        {
            if(IndexList[i] > highest)
                highest = IndexList[i];
        }      
        return highest; 
    }
}
//https://leetcode.com/problems/maximum-depth-of-binary-tree
//on a roll med tree opgaver, helt uden hjælp den her. Selvom min løsning måske ikke er den bedste, er den nu okay. 
