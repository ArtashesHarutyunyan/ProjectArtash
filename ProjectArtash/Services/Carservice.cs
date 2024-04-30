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
            foreach (Car car in carmarket.Garage.Items)
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
            Console.WriteLine("What car do you want? Input the car's key:");
            int userKey;
            while (!int.TryParse(Console.ReadLine(), out userKey) || userKey < 1 || userKey > carmarket.Garage.Items.Count)
            {
                Console.WriteLine("Invalid choice. Please select a valid car key.");
                Console.WriteLine("Available keys: 1 to " + carmarket.Garage.Items.Count);
                Console.WriteLine("What car do you want? Input the car's key:");
            }

            return carmarket.Garage.Items[userKey - 1];
        }
        public static void EndOfBuyingWithLoanFromBank(Client client, Car chosenCar, Carmarket carmarket)
        {
            bool isLoanConfirmed = false;
            BankClient bankclient = new BankClient(client.Name, client.Surname, client.Age);
            bankclient.AddMoneyToWallet(client.Wallet);
            BankService.GivingLoanForBuyIngCar(bankclient, chosenCar, ref isLoanConfirmed);
            if (isLoanConfirmed)
            {
                EndOfBuyingWithCashMoney(chosenCar, bankclient, carmarket);
            }
        }
        public static void EndOfBuyingWithCashMoney(Car car, Client client, Carmarket carmarket)
        {
            Console.WriteLine($"Are you sure you want to buy {car.Name}? Answer Yes or No");
            string? input = Console.ReadLine()?.ToLower();
            while (input != "yes" && input != "no")
            {
                Console.WriteLine("Invalid input. Please enter Yes or No.");
                input = Console.ReadLine()?.ToLower();
            }

            switch (input)
            {
                case "yes":
                    client.MinusMoneyFromWallet(car.Price);
                    carmarket.Garage.RemoveItemFromGarage(car);
                    PrintHDM(car, client);
                    break;
                case "no":
                    Console.WriteLine("See you next time!");
                    break;
            }
        }
        public static void PrintHDM(Car car, Client client)
        {
            Console.WriteLine($"{client.Name} {client.Surname} bought {car.Name} {car.Model} {car.ProducedYear} for {car.Price}$");
        }

        public static Client MakingClientWithUser()
        {
            string name = "";
            string surname = "";
            int age = 0;


            while (string.IsNullOrEmpty(name))   // vonc anem vor chkarana tver u $%^^ **&^%$#@ dni
            {
                Console.Write("Hello to our carservice, Please write your name: ");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name cannot be empty. Please try again.");
                }
            }


            while (string.IsNullOrEmpty(surname))  
            {
                Console.Write("Surname: ");
                surname = Console.ReadLine();
                if (string.IsNullOrEmpty(surname))
                {
                    Console.WriteLine("Surname cannot be empty. Please try again.");
                }
            }


            while (age <= 0)
            {
                Console.Write("Age: ");
                if (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
                {
                    Console.WriteLine("Please enter a valid age.");
                }
            }

            Console.Write("How much money do you have? ");
            int wallet = int.Parse(Console.ReadLine());

            Client client = new Client(name, surname, age);
            client.SetAmountOfWallet(wallet);
            return client;
        }
    }
}
