using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_DP.Factory.AbstractFactory.AbstractInterface;
using DP.Common.Models;

namespace AbstractFactory_DP.Factory.AbstractFactory.ConcreteFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee e)
        {
            IComputerFactory returnValue = null;
            if (e.EmployeeTypeID == 1)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new AppleOsLaptopFactory();
                }
                else
                {
                    returnValue = new AppleOsFactory();
                }
            }
            else if (e.EmployeeTypeID == 2)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new WindowsOsLaptopFactory();
                }
                else
                    returnValue = new WindowsOsFactory();
            }
            return returnValue;
        }
    }
}
