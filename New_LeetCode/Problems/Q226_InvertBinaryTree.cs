using New_LeetCode.Structure;

namespace New_LeetCode.Problems;

internal class Q226_InvertBinaryTree
{
    public TreeNode InvertTree(TreeNode root)
    {
        TreeNode copyTree;
        CopyTree(root, out copyTree);

        return copyTree;
    }

    private void CopyTree(TreeNode oldTree, out TreeNode copyTree)
    {
        copyTree = null;

        if (oldTree == null) return;

        copyTree = new TreeNode(oldTree.val);

        TreeNode copyLeftTree;
        CopyTree(oldTree.right, out copyLeftTree);

        TreeNode copyRightTree;
        CopyTree(oldTree.left, out copyRightTree);

        copyTree.left = copyLeftTree;
        copyTree.right = copyRightTree;
    }
}