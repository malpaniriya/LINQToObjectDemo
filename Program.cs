using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectDemo
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public int Salary { get; set; }

    }
        public class Program
        {
            static void Main(string[] args)
            {
            List<Employee> Employees = new List<Employee>()
                {
                    new Employee { Id = 1, Name = "Riya", City = "Pune", Salary = 35000 },
                    new Employee { Id = 1, Name = "Shruti", City = "Satara", Salary = 25000 },
                    new Employee { Id = 1, Name = "Aditya", City = "Nashik", Salary = 45000 },
                    new Employee { Id = 1, Name = "Amit", City = "Solapur", Salary = 55000 },
                    new Employee { Id = 1, Name = "Sumit", City = "Mumbai", Salary = 25000 },
                    new Employee { Id = 1, Name = "Bharat", City = "Nagpur", Salary = 65000 },
                    new Employee { Id = 1, Name = "Yash", City = "Tirupati", Salary = 85000 },
                    new Employee { Id = 1, Name = "Ruturaj", City = "Pune", Salary = 35000 },
                    new Employee { Id = 1, Name = "Meet", City = "Mumabi", Salary = 55000 },
                    new Employee { Id = 1, Name = "Roshan", City = "Nashik", Salary = 33000 },
                    new Employee { Id = 1, Name = "Shravan", City = "Satara", Salary = 44000 },






                };

            //var result = from e in Employees
            //             where e.City == "Pune"
            //             select e;

            //foreach(Employee emp in result)
            //{
            //    Console.WriteLine($"{emp.Id},{emp.Name},{emp.City},{emp.Salary}");
            //}

            //var result2 = from e in Employees
            //              where e.Name.StartsWith("R")
            //              select e;


            //foreach (Employee item in result2)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}

            //var result3 = from e in Employees
            //              where e.Salary > 65000 && e.City == "Pune"
            //              select e;


            //foreach (Employee item in result3)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}




        }
    }
    }

