using System;
using System.Text.RegularExpressions;

namespace Number3I_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Regex RegExp = new Regex(@"\b[0-23]{1,2}\:[0-59]{1,2}\:[0-59]{1,2}\b");
            // Regex RegExp = new Regex(@"\b\d{3}\.\d{3}\.\d\.\d{2}\b");
          //  Regex RegExp = new Regex(@"\w+:\s+[int|short|byte]+\s+\[\d+\]");
            foreach (Match match in RegExp.Matches(str))
            {
                Console.WriteLine(match);
            }
        }
    }
}
