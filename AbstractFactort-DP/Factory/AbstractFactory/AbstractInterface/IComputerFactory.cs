using AbstractFactory_DP.Factory.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP.Factory.AbstractFactory.AbstractInterface
{
    public interface IComputerFactory
    {
        IProcessor Processor();
        IOperatingSystem Brand();
        ISystemType SystemType();
    }
}
