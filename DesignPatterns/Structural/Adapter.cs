using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
