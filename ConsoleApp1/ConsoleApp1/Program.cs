using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "bU tasKI metHodla yAzmAliSiz";

            Console.WriteLine(big(name));

            //name = name.ToLower();

            //Console.WriteLine(name);
            
        }
        public static string big (string name)
        {
            name = name.Replace("bU", "Bu");
            name = name.Replace("tasKI", "Taski");
            name = name.Replace("metHodla", "Methodla");
            name = name.Replace("yAzmAliSiz", "Yazmalisiz");
            
            {
                return name;
            }
        }
    }
}
