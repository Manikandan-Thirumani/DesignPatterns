using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP.Manager
{
    public interface IEmployeeManager
    {
        string GetLocation();
        decimal GetPay();
    }
}
