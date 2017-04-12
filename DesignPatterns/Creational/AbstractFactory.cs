using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Abstract factory is the extension of basic Factory pattern. It provides Factory interfaces 
 * for creating a family of related classes. In other words, here I am declaring interfaces 
 * for Factories, which will in turn work in similar fashion as with Factories.
 *
 * The factory method is also implemented using common interface each of which returns objects.
 */

namespace DesignPatterns.Creational
{
    public interface IFactory1
    {
        IPeople GetPeople();
    }

    public interface IFactory2
    {
        IProduct GetProduct();
    }

    public class Factory1: IFactory1
    {
        public IPeople GetPeople()
        {
            return new Villagers();
        }
    }

    public class Factory2 : IFactory2
    {
        public IProduct GetProduct()
        {
            return new IPhone();
        }
    }

    public abstract class AbstractFactory12
    {
        public abstract IFactory1 GetFactory1();
        public abstract IFactory2 GetFactory2();
    }

    public class ConcreteFactory : AbstractFactory12
    {
        public override IFactory1 GetFactory1()
        {
            return new Factory1();
        }

        public override IFactory2 GetFactory2()
        {
            return new Factory2();
        }
    }
}
