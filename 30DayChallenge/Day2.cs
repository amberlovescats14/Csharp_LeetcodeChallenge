using System;
namespace _30DayChallenge
{
    public class Day2
    {

        public bool IsHappy(int n)
        {
            var isOne = false;
            var maxCount = 10000;
            var count = 0;
            var replacment = n;
            while (count != maxCount)
            {
                var rString = replacment.ToString();
                var sum = 0;
                for (int i = 0; i < rString.Length; i++)
                {
                    sum += (int)Math.Pow(int.Parse(rString[i].ToString()), 2);
                }
                if(sum == 1)
                {
                    isOne = true;
                    break;
                }
                replacment = sum;
                count++;
            }
            return isOne;
        }
    }
}
