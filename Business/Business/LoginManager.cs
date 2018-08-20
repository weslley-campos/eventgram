using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Persistence.Persistence;

namespace Business.Business
{

    public class LoginManager
    {
        UserPersistence userPersistence = new UserPersistence();

        public int? Validate(string email, string senha) => userPersistence.Validate(email, senha);
       
    }
}
