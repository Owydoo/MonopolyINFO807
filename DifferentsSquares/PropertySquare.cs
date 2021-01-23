using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyINFO807.DifferentsSquares
{
    class PropertySquare : Square
    {
        public PropertySquare(string _name, Square _nextSquare)
        {
            this.name = _name;
            this.nextSquare = null;
        }
    }
}
