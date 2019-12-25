using System;
using System.Text.RegularExpressions;
namespace Number6_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string newstr = string.Empty;
            
            
            Regex RegExp = new Regex(@"\-?\d+\s*[+|\-|*|/]\s*\-?\d+\s*[=]\s*\-?\d+");
            foreach (Match match in RegExp.Matches(str))
            {
                newstr += match;
                Console.WriteLine(match);


            }
                
                str = newstr.Replace(" ", string.Empty);
              //  Console.WriteLine(str);
                string[] str2 = str.Split('+',  '=', '*', '/');
            
                int[] vals = new int[str2.Length];
                for (int i = 0; i < str2.Length; i++)
                {
                    vals[i] = Convert.ToInt32(str2[i]);
                    Console.WriteLine(vals[i] + "  ");
                }
            
               
            
            
        } 
    }
}
