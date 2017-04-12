using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Decorator pattern is used to create responsibilities dynamically. That means each class 
 * in case of Decorator patter adds up special characteristics.In other words, 
 * Decorator pattern is the same as inheritance.
 *
 * This is the same parent child relationship where the child class adds up new feature called Method2 while other characteristics is derived from the parent.
 */

namespace DesignPatterns.Structural
{
    public class ParentClass
    {
        public void Method1()
        { 
        
        }
    }

    public class DecoratorChild : ParentClass
    {
        public void Method2()
        { 
        
        }
    }
}
