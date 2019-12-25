using System;
using System.Text.RegularExpressions;

namespace Number5_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            ResultReg(str);
            ResultMethods(str);
        }
        static void ResultReg(string str)
        {
            Regex RegExp = new Regex(@"\b[A-Z][a-z]*\d{2}\b");
            foreach (Match match in RegExp.Matches(str))
            {
                Console.WriteLine(match);
            }
        }
        static void ResultMethods(string str)
        {
            string[] arr = str.Split(new char[] { ' ', ',', '-', '.' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                char[] array = arr[i].ToCharArray();
                if (Char.IsUpper(array[0]) &&Char.IsLetter(array[array.Length-3])&& Char.IsDigit(array[array.Length - 1]) && Char.IsDigit(array[array.Length - 2]))
                {
                    string newstr = new string(array);
                    Console.WriteLine(newstr);
                }
            }
        }
    }
}
