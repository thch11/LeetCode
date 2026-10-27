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
    public bool IsSameTree(TreeNode p, TreeNode q) 
    {
        List<int?> Left = new List<int?>();
        List<int?> Right = new List<int?>();
        TraverseLeft(p);
        TraverseRight(q);
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

            TraverseRight(node.left);

            TraverseRight(node.right);
        }
        for(int i = 0; i < Left.Count; i++)
        {
            if(Left[i] != Right[i])
                return false;
        }

        return true;
    }
}
//Ja.. Mine metoder har ikke så gode navne, men det er fordi at det er taget direkte ud af Symmetric Tree, det er jo næsten samme problem..
//https://leetcode.com/problems/same-tree
