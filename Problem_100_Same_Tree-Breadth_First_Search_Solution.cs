/*
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
public class BreadthFirstSearch
{
    public int val;
    public BreadthFirstSearch left;
    public BreadthFirstSearch right;

    public BreadthFirstSearch(int val = 0, BreadthFirstSearch left = null, BreadthFirstSearch right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;
        if (p == null || q == null || p.val != q.val)
            return false;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(p);
        queue.Enqueue(q);

        while (queue.Count > 0)
        {
            TreeNode nodeP = queue.Dequeue();
            TreeNode nodeQ = queue.Dequeue();

            if (nodeP == null && nodeQ == null)
                continue;
            if (nodeP == null || nodeQ == null || nodeP.val != nodeQ.val)
                return false;

            queue.Enqueue(nodeP.left);
            queue.Enqueue(nodeQ.left);
            queue.Enqueue(nodeP.right);
            queue.Enqueue(nodeQ.right);
        }

        return true;
    }
}