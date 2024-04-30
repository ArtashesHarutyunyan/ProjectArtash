using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ProjectArtash.Models.Persons;
using ProjectArtash.Models.Company;

namespace ProjectArtash.Models.Banks
{
    public class BankClient: Client     //vonc grem public class BankCLient<T>:Client where T : Company(abstract class)
    {
        public BankClient(string name, string surname, int age) : base(name, surname, age)
        {
        }

        public int LoanToBanks { get; private set; }

        public void SetLoanToBanks(int loan)
        {
            LoanToBanks += loan;
        }

        public string CompanyWhereIsWorking { get; set; } // public T CompanyWhereIsWorking
    }


}
