using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArtash.Models.Cars
{
    public  class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public DateTime ProducedYear { get; set; }
        public int Price { get; set; }
        public virtual string PrintInformation()
        {
            return $"{this.Name} {this.Model} {this.ProducedYear} {this.Price}";
        }
       



    }
}
