using New_LeetCode.Structure;

namespace New_LeetCode.Problems;

public class Q98_ValidateBinarySearchTree
{
    public bool IsValidBST(TreeNode root)
    {
        if (root == null) return true;

        if (root.left != null && root.left.val >= root.val) return false;
        if (root.right != null && root.right.val <= root.val) return false;

        if (!IsValidBST(root.left, null, root.val)) return false;
        if (!IsValidBST(root.right, root.val, null)) return false;

        return true;
    }

    private bool IsValidBST(TreeNode root, int? leftBound, int? rightBound)
    {
        if (root == null) return true;

        if (root.left != null)
        {
            if (root.left.val >= root.val)
                return false;

            if (leftBound != null && root.left.val <= leftBound)
                return false;

        }

        if (root.right != null)
        {
            if (root.right.val <= root.val)
                return false;

            if (rightBound != null && root.right.val >= rightBound)
                return false;
        }

        if (!IsValidBST(root.left, leftBound, root.val)) return false;
        if (!IsValidBST(root.right, root.val, rightBound)) return false;

        return true;
    }
}