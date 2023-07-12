using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string employeeName;
            char employeeGender;
            double salary;
            DateTime doj;
            Console.WriteLine("Enter your ID");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            employeeName = Console.ReadLine();
            Console.WriteLine("Enter your Gender");
            employeeGender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter your salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Date of Joining");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ID\t" + "Employee Name\t" + "Employee Gender\t\t" +
               "Employee Salary\t\t" + "Date of Joining");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine(id + "\t" + employeeName + "\t" + "\t\t" + employeeGender + "\t\t" + salary + "\t\t\t" + doj);
            if (salary > 90000)
            {
                Console.WriteLine("You have to pay 30%tax");
            }
            else
            {
                Console.WriteLine("You have to pay 15% tax");
            }
            Console.ReadKey();
        }
    }
}
