using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural
{
    //treats elements as composition of one or more element, so that components can be separated between one another
    public interface IComposite
    {
        void CompositeMethod();
    }

    public class LeafComposite : IComposite
    {
        public void CompositeMethod()
        {
            throw new NotImplementedException();
        }
    }

    //elements from IComposite can be separated from others
    public class NormalComposite : IComposite
    {
        public void CompositeMethod()
        {
            throw new NotImplementedException();
        }

        public void DoSomethingMore()
        { 
        
        }
    }
}
