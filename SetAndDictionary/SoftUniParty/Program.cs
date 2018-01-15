using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    public class Program
    {
        public static void Main()
        {
            var vip = new SortedSet<string>();
            var regular = new SortedSet<string>();

            while (true)
            {
                var guest = Console.ReadLine();
                if (guest == "PARTY")
                {
                    break;
                }

                bool isVip = IsVip(guest);
                if (isVip)
                {
                   vip.Add(guest);
                }
                else
                {
                    regular.Add(guest);
                }
            }

            while (true)
            {
                var guest = Console.ReadLine();
                if (guest == "END")
                {
                    break;
                }

                bool isVip = IsVip(guest);
                if (isVip)
                {
                    vip.Remove(guest);
                }
                else
                {
                    regular.Remove(guest);
                }
            }

            regular.UnionWith(vip);

            Console.WriteLine(regular.Count);
            foreach (var guest in regular)
            {
                Console.WriteLine(guest);
            }
        }

        private static bool IsVip(string guest)
        {
            var guestAsArray = guest.ToCharArray();
            bool isVip = false;

            if (char.IsDigit(guestAsArray[0]))
            {
                isVip = true;
            }
            return isVip;
        }
    }
}
