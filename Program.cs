using System;
namespace Save_the_ocean
{
    public class MainProgram
    {
        public static void Main()
        {
            const string StartMessage = "1.Jugar\n2.Sortir", SelectName= "Introdueix el teu nom:", SelectRole= "Introdueix el teu rol:\n1.Tecnic\n2.Veterinari",
                ReducedGA = "El tractament aplicat ha reduït el GA fins al ", Recovered= "%. L’exemplar està recuperat i pot tornar al seu hàbitat.\nLa teva experiència ha augmentat en +50XP.", 
                Unrecovered= "%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. \nLa teva experiència s’ha reduït en -20XP.", ActualExp= "La teva experiència actual és de {0}XP.", AnimalDecision="Què vols fer?";
            int play, role, animalChoice, healingChoice, nouGA;
            string name;
            bool retrieve;
            Random random = new Random();

            animalChoice = random.Next(1, 4);
            Rescue rescue = new Rescue();//Si no es crea un de buit, el codi no compila ja que l'altre constructor està dins d'un if
            Player player = new Player();

            if(animalChoice == 1)
            {
                Animal cetaci = new Cetacean("Willy", "etaci", "Orca", 5000);
                rescue = new Rescue(random.Next(1,1000), "12/12/2020", "Orca", random.Next(1,100), "Cadaquès", cetaci);
            }
            else if(animalChoice == 2)
            {
                Animal tortugaMarina = new SeaTurtle("Olga", "Tortuga Marina", "Tortuga babaua", 100);
                rescue = new Rescue(random.Next(1, 1000), "12/12/2020", "Tortuga babaua", random.Next(1, 100), "Gavà", tortugaMarina);
            }
            else
            {
                Animal auMarina = new SeaBird("Bert", "Au Marina", "Gavina", 10);
                rescue = new Rescue(random.Next(1, 1000), "12/12/2020", "Gavina", random.Next(1, 100), "Barcelona", auMarina);
            }
            Console.WriteLine(StartMessage);
            play = Convert.ToInt32(Console.ReadLine());
            while (!Validate(play))
            {
                Console.WriteLine(StartMessage);
                play = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(SelectRole);
            role = Convert.ToInt32(Console.ReadLine());
            while (!Validate(role))
            {
                Console.WriteLine(SelectRole);
                role = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(SelectName);
            name = Console.ReadLine() ?? " ";

            if (role == 1)
            {
                 player = new Player(name, "tecnic", 45);
            }
            else
            {
                 player = new Player(name, "veterinari", 80);
            }
            rescue.ShowRescue();
            rescue.ShowAnimal();
            rescue.showGa(animalChoice);
            healingChoice = Convert.ToInt32(Console.ReadLine());
            while (!Validate(healingChoice))
            {
                Console.WriteLine(AnimalDecision);
                healingChoice = Convert.ToInt32(Console.ReadLine());
            }
            if (healingChoice == 1)
            {
                retrieve = true;
            }
            else
            {
                retrieve = false;
            }

            nouGA = rescue.Animal.CalculateGA(rescue.GA, retrieve);

            if (nouGA <= 5)
            {
                Console.WriteLine(ReducedGA+ nouGA + Recovered);
                player.Exp += 50;
                Console.WriteLine(ActualExp,player.Exp);
            }
            else
            {
                Console.WriteLine(ReducedGA + nouGA + Unrecovered);
                player.Exp -= 20;
                Console.WriteLine(ActualExp, player.Exp);
            }
        }
        /// <summary>
        /// Method to validate if the number is 1 or 2
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool Validate(int num)
        {
            if (num == 1 || num == 2)
            {
                return true;
            }
            return false;
        }   
    }
}