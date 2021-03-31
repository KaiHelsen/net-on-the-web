using System;
using System.Collections.Generic;
using net_on_the_web.Models;

namespace net_on_the_web.Models
{
    public class StudentList
    {
        private List<Student> _students = new List<Student>();
        
        public StudentList(int amountOfStudents)
        {
            int classid = 20;
            for (int i = 0; i < amountOfStudents; i++)
            {
                _students.Add(new Student(this.GetRandomName(), null));
            }
        }

        private string GetRandomName()
        {
            Random rand = new Random();

            string name = RandomNameGenerator.generate();
            return name;
        }

        public Student[] GetStudentArray()
        {
            return _students.ToArray();
        }

        public Student GetStudent(int index)
        {
            if (index > this._students.Count)
            {
                throw new IndexOutOfRangeException();
            }
            return this._students[index];
        }
        
        public void SetStudentClass(Student student, ClassRoom classRoom)
        {
            if (_students.Contains((student)))
            {
                _students.Find(x => x == student).MyClass = classRoom;
            }
            else
            {
                _students.Add(new Student(RandomNameGenerator.generate(), classRoom));
            }
        }
    }
}