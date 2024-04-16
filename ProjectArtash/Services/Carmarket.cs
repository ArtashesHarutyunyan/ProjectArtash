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

        public Carmarket InitializingCarMarket()
        {
            Carmarket carMarket = new Carmarket
            {
                Name = "Metsaniv",
                Cars = new List<Car>
            {
            new Audi { Name = "Audi", Model = "a5", ProducedYear = new DateTime(2005,05,21), Price = 8000 },
            new Bmw { Name = "Bmw", Model = "x5", ProducedYear = new DateTime(2006,12,25), Price = 15000 },
            new Mercedes { Name = "Mercedes", Model = "s500", ProducedYear = new DateTime(2012,01,05), Price = 35000 }
            },
                Employees = new List<Employee>
                {
                    new Employee("Hakob", "Hakobyan",55),
                    new Employee("Karine", "Grigoryan",33)
                }
            };
            return carMarket;
        }

    }
}
