using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WildDuck : IDuck
    {
        string name;
        public WildDuck(string name)
        {
            this.name = name;
        }
        public void Fly() => Console.WriteLine("{0} летает", name);
        public void Swim() => Console.WriteLine("{0} плавает", name);
        public void Quack() => Console.WriteLine("{0} Крякает", name);
    }
}
