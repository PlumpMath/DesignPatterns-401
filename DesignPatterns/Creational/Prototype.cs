using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class ConcretePrototype1 : Prototype
    {
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    class ConcretePrototype2 : Prototype
    {
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone(); //clones the concrete class
        }
    }
}
