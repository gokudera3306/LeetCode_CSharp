using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_LeetCode.Structure;

namespace New_LeetCode.Other;

internal class DFS
{
    public void IterativePreOrder(TreeNode? node)
    {
        if (node == null) return;

        var nodeStack = new Stack<TreeNode>();
        nodeStack.Push(node);

        while (nodeStack.Any())
        {
            var currentNode = nodeStack.Pop();

            Console.Write($"{currentNode.val}, ");

            if (currentNode.right != null)
                nodeStack.Push(currentNode.right);

            if (currentNode.left != null)
                nodeStack.Push(currentNode.left);
        }
    }

    public void IterativePostOrder(TreeNode? node)
    {
        if (node == null) return;

        var stack1 = new Stack<TreeNode>();
        var stack2 = new Stack<TreeNode>();

        stack1.Push(node);

        while (stack1.Count > 0)
        {
            var node1 = stack1.Pop();
            stack2.Push(node1);

            if (node1.left != null)
                stack1.Push(node1.left);

            if (node1.right != null)
                stack1.Push(node1.right);
        }

        while (stack2.Count > 0)
            Console.Write($"{stack2.Pop().val}, ");
    }

    public void IterativeInOrder(TreeNode? node)
    {
        if (node == null) return;

        var nodeStack = new Stack<TreeNode>();
        var current = node;

        while (current != null || nodeStack.Count > 0)
        {
            while (current != null)
            {
                nodeStack.Push(current);
                current = current.left;
            }

            current = nodeStack.Pop();
            Console.Write($"{current.val}, ");
            current = current.right;
        }
    }
}