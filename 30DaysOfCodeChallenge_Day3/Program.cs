/*
Day 3: Intro to Conditional Statements

Objective 
In this challenge, we're getting started with conditional statements. Check out the Tutorial tab for learning materials and an instructional video!

Task 
Given an integer, , perform the following conditional actions:

If  is odd, print Weird
If  is even and in the inclusive range of  to , print Not Weird
If  is even and in the inclusive range of  to , print Weird
If  is even and greater than , print Not Weird
Complete the stub code provided in your editor to print whether or not  is weird.

Input Format

A single line containing a positive integer, .

Constraints
1<= n <= 100

Output Format

Print Weird if the number is weird; otherwise, print Not Weird.

Sample Input 0 
3
Sample Output 0

Weird
Sample Input 1

24
Sample Output 1

Not Weird
Explanation

Sample Case 0:  
 is odd and odd numbers are weird, so we print Weird.

Sample Case 1:  
 and  is even, so it isn't weird. Thus, we print Not Weird.

Explanation

Sample Case 0:  
n is odd and odd numbers are weird, so we print Weird.

Sample Case 1:  
n>20 and  is even, so it isn't weird. Thus, we print Not Weird.
*/

using System;

namespace _30DaysOfCodeChallenge_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if ((1 <= N) && (N <= 100))
            {
                if ((N % 2) == 1) Console.WriteLine("Weird");
                if (((N % 2) == 0) && (2 <= N) && (N <= 5)) Console.WriteLine("Not Weird");
                if (((N % 2) == 0) && (6 <= N) && (N <= 20)) Console.WriteLine("Weird");
                if (((N % 2) == 0) && (N > 20)) Console.WriteLine("Not Weird");
            }
        }
    }
}
