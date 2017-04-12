using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
