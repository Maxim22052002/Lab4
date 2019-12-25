using System;

namespace Number4_4_
{
    class Program
    {
        
        
            static void Main(string[] args)
            {
                string str = Console.ReadLine();
                MethodsResult(str);
                Console.WriteLine();
                ArrayResult(str);

            }
            static void MethodsResult(string str)
            {
                string[] array = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int num = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    bool flag = true;
                if ((array[i].EndsWith(",")) || (array[i].EndsWith(".")))
                {
                    flag = false;
                }
                if ((array[i] != "-") && flag)
                    {
                        array[i] += ("(" + num + ")");
                        num++;

                    }
                if (flag == false&&array[i].EndsWith("."))
                {
                    array[i] = array[i].Remove(array[i].Length - 1);
                    array[i] += ("(" + num + ").");
                    num++;
                }
                if (flag == false && array[i].EndsWith(","))
                {
                    array[i] = array[i].Remove(array[i].Length - 1);
                    array[i] += ("(" + num + "),");
                    num++;
                }
            }
                string newstr = string.Join(" ", array);
                Console.Write(newstr);
            //string[] array = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //int num = 1;
            //for (int i = 0; i < array.Length; i++)
            //{

            //    if (array[i].EndsWith("."))
            //    {
            //        array[i] = array[i].Remove(array[i].Length - 1);
            //        array[i] += ("(" + num + ").");
            //        num++;
            //    }
            //    if ((array[i] != "-"))
            //    {
            //        array[i] += ("(" + num + ")");
            //        num++;

            //    }
            //    //if (flag == false)
            //    //{
            //    // array[i] = array[i].Remove(array[i].Length - 1);
            //    // array[i] += ("(" + num + "),") ;
            //    // num++;
            //    //}







            }
            static void ArrayResult(string str)
            {
                string newstr = string.Empty;
                char[] mas = str.ToCharArray();
                int num = 1;
                for (int i = 0; i < mas.Length; i++)
                {
                    newstr += mas[i];
                    if (((Char.IsLetter(mas[i])) && (Char.IsWhiteSpace(mas[i + 1]))) || ((Char.IsLetter(mas[i])) && (mas[i + 1] == '.')) || ((Char.IsLetter(mas[i]) && (mas[i + 1] == ','))))
                    {
                        newstr += ("(" + num + ")");
                        num++;

                    }

                }
                Console.WriteLine(newstr);

            }


        
    }
}
