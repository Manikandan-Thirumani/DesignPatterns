using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Common.Models;
using FactoryMethod_DP.Factory.Manager;

namespace FactoryMethod_DP.Factory.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.PetrolAllowance = manager.GetPetrolAllowance();
            return manager;
        }
    }
}
