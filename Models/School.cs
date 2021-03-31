using System;
using System.Collections.Generic;
using net_on_the_web.Models;
using net_on_the_web.Pages;

namespace net_on_the_web.Models
{
    public class School
    {
        public List<ClassRoom> _classesList = new List<ClassRoom>();
        public StudentList Students;
        public TeacherList _teachers;

        public School(int classAmount, int teacherAmount, int studentAmount)
        {
            for (int i = 0; i < classAmount; i++)
            {
                ClassRoom newRoom = new ClassRoom("Class " + i + "" , "20B");
                newRoom.MyTeacher = new Teacher(RandomNameGenerator.generate(), newRoom);
                
                _classesList.Add(newRoom);
            }

            _teachers = new TeacherList(teacherAmount);
            Students = new StudentList(studentAmount);
            
            //assign a teacher to every class
            foreach (ClassRoom classRoom in _classesList)
            {
                int index = new Random().Next(_teachers.getTeacherCount());
                
                classRoom.MyTeacher = _teachers._teachers[index];
                _teachers._teachers[index].myClass = classRoom;
            }
            
            //assign students to classes
            foreach (Student student in Students.GetStudentArray())
            {
                student.MyClass = _classesList[new Random().Next(_classesList.Count)];
            }
        }

        public ClassRoom[] GetClasses()
        {
            return _classesList.ToArray();
        }
    }
}