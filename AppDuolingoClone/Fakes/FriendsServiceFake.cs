using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppDuolingoClone.Interfaces;
using AppDuolingoClone.Models;

namespace AppDuolingoClone.Fakes
{
    public class FriendsServiceFake : IFriendsService
    {
        public async Task<IList<Friend>> GetFriends()
        {
            return await Task.Run(() =>
            {
                return new List<Friend>()
                {
                    GetNewFriend("profile_friends_lisa", "Lisa Simpsons", "12345 XP"),
                    GetNewFriend("profile_friends_bart", "Bart Simpsons", "500 XP"),
                    GetNewFriend("profile_friends_homer", "Homer Simpsons", "200 XP"),
                    GetNewFriend("profile_friends_marge", "Marge Simpsons", "10000 XP")
                };
            });
        }

        private static Friend GetNewFriend(
            string photo,
            string name,
            string experience)
        {
            return new Friend
            {
                Photo = photo,
                Name = name,
                Experience = experience
            };
        }
    }
}
