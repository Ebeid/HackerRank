/*
Project Euler - Problem 1 - Multiples of 3 and 5 [ https://projecteuler.net/problem=1 ]

This problem is a programming version of Problem 1 from projecteuler.net
If we list all the natural numbers below  that are multiples of 3 or 5, we get 3,5,6 and 9. The sum of these multiples is 35.
Find the sum of all the multiples of 3 or 5 below N.

Input Format
First line contains  that denotes the number of test cases. This is followed by  lines, each containing an integer, .

Constraints
1 <= T <= 100000
1 <= T <= 1000000000

Output Format
For each test case, print an integer that denotes the sum of all the multiples of 3 or 5 below N.

Sample Input 0
2
10
100

Sample Output 0
23
2318

Explanation 0
For N, if we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Similarly for N = 100, we get 2318.
*/

using System;
using System.Collections.Generic;

namespace ProjectEuler_Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            long input = 0;

            for (int i = 0; i < testCases; i++)
            {
                input = int.Parse(Console.ReadLine());
                input = input-1;
                long n3 = input / 3;
                n3 = n3 * (n3 + 1) / 2;
                long n5 = input / 5;
                n5 = n5 * (n5 + 1) / 2;
                long n15 = input / 15;
                n15 = n15 * (n15 + 1) / 2;

                Console.WriteLine(3*n3 + 5*n5 - 15*n15);
            }
        }
    }
}
