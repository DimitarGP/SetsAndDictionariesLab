using System.Collections.Generic;
using System.IO;

namespace ChekPerformanceSetList
{
    using System;

    public class Program
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            HashSet<string> set = new HashSet<string>();
            var specialString = GetRandomString();
            var random = new Random();
            int number = random.Next(0, 1000000);

            AddToCollection(specialString, number, list);
            AddToCollection(specialString, number, set);

            SearchInCollection(specialString, list);
            SearchInCollection(specialString, set);

            RemoveFromCollection(specialString, list);
            RemoveFromCollection(specialString, set);

            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 1000000; i++)
            {
                if (i == number)
                {
                   
                }
            }


        }
    }
}
