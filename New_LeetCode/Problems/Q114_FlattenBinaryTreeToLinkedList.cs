using New_LeetCode.Structure;

namespace New_LeetCode.Problems;

public class Q114_FlattenBinaryTreeToLinkedList
{
    public void Flatten(TreeNode root)
    {
        if (root == null) return;

        Flatten(root.Left);
        Flatten(root.Right);

        var leftFlattenTree = root.Left;
        var rightFlattenTree = root.Right;

        root.Left = null;

        if (leftFlattenTree != null)
        {
            root.Right = leftFlattenTree;

            var lastNode = leftFlattenTree;
            while (lastNode.Right != null)
                lastNode = lastNode.Right;

            lastNode.Right = rightFlattenTree;
        }
    }
}