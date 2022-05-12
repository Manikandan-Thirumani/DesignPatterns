using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_DP.Factory.AbstractFactory.AbstractInterface;
using AbstractFactory_DP.Factory.AbstractFactory.AbstractProduct;
using AbstractFactory_DP.Factory.AbstractFactory.ConcreteProduct;

namespace AbstractFactory_DP.Factory.AbstractFactory.ConcreteFactory
{
    public class WindowsOsFactory : IComputerFactory
    {
        public IOperatingSystem Brand()
        {
            return new Windows();
        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
}
