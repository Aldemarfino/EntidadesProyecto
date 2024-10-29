using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(string filename):base(filename) { }

        public override List<User> Read()
        {
            try
            {
                string line;
                List<User> userList = new List<User>();
                StreamReader reader = new StreamReader(fileName);
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    userList.Add(Map(line));
                }
                reader.Close();
                return userList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private User Map(string line)
        {
            User user = new User();
            string[] vect = line.Split(';');
            return new User((vect[0]), vect[1], vect[2]);
        }
        public User GetByUsername(string username)
        {
            try
            {
                return Read().FirstOrDefault<User>(x => x.UserName.Equals(username));
            }
            catch (Exception )
            {

                return null;
            }
            
        }
        public User GetByEmail(string email)
        {
            try
            {
                return Read().FirstOrDefault<User>(x => x.Email.Equals(email));
            }
            catch (Exception)
            {

                return null;
            }
            
        }
    }
}
