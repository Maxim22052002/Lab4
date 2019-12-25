using System;

namespace Number2_4__Clear_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[2];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
           // MethodsResult(array);
            Console.WriteLine();
            ArrayResult(array);
        }
        static void MethodsResult(string[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                string[] arr = mas[i].Split(new char[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j].EndsWith(".com", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.Write(mas[i]);
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }
        static void ArrayResult( string[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                bool mark = false;
                for (int j = 0; j < mas[i].Length-3; j++)
                {
                    if ((mas[i][j] == '.') && (mas[i][j + 1] == 'c')|| (mas[i][j + 1] == 'C') && (mas[i][j + 2] == 'o')|| (mas[i][j + 2] == 'O')&&(mas[i][j + 3] == 'm')|| (mas[i][j + 3] == 'M')&& (mas[i][j + 4] == ' '))
                    {
                        mark = true;
                        break;
                    }
                    
                }
                if (mark)
                {
                    Console.WriteLine(mas[i]);
                }

            }
        }
    }
}
