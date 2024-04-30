using ProjectArtash.Models.Cars;
using ProjectArtash.Models.Garage;
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
        public List<Employee> Employees { get; set; }
        public Garage<Car> Garage { get; set; }
        public Carmarket()
        {
            Garage = new Garage<Car>();
        }


        public Carmarket InitializingCarMarket()
        {
            var carMarket = new Carmarket
            {
                Name = "Metsaniv",
                Employees = new List<Employee>
                {
                    new Employee("Hakob", "Hakobyan", 55),
                    new Employee("Karine", "Grigoryan", 33)
                }
            };

            carMarket.Garage.AddItemToGarage(new Audi { Name = "Audi", Model = "a5", ProducedYear = new DateTime(2005, 5, 21), Price = 8000 });
            carMarket.Garage.AddItemToGarage(new Bmw { Name = "Bmw", Model = "x5", ProducedYear = new DateTime(2006, 12, 25), Price = 15000 });
            carMarket.Garage.AddItemToGarage(new Mercedes { Name = "Mercedes", Model = "s500", ProducedYear = new DateTime(2012, 1, 5), Price = 35000 });

            return carMarket;
        }
    }
}
