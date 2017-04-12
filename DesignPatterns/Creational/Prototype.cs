using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This pattern creates the kind of object using its prototype. In other words, while creating 
 * the object of Prototype object, the class actually creates a clone of it and returns it as 
 * prototype.
 *
 * You can see here, I have used MemberwiseClone method to clone the prototype when required.
 */

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
