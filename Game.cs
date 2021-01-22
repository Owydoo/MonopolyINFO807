using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyINFO807
{
    class Game
    {
        public List<Player> players;

        public Game()
        {
            this.players = new List<Player>();
        }

        public Game(List<Player> players)
        {
            this.players = players;
        }

        /// <summary>
        /// Add a Player in the game.
        /// Problem, does not check if the number of players exceeds the limit.
        /// </summary>
        /// <param name="_player"></param>
        public void AddPlayer(Player _player)
        {
            if (TooMuchPlayers(players))
            {
                Console.WriteLine("Vous ne pouvez enregistrer ce joueur, il y a déjà trop de joueurs.");
            }
            else
            {
                players.Add(_player);
                Console.WriteLine(_player.name + " a été ajouté aux joueurs de cette partie");
            }
        }

        /// <summary>
        /// Checks if there are too much players who want to play monopoly
        /// PROBLEM : Not in modelio
        /// </summary>
        /// <param name="_players"></param>
        /// <returns></returns>
        private bool TooMuchPlayers(List<Player> _players)
        {
            return (_players.Count >= 6);
        }

        public void BeginGame()
        {
            //Checks if the number of players is right to begin
            if (CheckNbPlayers(players))
            {
                //Creating the board, etc ...
                Console.WriteLine("Creating the board, etc ...");
            }
            else
            {
                Console.WriteLine($"Désolé, le nombre de joueurs doit être entre 2 et 6 et il est de {players.Count}." );
            }
            

        }

        /// <summary>
        /// Checks that the number of players registered is ok to begin the game
        /// </summary>
        /// <param name="_players"></param>
        /// <returns></returns>
        private bool CheckNbPlayers(List<Player> _players)
        {
            return (_players.Count >= 2 && _players.Count <= 6);
        }

        /// <summary>
        /// Returns a list of players in a string
        /// </summary>
        /// <returns></returns>
        public string PlayersToString()
        {
            string _displayText = "";
            int _index = 0;
            foreach (var _player in players)
            {
                _index++;
                _displayText = _displayText + "Joueur " + _index + "\n";
                _displayText = _displayText + _player.ToString() + "\n";
            }

            return _displayText;
        }

    }
}
