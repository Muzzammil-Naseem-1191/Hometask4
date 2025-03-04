using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4_Q2_OOP_1191
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee(int employeeID, string name, string department, double salary)
        {
            EmployeeID = employeeID;
            Name = name;
            Department = department;
            Salary = salary;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"-----Emplyee Details-----");
            Console.WriteLine($"Emplyee ID: {EmployeeID}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Department: {Department}");
            Console.WriteLine($"Employee Salary: {Salary}");

        }
        public void IncreaseSalary(double amount)
        {
            Salary = Salary + amount;
            Console.WriteLine($"Salary increased by {amount:F2}, New salary amount is {Salary:F2}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1191, "Muzzammil Naseem", "DCS", 10000);
            emp.DisplayEmployeeDetails();
            emp.IncreaseSalary(5000);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Updated Information:");
            emp.DisplayEmployeeDetails();
        }
    }
}
