using ProjectArtash.Models.Banks;
using ProjectArtash.Models.Cars;
using ProjectArtash.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArtash.Services
{
    public static class CarService
    {
        public static void ShowCarsInCarMarket(Carmarket carmarket)
        {
            Console.WriteLine("Here are cars in carmarket");
            int i = 1;
            foreach (Car car in carmarket.Cars)
            {
                Console.WriteLine($"{i}: {car.PrintInformation()} ");
                i++;
            }
        }
        public static void FindOutIfClientWantsToBuyWithCash(Client client)
        {
            Console.WriteLine("");
        }


        public static Car ChoosingCar(Carmarket carmarket)
        {
            Car chosencar = new Car();
            Console.WriteLine("What Car Do You Want,Input the Key:");
            int userKey = int.Parse(Console.ReadLine());
            if (carmarket.Cars[userKey - 1] == null)
            {
                Console.WriteLine("Invalid choice. Please select a valid car.");
                return ChoosingCar(carmarket);

            }
            else
            {

                return carmarket.Cars[userKey - 1];
            }
        }
        public static void EndOfBuyingWithLoanFromBank(Client client,Car chosenCar,Carmarket carmarket)
        {
            bool isLoanConfirmed = false;
            BankClient bankclient = new BankClient(client.Name, client.Surname, client.Age);
            bankclient.AddMoneyToWallet(client.Wallet);
            BankService.GivingLoan(bankclient, chosenCar,ref isLoanConfirmed);
            if(isLoanConfirmed)
            {
               EndOfBuyingWithCashMoney(chosenCar,bankclient,carmarket);
            }
        }
        public static void EndOfBuyingWithCashMoney(Car car, Client client,Carmarket carmarket)
        {
            Console.WriteLine($"Are you sure you want to buy {car.Name}? Answer Yes or no");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "yes":
                    client.MinusMoneyToWallet(car.Price);
                    carmarket.Cars.Remove(car);
                    PrintHDM(car, client);
                    break;
                case "no":
                    Console.WriteLine("See You Next Time");
                    break;
            }
        }
        public static void PrintHDM(Car car, Client client)
        {
            Console.WriteLine($"{client.Name} {client.Surname} bought {car.Name} {car.Model} {car.ProducedYear} for {car.Price}$");
        }
        public static Client MakingClientWithUser()
        {
            Console.Write("Hello to our carservice,Please Write What is your name:");
            string name = Console.ReadLine();
            Console.Write("Surname:");
            string surname = Console.ReadLine();
            Console.Write("Age:");
            int age = int.Parse(Console.ReadLine());
            Console.Write("How much money do you have?");
            int wallet = int.Parse(Console.ReadLine());
            Client client = new Client(name, surname, age);
            client.SetAmountOfWallet(wallet);
            return client;
        }
    }
}
