// Ignore Spelling: emp

using Employee;
using System;
using System.Security.Cryptography;

namespace CaseStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDInput:
            Console.WriteLine("Enter Employee Id:");
            string input1 = Console.ReadLine();
            int empId;
               if (int.TryParse(input1, out empId))
            {
                if (empId >= 1 && empId <= 1000)
                {
                    Console.WriteLine("Okay.");
                }
                else
                {
                    Console.WriteLine("Id should be between 1 - 1000.");
                    goto IDInput;
                }
            }
            else {
                goto IDInput;
            }
        nameInput:
            Console.WriteLine("Enter Employee Name:");
            string empName = Console.ReadLine();
            try
            {
                if (!string.IsNullOrEmpty(empName))
                {
                    Console.WriteLine("Name is okay");
                }
                else
                {
                    Console.WriteLine("Name should not be empty or a number.");
                    goto nameInput;
                }
            }
            catch
            {

            };

            //salary validation
            SalaryInput:
            Console.WriteLine("Enter Employee Salary:");
            string input3 = Console.ReadLine();
                int empSalary;
                if (int.TryParse(input3, out empSalary))
                {
                    if (empSalary >= 20000 && empSalary <= 300000)
                    {
                        Console.WriteLine("Okay");
                    }
                    else
                    {
                        Console.WriteLine("Salary should be between 20000 - 300000.");
                        goto SalaryInput;
                    }
                }
                else
                {
                    goto SalaryInput;
                }

            DesignationInput:
            Console.WriteLine("Enter Employee Designation:");
            string empDesignation = Console.ReadLine();
            try
            {
                if (!string.IsNullOrEmpty(empDesignation))
                {
                    Console.WriteLine("Designation is okay");
                }
                else
                {
                    Console.WriteLine("Designation shouldn't be empty or a number.");
                    goto DesignationInput;
                }
            }
            catch {  };

            //Employment Date validation
            DateInput:
            Console.WriteLine("Enter Employee's Date Of Joining:");
            string dateOfJoining = Console.ReadLine();
            if (!string.IsNullOrEmpty(dateOfJoining))
            {
                Console.WriteLine("okay");
            }
            else
            {
                Console.WriteLine("Date should not be empty or a number");
                goto DateInput;
            }

            Utility dayOfJoining = new Utility();
            Employees emp = new Employees();


            emp.Id = empId;
            emp.Name = empName;
            emp.Salary = empSalary;
            emp.Designation = empDesignation;
            emp.DateOfJoining = dayOfJoining.ConvertToDate(dateOfJoining);

            Console.WriteLine("Employee ID:"+ emp.Id);
            Console.WriteLine("Employee Name:"+ emp.Name );
            Console.WriteLine("Employee Salary:" + emp.Salary);
            Console.WriteLine("Employee Designation:" + emp.Designation);
            Console.WriteLine("Employee Date Of Joining:" + emp.DateOfJoining);
            Console.ReadKey();

        }
    }
}