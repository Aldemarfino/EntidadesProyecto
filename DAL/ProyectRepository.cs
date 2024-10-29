using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
namespace DAL
{
    public class ProyectRepository : BaseRepository<Proyect>
    {
        public ProyectRepository(string filename):base(filename) { }
        public override List<Proyect> Read()
        {
            throw new NotImplementedException();
        }
    }
}
