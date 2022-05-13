using DP.Common.Models;
using DP.Common.Stores;
using System;
using System.Collections.Generic;
using Factory_DP.Factory;
using Factory_DP.Manager;

namespace Factory_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = EmployeeStore.AllEmployees();

            foreach (Employee emp in employees)
            {
                var emptype = emp.EmployeeTypeID == 1 ? "Permanent" : "Contract";

                EmployeeManagerFactory empFactory = new EmployeeManagerFactory();
                IEmployeeManager empManager = empFactory.GetEmployeeManager(emp.EmployeeTypeID);
                emp.Location = empManager.GetLocation();
                emp.BasicPay = empManager.GetPay();
                Console.WriteLine("{0} is {1} employee. Seat allocated in  {2} and Basic Pay is {3}$", emp.Name, emptype, emp.Location, emp.BasicPay);

            }
        }
    }
}
