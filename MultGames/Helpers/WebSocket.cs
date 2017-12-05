using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSocketSharp.Server;

namespace GameRoomsAPI.Helpers
{
    public class WebSocket
    {
        static public WebSocketServer WS;
        static public void Start()
        {
            WS = new WebSocketServer("ws://localhost:8081/");
            WS.Start();
        }
    }
}