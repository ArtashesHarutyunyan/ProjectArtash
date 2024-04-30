using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectArtash.Models.Garage
{
    public class Garage<T>
    {
        public List<T> Items { get; set; }

        public Garage()
        {
            this.Items = new List<T>();
        }

        public void DisplayItem()
        {
            foreach (var item in Items)
            {
                Console.WriteLine($"The item in the garage is: {item}");   //sxala
            }

        }
        public void AddItemToGarage(T item)
        {
            Items.Add(item);
        }
        public void RemoveItemFromGarage(T item)
        {
            Items.Remove(item);
        }
    }
}

