using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_DP.Factory.AbstractFactory.AbstractProduct;

namespace AbstractFactory_DP.Factory.AbstractFactory.ConcreteProduct
{
    public class Windows : IOperatingSystem
    {
        public string GetBrand()
        {
            return Enumerations.OsTypes.WINDOWS.ToString();
        }
    }
}
