using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyINFO807.DifferentsSquares
{
    class SpecialSquare : Square
    {
        public SpecialSquare()
        {
            this.name = "";
            this.nextSquare = null;
        }
        public SpecialSquare(string _name, Square _square)
        {
            this.name = _name;
            this.nextSquare = _square;
        }
    }
}
