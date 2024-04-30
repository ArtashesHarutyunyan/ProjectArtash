using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArtash.Models.Golds;

public class Gold
{
    public double Weight { get; set; }
    public int Quality { get; set; }
    public int Price {  get; private set; }



    public Gold(double weight, int quality)
    {
        Weight = weight;
        Quality = quality;
        if (Quality == 585)
        {
            Price = (int)weight * 15000;
        }
        if (Quality == 999)
        {
            Price = (int)weight * 20000;
        }
        else
        {
            Price = 0;
        }

    }

    public override string ToString()
    {
        return $"Gold: {Weight}g, {Quality} carats";
    }
}
