using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_DP.Factory.AbstractFactory.AbstractInterface;
using AbstractFactory_DP.Factory.AbstractFactory.AbstractProduct;

namespace AbstractFactory_DP.Factory.AbstractFactory.client
{
    public class EmployeeSystemManager
    {
        IComputerFactory _IComputerFactory;
        public EmployeeSystemManager(IComputerFactory iComputerFactory)
        {
            _IComputerFactory = iComputerFactory;
        }
        public string GetSystemDetails()
        {
            IOperatingSystem brand = _IComputerFactory.Brand();
            IProcessor processor = _IComputerFactory.Processor();
            ISystemType systemType = _IComputerFactory.SystemType();
            string returnValue = string.Format("{0} {1} {2}", brand.GetBrand(),
                systemType.GetSystemType(), processor.GetProcessor());
            return returnValue;
        }
    }
}
