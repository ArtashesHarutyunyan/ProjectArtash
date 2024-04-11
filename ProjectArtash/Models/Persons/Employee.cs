using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArtash.Models.Persons
{
    public class Employee : Person
    {
        public static int maxAge { get; set; } = 65;
        public Employee(string name, string surname, int age) : base(name, surname, age)
        {
            if (age < maxAge)
            {
                this.Age = age;
            }
            //else (Exception handle)
        }
        public int Salary { get; private set; }
        public void SetSalary(int salary)
        {
            this.Salary = salary;
        }
        public override void PrintInformation()
        {
            Console.WriteLine($"{this.Name} {this.Salary}");
        }
    }
}
