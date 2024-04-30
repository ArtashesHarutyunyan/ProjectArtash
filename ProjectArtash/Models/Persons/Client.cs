using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArtash.Models.Persons
{
    public class Client : Person   
    {
        public Client(string name, string surname, int age) : base(name, surname, age)
        {

        }
        public int Wallet { get; private set; } 
        public void SetAmountOfWallet(int amountOfWallet)
        {
            this.Wallet = amountOfWallet;
        }
        public void AddMoneyToWallet(int money)
        {
            Wallet += money;
        }
        public void MinusMoneyFromWallet(int money)
        {
            Wallet -= money;
        }

        public override void PrintInformation()
        {
            Console.WriteLine($"{this.Name},{this.Wallet}");
        }
        
        

    }
}
