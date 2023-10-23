using New_LeetCode.Structure;

namespace New_LeetCode.Problems;

public class Q98_ValidateBinarySearchTree
{
    public bool IsValidBST(TreeNode root)
    {
        if (root == null) return true;

        if (root.Left != null && root.Left.Val >= root.Val) return false;
        if (root.Right != null && root.Right.Val <= root.Val) return false;

        if (!IsValidBST(root.Left, null, root.Val)) return false;
        if (!IsValidBST(root.Right, root.Val, null)) return false;

        return true;
    }

    private bool IsValidBST(TreeNode root, int? leftBound, int? rightBound)
    {
        if (root == null) return true;

        if (root.Left != null)
        {
            if (root.Left.Val >= root.Val)
                return false;

            if (leftBound != null && root.Left.Val <= leftBound)
                return false;

        }

        if (root.Right != null)
        {
            if (root.Right.Val <= root.Val)
                return false;

            if (rightBound != null && root.Right.Val >= rightBound)
                return false;
        }

        if (!IsValidBST(root.Left, leftBound, root.Val)) return false;
        if (!IsValidBST(root.Right, root.Val, rightBound)) return false;

        return true;
    }
}