﻿using New_LeetCode.Structure;

namespace New_LeetCode.Problems;

internal class Q230_KthSmallestElementInABST
{
    public int KthSmallest(TreeNode root, int k)
    {
        var currentIndex = 0;
        return TraverseTree(root, k, ref currentIndex);
    }

    private int TraverseTree(TreeNode node, int k, ref int currentIndex)
    {
        if (node == null) return -1;

        var result = TraverseTree(node.Left, k, ref currentIndex);
        if (result != -1) return result;

        currentIndex++;
        if (currentIndex == k) return node.Val;
            
        result = TraverseTree(node.Right, k, ref currentIndex);
        if (result != -1) return result;

        return -1;
    }
}