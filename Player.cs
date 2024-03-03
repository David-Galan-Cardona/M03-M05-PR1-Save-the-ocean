using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_the_ocean
{
    public class Player
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public int Exp { get; set; }

        public Player(string name, string role, int exp)
        {
            Name = name;
            Role = role;
            Exp = exp;
        }
        public Player()
        {
            Name = "";
            Role = "";
            Exp = 0;
        }
    }
}
