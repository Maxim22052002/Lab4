using System;
using System.Text.RegularExpressions;
namespace Number2I_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            ResultMethods(str);
            Console.WriteLine();
            ResultReg(str);



        }
        static void ResultMethods(string str)
        {
            string[] keywords = new string[] { "abstract", "as",   "base", "bool",
"break",    "byte"  ,"case",    "catch",
"char" , "checked" ,  "class"  , "const",
"continue" , "decimal"  , "default" ,  "delegate",
"do"  ,  "double",  "else"  ,  "enum",
"event" ,  "explicit" ,   "extern"  ,"false"    ,
"finally",  "fixed", "float" ,  "for"   ,
"foreach",  "goto", "if",   "implicit",
"in", "int" ,"interface"  , "internal"  ,
"is",   "lock", "long"  ,  "namespace",
"new",  "null", "object", "operator",
"out",  "override"  ,"params" , "private",
"protected", "public" ,"readonly", "ref",
"return",   "sbyte", "sealed" ,"short"  ,
"sizeof",   "stackalloc",   "static" ,"string",
"struct",  "switch",    "this",    "throw"  ,
"true", "try",  "typeof",   "uint",
"ulong" ,  "unchecked"  ,"unsafe", "ushort",

"using",    "sing", "static",   "virtual", "void","add", "alias", "ascending",
"async", "await", "by",
"descending" ,"dynamic", "equals",
"from" ,"get", "global",
"group" ,"into", "join",
"let", "nameof" ,"on",
"orderby" ,"partial" , "partial",
"remove" ,"select", "set",
"unmanaged" ,   "value", "var",
"when" , "where",
"yield"

    };
            
            string[] arrayInput = str.Split(" ");
            string output = "";

            //for (int i = 0; i < arrayInput.Length; i++)
            //{
            //    Console.WriteLine(" "+arrayInput[i]);
            //}

            for (int i = 0; i < arrayInput.Length; i++)
            {

                bool isBreak = false;
                foreach (string key in keywords)
                {
                    if (key.Equals(arrayInput[i]))
                    {
                        isBreak = true;
                    }
                }
                if (isBreak)
                {
                    //break;
                }
                else
                {
                    output += arrayInput[i] + ' ';
                }


            }

            Console.WriteLine("Output string: " + output);
        }
        static void ResultReg(string str)
        {
            
            string target = " ";
            //  Regex regex = new Regex(@"\b\s*(in|int)\s*\b");
            Regex regex = new Regex(@"\b\s*(abstract|as|base|bool|
|break|byte|case|catch|
|char|checked|class|const|
|continue|decimal|default|delegate|
|do|double|else|enum|
|event|explicit|extern|false|
|finally|fixed|float|for|
|foreach|goto|if|implicit|
|in|int|interface|internal|
|is|lock|long|namespace|
|new|null|object|operator|
|out|override|params|private|
|protected|public|readonly|ref|
|return|sbyte|sealed|short|
|sizeof|stackalloc|static|string|
|struct|switch|this|throw|
|true|try|typeof|uint|
|ulong|unchecked|unsafe|ushort|
|using|using|static|virtual|void|
|volatile|while|add|alias|ascending|
|async|await|by|
|descending|dynamic|equals|
|from|get|global|
|group|into|join|
|let|nameof|on|
|orderby|partial| 
|remove|select|set|
|unmanaged|value|var|
|when|where|where|
|yield)\s\b");
            string result = regex.Replace(str, target);
            Console.WriteLine("Output string: "+result);
            
            //string[] boxstr = new string[] { "int" };
            //string str = Console.ReadLine();
            //char[] array = str.ToCharArray();
            //string space = " ";
            //string reg = @"\s+";
            //string word = string.Empty;
            //for (int i = 0; i < str.Length; i++)
            //{
            // if (array[i] == ' ')
            // {
            // //space = i;
            // word += str[i];
            // if (word == boxstr[i])
            // {


            // Regex regex = new Regex(reg);
            // string result = regex.Replace(boxstr[i], space);
            // Console.WriteLine(result);
            // }

            // }



            //}
            //for(int i = 0; i < str.Length; i++)
            //{
            // Regex regex = new Regex(reg);
            // string result = regex.Replace(boxstr[i], space);
            // Console.WriteLine(result[i]);
            //}
            //string str = Console.ReadLine();

            //string pattern = @"\sif\s";


            //foreach(Match match in regex.Matches(str))
            // Console.WriteLine(match);

        }
        

        



    }
}
