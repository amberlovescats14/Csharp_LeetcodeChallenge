using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _30DayChallenge
{
    public class Problems
    {
        public int SingleNumber(int[] nums)
        {
            var keyValues = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (keyValues.ContainsKey(item)) keyValues[item]++;
                else keyValues.Add(item, 1);
            }
            return keyValues.Where(pair => pair.Value == 1).ToList()[0].Key;

        }

        public static string StringLetterCount(string str)
        {
            var regex = new Regex(@"[a-zA-Z]");
            var keyValues = new Dictionary<int, char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (regex.IsMatch(str[i].ToString()))
                {
                    if (keyValues.ContainsValue(str[i]))
                    {
                        var key = keyValues.Where(pair => pair.Value == str[i]).ToList()[0].Key;
                        keyValues.Add(key++, str[i]);
                        keyValues.Remove(key);
                    }
                }
                else keyValues.Add(1, str[i]);
            }
            return string.Join("", keyValues.ToList());
        }

        public string testing(string response)
        {
            var resposeSplitArr = response.Split(" ").ToList();
            var startIndex = 0;
            var endIndex = resposeSplitArr.Count;
            for (int i = 0; i < resposeSplitArr.Count; i++)
            {
                if (resposeSplitArr[i].Contains("Message:")) startIndex = i;
                if(resposeSplitArr[i].Contains("["))
                {
                    endIndex = i;
                    break;
                }
            }
            Console.WriteLine(startIndex);
            Console.WriteLine(endIndex);
            return string.Join(" ", resposeSplitArr.GetRange(startIndex, endIndex-startIndex));
        }
    }
}
