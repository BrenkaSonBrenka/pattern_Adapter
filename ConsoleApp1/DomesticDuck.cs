using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DomesticDuck : IDuck
    {
        string name;
        public DomesticDuck(string name)
        {
            this.name = name;
        }
        public void Fly() => Console.WriteLine("{0} летает", name);
        public void Swim() => Console.WriteLine("{0} плавает", name);
        public void Quack() => Console.WriteLine("{0} Крякает", name);
    }
}
