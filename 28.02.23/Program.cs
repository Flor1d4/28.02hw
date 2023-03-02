using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> engToRusDict = new Dictionary<string, string>()
            {
            {"Ukraine", "Украина"}, {"Austria","Австрия"}, {"USA", "США"}, {"China", "Китай"}, {"Germany", "Германия"}, {"Japan", "Япония"}
            };

            Dictionary<string, string> rusToEngDict = new Dictionary<string, string>()
            {
                {"Украина", "Ukraine"}, {"Австрия","Austria"}, {"США", "USA"}, {"Китай", "China"}, {"Германия", "Germany"}, {"Япония", "Japan"}
            };
            //Dictionary<string, string> nRusKeys = new Dictionary<string, string>()
            //{
            //    {"Erhfbyf", "Украина"}, {"Австрия","Austria"}, {"США", "USA"}, {"Китай", "China"}, {"Германия", "Germany"}, {"Япония", "Japan"}
            //};
            //Dictionary<string, string> noEngKey = new Dictionary<string, string>()
            //{
            //    {"Украина", "Erhfbyf"}, {"Австрия","Austria"}, {"США", "USA"}, {"Китай", "China"}, {"Германия", "Germany"}, {"Япония", "Japan"}
            //};
            Console.WriteLine("↓ Выберите перевод ↓\n");
            Console.WriteLine("█ 1 █ Англо-русский");
            Console.WriteLine("█ 2 █ Русско-английский");
            //Console.WriteLine("█ 3 █ Нет русской раскладки");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Введите название страны на английском языке: ");
                string engCountry = Console.ReadLine();

                if (engToRusDict.ContainsKey(engCountry))
                {
                    Console.WriteLine($"Перевод: {engToRusDict[engCountry]}");
                }
                else
                {
                    Console.WriteLine("Этой страны нет в словаре.");
                }
            }
            else if (choice == 2)
            {
                Console.Write("Введите название страны на русском языке: ");
                string rusCountry = Console.ReadLine();

                if (rusToEngDict.ContainsKey(rusCountry))
                {
                    Console.WriteLine($"Перевод: {rusToEngDict[rusCountry]}");
                }
                else
                {
                    Console.WriteLine("Этой страны нет в словаре.");
                }
            }
            //else if (choice == 3)
            //{
            //    Console.Write("Введите название страны на русском языке: ");

            //    if (noEngKey.ContainsKey(Console.ReadLine()))
            //    {
            //        Console.WriteLine($"Перевод: {noEngKey[Console.ReadLine()]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Этой страны нет в словаре.");
            //    }
            //}
            else
            {
                Console.WriteLine("Неверно. ");
            }           
        }
    }
}


