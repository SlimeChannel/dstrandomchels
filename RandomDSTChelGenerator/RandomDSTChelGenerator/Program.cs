using System;
using System.Collections.Generic;

namespace RandomDSTChelGenerator
{
    internal class Program
    {
        private static List<string> _chels = new List<string>()
        {
            "Вилсон",
            "Огонёк",
            "Качоек",
            "Параноик",
            "Робот",
            "Бабка",
            "Бебер",
            "Клоунада",
            "Прямоугольник",
            "Паук",
            "Механник",
            "Кок",
            "Чёрт",
            "Дерево",
            "Стрекоза",
            "Аппетитный мальчик",
            "Бабулька"
        };
        private static Random _rand = new Random();
        private static List<string> _args = new List<string>();

        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string inputString = Console.ReadLine();
            int argNum = 0;
            string arg = string.Empty;

            foreach (char c in inputString)
            {
                if(c == ' ')
                {
                    _args.Add((string)arg.Clone());
                    arg = string.Empty;
                    argNum++;
                    continue;
                }
                arg += c; 
            }

            foreach(string s in _args)
            {
                _chels.Remove(s);
            }

            Console.WriteLine(_chels[_rand.Next(_chels.Count - 1)]);
        }
    }
}
