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

        public void Create(UserDefault user) => userPersistence.Add(user);
    }
}
