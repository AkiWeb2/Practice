using System;
namespace Console
{
    class Class
    {
        // Объявление делегата, ссылающегося на функцию
        // с двумя параметрами и целочисленным результатом
        public delegate int AddDelegate(int num1, int num2);
        public int a { get; set; }
        public int b { get; set; }
        // Конструктор
        public Class(int a, int b)
        {
            this.a = a;
            this.b = b;
            Get(a, b);
        }
        private static void Get(int a, int b)
        {
            // Создание метода делегата и передача функции Add в качестве аргумента
            AddDelegate funct1 = new AddDelegate(Add);
            // Вызов делегата
            int k = funct1(a, b);
            System.Console.WriteLine("Sumation = {0}", k);
            System.Console.Read();
        }

        // Статическая функция Add с той же сигнатурой, что и у делегата
        private static int Add(int num1, int num2)
        {
            int sumation = num1 + num2;
            return sumation;
        }
    }
}
