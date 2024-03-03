using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_the_ocean
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string SuperFamily { get; set; }
        public string Species { get; set; }
        public int Weight { get; set; }

        public Animal(string name, string superFamily, string species, int weight)
        {
            Name = name;
            SuperFamily = superFamily;
            Species = species;
            Weight = weight;
        }
        public Animal()
        {
            Name="";
            SuperFamily = "";
            Species = "";
            Weight = 5;
        }
        public abstract int CalculateGA(int GA, bool retrieve);
    }
}
