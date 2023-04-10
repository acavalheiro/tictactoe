using System.Numerics;

namespace TicTacToe.UI.Engine
{
    public class Player
    {
        public Player(string name, char tag)
        {
            this.Name = name;
            this.Tag = tag;
        }
        public string Name { get; set; }
        public char Tag { get; set; }

    }
    public class GameEngine
    {
        private Player playerOne;
        private Player playerTwo;

        public string[,] values = new string[3, 3];

        bool player;

        public void PlayerCall(int x, int y)
        {
            if (!string.IsNullOrEmpty(values[x, y]))
                return;

            values[x, y] = player ? "X" : "0";
            player = !player;
        }

        public bool IsLocked(int x, int y)
        {
            return !string.IsNullOrEmpty(values[x, y]);// ? string.Empty : "cannotuse";
        }

        public void Restart() => values = new string[3, 3];

        public void SetupPlayers(string playerOne, string playerTwo)
        {
            this.playerOne = new Player(playerOne, 'X');
            this.playerTwo = new Player(playerTwo, '0');
        }
    }
}
