using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoneLabWebApp.Services.Interfaces
{
    public interface ILoginService
    {
        public Task AddUserName(string userName);

        public Task RemoveUserName(string userName);
    }
}
