using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Manager
{
    internal class Editable : FileClass
    {
        public Editable(string filename,string filecontent) 
        {
            SetFileName(filename);
            SetFileType("Editable");
            SetFileContent(filecontent);
            SetFileSize(filecontent.Length);

        }

        public Editable() { }
        public void Edited(Editable ed,string newcontent)
        {
            ed.SetFileContent(newcontent);
            ed.SetFileSize(newcontent.Length);
        }

        public void Translated()
        { }
    }
}
