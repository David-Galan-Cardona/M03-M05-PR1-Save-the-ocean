using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_the_ocean
{
    public class Rescue
    {
        public const string Orca = "L'orca té un grau d'afectació de ";
        public const string SeaTurtle = "La tortuga té un grau d'afectació de ";
        public const string SeaBird = "La gavina té un grau d'afectació de ";
        public const string SelectAnimalDecision = ", què vols fer?:\n1.Curar aquí\n2.Fer un trasllat al centre";

        public const string Table1 = "+-------------------------------------------------------------+\n|                       RESCAT                                |\n" +
            "+-------------------------------------------------------------+\n| # Rescat | Data rescat | Superfamília   | GA | Localització |\n+-------------------------------------------------------------+\n| {0}   | {1}  | {2}         | {3} | {4}     |\n+-------------------------------------------------------------+",
            Table2= "+-------------------------------------------------------------+\n|                       FITXA                                 |\n+-------------------------------------------------------------+\n| # Nom | Superfamília | Espècie        | Pes aproximat       |\n+-------------------------------------------------------------+\n| {0} | {1}       | {2}   | {3}kg              |\n+-------------------------------------------------------------+";
        public string RescueId { get; set; }
        public string Date { get; set; }
        public string Species { get; set; }
        public int GA { get; set; }
        public string Location { get; set; }
        public Animal Animal { get; set; }

        public Rescue()//Aquest es fa per a que el codi pugui compilar-se sense errors, encara que no fa cap servei
        {
            RescueId = "RES 001";
            Date = "01/01/2021";
            Species = "Sea Bird";
            GA = 5;
            Location = "Beach";
            Animal = new SeaBird("Sea Bird", "Laridae", "Larus", 5);
        }
        public Rescue(int rescueId, string date, string species, int ga, string location, Animal animal)
        {
            if (rescueId < 100)//amb això asegurem que tingui 3 xifres
            {
                RescueId = "RES 0" + rescueId;
            }
            else if (rescueId < 10)
            {
                RescueId = "RES 00" + rescueId;
            }
            else { RescueId = "RES" + rescueId; }
            Date = date;
            Species = species;
            GA = ga;
            Location = location;
            Animal = animal;
        }
        /// <summary>
        /// Method to show the first table
        /// </summary>
        public void ShowRescue()
        {
            Console.WriteLine(Table1, RescueId, Date, Species, GA, Location);
        }
        /// <summary>
        /// Method to show the second table
        /// </summary>
        public void ShowAnimal()
        {
            Console.WriteLine(Table2, Animal.Name, Animal.SuperFamily, Animal.Species, Animal.Weight);
        }

        /// <summary>
        /// Method to show the GA of the animal
        /// </summary>
        /// <param name="animalChoice"></param>
        public void showGa(int animalChoice)
        {
            if (animalChoice == 1)
            {
                Console.WriteLine(Orca + GA + "%" + SelectAnimalDecision);
            }
            else if (animalChoice == 2)
            {
                Console.WriteLine(SeaTurtle + GA + "%" + SelectAnimalDecision);
            }
            else
            {
                Console.WriteLine(SeaBird + GA + "%" + SelectAnimalDecision);
            }
        }

    }
}
