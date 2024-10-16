using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class User
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public List<Proyect> Proyects { get; set; }

        public User()
        {
            Proyects = new List<Proyect>();
        }

        public User(int idUser, string userName, string email, string password, string role)
        {
            IdUser = idUser;
            UserName = userName;
            Email = email;
            Password = password;
            Role = role;
            Proyects = new List<Proyect>();
        }
    }
}
