using ProjectArtash.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArtash.Models.Cars;

namespace ProjectArtash.Models.Banks
{
    public static class BankService
    {
        public static void GivingLoan(BankClient bankClient,Car chosenCar,ref bool isConfirmed)
        {
            Console.WriteLine("Where are you working?");
            string company = Console.ReadLine();
            bankClient.CompanyWhereIsWorking = company;
            if (ValidationForBankClient.isAgeOkay(bankClient) && ValidationForBankClient.isWorking(bankClient))
            {
                int moneyFromBank = chosenCar.Price- bankClient.Wallet;
                Console.WriteLine("Succes Of Giving Loan,check your wallet");    //uxxel
                bankClient.SetLoanToBanks(moneyFromBank);
                bankClient.AddMoneyToWallet(moneyFromBank);
                isConfirmed = true;

            }
            else
            {
                Console.WriteLine("Error,Cant give you a loan");
            }

        }

    }
}
