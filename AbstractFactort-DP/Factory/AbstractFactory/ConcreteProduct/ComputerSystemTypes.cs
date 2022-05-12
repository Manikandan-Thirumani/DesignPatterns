using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_DP.Factory.AbstractFactory.AbstractProduct;

namespace AbstractFactory_DP.Factory.AbstractFactory.ConcreteProduct
{
    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return Enumerations.ComputerTypes.Laptop.ToString();
        }
    }
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return Enumerations.ComputerTypes.Desktop.ToString();
        }
    }
}
