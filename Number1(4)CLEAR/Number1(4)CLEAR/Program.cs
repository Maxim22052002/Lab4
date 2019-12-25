using System;

namespace Number1_4_CLEAR
{
    class Program
    {
        
            static void Main(string[] args)
            {
                 string str = Console.ReadLine();
                 StrArray(str);
                 Console.WriteLine();
                 StrMethods(str);
            
            }
            static void StrArray(string str)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    bool mark = true;
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[i] == str[j] && i != j)
                        {
                            mark = false;
                            break;
                        }
                    }
                    if (mark)
                    {
                        Console.Write(str[i] + " ");
                    
                    }

                }

            }
            static void StrMethods(string str)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str.IndexOf(str[i]) == str.LastIndexOf(str[i]))
                    {
                        Console.Write(str[i] + " ");
                    }

                }
            }
    }
}
    

