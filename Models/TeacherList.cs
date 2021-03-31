using System;
using System.Collections.Generic;

namespace net_on_the_web.Models
{
    public class TeacherList
    {
        public List<Teacher> _teachers = new List<Teacher>();

        public TeacherList(int AmountOfTeachers)
        {
            Random rand = new Random(2);

            for (int i = 0; i < AmountOfTeachers; i++)
            {
                Teacher newTeacher = new Teacher(RandomNameGenerator.generate(), null);

                _teachers.Add(newTeacher);
            }
        }

        public Teacher[] getTeachers()
        {
            return _teachers.ToArray();
        }

        public int getTeacherCount()
        {
            return _teachers.Count;
        }

        public Teacher getTeacherByIndex(int index)
        {
            return _teachers[index];
        }

        public void setTeacherClassRoom(int index, ClassRoom classRoom)
        {
            _teachers[index].myClass = classRoom;
        }
    }
}