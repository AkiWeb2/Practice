using System;
using System.IO;


namespace Test {
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] mas = { "Admin", "Bugalteria", "Otpravka", "register" };
            for (int i = 0; i <= mas.Length - 1; i++)
            {
                if (mas[i] == a)
                {
                    string secondLine = File.ReadLines("C:\\Users\\AkiWeb\\Desktop\\Программирование\\Считывание строчки\\S.txt").Skip(i).First();
                    if (secondLine == a)
                    {
                        Console.WriteLine(secondLine);
                    }
                    
                }
            }
        }
    }
}

