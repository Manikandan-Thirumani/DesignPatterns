using System;
using System.Collections.Generic;
using AbstractFactory_DP.Factory.AbstractFactory;
using AbstractFactory_DP.Factory.AbstractFactory.AbstractInterface;
using AbstractFactory_DP.Factory.AbstractFactory.client;
using AbstractFactory_DP.Factory.AbstractFactory.ConcreteFactory;
using DP.Common.Models;

namespace AbstractFactory_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(){EmployeeTypeID=1,Name = "Madhu",ComputerDetails = null,JobDescription = "Manager"});
            employees.Add(new Employee() { EmployeeTypeID = 1, Name = "Muthu", ComputerDetails = null, JobDescription = "developer" });
            employees.Add(new Employee() { EmployeeTypeID = 2, Name = "Suresh", ComputerDetails = null, JobDescription = "Manager" });
            employees.Add(new Employee() { EmployeeTypeID = 2, Name = "mani", ComputerDetails = null, JobDescription = "developer" });
            foreach (Employee emp in employees)
            {
                var emptype = emp.EmployeeTypeID == 1 ? "Permanent" : "Contract";
                IComputerFactory factory = new EmployeeSystemFactory().Create(emp);
                EmployeeSystemManager manager = new EmployeeSystemManager(factory);
                emp.ComputerDetails = manager.GetSystemDetails();
                Console.WriteLine("{0} is {1}-{2}.So he/she receive  {3}",emp.Name, emptype,emp.JobDescription,emp.ComputerDetails);
            }


        }

    }
}
