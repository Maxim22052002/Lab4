using System;
using System.Collections.Generic;
namespace Number1I_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polibiu Encrypton : ");
            string message = Console.ReadLine();
            EncryptonPolibiu(message);
            Console.WriteLine();
            Console.WriteLine("Polibiu Decription : ");
            string message1 = Console.ReadLine();
            DecriptionPolibiu(message1);
            //Console.WriteLine();
            //Console.WriteLine("Gronsfeld: ");
            //string text = Console.ReadLine();
            //string key = Console.ReadLine();
            //Gronsfeld(text,key);
            //Console.WriteLine();
            //Console.WriteLine("BookCipher: ");
            //string str1 = Console.ReadLine();
            //BookCipher(str1);


        }
        static void EncryptonPolibiu(string message)
        {
            
            
                char[,] alfrus = { {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё'},
                                   {'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М'},
                                   {'Н', 'О', 'П', 'Р', 'С', 'Т', 'У'},
                                   {'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ'},
                                   {'Ы', 'Ь', 'Э', 'Ю', 'Я', '0', '1'},
                                   { '2','3', '4', '5', '6', '7', '8'},
                                   {'9', ' ', ',', '.', '!', '?', ';'}
                               };


                
                
                string new_message = "";



                for (int i = 0; i < message.Length; i++)
                {
                for (int j = 0; j < alfrus.GetLength(0); j++)
                {
                    for (int k = 0; k < alfrus.GetLength(1); k++)
                    {
                        if (Char.ToLower(alfrus[j, k]) == message[i] || Char.ToUpper(alfrus[j, k]) == message[i])
                        {
                            new_message += (Convert.ToString(j) + Convert.ToString(k));
                            break;
                        }   
                    }
                    
                }
                }
                Console.WriteLine(new_message);
        }
        static void DecriptionPolibiu(string message1)
        {
            char[,] alfrus = {     {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё'},
                                   {'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М'},
                                   {'Н', 'О', 'П', 'Р', 'С', 'Т', 'У'},
                                   {'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ'},
                                   {'Ы', 'Ь', 'Э', 'Ю', 'Я', '0', '1'},
                                   { '2','3', '4', '5', '6', '7', '8'},
                                   {'9', ' ', ',', '.', '!', '?', ';'}
                               };

            string new_message1 = "";
            for (int i = 0; i < message1.Length; i += 2)
            {
                new_message1 += alfrus[Convert.ToInt32(message1[i].ToString()), Convert.ToInt32(message1[i + 1].ToString())];
            }
            Console.WriteLine(new_message1);
        }
        static void Gronsfeld(string text, string key)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz", newKey = key, result = "";
            bool encode = true;
            int op = encode ? +1 : -1, offset, indexOf = 0;
            while (newKey.Length < text.Length)
            {
                newKey += key;
            }
            if (newKey.Length > text.Length)
            {
                newKey = newKey.Substring(0, newKey.Length - (newKey.Length - text.Length));
            }

            for (int i = 0; i < text.Length; i++)
            {
                indexOf = abc.IndexOf(text[i]);
                if (indexOf != -1)
                {
                    offset = abc.IndexOf(text[i]) + (Convert.ToInt32(newKey[i]) - 48) * op;
                    if (offset >= abc.Length)
                        offset = offset - abc.Length;
                    else if (offset < 0)
                        offset = abc.Length + offset;
                    result += abc[offset];
                }
                else
                    result += text[i];
            }
            Console.WriteLine(result);
        }
        static void BookCipher(string str)
        {
            string key= "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string newstr = str.ToLower();
            newstr = newstr.Replace(" ", string.Empty);
            char[] mas = newstr.ToCharArray();
            Random rand = new Random();
            List<int> test = new List<int>();
            for(int i = 0; i < mas.Length; i++)
            {
                int N = rand.Next(0, 2);
                switch (N)
                {
                    case 0:
                        test.Add(key.IndexOf(mas[i]));
                        Console.Write(test[i]+" ");
                        break;
                    default:
                        test.Add(key.LastIndexOf(mas[i]));
                        Console.Write(test[i] + " ");
                        break;
                }
            }


        }
    }   
}
