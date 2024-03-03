using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_the_ocean
{
    public class SeaTurtle: Animal
    {
        public SeaTurtle(string name, string superFamily, string species, int weight) : base(name, superFamily, species, weight)
        {
            Name = name;
            SuperFamily = superFamily;
            Species = species;
            Weight = weight;
        }
        /// <summary>
        /// Method to calculate the GA of the SeaTurtle
        /// </summary>
        /// <param name="GA"></param>
        /// <param name="retrieve"></param>
        /// <returns></returns>
        public override int CalculateGA(int GA, bool retrieve)
        {
            int x;
            int result;
            if (retrieve)
            {
                x = 5;
            }
            else
            {
                x = 5;
            }
            
            result = GA - (GA - 2)*(2*GA + 3) -x;
            if (result < 0)
            {
                return 0;
            }
            else
            {
                return result;
            }
        }

    }
}
