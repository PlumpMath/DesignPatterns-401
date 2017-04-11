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

    class Adapter
    {
    }
}
