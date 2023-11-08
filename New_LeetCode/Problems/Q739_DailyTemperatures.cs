namespace New_LeetCode.Problems;

public class Q739_DailyTemperatures
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var waitDays = new int[temperatures.Length];
        var greaterStack = new Stack<ValueTuple<int, int>>();

        for (var i = temperatures.Length - 1; i > 0; i--)
        {
            greaterStack.Push((temperatures[i], waitDays[i]));
            
            if (temperatures[i - 1] < temperatures[i])
            {
                waitDays[i - 1] = 1;
                continue;
            }

            var totalWaitDays = 0;
            while (greaterStack.Any())
            {
                var (temperature, wait) = greaterStack.Peek();

                if (temperatures[i - 1] < temperature)
                    break;

                totalWaitDays += wait;
                greaterStack.Pop();
            }

            waitDays[i - 1] = (!greaterStack.Any()) ? 0 : totalWaitDays + 1;
        }

        return waitDays;
    }
}