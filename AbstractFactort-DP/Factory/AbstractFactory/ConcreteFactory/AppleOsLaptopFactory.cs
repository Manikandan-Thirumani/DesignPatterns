using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_DP.Factory.AbstractFactory.AbstractProduct;
using AbstractFactory_DP.Factory.AbstractFactory.ConcreteFactory;
using AbstractFactory_DP.Factory.AbstractFactory.ConcreteProduct;

namespace AbstractFactory_DP.Factory.AbstractFactory
{
    public class AppleOsLaptopFactory : AppleOsFactory
    {

        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
