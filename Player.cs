using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyINFO807
{
    class Player
    {
        public string name;
        public int money;

        public Player(string _name)
        {
            this.name = _name;
            this.money = 200;
        }

        public Player(string _name, int _money)
        {
            this.name = _name;
            this.money = _money;
        }

        public override string ToString()
        {
            return ($"Nom : {this.name}\nArgent : {this.money}");

            
            
        }
    }
}
