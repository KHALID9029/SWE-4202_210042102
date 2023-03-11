using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Enrollment
{
    internal class Department
    {
        private int Code;
        private string Name;

        public Department(int _Code, string _Name)
        {
            Code= _Code;
            Name= _Name;    
        }

        public Department() { }

        public List<Student> Students= new List<Student>();

        public int GetCode() { return Code; }
        public string GetName() { return Name; }

        public void SetCode(int _Code) { Code = _Code;}
        public void SetName(string _Name) { Name= _Name;}
    }
}
