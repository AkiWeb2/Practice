using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фабрика_Методов
{
    public class ConcreateStep : Prodyct
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override bool Studint { get; set; }
        public decimal Step { get; set; }


        public ConcreateStep(string Name, int Age, bool Studint, decimal Step) : base(Name, Age, Studint)
        {
            this.Studint = Studint;
            this.Name = Name;
            this.Age = Age;
            this.Step = Step;
            TrueGet(Name, Age, Studint, Step);
        }

        private static void TrueGet(string Name, int Age, bool Studint, decimal Step)
        {
            try
            {

                if (Studint == true)
                {
                    Console.WriteLine($"У человека по имени {Name} которому {Age} лет, имеет степендию {Step} руб. ");

                }
                else if (Studint == false)
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
