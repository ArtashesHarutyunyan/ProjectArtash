using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArtash.Models.Persons;

namespace ProjectArtash.Models.Banks
{
    public static class ValidationForBankClient
    {
        public static bool isAgeOkay(Client bankclient)
        {
            if ((bankclient.Age > 18) && (bankclient.Age < Person.maxAgeOfWorking))
            {
                return true;
            }
            else { return false; }
        }
        public static bool isWorking(BankClient bankclient)
        {
            if (bankclient.CompanyWhereIsWorking != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
