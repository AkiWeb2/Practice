using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace Фабрика_Методов
{
   
    public class Dev : Creator
    {


        public override string Name { get; set; }
        public override int Age { get; set; }
        public override bool Studint { get; set; }

        public Dev(string Name, int Age, bool Studint) : base(Name, Age, Studint)
        {
            this.Name = Name;
            this.Age = Age;
            this.Studint = Studint;
            Operation(Name, Age, Studint);
        }

        public void Operation(string Name, int Age, bool Studint)
        {
            try
            {

                if (Studint == true)
                {
                    Console.WriteLine($"{Name} ему {Age} лет и он студент");
                    OpGetTrue(Name, Age, Studint);
                }
                else if (Studint == false)
                {
                    Console.WriteLine($"{Name} ему {Age} лет и он не студент");
                    OpGetFalse(Name, Age, Studint);
                }
                else { Console.WriteLine("Error"); }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void OpGetTrue(string Name, int Age, bool Studint)
        {
            Console.WriteLine("Ваша степендия:");
            decimal Step = decimal.Parse(Console.ReadLine());
            var OpTrue = new ConcreateStep(Name, Age, Studint, Step);

        }
        public void OpGetFalse(string Name, int Age, bool Studint)
        {

            var OpFalse = new ConFactory(Name, Age, Studint);

        }

        public override Prodyct FactoryMethod()
        {
            throw new NotImplementedException();
        }
    }
}
