﻿using System;
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
            Console.WriteLine("Welcome To Employee Wage Computation Program \n");
            //Creating Object for each company and passing value to constructor.
            CalculateEmpWage company = new CalculateEmpWage();
            company.AddCompany("Dmart", 30, 120, 25);
            company.AddCompany("Reliance", 25, 125, 24);
            company.AddCompany("Amazon", 40, 110, 22);
            company.GetWage();
            Console.WriteLine("Total Wage for Company is: " + company.GetTotalWage("Dmart"));
            Console.ReadLine();
        }
    }
}
