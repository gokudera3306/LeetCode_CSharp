using New_LeetCode.Structure;

namespace New_LeetCode.Problems;

public class Q114_FlattenBinaryTreeToLinkedList
{
    public void Flatten(TreeNode root)
    {
        if (root == null) return;

        Flatten(root.left);
        Flatten(root.right);

        var leftFlattenTree = root.left;
        var rightFlattenTree = root.right;

        root.left = null;

        if (leftFlattenTree != null)
        {
            root.right = leftFlattenTree;

            var lastNode = leftFlattenTree;
            while (lastNode.right != null)
                lastNode = lastNode.right;

            lastNode.right = rightFlattenTree;
        }
    }
}