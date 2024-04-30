using ProjectArtash.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArtash.Models.Company
{
    public class Company1 : Company
    {
        public override string Name { get => Name; set => Name = "Company1"; }
        public Employee Employee { get; set; }

        public override void SetSalaryOfEmployee()
        {
           Employee.SetSalary(200000);
        }
    }
}
