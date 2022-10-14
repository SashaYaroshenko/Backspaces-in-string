using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.CleanString("abc####d##c#");
        }
    }

    public class Kata
    {
        public static string CleanString(string s)
        {
            while (s.Contains("#") == true)
            {
                s = Regex.Replace(s, @"(\A[#])|([^#]#)", "");
            }
            return s;
        }
    }
}


