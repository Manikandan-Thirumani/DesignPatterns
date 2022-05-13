using System;
using System.Collections.Generic;
using DP.Common.Models;
using DP.Common.Stores;
using FactoryMethod_DP.Factory.FactoryMethod;

namespace FactoryMethod_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = EmployeeStore.AllEmployees();

            foreach (Employee emp in employees)
            {
                var emptype = emp.EmployeeTypeID == 1 ? "Permanent" : "Contract";
                BaseEmployeeFactory empFactory =
                    new EmployeeManagerFactory().CreateFactory(emp);
                empFactory.CalculateValuesBasedonEmployeeType();
                Console.WriteLine("{0} is {1} employee. Seat allocated in  {2} with salary breakup Basic Pay - {3}$ , Petrol allowance - {4}$ , House allowance - {5}$", emp.Name, emptype, emp.Location, emp.BasicPay,emp.PetrolAllowance,emp.HouseAllowance);

            }
        }
    }
}
