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
    public int SumNumbers(TreeNode root) 
    {
        IList<string> sumList = new List<string>();

        Traverse(root.val.ToString(), root);
        void Traverse(string a, TreeNode current)
        {
            if(current == null)
                return;
            if(current.left == null && current.right == null)
            {
                sumList.Add(a);
                return;
            }

            if(current.left != null)
                Traverse(a + current.left.val.ToString(), current.left);
            if(current.right != null)
                Traverse(a + current.right.val.ToString(), current.right);
        }

        int sum = 0;

        for(int i = 0; i < sumList.Count; i++)
        {
            sum += int.Parse(sumList[i]);
        }
        return sum;
    }
}
//https://leetcode.com/problems/sum-root-to-leaf-numbers
//Også kode skrevet helt fra scratch.. Ret cool, føler jeg er ved at have okay styr på trees og hvordan man navigerer dem. 
