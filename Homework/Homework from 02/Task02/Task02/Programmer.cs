using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Programmer : Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

       
        public Programmer(string name, int employeeId, decimal hourlyRate, int hoursWorked)
        {
            Name = name;
            EmployeeId = employeeId;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

       
        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        
        public override void DisplayInfo()
        {
            Console.WriteLine($"Programmer ID: {EmployeeId}, Name: {Name}, Total Salary: {CalculateSalary():C}");
        }
    }
}
