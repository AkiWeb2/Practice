using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фабрика_Методов
{
    interface IProdyct
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Studint { get; set; }
    }
    public abstract class Prodyct : IProdyct
    {
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
        public abstract bool Studint { get; set; }

        public Prodyct(string Name, int Age, bool Studint)
        {
            this.Name = Name;
            this.Age = Age;
            this.Studint = Studint;
        }
    }
}
