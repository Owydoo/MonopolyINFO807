using MonopolyINFO807.DifferentsSquares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyINFO807
{
    class Board
    {
        public List<Square> squares = new List<Square>();

        //We need the list of players from game because the board needs to know where is each player
        public List<Player> players; 

        //create all the squares :
        public static StartSquare startSquare = new StartSquare(propSquare1);
        public static PropertySquare propSquare1 = new PropertySquare("Boulevard de Belleville", nothingSquare1);
        public static Square nothingSquare1 = new SpecialSquare("Caisse de Communauté", startSquare);
        
        
        public Board(List<Player> _players)
        {

            this.players = _players;

            squares.Add(startSquare); //If I change squares[0] does it change _startSquare ?
            squares.Add(propSquare1);
            squares.Add(nothingSquare1);
        }

        /// <summary>
        /// Finds the player with _playerName and moves him from his position to the next
        /// Square _nbFromDice times.
        /// </summary>
        /// <param name="_nbFromDice"></param>
        /// <param name="_playerName"></param>
        public void Move(int _nbFromDice, string _playerName)
        {
            foreach (var player in players)
            {
                if (_playerName.Equals(player.name))
                {
                    //avancer de _nbFromDice cases
                    for (int i = 0; i < _nbFromDice; i++)
                    {
                        player.MoveToNextSquare();

                        string _displayText = $"Le joueur {player.name} passe sur la case player.position.name;" ;
                        Console.WriteLine(_displayText);

                    }

                    string _displayText2 = $"Le joueur {player.name} est arrivé sur la case player.position.name." ;
                    Console.WriteLine(_displayText2);

                }
            }

        }

        public override string ToString()
        {
            string _board = "";

            for (int i = 0; i < squares.Count; i++)
            {
                _board += $"case {i} : {squares[i].name}\n";
            }

            return _board;
        }
    }
}
