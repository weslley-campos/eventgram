using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class UserDefault
    {
        private int id;
        private string nome;
        private string email;
        private string senha;

        public UserDefault() => Id = 0; 

        public UserDefault(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
