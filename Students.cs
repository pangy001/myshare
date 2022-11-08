using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Student
    {
        public int ID { get; set; }
        public int ClassID { get; set; }
        public string Name { get; set; }
    }

    public class StudentGenerator
    {
        public static IList<Student> GetStudentList(int count)
        {
            IList<Student> students = new List<Student>();
            for(int i = 0; i < count; i++)
            {
                if(i < 100)
                {
                    students.Add(new Student { ID = i, ClassID = i % 3, Name = $"stu{i}" });
                }
                else
                {
                    students.Add(new Student { ID = i, ClassID = 0, Name = $"stu{i}" });
                }
                
            }

            return students;
        }
    }
}
