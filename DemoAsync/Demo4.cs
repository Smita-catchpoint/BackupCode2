using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAsync
{
    internal class Demo4
    {

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }
        }
        static async Task<Employee> GetEmployeeDetails()
        {
            Employee employee = new Employee()
            {
                ID = 101,
                Name = "James",
                Salary = 10000
            };

            return employee;
        }
        private async static void SomeMethod()
        {
            Employee emp = await GetEmployeeDetails();
            Console.WriteLine($"ID: {emp.ID}, Name : {emp.Name}, Salary : {emp.Salary}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread Started");
            SomeMethod();
            Console.WriteLine($"Main Thread Completed");
            Console.ReadKey();
        }
    }

}
