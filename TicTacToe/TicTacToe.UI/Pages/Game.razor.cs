using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using TicTacToe.UI;
using TicTacToe.UI.Shared;
using TicTacToe.UI.Engine;

namespace TicTacToe.UI.Pages
{
    public partial class Game
    {
        string visibility = "display:none;";
        string label = "Start Game";
        string? PlayerOne { get; set; }

        string? PlayerTwo { get; set; }

        private async Task StartGame()
        {
            visibility = string.Empty;
            GameEngine.SetupPlayers(PlayerOne, PlayerTwo);
            label = "Restart";
            await Task.CompletedTask;
        }
    }
}