using ProjectArtash.Models.Cars;
using ProjectArtash.Models.Persons;
using ProjectArtash.Services;
public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {

            Client client = CarService.MakingClientWithUser();
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
            Car chosenCar = CarService.OfferingCarsToCLient(client, carMarket.Cars);
            CarService.EndOfBuying(chosenCar, client);
        }

    }
}