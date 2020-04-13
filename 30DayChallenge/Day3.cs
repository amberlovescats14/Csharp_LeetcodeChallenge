using System;
using System.Collections.Generic;
using System.Linq;

namespace _30DayChallenge
{
    public class Day3
    {
        public int MaxSubArray(int[] nums)
        {
            var subArrays = new List<List<int>>();
            var tempList = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                tempList.Clear();
                tempList.Add(nums[i]);
                for (int j = 1; j < nums.Length; j++)
                {
                    tempList.Add(nums[j]);
                    subArrays.Add(tempList);
                }
            }
            return subArrays.Select(l => l.Aggregate(0,(a, b) => a + b)).Max();
        }
    }
}
