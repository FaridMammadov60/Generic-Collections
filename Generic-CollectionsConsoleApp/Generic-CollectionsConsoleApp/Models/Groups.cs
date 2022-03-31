using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_CollectionsConsoleApp.Models
{
    internal class Groups
    {
        #region Fields
        string _groupname = "AP";
        static int num= 100;       
        string _no;
        Student[] _student;
        #endregion

        #region Properties
        public string No 
        { 
            get
            {
                return _no;
            }         
        }

        public Student[] Students 
        {
            get
            {
                return _student;
            }
            set
            {
                _student = value;
            }
        }

        #endregion

        #region Consturtor
        public Groups()
        {
            num++;
            _no = _groupname + num;
            Students = new Student[0];
        }
        #endregion

        public override string ToString()
        {
            return $"{_no}"; 
        }
        #region Method
        public void AddStudent(Student student)
        {
            Array.Resize(ref _student, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
        public void GetAllStudent()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(Students[i]);
            }

        }

        public Student [] Sort()
        {
            Student[] stu = Students;            
            Array.Sort<Student>(stu, delegate (Student c1, Student c2)
            {
                return c1.Point.CompareTo(c2.Point);          
                
            });           
            return stu;
        }
        #endregion
    }
}
