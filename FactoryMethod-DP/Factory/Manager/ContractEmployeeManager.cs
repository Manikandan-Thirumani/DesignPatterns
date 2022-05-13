using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_DP.Factory.Manager
{
    public class ContractEmployeeManager : IEmployeeManager
    {

        public string GetLocation()
        {
            return "First floor";

        }
        public decimal GetPay()
        {
            return 500;
        }

        public decimal GetPetrolAllowance()
        {
            return 111;
        }
    }
}
