using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Singleton pattern creates a class which can have a single object throughout the application, 
 * so that whenever any other object tries to access the object of the class, it will access 
 * the same object always.
 *
 * In the code you can see I have intentionally made the constructor as private. 
 * This will make sure that the class cant be instantiated from outside. On the other hand, 
 * you also need to make a property which will return the static instance of the object present 
 * within the class itself. Hence the object will be shared between all the external entities.
 */

namespace DesignPatterns.Creational
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private Singleton()
        { 
        
        }

        public static Singleton Instance
        {
            get
            {
                lock (_instance)
                {
                    _instance = _instance ?? new Singleton();
                    return _instance;
                }
            }
        }
    }
}
