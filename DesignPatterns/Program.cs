using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //factory pattern
            //var factory = new Factory();
            //var people = factory.GetPeople(PeopleType.URBAN);

            //Console.WriteLine(people.GetName());

            //factory method pattern
            var productConcreteFactory = new ProductConcreteFactory();
            Console.WriteLine(productConcreteFactory.GetObject());

            Console.Read();
        }
    }
}
