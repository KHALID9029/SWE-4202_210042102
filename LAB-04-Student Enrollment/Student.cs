using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Enrollment
{
    internal class Student
    {
        private int Id;
        private string Name;
        private string Section;
        private int DepCode;

        public Student(int id, string name, string section, int depCode)
        {
            Id = id;
            Name = name;
            Section = section;
            DepCode = depCode;
        }

        public int GetId() { return Id; }   
        public string GetName() { return Name; }
        public string GetSection() { return Section; }
        public int GetDepCode() { return DepCode; }

        public void SetId(int id) { Id = id; }
        public void SetName(string name) { Name= name; }
        public void SetSection(string section) { Section= section; }
        public void SetDepCode(int depCode) { DepCode= depCode; }
    }
}
