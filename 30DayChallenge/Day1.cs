using System;
using System.Collections.Generic;
using System.Linq;

namespace _30DayChallenge
{
    public class Day1
    {
        public int SingleNumber(int[] nums)
        {
            //Dictionary<int, int> dictionary = new Dictionary<int, int>();
            //foreach (var item in collection)
            //{

            //}
            var test = nums.Select(n => n).GroupBy(n => n).Where(n => n.Count() == 1).ToList()[0].Key;
            Console.WriteLine(test);

            return 1;
        }
    }
}
