using System;
using System.Diagnostics.Metrics;
using System.Net.Cache;
using System.Reflection.Metadata.Ecma335;

namespace Test
{
    class Hash<T>
    {
        public int number { get; set; }
       
        public Hash(int number)
        {
            
            ListHash(number);
        }
        static void ListHash(int number)
        {
            Console.WriteLine($"{number}");
        }
    }

  


    class Program
    {
        static void Main(string[] args)
        {
            ConMain();
        }

        private static void ConMain()
        {
           int A = int.Parse(Console.ReadLine());
            if (A != null)
            {
                Hash<int> hash = new Hash<int>(A);
            }
          
        }
    }
}