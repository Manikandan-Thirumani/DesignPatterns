using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP.Manager
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
    }
}
