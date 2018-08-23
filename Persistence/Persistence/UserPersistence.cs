using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Persistence.Persistence
{
    public class UserPersistence
    {
        private static List<User> users;

        static UserPersistence()
        {
            if (users == null)
            {
                users = new List<User>();
                new UserPersistence().Add(new User("Thiago", "thiago@bol.com", "1231"));
                new UserPersistence().Add(new User("Ana", "ana@bol.com", "131"));
                new UserPersistence().Add(new User("Pedro", "weslley@bol.com", "131"));
                new UserPersistence().Add(new User("Carlos", "gabriel@bol.com", "131"));
            }
        }

        public int? Validate(string email, string senha)
        { 
            User user = users.Find(u => u.Email.Equals(email) && u.Senha.Equals(senha));
            return user == null ? -1 : user.Id ;
        }

        public void Add(User user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
        }

        public int Find(User user) => users.FindIndex(e => e.Id == user.Id);

        public void Update(User user) => users[Find(user)] = user;
        
        public List<User> GetAll() => users;

        public User GetBy(int? id) => id.HasValue ? users.Find(user => user.Id == id) : null;

        public void Delete(int id) => users.Remove(GetBy(id));
    }
}
