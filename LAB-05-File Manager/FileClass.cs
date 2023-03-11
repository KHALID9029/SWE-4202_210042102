using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Manager
{
    internal class FileClass
    {
        private string FileName;
        private string FileType;
        private string FileContent;
        private int FileSize;


        public string GetFileName( ) { return FileName; }
        public string GetFileType( ) { return FileType; }
        public int GetFileSize( ) { return FileSize; }
        public string GetFileContent( ) { return FileContent; }

        public void SetFileName(string fileName ) { FileName = fileName; }
        public void SetFileType(string fileType ) { FileType= fileType; }
        public void SetFileSize(int fileSize ) { FileSize= fileSize; }
        public void SetFileContent(string fileContent) { FileContent= fileContent; }
    }
}
