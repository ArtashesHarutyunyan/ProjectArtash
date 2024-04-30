using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArtash.Models.Persons;

namespace ProjectArtash.Models.Banks
{
    public delegate bool BankClientValidationDelegate(BankClient bankClient);

    public  class ValidationForBankClient
    {

        public  bool isAgeOkay(BankClient bankclient)
        {
            return (bankclient.Age > 18) && (bankclient.Age < Person.maxAgeOfWorking);
        }
        public  bool isWorking(BankClient bankclient)
        {
            return (bankclient.CompanyWhereIsWorking != null);
          
        }
        BankClientValidationDelegate ageValidation = client => client.Age > 18 && client.Age < Person.maxAgeOfWorking;
        BankClientValidationDelegate workingValidation = client => client.CompanyWhereIsWorking != null;

    }
}
