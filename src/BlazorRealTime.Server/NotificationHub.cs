using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRealTime.Server
{
    public class NotificationHub : Hub
    {

        public override Task OnConnectedAsync()
        {
            Debug.WriteLine(Context.ConnectionId);
            return base.OnConnectedAsync();
        }

    }
}
