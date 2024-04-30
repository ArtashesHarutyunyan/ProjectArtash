using ProjectArtash.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArtash.Models.Garage;
using ProjectArtash.Models.Golds;

namespace ProjectArtash.Models.Banks
{
    public class Bank
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Address { get; set; }

        public static int PercentOfLoan { get; set; } = 18;
        public  Garage<int> MoneyOfBank { get; set; } // durs chi galis
        public Garage<Gold> GoldGarage { get; set; }
        public Bank()
        {
            MoneyOfBank = new Garage<int>();
            GoldGarage = new Garage<Gold>();
        }


    }
}

