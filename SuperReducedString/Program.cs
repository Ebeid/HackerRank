using System;
using System.Collections;

namespace SuperReducedString
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputString = Console.ReadLine();
            while (IsReducible(inputString))
                inputString = Reduce(inputString);

            if (string.IsNullOrWhiteSpace(inputString))
                Console.WriteLine("Empty String");
            else
                Console.WriteLine(inputString);
        }

        static bool IsReducible(string input)
        {
            if (String.IsNullOrWhiteSpace(input)) return false;
            char[] inputArray = input.ToCharArray();
            for(int i = 1; i<input.Length; i++)
            {
                if (inputArray[i - 1] == inputArray[i])
                    return true;
            }
            return false;
        }

        static string Reduce(string input)
        {
            if ((String.IsNullOrWhiteSpace(input)) || (input.Length == 1)) return input;
            char[] inputArray = input.ToCharArray();
            int j = 0;
            string strOutput = string.Empty;
            for (int i = 0; i < input.Length-1; i++)
            {
                if (inputArray[i] == inputArray[i + 1])
                {
                    j = i;
                    break;
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (i == j)
                {
                    i++;
                    continue;
                }
                strOutput = String.Concat(strOutput, inputArray[i].ToString());
            }
            return strOutput;
        }
        static string RemoveDuplicates(string input)
        {
            if ((String.IsNullOrWhiteSpace(input)) || (input.Length == 1)) return input;
            char[] inputArray = input.ToCharArray();
            ArrayList output = new ArrayList();
            string strOutput = string.Empty;
            for (int i = 1; i < input.Length; i++)
            {
                if ((inputArray[i-1] == inputArray[i]) && ( i != input.Length-1 ))
                    continue;
                output.Add(inputArray[i-1]);
            }
            foreach (var item in output)
                strOutput = String.Concat(strOutput, item.ToString());
            
            return strOutput;
        }
    }
}
