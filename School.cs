using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSprac19_Indexer
{
    class School
    {
        private List<Student> studentList = new List<Student>();
        public School()
        {
            studentList.Add(new Student { ID = 1, Department = "CSE", Name = "Siam", });
            studentList.Add(new Student { ID = 2, Department = "CSE", Name = "Nafiz", });
            studentList.Add(new Student { ID = 3, Department = "BBA", Name = "Tamim", });
            studentList.Add(new Student { ID = 4, Department = "BBA", Name = "Ahad", });
            studentList.Add(new Student { ID = 5, Department = "EEE", Name = "Habib", });
            studentList.Add(new Student { ID = 6, Department = "EEE", Name = "Prodip", });
        }

        public string this[int id]
        {
            get
            {
                foreach(Student s in studentList)
                {
                    if(s.ID==id)
                    {
                        return s.Name;
                    }
                }
                return "Invalid ID";
            }
            set
            {
                foreach (Student s in studentList)
                {
                    if (s.ID == id)
                    {
                        s.Name = value;
                    }
                }
            }
        }

        public string this[string name]
        {
            get
            {
                foreach (Student s in studentList)
                {
                    if (s.Name.Equals(name))
                    {
                        return s.Department;
                    }
                }
                return "Invalid ID";
            }
            set
            {
                foreach (Student s in studentList)
                {
                    if (s.Name.Equals(name))
                    {
                        s.Department = value;
                    }
                }
            }
        }
    }
}
