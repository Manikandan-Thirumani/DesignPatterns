using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Common.Models
{
    public class Employee
    {
        public int EmployeeTypeID { get; set; }
        public string Name { get; set; }
        public string JobDescription { get; set; }
        public string ComputerDetails { get; set; }
        public string Location { get; set; }
        public decimal BasicPay { get; set; }
        public decimal PetrolAllowance { get; set; }
        public decimal HouseAllowance { get; set; }
    }
}
