using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Adapter : IDuck
    {
        private Turkey turkey;
        public Adapter(Turkey turkey)
        {
            this.turkey = turkey;
        }
        public void Fly() => turkey.Fly();
        public void Swim() => turkey.Swim();
        public void Quack() => turkey.Gaga();
    }
}
