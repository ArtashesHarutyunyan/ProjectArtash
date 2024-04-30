using ProjectArtash.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArtash.Models.Cars;
using ProjectArtash.Models.Golds;

namespace ProjectArtash.Models.Banks
{
    public static class BankService
    {
        public static void GivingLoanForBuyIngCar(BankClient bankClient, Car chosenCar, ref bool isConfirmed)
        {
            Console.WriteLine("Hello from bank,you want to buy car with loan,Please answer the questions");
            Console.WriteLine("Where are you working?");
            string? company = Console.ReadLine();
            bankClient.CompanyWhereIsWorking = company;
            if (ValidationForBankClient.isAgeOkay(bankClient) && ValidationForBankClient.isWorking(bankClient))
            {
                int moneyFromBank = chosenCar.Price - bankClient.Wallet;
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
        public static void GivingCommercialLoan(Bank bank, BankClient bankClient, int moneyOfLoan,ValidationForBankClient del)
        {
            if (del.isAgeOkay(bankClient) && del.isWorking(bankClient))
            {
                bankClient.SetLoanToBanks(moneyOfLoan);
                bankClient.AddMoneyToWallet(moneyOfLoan);                             //durs chi galis
                bank.MoneyOfBank.RemoveItemFromGarage(moneyOfLoan);
                

            }

        }
        public static void GivingLoanWithGold(Bank bank, BankClient bankClient, Gold gold)
        {
            bankClient.SetLoanToBanks(gold.Price);
            bankClient.AddMoneyToWallet(gold.Price);
            bank.GoldGarage.AddItemToGarage(gold);
            
        }





    }
}
