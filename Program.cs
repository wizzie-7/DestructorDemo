using System;

namespace DestructorDemo
{
    class Employee
    {
        int empID = 1001;
        string empname = "Vivek Jadhav";
        public Employee()
        {
            Console.WriteLine("Contructor of Employee class");
        }
        ~Employee()
        {
            Console.WriteLine("Destroy object of Employee");
        }
        public void printDetails()
        {
            Console.WriteLine("Employee ID: {0} || Employee Name: {1}", empID, empname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.printDetails();
            // Employee EMP2 = new Employee();
        }
    }
}
