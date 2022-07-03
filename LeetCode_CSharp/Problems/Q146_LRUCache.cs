using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.Problems
{
    public class Q146_LRUCache
    {
        private readonly Dictionary<int, CacheNode> cacheDic;
        private CacheNode Tail;
        private CacheNode Head;
        private int capacity;

        public Q146_LRUCache(int capacity)
        {
            cacheDic = new Dictionary<int, CacheNode>();
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            if (!cacheDic.TryGetValue(key, out CacheNode cache)) return -1;

            UpdateCache(cache);
            return cache.Value;
        }

        private void UpdateCache(CacheNode cache)
        {
            if (Head == cache) return; // Still First

            if (Head == null || Tail == null) // No Cache
            {
                Head = cache;
                Tail = cache;
                return;
            }

            if (Head == Tail) // One Cache
            {
                Head = cache;

                if (capacity == 1)
                {
                    var tailKey = Tail.Key;
                    cacheDic.Remove(tailKey);
                    Tail = cache;
                    return;
                }

                Tail.RightNode = Head;
                Head.LeftNode = Tail;
                return;
            }

            var leftNode = cache.LeftNode;
            var rightNode = cache.RightNode;

            if (leftNode != null)
                leftNode.RightNode = rightNode;

            if (rightNode != null)
                rightNode.LeftNode = leftNode;

            if (Tail == cache)
                Tail = cache.RightNode;

            Head.RightNode = cache;
            cache.LeftNode = Head;
            cache.RightNode = null;
            Head = cache;

            if (cacheDic.Count > capacity)
            {
                var tailKey = Tail.Key;
                cacheDic.Remove(tailKey);
                Tail = Tail.RightNode;

                if (Tail != null)
                    Tail.LeftNode = null;
            }
        }

        public void Put(int key, int value)
        {
            if (cacheDic.TryGetValue(key, out CacheNode cache))
            {
                cache.Value = value;
                UpdateCache(cache);
            }
            else
            {
                var newCache = new CacheNode(key, value);
                cacheDic[key] = newCache;
                UpdateCache(newCache);
            }
        }

        class CacheNode
        {
            public CacheNode RightNode;
            public CacheNode LeftNode;

            public int Key;
            public int Value;

            public CacheNode(int key, int value)
            {
                Key = key;
                Value = value;
            }
        }
    }
}
