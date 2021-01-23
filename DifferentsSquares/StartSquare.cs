using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyINFO807.DifferentsSquares
{
    class StartSquare : Square
    {
        public StartSquare()
        {
            this.name = "Départ";
            this.nextSquare = new PropertySquare("Boulevard de Belleville", null);
        }

        public StartSquare(PropertySquare _square)
        {
            this.name = "Départ";
            this.nextSquare = _square;
        }
    }
}
