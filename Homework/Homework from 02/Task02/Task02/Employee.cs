using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }

       
        public abstract decimal CalculateSalary();

        
        public abstract void DisplayInfo();
    }
}
