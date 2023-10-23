namespace New_LeetCode.Problems;

internal class Q53MaximumSubarray
{
    class Node
    {
        public int Sum;

        public void Add(int newNum)
        {
            Sum += newNum;
        }

        public Node(int num)
        {
            Sum = num;
        }

        public override string ToString()
        {
            return Sum.ToString();
        }
    }

    public int MaxSubArray(int[] nums)
    {

        if (nums.Length == 1) return nums[0];

        var nodes = new List<Node>();
        var isPositive = nums[0] >= 0;

        var tempNode = new Node(nums[0]);
        for (var x = 1; x < nums.Length; x++)
        {
            if ((nums[x] >= 0 && isPositive) || (nums[x] < 0 && !isPositive))
                tempNode.Add(nums[x]);
            else
            {
                nodes.Add(tempNode);
                tempNode = new Node(nums[x]);
                isPositive = !isPositive;
            }
        }

        nodes.Add(tempNode);

        if (nodes.Count == 1 && nodes[0].Sum < 0)
        {
            Array.Sort(nums);
            return nums[nums.Length - 1];
        }

        //foreach(var i in nodes)
        //    Console.WriteLine(i.ToString());

        var maxSum = 0;

        for (var x = 0; x < nodes.Count; x++)
        {
            if (nodes[x].Sum < 0) continue;

            var rSum = FindMaxSumRight(nodes, x);
            var lSum = FindMaxSumLeft(nodes, x);

            if (rSum + lSum + nodes[x].Sum > maxSum)
                maxSum = rSum + lSum + nodes[x].Sum;
        }


        //Console.WriteLine(rSum + " " + lSum);

        return maxSum;
    }

    private int FindMaxSumRight(List<Node> nodes, int index)
    {
        var maxResult = 0;

        var tempSum = 0;

        if (nodes.Count - 1 > index)
        {
            for (var x = index + 1; x < nodes.Count; x += 2)
            {
                if (x + 1 < nodes.Count)
                {
                    tempSum += nodes[x].Sum + nodes[x + 1].Sum;

                    if (tempSum > maxResult)
                        maxResult = tempSum;
                }
            }
        }

        return maxResult;
    }

    private int FindMaxSumLeft(List<Node> nodes, int index)
    {
        var maxResult = 0;

        var tempSum = 0;

        if (index > 0)
        {
            for (var x = index - 1; x >= 0; x -= 2)
            {
                if (x - 1 >= 0)
                {
                    tempSum += nodes[x].Sum + nodes[x - 1].Sum;

                    if (tempSum > maxResult)
                        maxResult = tempSum;
                }
            }
        }

        return maxResult;
    }
}