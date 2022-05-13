using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP.Manager
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
    }
}
