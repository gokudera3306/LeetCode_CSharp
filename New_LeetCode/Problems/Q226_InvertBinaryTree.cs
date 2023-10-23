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

        copyTree = new TreeNode(oldTree.Val);

        TreeNode copyLeftTree;
        CopyTree(oldTree.Right, out copyLeftTree);

        TreeNode copyRightTree;
        CopyTree(oldTree.Left, out copyRightTree);

        copyTree.Left = copyLeftTree;
        copyTree.Right = copyRightTree;
    }
}