using System;

namespace Number3_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            MethodAnswer(str);
            ArrayResult(str);


        }
        static void MethodAnswer(string str)
        {
            string[] array = str.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < array.Length / 2; i++)
            {
                string temp = string.Empty;              
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            string resultstring = string.Join(" ", array);
            Console.WriteLine(resultstring + ".");
        }
        static void ArrayResult(string str)
        {
            string newstr = string.Empty;
            char tmp = '0';
            char[] mas = str.ToCharArray();
            
            int Rev = 0;
            for (int i = mas.Length - 2; i >= 0; i--)
            {
                newstr += mas[i];
            }
            newstr += ".";
            //Console.WriteLine(newstr);
            char[] array = newstr.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {

                if (Char.IsWhiteSpace(array[i]) || array[i] == '.')
                {
                    for (int j = Rev, k = i - 1; j < k; j++, k--)
                    {
                        tmp = array[j];
                        array[j] = array[k];
                        array[k] = tmp;
                    }
                    Rev = i + 1;
                }

            }
            string res = new string(array);
            Console.WriteLine(res);


        }

    }
}
