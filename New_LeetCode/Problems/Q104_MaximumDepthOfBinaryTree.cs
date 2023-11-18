using New_LeetCode.Structure;

namespace New_LeetCode.Problems;

internal class Q104MaximumDepthOfBinaryTree
{
    public int MaxDepth(TreeNode root)
    {
        if (root is null) return 0;

        var maxDepth = FindMaxDepth(root);

        return maxDepth;
    }

    public int FindMaxDepth(TreeNode root)
    {
        int leftDepth, rightDepth;

        if (root.left is null)
            leftDepth = 1;
        else
            leftDepth = FindMaxDepth(root.left) + 1;

        if (root.right is null)
            rightDepth = 1;
        else
            rightDepth = FindMaxDepth(root.right) + 1;

        return leftDepth > rightDepth ? leftDepth : rightDepth;
    }
}