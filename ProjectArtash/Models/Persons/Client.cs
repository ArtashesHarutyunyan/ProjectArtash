using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArtash.Models.Persons
{
    public class Client : Person     //karam arandzin carmarketclient class unenam u bankclient class(vorovhetev tarber informacianeren petq gorcarqneri hamar)
    {
        public Client(string name, string surname, int age) : base(name, surname, age)
        {

        }
        public int Wallet { get; private set; }  //uzumem unenam amsakanshrjanarutyun vory vor henc walleti het gorcoxutyun klini,kgumari
        public void SetAmountOfWallet(int amountOfWallet)
        {
            this.Wallet = amountOfWallet;
        }

        public override void PrintInformation()
        {
            Console.WriteLine($"{this.Name},{this.Wallet}");
        }
        public int LoanToBanks { get; set; }
        //public bool isEmployee _ karam senc mi ban grem,vor tenam ashxatuma te che?

    }
}
