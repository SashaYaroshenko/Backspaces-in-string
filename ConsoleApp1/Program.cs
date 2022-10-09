using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.CleanString("abc#d##c");
        }
    }

    public class Kata
    {
        public static string CleanString(string s)
        {
            string result = ""; // for the difference between main and newBranch
            int countBackSp = s.Count(x => x == '#');
            int countLetter = s.Count(x => Char.IsLetter(x));
            if(String.IsNullOrEmpty(s))
            {
                return "";
            }
            if(countBackSp > countLetter)
            {
                return "";
            }
            else
            {
                for(int i = 1; i < s.Length; i++)
                {
                    if (s[i]=='#')
                    { 
                        s = s.Remove(i - 1, 2);
                        i -= 2;
                    }
                   
                }
            }
            return s;
        }
    }
}
