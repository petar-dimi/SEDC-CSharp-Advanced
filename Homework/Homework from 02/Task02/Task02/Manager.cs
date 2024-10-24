using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task02
{
    public class Manager : Employee
    {
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }

        
        public Manager(string name, int employeeId, decimal baseSalary, decimal bonus)
        {
            Name = name;
            EmployeeId = employeeId;
            BaseSalary = baseSalary;
            Bonus = bonus;
        }

        
        public override decimal CalculateSalary()
        {
            return BaseSalary + Bonus;
        }

        
        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager ID: {EmployeeId}, Name: {Name}, Total Salary: {CalculateSalary():C}");
        }
    }
}
