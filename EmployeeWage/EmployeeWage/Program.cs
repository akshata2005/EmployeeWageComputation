using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Program
    {
       public static void Main(string[] args)
        {
            //printing message on console
            Console.WriteLine("Welcome To Employee Wage Computation Program");
            CalculateEmpWage.WageCompute();    // calling static method using class name.
            Console.ReadLine();
        }
           
    }
}
