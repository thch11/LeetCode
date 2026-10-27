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
    public IList<int> PostorderTraversal(TreeNode root)
    {
        IList<int> PostOrder = new List<int>();
        Traverse(root);

        void Traverse(TreeNode current)

        {
            if(current == null)
                return;

            Traverse(current.left);

            Traverse(current.right);
            
            PostOrder.Add(current.val);
        }
        return PostOrder;
    }
}
//https://leetcode.com/problems/binary-tree-postorder-traversal
//Nærmest samme opgave som før, skulle bare lige rykkes lidt på rækkefølgen. 
