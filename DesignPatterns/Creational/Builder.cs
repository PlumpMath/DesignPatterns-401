using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This pattern creates object based on the Interface, but also lets the subclass decide which 
 * class to instantiate. It also has finer control over the construction process.
 *
 * There is a concept of Director in Builder Pattern implementation. The director actually creates the object and also runs a few tasks after that.
 *
 * In case of Builder pattern you can see the Director is actually using CreateBuilder to create the instance of the builder. So when the Bulder is actually created, we can also invoke a few common task in it.
 */

namespace DesignPatterns.Creational
{
    public interface IBuilder
    {
        string RunBuilderTask1();
        string RunBuilderTask2();
    }

    public class Builder1 : IBuilder
    {
        #region IBuilder Members
        public string RunBuilderTask1()
        {
            throw new ApplicationException("Task1");
        }

        public string RunBuilderTask2()
        {
            throw new ApplicationException("Task2");
        }
        #endregion
    }

    public class Builder2 : IBuilder
    {
        #region IBuilder Members
        public string RunBuilderTask1()
        {
            return "Task3";
        }

        public string RunBuilderTask2()
        {
            return "Task4";
        }
        #endregion
    }

    public class Director
    {
        public IBuilder CreateBuilder(int type)
        {
            IBuilder builder = null;

            if (type == 1)
            {
                builder = new Builder1();
            }
            else
            {
                builder = new Builder2();
            }

            builder.RunBuilderTask1();
            builder.RunBuilderTask2();

            return builder;
        }
    }
}
