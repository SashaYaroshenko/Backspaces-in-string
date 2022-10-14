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
            string result = "";
            if (String.IsNullOrEmpty(s) != true)
            {
                result = s;
                while (result.Contains("#") == true)
                {
                    for (int i = 0; i < result.Length - 1; i++)
                    {
                        if (result[i] != '#' && result[i+1]=='#')
                        {
                            result = result.Remove(i, 2);
                            if (i != 0) i--;
                        }
                        result = result.TrimStart('#');
                    }
                }
            }
            return result;
        }
    }
}
