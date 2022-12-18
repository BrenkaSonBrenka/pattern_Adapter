using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Turkey
    {
        public virtual void Fly()  => Console.WriteLine("Индюк летает");
        public virtual void Swim() => Console.WriteLine("Индюк плавает");
        public virtual void Gaga() => Console.WriteLine("Индюк гогочет");
    }
}
