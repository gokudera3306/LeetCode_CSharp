using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.Problems
{
    public class Q208_ImplementTrie
    {
        private readonly CharNode root;

        public Q208_ImplementTrie()
        {
            root = new CharNode(' ');
        }

        public void Insert(string word)
        {
            var currentNode = root;

            foreach (var c in word)
            {
                var foundNode = currentNode.FindChar(c);

                if (foundNode == null)
                    currentNode = currentNode.AddChar(c);
                else
                    currentNode = foundNode;
            }

            currentNode.IsEnd = true;
        }

        public bool Search(string word)
        {
            var currentNode = root;

            foreach (var c in word)
            {
                var node = currentNode.FindChar(c);

                if (node == null) return false;

                currentNode = node;
            }

            return currentNode.IsEnd;
        }

        public bool StartsWith(string prefix)
        {
            var currentNode = root;

            foreach (var c in prefix)
            {
                var node = currentNode.FindChar(c);

                if (node == null) return false;

                currentNode = node;
            }

            return true;
        }

        public class CharNode
        {
            private readonly List<CharNode> childNode;

            public char Char { get; private set; }
            public bool IsEnd { get; set; }

            public CharNode(char c)
            {
                Char = c;
                childNode = new List<CharNode>();
            }

            public CharNode FindChar(char target)
            {
                foreach (var node in childNode)
                    if (node.Char == target) return node;

                return null;
            }

            public CharNode AddChar(char c)
            {
                var newNode = new CharNode(c);
                childNode.Add(newNode);

                return newNode;
            }
        }
    }
}
