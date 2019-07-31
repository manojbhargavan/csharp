using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeViewer.Model
{
    public class Employee
    {
        public long Id { get; set; }
        public string Employee_Name { get; set; }
        public long Employee_Salary { get; set; }
        public long Employee_Age { get; set; }
        public string Profile_Image { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Employee_Name}, Salary: {Employee_Salary}, Age: {Employee_Age} Image: {Profile_Image}";
        }
    }
}
