using DP.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod_DP.Factory.Manager;

namespace FactoryMethod_DP.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee emp)
        {
            _emp = emp;
        }
        public Employee CalculateValuesBasedonEmployeeType()
        {
            IEmployeeManager manager = this.Create();
            _emp.Location = manager.GetLocation();
            _emp.BasicPay = manager.GetPay();
            return _emp;
        }
        public abstract IEmployeeManager Create();
    }
}
