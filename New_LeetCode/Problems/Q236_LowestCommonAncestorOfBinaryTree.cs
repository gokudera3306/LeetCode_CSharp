using New_LeetCode.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_LeetCode.Problems
{
    internal class Q236_LowestCommonAncestorOfBinaryTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var nodeStack = new Stack<TreeNode>();

            var isFoundCount = 0; 
            traverse(root, p, q, nodeStack, ref isFoundCount);

            return nodeStack.Pop();
        }

        private void traverse(TreeNode? current, TreeNode treeNode, TreeNode treeNode1, Stack<TreeNode> nodeStack, ref int isFoundCount)
        {
            if (isFoundCount == 2) return;
            if (current == null) return;

            var hasPush = false;
            
            if (isFoundCount < 1)
            {
                hasPush = true;
                nodeStack.Push(current);
                
                Console.WriteLine("Stack: " + string.Join(',', nodeStack.Select(_ => _.val)));
            }

            if (current.Equals(treeNode) || current.Equals(treeNode1)) isFoundCount++;
            if (isFoundCount == 2) return;
            
            traverse(current.left, treeNode, treeNode1, nodeStack, ref isFoundCount);
            if (isFoundCount == 2) return;
            
            traverse(current.right, treeNode, treeNode1, nodeStack, ref isFoundCount);
            if (isFoundCount == 2) return;

            if (hasPush)
                nodeStack.Pop();
        }
        
        //TODO: Better solution
    }
}
