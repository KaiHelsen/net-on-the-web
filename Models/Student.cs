using System;
using System.Data.Common;

namespace net_on_the_web.Models
{
    public class Student
    {
        private static int _idCounter = 0;
        public int Id;
        public string Name;
        public int ClassId;

        public Student(string _name, int _classId)
        {
            Random rand = new Random();
            this.Id = _idCounter++;
            this.Name = _name;
            this.ClassId = _classId;
        }

        public void ResetIdCounter()
        {
            _idCounter = 0;
        }
    }
}