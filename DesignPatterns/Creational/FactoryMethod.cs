using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
