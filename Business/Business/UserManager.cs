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

        public List<UserDefault> GetAll() => userPersistence.GetAll();

        public UserDefault GetById(int id) => userPersistence.GetById(id);

        public void Create(UserDefault user) => userPersistence.Add(user);

        public void Edit(UserDefault user) => userPersistence.Update(user);
    }
}
