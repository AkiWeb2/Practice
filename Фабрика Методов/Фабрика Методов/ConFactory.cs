using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фабрика_Методов
{
    public class ConFactory : Creator
    {
        public override Prodyct FactoryMethod() => new ConcreateStep(Name, Age, Studint, Step);
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override bool Studint { get; set; }

        public decimal Step { get; set; }

        public ConFactory(string Name, int Age, bool Studint) : base(Name, Age, Studint)
        {
            this.Studint = Studint;
            this.Name = Name;
            this.Age = Age;
            FalseGet(Name, Age, Studint);

        }
        private void FalseGet(string Name, int Age, bool Studint)
        {
            try
            {

                if (Studint == false)
                {
                    Console.WriteLine($"У человека по имени {Name} которому {Age} лет, не имеет степендию");

                }
                else if (Studint == true)
                {
                    Console.WriteLine("Error");
                }
                else { Console.WriteLine("Error"); }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

}
