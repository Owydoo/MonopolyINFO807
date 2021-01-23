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

        public Square position;

        public Player(string _name)
        {
            this.name = _name;
            this.money = 200;
            this.position = Board.startSquare; //Does this work ?
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

        /// <summary>
        /// Methods that goes to the next square
        /// </summary>
        public void MoveToNextSquare()
        {
            this.position = position.nextSquare;
        }
    }
}
