using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{

    class Program
    {
        static void Main()
        {
            Turkey turkey = new Turkey();
            IDuck[] ducks = {
                new Adapter(turkey),
                new DomesticDuck("Домашняя утка"),
                new WildDuck("Дикая утка")
            };
            foreach (var duck in ducks) 
            {
                duck.Fly();
                duck.Swim();
                duck.Quack();
            }
            Console.ReadLine();
        }
    }
}