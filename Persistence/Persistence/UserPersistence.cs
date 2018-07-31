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

        public void Update(UserDefault user)
        {
            int idx = users.FindIndex(e => e.Email == user.Email);
            users[idx] = user;
        }

        public List<UserDefault> GetAll() => users;

        public UserDefault GetById(int? id)
        {
            return id.HasValue ? users.Find(user => user.Id == id) : null;
        }
    }
}
