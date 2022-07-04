using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.Problems
{
    public class Q138_CopyListWithRandomPointer
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;

            var nodeDictionary = new Dictionary<Node, Node>();

            var newHead = new Node(head.val);
            nodeDictionary.Add(head, newHead);

            var currentNode = head.next;
            var newCurrentNode = newHead;

            while (currentNode != null)
            {
                var newNode = new Node(currentNode.val);
                nodeDictionary.Add(currentNode, newNode);

                newCurrentNode.next = newNode;
                newCurrentNode = newCurrentNode.next;

                currentNode = currentNode.next;
            }

            currentNode = head;
            newCurrentNode = newHead;

            while (currentNode != null)
            {
                if (currentNode.random != null)
                    newCurrentNode.random = nodeDictionary[currentNode.random];

                currentNode = currentNode.next;
                newCurrentNode = newCurrentNode.next;
            }

            return newHead;
        }

        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }
    }
}
