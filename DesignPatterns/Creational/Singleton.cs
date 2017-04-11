using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
