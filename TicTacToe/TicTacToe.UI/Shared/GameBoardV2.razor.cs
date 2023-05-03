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
using System.Diagnostics;
using TicTacToe.UI.Engine;

namespace TicTacToe.UI.Shared
{
    public partial class GameBoardV2
    {
        [Parameter]
        public GameEngine? Engine { get; set; }
    }
}