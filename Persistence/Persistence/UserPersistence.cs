using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Persistence.Persistence
{
    public class UserPersistence
    {
        private static List<UserDefault> users;

        static UserPersistence()
        {
            if (users == null)
            {
                users = new List<UserDefault>();
                new UserPersistence().Add(new UserDefault("Thiago", "thiago@bol.com", "1231"));
                new UserPersistence().Add(new UserDefault("Weslley", "weslley@bol.com", "131"));
            }
        }

        public void Add(UserDefault user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
        }

        public int Find(UserDefault user) => users.FindIndex(e => e.Id == user.Id);

        public void Update(UserDefault user) => users[Find(user)] = user;
        
        public List<UserDefault> GetAll() => users;

        public UserDefault GetBy(int? id) => id.HasValue ? users.Find(user => user.Id == id) : null;

        public void Delete(int id) => users.Remove(GetBy(id));
        
    }
}
