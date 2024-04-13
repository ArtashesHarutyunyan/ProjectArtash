using ProjectArtash.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArtash.Models.Banks
{
    public static class BankService
    {
        public static void GivingLoan(Client client,int money)  //Aranc using dnelu chi erevum client classy?
        {
            if ((client.Age > 18) && (client.Age < Person.maxAgeOfWorking))
            {
                if ((client.LoanToBanks < 1000000) &&  (client.Wallet > 100000))
                {
                    client.AddMoneyToWallet(money);
                    client.LoanToBanks = client.LoanToBanks + money;
                    Console.WriteLine("Succes,Your money is on your wallet");
                }
            }
            else
            {
                Console.WriteLine("Cant Give Loan");
            }
        }
    }
}
