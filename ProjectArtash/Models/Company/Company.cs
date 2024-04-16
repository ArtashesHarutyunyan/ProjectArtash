using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArtash.Models.Company
{
    public abstract class Company
    {
        public abstract string Name { get; set; }
        public abstract void SetSalaryOfEmployee();
    }
}
