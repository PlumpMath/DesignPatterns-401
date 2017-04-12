using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Flyweight allows you to share bulky data which are common to each object. In other words, 
 * if you think that same data is repeating for every object, you can use this pattern 
 * to point to the single object and hence can easily save space.
 *
 * Here the FlyweightPointer creates a static member Company, which is used for every object of MyObject.
 */

namespace DesignPatterns.Structural
{
    //defines flyweight object which repeats itself
    public class FlyWeight
    {
        public string Company { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyWebsite { get; set; }

        //bulky data
        public byte[] CompanyLogo { get; set; }
    }

    public static class FlyWeightPointer
    {
        public static FlyWeight Company = new FlyWeight
        {
            Company = "Abc",
            CompanyLocation = "XYZ",
            CompanyWebsite = "www.abc.com"
        };
    }

    public class MyObject
    {
        public string Name { get; set; }
        public FlyWeight Company
        {
            get
            {
                return FlyWeightPointer.Company;
            }
        }
    }
}
