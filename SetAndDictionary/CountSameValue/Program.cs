namespace CountSameValue
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var inputToken = input.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);

            SortedDictionary<double, int> dict = new SortedDictionary<double, int>();

            foreach (var token in inputToken)
            {
                double remainder;
                if (token.Contains(","))
                {
                    remainder = double.Parse(token.Replace(",", "."));
                }
                else
                {
                    remainder = double.Parse(token);
                }

                if (!dict.ContainsKey(remainder))
                {
                    dict.Add(remainder, 1);
                }
                else
                {
                    dict[remainder]++;
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
