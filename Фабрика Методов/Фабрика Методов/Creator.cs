using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фабрика_Методов
{
    public abstract class Creator : Prodyct
    {
        public abstract Prodyct FactoryMethod();

        public Creator(string Name, int Age, bool Studint) : base(Name, Age, Studint)
        {
            this.Studint = Studint;
            this.Name = Name;
            this.Age = Age;
        }

        public void Operation(string Name, int Age, bool Studint)
        {
            var p = FactoryMethod();
        }

    }
}
