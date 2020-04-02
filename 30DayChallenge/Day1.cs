using System;
using System.Linq;

namespace _30DayChallenge
{
    public class Day1
    {
        public int SingleNumber(int[] nums)
        {
            return nums.Select(n => n)
                .GroupBy(n => n)
                .Where(n => n.Count() == 1)
                .ToList()[0].Key;
        }
    }
}
