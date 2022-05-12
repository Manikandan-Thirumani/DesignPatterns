using AbstractFactory_DP.Factory.AbstractFactory.AbstractInterface;
using AbstractFactory_DP.Factory.AbstractFactory.AbstractProduct;
using AbstractFactory_DP.Factory.AbstractFactory.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP.Factory.AbstractFactory.ConcreteFactory
{
    public class AppleOsFactory : IComputerFactory
    {
        public IOperatingSystem Brand()
        {
            return new AppleOs();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
}
