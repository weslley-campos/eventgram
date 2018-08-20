using System;
using System.Collections.Generic;
using System.Text;
using Persistence.Persistence;
using Model.Models;

namespace Business.Business
{
    public class UserManager
    {
        UserPersistence userPersistence;

        public UserManager() => userPersistence = new UserPersistence();

        public List<User> GetAll() => userPersistence.GetAll();

        public User GetBy(int id) => userPersistence.GetBy(id);

        public void Create(User user) => userPersistence.Add(user);

        public void Edit(User user) => userPersistence.Update(user);

        public void Delete(int id) => userPersistence.Delete(id);
    }
}
