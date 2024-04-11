using ProjectArtash.Models.Cars;
using ProjectArtash.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArtash.Services
{
    public class Carmarket
    {
        public string Name { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public List<Car> Cars { get; set; }
        public List<Employee> Employees { get; set; }



    }
}
