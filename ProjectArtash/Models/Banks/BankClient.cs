using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ProjectArtash.Models.Persons;

namespace ProjectArtash.Models.Banks
{
    public class BankClient : Client
    {
        public BankClient(string name, string username, int age) : base(name, username, age)
        {

        }
        public int LoanToBanks { get; private set; }
        public void SetLoanToBanks(int loan)
        {
            this.LoanToBanks += loan;
        }
        public string CompanyWhereIsWorking { get; set; }


    }
}
