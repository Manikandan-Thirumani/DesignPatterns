using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_DP.Factory.Manager
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public string GetLocation()
        {
            return "Ground floor";
        }

        public decimal GetPay()
        {
            return 1000;
        }

        public decimal GetHouseAllowance()
        {
            return 121;
        }
    }
}
