using ProjectArtash.Models.Banks;
using ProjectArtash.Models.Cars;
using ProjectArtash.Models.Persons;
using ProjectArtash.Models.QueueTerminal;
using ProjectArtash.Models.User;
using ProjectArtash.Services;
public class Program
{
    
    public static void Main(string[] args)
    {
        Client client = CarService.MakingClientWithUser();
        Carmarket carMarket = new Carmarket();
        carMarket = carMarket.InitializingCarMarket();
        CarService.ShowCarsInCarMarket(carMarket);
        Car chosenCar = CarService.ChoosingCar(carMarket);

        if (chosenCar.Price > client.Wallet)
        {
            Console.WriteLine("You dont have enough money,now we will try to get money from bank");
            CarService.EndOfBuyingWithLoanFromBank(client, chosenCar, carMarket);

        }
        else
        {
            CarService.EndOfBuyingWithCashMoney(chosenCar, client, carMarket);
        }
        Terminal terminalOfIneco = new Terminal();
        terminalOfIneco.GetToken(client);
        terminalOfIneco.ServeQueueWithDelay(client);
        
        

    }
}