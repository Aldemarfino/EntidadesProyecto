using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Archive
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public Proyect Proyect { get; set; }

        public Archive() { }

        public Archive(int idArchive, string fileName, string filePath)
        {
            FileName = fileName;
            FilePath = filePath;
        }
    }
}
