    using System;
using System.Linq;
using System.Text;

namespace _30DayChallenge
{
    public class Day7
    {
        public bool BackspaceCompare(string S, string T)
        {
            var sHashCount = S.Where(c => c == '#').Count();
            var tHashCount = T.Where(c => c == '#').Count();
            return (S.Where(c => c != '#').Count() - sHashCount) ==
                        (T.Where(c => c != '#').Count() - tHashCount);
            //StringBuilder newS = new StringBuilder();
            //for (int i = S.Length-1; i >= 0; i--)
            //{
            //    if(i == 0)
            //        if(i != '#')
            //            if(S[i+1] != '#')
            //        {
            //            newS.Append(S[i]);
            //            break;
            //        }
            //    if (S[i] == '#')
            //    {
            //        i--;
            //        continue;
            //    }
            //    else newS.Append(S[i]);
            //}
            //StringBuilder newT = new StringBuilder();
            //for (int i = S.Length - 1; i >= 0; i--)
            //{
            //    if (i == 0)
            //        if (i != '#')
            //            if(T[i+1] != '#')
            //        {
            //            newT.Append(T[i]);
            //            break;
            //        }
            //    if (T[i] == '#')
            //    {
            //        i--;
            //        continue;
            //    }
            //    else newT.Append(T[i]);
            //}
            //Console.WriteLine("S: "+ newS.ToString());
            //Console.WriteLine("T: "+ newT.ToString());
            //return newS.ToString().Length == newT.ToString().Length;
        }
    }
}

