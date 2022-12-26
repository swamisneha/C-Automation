﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.Runner
{
    public class Employee
    {
        public int empId;
        public string empName;
        public double empSalary;
        public static string companyName;
        public static string companyLocation;
        public char empPerformanceType;

        public void PrintEmployeeDetail()
        {

            Console.WriteLine("Employee ID: " + empId);
            Console.WriteLine("Employee Name:" + empName);
            Console.WriteLine("Employee Salary: " + empSalary);
            Console.WriteLine("Employee Performance: " + empPerformanceType);
            Console.WriteLine("Company Name: " + Employee.companyName);
            Console.WriteLine("Company Location: " + Employee.companyLocation);
            Console.WriteLine("-------------------------------------------------");
        }
        //CalculateBonus

        public void GetGrossSalarywithBonus()
        {
            Console.WriteLine("Employee Id: " + empId);
            if (empPerformanceType == 'A')
            {
                Console.WriteLine("25%");
                Console.WriteLine(empSalary + (empSalary * 25 / 100));
            }
            else if (empPerformanceType == 'B')
            {
                Console.WriteLine("15%");
                Console.WriteLine(empSalary + (empSalary * 15 / 100));
            }
            else if (empPerformanceType == 'C')
            {
                Console.WriteLine("10%");
                Console.WriteLine(empSalary + (empSalary * 10 / 100));
            }
            else
            {
                Console.WriteLine("Not Eligible for Bonus!!!");
            }
            Console.WriteLine("----------------------------------------");
        }
    }
}

