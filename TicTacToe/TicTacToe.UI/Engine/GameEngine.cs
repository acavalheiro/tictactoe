using System.Runtime.CompilerServices;

namespace TicTacToe.UI.Engine
{
    public class Player
    {
        public Player(string name, string tag)
        {
            this.Name = name;
            this.Tag = tag;
        }
        public string Name { get; set; }
        public string Tag { get; set; }

        public int Wins { get; set; }

    }
    public class GameEngine
    {
        public Player? playerOne;
        public Player? playerTwo;

        private Player? currentPlayer;

        public string[,] Board => this._board;

        private string[,] _board = new string[3, 3];

        private bool _player;

        private int _currentMoves = 0;

        public string? GameStatus { get; set; }

        public void PlayerCall(int x, int y)
        {
            if (!string.IsNullOrEmpty(_board[x, y]))
                return;

            _board[x, y] = this.currentPlayer.Tag;
            _currentMoves++;

            if (this.CheckForWin())
            {
                if (this.currentPlayer.Tag == this.playerOne.Tag)
                    this.playerOne.Wins++;
                else
                    this.playerTwo.Wins++;

                this.SetGameStatus(true);
                return;
            }

            this.SetCurrentPlayer();

            this.SetGameStatus();
        }

        public bool IsLocked(int x, int y)
        {
            return !string.IsNullOrEmpty(_board[x, y]);
        }


        public void SetupPlayers(string playerOne, string playerTwo)
        {
            this.playerOne = new Player(playerOne, "X");
            this.playerTwo = new Player(playerTwo, "0");
            this.Restart();
        }

        public void Restart()
        {
            _board = new string[3, 3];
            this._currentMoves = 0;
            this.SetCurrentPlayer();
            this.SetGameStatus();
        }

        private void SetCurrentPlayer()
        {
            this.currentPlayer = _player ? playerOne : playerTwo;
            _player = !_player;
        }

        private void SetGameStatus(bool isWinner = false)
        {
            this.GameStatus = isWinner ? $"Player {this.currentPlayer.Name} ({this.currentPlayer.Tag}) Wins!" : $"Player {this.currentPlayer.Name} ({this.currentPlayer.Tag}) to play!";
        }

        private bool CheckForWin()
        {
            if (this._currentMoves < 5) return false;

            for (int i = 0; i < 3; i++)
            {
                if (_board[i, 0] == this.currentPlayer.Tag && _board[i, 1] == this.currentPlayer.Tag && _board[i, 2] == this.currentPlayer.Tag)
                {
                    return true;
                }

                if (_board[0, i] == this.currentPlayer.Tag && _board[1, i] == this.currentPlayer.Tag && _board[2, i] == this.currentPlayer.Tag)
                {
                    return true;
                }
            }

            return (_board[0, 0] == this.currentPlayer.Tag && _board[1, 1] == this.currentPlayer.Tag && _board[2, 2] == this.currentPlayer.Tag) ||
                (_board[0, 2] == this.currentPlayer.Tag && _board[1, 1] == this.currentPlayer.Tag && _board[2, 0] == this.currentPlayer.Tag);
        }
    }
}
