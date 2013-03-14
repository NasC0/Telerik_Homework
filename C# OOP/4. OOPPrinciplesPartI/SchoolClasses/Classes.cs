/* Classes that hold information about the students attending them
 * and the teachers who participate */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Classes : IComment
    {
        private string comment;
        private List<Student> studentsSet;
        private List<Teacher> teachersSet;
        private string textID;

        public Classes(string textID) : this(textID, new List<Student>(), new List<Teacher>())
        {
            
        }

        public Classes(string textID, List<Student> studentList) : this(textID, studentList, new List<Teacher>())
        {
            
        }

        public Classes(string textID, List<Student> studentList, List<Teacher> teacherList)
        {
            this.textID = textID;
            this.studentsSet = studentList;
            this.teachersSet = teacherList;
        }

        public void AddStudents(Student student)
        {
            this.studentsSet.Add(student);
        }


        public void AddTeachers(Teacher teacher)
        {
            this.teachersSet.Add(teacher);
        }

        public void AddStudentsList(List<Student> studentList)
        {
            
        }

        public void AddTeachersList(List<Teacher> teachersList)
        {
            this.teachersSet.AddRange(teachersList);
        }

        public void RemoveStudents(Student student)
        {
            this.studentsSet.Remove(student);
        }

        public void RemoveTeachers(Teacher teacher)
        {
            this.teachersSet.Remove(teacher);
        }

        public void ClearStudents()
        {
            this.studentsSet.Clear();
        }

        public void ClearTeachers()
        {
            this.teachersSet.Clear();
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public string TextID
        {
            get { return this.textID; }
        }
    }
}
