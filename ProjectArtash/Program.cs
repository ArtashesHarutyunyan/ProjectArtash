using ProjectArtash.Models.Cars;
using ProjectArtash.Models.Persons;
using ProjectArtash.Services;
public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {

            Client client = Carservice.MakingClientWithUser();
            Carmarket carMarket = new Carmarket
            {
                Name = "Metsaniv",
                Cars = new List<Car>
        {
        new Audi { Name = "Audi", Model = "a5", Year = 2015, Price = 8000 },
        new Bmw { Name = "Bmw", Model = "x5", Year = 2006, Price = 15000 },
        new Mercedes { Name = "Mercedes", Model = "s500", Year = 2012, Price = 35000 }
        },
                Employees = new List<Employee>
            {
                new Employee("Hakob", "Hakobyan",55),
                new Employee("Karine", "Grigoryan",33)
            }
            };
            Car chosenCar = Carservice.OfferingCarsToCLient(client, carMarket.Cars);
            Carservice.EndOfBuying(chosenCar, client);
        }

    }
}