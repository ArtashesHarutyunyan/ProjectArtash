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
        public static void GivingLoan(Client client)  //Aranc using dnelu chi erevum client classy?
        {
            if ((client.Age > 18) && (client.Age < Person.maxAgeOfWorking))
            {

            }
            else
            {
                Console.WriteLine("Cant Give Loan,beacause of Age");
            }
        }
    }
}
