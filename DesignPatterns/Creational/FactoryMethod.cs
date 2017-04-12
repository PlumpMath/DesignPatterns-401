using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * A Factory method is just an addition to Factory class. It creates the object of the class 
 * through interfaces but on the other hand, it also lets the subclass to decide which class 
 * to be instantiated.
 *
 * You can see I have used GetObject in concreteFactory. As a result, you can easily call DoSomething() from it to get the IProduct.
 *
 * You might also write your custom logic after getting the object in the concrete Factory Method. The GetObject is made abstract in the Factory interface.
 */

namespace DesignPatterns.Creational
{
    public interface IProduct
    {
        string GetName();
        string SetPrice(double price);
    }

    public class IPhone: IProduct
    {
        private double _price;

        #region IProduct Members
        public string GetName()
        {
            return "Apple Touchpad";
        }

        public string SetPrice(double price)
        {
            this._price = price;
            return "success";
        }
        #endregion
    }

    public abstract class ProductAbstractFactory
    {
        public IProduct DoSomething()
        {
            IProduct product = this.GetObject();

            //do something after you get the object
            product.SetPrice(20.30);
            return product;
        }

        public abstract IProduct GetObject();
    }

    public class ProductConcreteFactory : ProductAbstractFactory
    {
        //implementation of factory method
        public override IProduct GetObject()
        {
            return this.DoSomething();
        }
    }
}
