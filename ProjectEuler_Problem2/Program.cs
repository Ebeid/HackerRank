using System;
using System.Collections;
using System.Collections.Generic;


namespace ProjectEuler_Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            if (iterations > 100000) return;
            long upperBound = 0;
            long result = 0;
            ArrayList results = new ArrayList();

            for (int j = 0; j <iterations; j++)
            {
                upperBound = long.Parse(Console.ReadLine());
                result = 0;
                Dictionary<long, long> fibonacciMemorizedResults = new Dictionary<long, long>();
                for (int i = 0; i < int.MaxValue; i++)
                {
                    if (i <= 1)
                        fibonacciMemorizedResults[i] = i;
                    else
                    {
                        fibonacciMemorizedResults[i] = fibonacciMemorizedResults[i - 1] + fibonacciMemorizedResults[i - 2];
                        if (fibonacciMemorizedResults[i] > upperBound) break;
                        fibonacciMemorizedResults[i - 2] = 0;
                    }

                    if ((fibonacciMemorizedResults[i] % 2) == 0)
                        result = result + fibonacciMemorizedResults[i];
                }
                results.Add(result);
            }
            foreach (var item in results)
                Console.WriteLine(item.ToString());
        }
    }
}
