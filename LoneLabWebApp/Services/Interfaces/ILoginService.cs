using System.Collections.Generic;

namespace LoneLabWebApp.Services.Interfaces
{
    public interface ILoginService
    {
        public void AddUserName(string userName);

        public void RemoveUserName(string userName);

        public List<string> GetUserNames();
    }
}
