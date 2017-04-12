using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Adapter pattern converts one instance of a class into another interface which client expects. 
 * In other words, Adapter pattern actually makes two classes compatible.
 *
 * Here in the structure, the adapter is used to make MyClass2 incompatible with IAdapter.
 */

namespace DesignPatterns.Structural
{
    public interface IAdapter
    { 
        //interface method Add which decouples the actual concrete objects
        void Add();
    }

    public class MyClass1 : IAdapter
    {
        public void Add()
        {
            throw new NotImplementedException();
        }
    }

    public class MyClass2
    {
        public void Push()
        { 
            
        }
    }

    public class Adapter: IAdapter
    {
        private MyClass2 _class2 = new MyClass2();

        public void Add()
        {
            this._class2.Push();
        }
    }
}
