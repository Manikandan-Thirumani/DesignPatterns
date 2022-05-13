using System;
using System.Collections.Generic;
using System.Text;
using DP.Common.Models;

namespace DP.Common.Stores
{
 public static  class EmployeeStore
    {
        public static List<Employee> AllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { EmployeeTypeID = 1, Name = "Madhu",  JobDescription = "Manager" });
            employees.Add(new Employee() { EmployeeTypeID = 1, Name = "Muthu",  JobDescription = "developer" });
            employees.Add(new Employee() { EmployeeTypeID = 2, Name = "Suresh", JobDescription = "Manager" });
            employees.Add(new Employee() { EmployeeTypeID = 2, Name = "mani",  JobDescription = "developer" });
            return employees;
        }
    }
}
