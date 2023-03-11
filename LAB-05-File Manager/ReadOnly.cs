using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace File_Manager
{
    internal class ReadOnly : FileClass
    {
        public ReadOnly(string filename, string filecontent) 
            {
              SetFileName(filename);
              SetFileType("Read Only");
              SetFileContent(filecontent);
              SetFileSize(filecontent.Length);
            }
        public void print()
        { }

        public void archived()
        { }
    }
}
