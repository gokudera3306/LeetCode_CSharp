using New_LeetCode.Structure;

namespace New_LeetCode.Problems;

public class Q105_ConstructBinaryTreeFromPreorderAndInorderTraversal
{
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0) return null;
        if (preorder.Length == 1) return new TreeNode(preorder[0]);

        return BuildSubTree(preorder.ToList(), inorder.ToList())!;
    }

    private TreeNode? BuildSubTree(List<int> preorder, List<int> inorder)
    {
        if (inorder.Count == 0) return null;
        if (inorder.Count == 1) return new TreeNode(inorder[0]);

        var rootNumber = preorder.First(inorder.Contains);
        
        var leftTree = BuildSubTree(preorder.Skip(1).ToList(), inorder.Take(inorder.IndexOf(rootNumber)).ToList());
        var rightTree = BuildSubTree(preorder.Skip(1).ToList(), inorder.Skip(inorder.IndexOf(rootNumber) + 1).ToList());
        
        var newNode = new TreeNode(rootNumber, leftTree, rightTree);

        return newNode;
    }
}