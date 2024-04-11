using ProjectArtash.Models.Cars;
using ProjectArtash.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArtash.Services
{
    public static class Carservice
    {
        public static Car OfferingCarsToCLient(Client client, List<Car> cars)
        {
            Console.WriteLine("You Can Choose One Of This Cars");
            Dictionary<int, Car> dict = new Dictionary<int, Car>();
            int key = 0;
            foreach (Car carForClient in cars)
            {

                if (client.Wallet > carForClient.Price)
                {
                    key++;
                    dict.Add(key, carForClient);
                }
            }
            foreach (KeyValuePair<int, Car> pair in dict)
            {
                Console.WriteLine($"Key: {pair.Key} : {pair.Value.Name} {pair.Value.Price}");
            }
            return ChoosingCar(dict);

        }
        public static Car ChoosingCar(Dictionary<int, Car> dict)
        {
            Console.WriteLine("What Car Do You Want,Input the Key:");
            int userKey = int.Parse(Console.ReadLine());
            if (dict.ContainsKey(userKey))
            {
                return dict[userKey];
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid car.");
                return null;
            }
        }
        public static void EndOfBuying(Car car, Client client)
        {
            Console.WriteLine($"Are you sure you want to buy {car.Name}? Answer Yes or no");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "yes":
                    PrintHDM(car, client);
                    break;
                case "no":
                    Console.WriteLine("See You Next Time");
                    break;
            }
        }
        public static void PrintHDM(Car car, Client client)
        {
            Console.WriteLine($"{client.Name} {client.Surname} bought {car.Name} {car.Model} {car.Year} for {car.Price}$");
        }
        public static Client MakingClientWithUser()
        {
            Console.Write("Hello to our carservice,Please Write What is your name:");
            string Name = Console.ReadLine();
            Console.Write("Surname:");
            string Surname = Console.ReadLine();
            Console.Write("Age:");
            int age = int.Parse(Console.ReadLine());
            Client client = new Client(Name, Surname, age);
            Console.Write("How much money do you have?:");
            client.SetAmountOfWallet(int.Parse(Console.ReadLine()));
            return client;

        }
    }
}
