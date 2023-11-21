public class Solution 
{
    public bool IsSameTree(TreeNode p, TreeNode q) 
    {
        if (p == null && q ==null)
            return true;
        if (p.val != q.val)
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
