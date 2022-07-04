using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.Problems
{
    public class Q322_CoinChange
    {
        public int CoinChange(int[] coins, int amount)
        {
            if (amount == 0) return 0;

            var dp = new int[amount + 1];
            dp[0] = 0;

            Array.Sort(coins);

            for (var currentAmount = 1; currentAmount <= amount; currentAmount++)
            {
                dp[currentAmount] = int.MaxValue;

                foreach (var coin in coins)
                {
                    if (currentAmount < coin) break;

                    if (dp[currentAmount - coin] != int.MaxValue)
                        dp[currentAmount] = Math.Min(dp[currentAmount], dp[currentAmount - coin] + 1);
                }
            }

            return dp[amount] == int.MaxValue ? -1 : dp[amount];
        }
    }
}
