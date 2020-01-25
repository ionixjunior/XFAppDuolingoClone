using System.Collections.Generic;
using System.Threading.Tasks;
using AppDuolingoClone.Models;

namespace AppDuolingoClone.Interfaces
{
    public interface IFriendsService
    {
        Task<IList<Friend>> GetFriends();
    }
}
