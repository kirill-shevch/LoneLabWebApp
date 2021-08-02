using LoneLabWebApp.Services.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoneLabWebApp.Services.Hubs
{
    public class UserListHub : Hub
    {
        public UserListHub()
        {
        }

        public async Task SendUserList(List<string> userNames)
        {
            await Clients.All.SendAsync("ReceiveUserList", string.Join(", ", userNames));
        }
    }
}
