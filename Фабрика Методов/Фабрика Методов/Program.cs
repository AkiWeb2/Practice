using System.Timers;
using Фабрика_Методов;


namespace Test
{
     class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Age:");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Если вы студент напишите True, если нет то False");
            bool Studint = bool.Parse(Console.ReadLine());
           
            Dev dev = new Dev(Name, Age, Studint);
        }
    }
}