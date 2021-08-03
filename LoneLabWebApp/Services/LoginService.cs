using LoneLabWebApp.Models;
using LoneLabWebApp.Services.Hubs;
using LoneLabWebApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoneLabWebApp.Services
{
    public class LoginService : ILoginService
    {
        private Dictionary<string, Player> _players = new Dictionary<string, Player>();
        private readonly UserListHub _userListHub;
        public LoginService(UserListHub userListHub)
        {
            _userListHub = userListHub;
        }
        public async Task AddUserName(string userName)
        {
            _players.Add(userName, new Player 
            { 
                Name = userName,
                Color = getRandomColor()
            });
            await _userListHub.SendUserList(_players);
        }

        public async Task RemoveUserName(string userName)
        {
            _players.Remove(userName);
            await _userListHub.SendUserList(_players);
        }

        private string getRandomColor()
        {
            var rand = new Random();
            var letters = "0123456789ABCDEF".ToCharArray();
            var color = new StringBuilder("#");
            for (var i = 0; i < 6; i++)
            {
                color.Append(letters[rand.Next(0, 15)]);
            }
            return color.ToString();
        }
    }
}
