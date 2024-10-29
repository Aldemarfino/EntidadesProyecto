using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class UserLogic : IOperations<User>
    {
        UserRepository userRepository;
        public UserLogic() 
        {
            userRepository = new UserRepository(Config.FILEUSER);
        }
        public bool Add(User obj)
        {
            return userRepository.Save(obj);
        }

        public List<User> GetAll()
        {
            return userRepository.Read();
        }

        public User ObtainByEmail(string text)
        {
            return userRepository.GetByEmail(text);
        }

        public User ObtainByUsername(string text)
        {
            return userRepository.GetByUsername(text);
        }

        public bool UpdateFile(List<User> list)
        {
            return userRepository.SaveList(list);
        }
        
    }
}
