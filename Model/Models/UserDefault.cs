using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key]
        public int Id { get => id; set => id = value; }

        [Required(ErrorMessage = "O nome do usuário é obrigatório")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]  
        public string Nome { get => nome; set => nome = value; }

        [Required(ErrorMessage = "O e-mail do usuário é obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get => email; set => email = value; }

        [Required(ErrorMessage = "A senha do usuário é obrigatória")]
        [StringLength(100, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Senha { get => senha; set => senha = value; }
    }
}
