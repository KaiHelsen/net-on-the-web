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
                ClassRoom newRoom = new ClassRoom("Class", "20B");
                newRoom.MyTeacher = new Teacher(RandomNameGenerator.generate(), newRoom);
                
                _classesList.Add(newRoom);
            }

            _teachers = new TeacherList(teacherAmount);
            Students = new StudentList(studentAmount);
        }

        /**
         * 
         */
        public ClassRoom[] GetClasses()
        {
            return _classesList.ToArray();
        }
    }
}