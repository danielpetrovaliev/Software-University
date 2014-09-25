using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_StringBuilder_Extensions
{
    public static class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder("This method must works");
            
            Console.WriteLine(text.Substring(9, 100));
            Console.WriteLine();
            text.RemoveText("must");
            Console.WriteLine(text);
            text.RemoveText("method");
            Console.WriteLine(text);

            Console.WriteLine();
            StringBuilder chat = new StringBuilder();
            chat.AppendAll(new List<string>() { "Hi", ", ", "how ", "are ", "you" })
                .AppendAll(new List<string>() { "\nI ", "am ", "fine"});
            Console.WriteLine(chat);

        }


        public static StringBuilder Substring(this StringBuilder strBuilder, 
            int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();

            string str = strBuilder.ToString();
            for (int i = 0; i < length; i++)
            {
                result.Append(str[startIndex]);
                startIndex++;
                if (startIndex > str.Length-1)
                {
                    break;
                }
            }
            return result;
        }

        public static StringBuilder RemoveText(this StringBuilder strBuilder,
            string textToReplace)
        {
            strBuilder.Replace(textToReplace, "");
            return strBuilder;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder strBuilder,
            IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                strBuilder.Append(item);
            }
            return strBuilder;
        }
    }
}
