using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonopolyINFO807
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            game.AddPlayer(new Player("Paul"));
            game.AddPlayer(new Player("Luc"));

            string _displayText = "Les joueurs ont été créés";
            alertBox.Text = _displayText;
            Console.WriteLine(_displayText);
            Console.WriteLine(game.PlayersToString());
        }

        private void createGame_Click(object sender, EventArgs e)
        {
            game = new Game();
            
            string _displayText = "La Partie a été créée";
            alertBox.Text = _displayText;
            Console.WriteLine(_displayText);
            
        }
    }
}
