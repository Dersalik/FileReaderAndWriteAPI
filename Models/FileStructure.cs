using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FileStructure
    {
        public List<FileDetails> files { get; set; }
        public FolderDetails Folder { get; set; }

    }
}
