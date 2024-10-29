using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BaseRepository<T>
    {
        protected string fileName = string.Empty;
        protected BaseRepository(string fileName)
        {
            this.fileName = fileName;
        }

        public bool Save(T Entity)
        {
            try
            {
                StreamWriter writer = new StreamWriter(fileName, true);
                writer.WriteLine(Entity.ToString());
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool SaveList(List<T> List)
        {
            try
            {
                StreamWriter writer = new StreamWriter(fileName);
                foreach (T Entity in List)
                {
                    writer.WriteLine(Entity.ToString());
                }
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public abstract List<T> Read();
    }
}
