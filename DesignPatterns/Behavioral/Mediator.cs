using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Mediator pattern ensures that the components are loosely coupled, such that they don't call 
 * each others explicitly, rather they always use a separate Mediator implementation to do 
 * those jobs. 
 * 
 * Here you can see the mediator Registers all the Components within it and then calls 
 * its method when required.
 */

namespace DesignPatterns.Behavioral
{
    public interface IComponent
    {
        void SetState(object state);
    }

    public class Component1 : IComponent
    {
        public void SetState(object state)
        {
            throw new NotImplementedException();
        }
    }

    public class Component2 : IComponent
    {
        public void SetState(object state)
        {
            throw new NotImplementedException();
        }
    }

    public class Mediator
    {
        public IComponent Component1 { get; set; }
        public IComponent Component2 { get; set; }

        public void ChangeState(object state)
        {
            this.Component1.SetState(state);
            this.Component2.SetState(state);
        }
    }
}
