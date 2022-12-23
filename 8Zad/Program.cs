using System;
using System.Text.RegularExpressions;

namespace _8Zad
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст");
            string s = Console.ReadLine();
            Regex regex = new Regex(@"[-.?!);(,:]");
            MatchCollection matches = regex.Matches(s);
            Console.WriteLine();
            if (matches.Count == 0)
            {
                Console.WriteLine("Ошибка строка не может быть пустой");
                return;
            }

            var newText = Regex.Replace(s, "[-.?!);(,:]", "");
            Console.WriteLine("Исправленный текст: ");
            Console.WriteLine(newText);
                Console.ReadLine();
            
        }
    }
}
